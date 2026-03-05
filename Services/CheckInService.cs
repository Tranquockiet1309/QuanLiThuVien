using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Data.Entities;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class CheckInService
    {
        private readonly LibraryContext dbContext;

        private const int CheckInPoint = 2; // điểm mỗi lần check-in

        public CheckInService(LibraryContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private static bool IsAdmin(string? role)
            => string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase);

        public bool HasCheckedInToday(int userId, DateTime? at = null)
        {
            var start = (at ?? DateTime.Now).Date;
            var end = start.AddDays(1);
            return dbContext.CheckIns.Any(c => c.UserId == userId && c.CheckInTime >= start && c.CheckInTime < end);
        }

        public ServiceResult CheckIn(int userId, string? note = null)
        {
            var user = dbContext.Users.SingleOrDefault(u => u.UserId == userId);
            if (user == null) return new ServiceResult { Success = false, Message = "Không tìm thấy người dùng!" };
            if (!user.IsActive) return new ServiceResult { Success = false, Message = "Tài khoản bị khóa, không thể check-in!" };
            if (IsAdmin(user.Role)) return new ServiceResult { Success = false, Message = "Admin không cần check-in." };
            if (HasCheckedInToday(userId)) return new ServiceResult { Success = false, Message = "Hôm nay bạn đã check-in rồi!" };

            using var tran = dbContext.Database.BeginTransaction();
            try
            {
                var check = new CheckIn
                {
                    UserId = userId,
                    CheckInTime = DateTime.Now,
                    Note = note
                };
                dbContext.CheckIns.Add(check);
                dbContext.SaveChanges(); // có CheckInId

                // Chỉ Reader mới cộng điểm
                if (!IsAdmin(user.Role))
                {
                    dbContext.PointsLedgers.Add(new PointsLedger
                    {
                        UserId = userId,
                        Points = CheckInPoint, // +2
                        Reason = "Điểm danh thư viện",
                        CreatedAt = DateTime.Now,
                        CheckInId = check.CheckInId
                    });
                }

                dbContext.SaveChanges();
                tran.Commit();
                return new ServiceResult { Success = true, Message = "Check-in thành công!" };
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return new ServiceResult { Success = false, Message = $"Lỗi khi check-in: {ex.Message}" };
            }
        }

        public List<CheckInDTO> GetByUser(int userId, DateTime? from = null, DateTime? to = null)
        {
            var q = dbContext.CheckIns.Include(c => c.User).Where(c => c.UserId == userId);
            if (from.HasValue) q = q.Where(c => c.CheckInTime >= from.Value);
            if (to.HasValue) q = q.Where(c => c.CheckInTime < to.Value);

            return q.OrderByDescending(c => c.CheckInTime)
                    .Select(c => new CheckInDTO
                    {
                        CheckInId = c.CheckInId,
                        UserId = c.UserId,
                        FullName = c.User.FullName,
                        UserName = c.User.UserName,
                        CheckInTime = c.CheckInTime,
                        Note = c.Note
                    })
                    .ToList();
        }
    }
}
