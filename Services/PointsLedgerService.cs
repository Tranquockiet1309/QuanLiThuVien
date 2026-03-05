using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Data.Entities;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class PointsLedgerService
    {
        private readonly LibraryContext dbContext;

        public PointsLedgerService(LibraryContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private static bool IsAdmin(string? role)
            => string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase);
        public List<PointsLedgerDTO> GetAll()
        {
            // Lấy tất cả các bản ghi trong bảng PointsLedgers, kèm theo thông tin User và CheckIn nếu có
            var pointsLedgers = dbContext.PointsLedgers
                .Include(p => p.CheckIn)  // Bao gồm thông tin về CheckIn
                .Include(p => p.User)     // Bao gồm thông tin về User
                .OrderByDescending(p => p.CreatedAt) // Sắp xếp theo thời gian tạo
                .Select(p => new PointsLedgerDTO
                {
                    LedgerId = p.LedgerId,
                    UserId = p.UserId,
                    FullName = p.User.FullName,
                    Points = p.Points,
                    Reason = p.Reason,
                    CreatedAt = p.CreatedAt,
                    CheckInId = p.CheckInId,
                    CheckInTime = p.CheckIn != null ? p.CheckIn.CheckInTime : (DateTime?)null
                })
                .ToList();

            return pointsLedgers;
        }


        // points > 0: cộng; points < 0: trừ
        public ServiceResult AddPoints(int userId, int points, string reason, int? checkInId = null)
        {
            if (points == 0)
                return new ServiceResult { Success = false, Message = "Giá trị điểm phải khác 0!" };

            var user = dbContext.Users.SingleOrDefault(u => u.UserId == userId);
            if (user == null) return new ServiceResult { Success = false, Message = "Không tìm thấy người dùng!" };
            if (!user.IsActive) return new ServiceResult { Success = false, Message = "Tài khoản bị khóa!" };

            // Chỉ chặn cộng điểm cho Admin; trừ điểm Admin vẫn cho phép nếu cần
            if (IsAdmin(user.Role) && points > 0)
                return new ServiceResult { Success = false, Message = "Không cộng điểm cho Admin!" };

            try
            {
                dbContext.PointsLedgers.Add(new PointsLedger
                {
                    UserId = userId,
                    Points = points,
                    Reason = reason,
                    CreatedAt = DateTime.Now,
                    CheckInId = checkInId
                });
                dbContext.SaveChanges();
                return new ServiceResult { Success = true, Message = "Ghi nhận điểm rèn luyện thành công!" };
            }
            catch (Exception ex)
            {
                return new ServiceResult { Success = false, Message = $"Lỗi khi ghi nhận điểm: {ex.Message}" };
            }
        }

        public int GetTotalPoints(int userId)
        {
            return dbContext.PointsLedgers
                            .Where(p => p.UserId == userId)
                            .Sum(p => (int?)p.Points) ?? 0;
        }

        public List<PointsLedgerDTO> GetHistory(int userId, DateTime? from = null, DateTime? to = null)
        {
            var q = dbContext.PointsLedgers
                             .Include(p => p.CheckIn)
                             .Include(p => p.User)
                             .Where(p => p.UserId == userId);

            if (from.HasValue) q = q.Where(p => p.CreatedAt >= from.Value);
            if (to.HasValue) q = q.Where(p => p.CreatedAt < to.Value);

            return q.OrderByDescending(p => p.CreatedAt)
                    .Select(p => new PointsLedgerDTO
                    {
                        LedgerId = p.LedgerId,
                        UserId = p.UserId,
                        FullName = p.User.FullName,
                        Points = p.Points,
                        Reason = p.Reason,
                        CreatedAt = p.CreatedAt,
                        CheckInId = p.CheckInId,
                        CheckInTime = p.CheckIn != null ? p.CheckIn.CheckInTime : (DateTime?)null
                    })
                    .ToList();
        }

        public ServiceResult RemoveAllOfUser(int userId)
        {
            try
            {
                var all = dbContext.PointsLedgers.Where(p => p.UserId == userId);
                dbContext.PointsLedgers.RemoveRange(all);
                dbContext.SaveChanges();
                return new ServiceResult { Success = true, Message = "Đã xóa lịch sử điểm rèn luyện của người dùng." };
            }
            catch (Exception ex)
            {
                return new ServiceResult { Success = false, Message = $"Lỗi khi xóa ledger: {ex.Message}" };
            }
        }
    }
}
