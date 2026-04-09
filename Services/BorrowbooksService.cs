using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Data.Entities;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class BorrowbooksService
    {
        private readonly LibraryContext db;

        public BorrowbooksService(LibraryContext context)
        {
            db = context;
        }

        // ✅ Lấy toàn bộ danh sách phiếu mượn
        public List<BorrowbooksDTO> GetAll()
        {
            return db.Borrowbooks
                .Select(b => new BorrowbooksDTO
                {
                    BorrowId = b.BorrowId,
                    UserId = b.UserId,
                    UserName = b.User.FullName,
                    BookId = b.BookId,
                    BookName = b.Book.BookName,
                    BorrowDate = b.BorrowDate,
                    ReturnDate = b.ReturnDate,
                    IsReturned = b.Status == "Đã trả"
                })
                .OrderByDescending(x => x.BorrowDate)
                .ToList();
        }

        // ✅ Mượn sách
        public ServiceResult BorrowBook(int userId, int bookId)
        {
            var user = db.Users.SingleOrDefault(u => u.UserId == userId);
            if (user == null)
                return new ServiceResult { Success = false, Message = "Người dùng không tồn tại!" };

            if (user.Role == "Admin")
                return new ServiceResult { Success = false, Message = "Admin không thể mượn sách!" };

            var book = db.Books.SingleOrDefault(b => b.BookId == bookId);
            if (book == null)
                return new ServiceResult { Success = false, Message = "Không tìm thấy sách!" };

            bool alreadyBorrowed = db.Borrowbooks.Any(bb => bb.BookId == bookId && bb.Status == "Đang mượn");
            if (alreadyBorrowed)
                return new ServiceResult { Success = false, Message = "Sách này đang được mượn!" };

            try
            {
                var borrow = new Borrowbooks
                {
                    UserId = userId,
                    BookId = bookId,
                    BorrowDate = DateTime.Now,
                    Status = "Đang mượn"
                };

                db.Borrowbooks.Add(borrow);
                db.SaveChanges();

                return new ServiceResult
                {
                    Success = true,
                    Message = $"✅ {user.FullName} đã mượn sách '{book.BookName}' thành công!"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult { Success = false, Message = $"Lỗi khi mượn sách: {ex.Message}" };
            }
        }

        // ✅ Trả sách
        public ServiceResult ReturnBook(int borrowId)
        {
            // Tìm phiếu mượn theo ID
            var record = db.Borrowbooks
                .Include(b => b.Book)
                .SingleOrDefault(b => b.BorrowId == borrowId);

            if (record == null)
                return new ServiceResult
                {
                    Success = false,
                    Message = "❌ Không tìm thấy phiếu mượn!"
                };

            // Kiểm tra người dùng
            var user = db.Users.SingleOrDefault(u => u.UserId == record.UserId);
            if (user == null)
                return new ServiceResult
                {
                    Success = false,
                    Message = "❌ Người dùng không tồn tại!"
                };

            // Nếu người này không có bản ghi mượn nào (chưa từng mượn)
            bool hasBorrowed = db.Borrowbooks.Any(b => b.UserId == record.UserId);
            if (!hasBorrowed)
                return new ServiceResult
                {
                    Success = false,
                    Message = $"❌ Người dùng '{user.FullName}' chưa có dữ liệu mượn sách!"
                };

            // Nếu sách đã trả
            if (record.Status == "Đã trả")
                return new ServiceResult
                {
                    Success = false,
                    Message = "⚠️ Sách này đã được trả trước đó!"
                };

            try
            {
                // Cập nhật trạng thái & ngày trả
                record.Status = "Đã trả";
                record.ReturnDate = DateTime.Now;

                db.SaveChanges();

                return new ServiceResult
                {
                    Success = true,
                    Message = $"✅ Trả sách '{record.Book.BookName}' thành công cho '{user.FullName}'!"
                };
            }
            catch (Exception ex)
            {
                return new ServiceResult
                {
                    Success = false,
                    Message = $"Lỗi khi trả sách: {ex.Message}"
                };
            }
        }
        public ServiceResult ReturnByUserAndBook(int userId, int bookId)
        {
            var user = db.Users.SingleOrDefault(u => u.UserId == userId);
            if (user == null)
                return new ServiceResult { Success = false, Message = "❌ Người dùng không tồn tại!" };

            var book = db.Books.SingleOrDefault(b => b.BookId == bookId);
            if (book == null)
                return new ServiceResult { Success = false, Message = "❌ Không tìm thấy sách!" };

            // bản ghi còn mở (Đang mượn)
            var openRecord = db.Borrowbooks
                .Where(b => b.UserId == userId && b.BookId == bookId && b.Status != "Đã trả")
                .OrderByDescending(b => b.BorrowDate)
                .FirstOrDefault();

            if (openRecord == null)
            {
                // kiểm tra xem có lịch sử mượn không
                bool everBorrowed = db.Borrowbooks.Any(b => b.UserId == userId && b.BookId == bookId);
                if (!everBorrowed)
                    return new ServiceResult { Success = false, Message = "❌ Người này chưa mượn cuốn sách này!" };

                return new ServiceResult { Success = false, Message = "⚠️ Sách này đã được trả trước đó!" };
            }

            openRecord.Status = "Đã trả";
            openRecord.ReturnDate = DateTime.Now;
            db.SaveChanges();

            return new ServiceResult
            {
                Success = true,
                Message = $"✅ Trả sách '{book.BookName}' thành công cho '{user.FullName}'!"
            };
        }


        // ✅ Lấy danh sách mượn theo người dùng
        public List<BorrowbooksDTO> GetByUser(int userId)
        {
            return db.Borrowbooks
                .Where(b => b.UserId == userId)
                .Select(b => new BorrowbooksDTO
                {
                    BorrowId = b.BorrowId,
                    UserId = b.UserId,
                    UserName = b.User.FullName,
                    BookId = b.BookId,
                    BookName = b.Book.BookName,
                    BorrowDate = b.BorrowDate,
                    ReturnDate = b.ReturnDate,
                    IsReturned = b.Status == "Đã trả"
                })
                .OrderByDescending(b => b.BorrowDate)
                .ToList();
        }
    }
}
