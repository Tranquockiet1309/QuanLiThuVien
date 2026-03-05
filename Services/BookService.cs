using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Data.Entities;
using DTO;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class BookService
    {
        private readonly LibraryContext dbContext;

        public BookService(LibraryContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // ✅ Lấy tất cả sách
        public List<BookDTO> GetAll()
        {
            return dbContext.Books
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .OrderBy(b => b.BookName)
                .Select(b => new BookDTO
                {
                    BookId = b.BookId,
                    BookName = b.BookName,
                    CategoryId = b.CategoryId,
                    CategoryName = b.Category != null ? b.Category.CateName : "",
                    PublisherId = b.PublisherId,
                    PublisherName = b.Publisher != null ? b.Publisher.PublisherName : "",
                    Price = b.Price,
                    FileImg = b.FileImg,
                    Description = b.Description,
                    CreatedAt = b.CreatedAt,
                    UpdatedAt = b.UpdatedAt
                })
                .ToList();
        }

        // ✅ Lấy theo ID
        public BookDTO? GetById(int id)
        {
            return dbContext.Books
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Where(b => b.BookId == id)
                .Select(b => new BookDTO
                {
                    BookId = b.BookId,
                    BookName = b.BookName,
                    CategoryId = b.CategoryId,
                    CategoryName = b.Category != null ? b.Category.CateName : "",
                    PublisherId = b.PublisherId,
                    PublisherName = b.Publisher != null ? b.Publisher.PublisherName : "",
                    Price = b.Price,
                    FileImg = b.FileImg,
                    Description = b.Description
                })
                .SingleOrDefault();
        }

        // ✅ Thêm sách
        public ServiceResult Add(BookDTO book)
        {
            if (string.IsNullOrEmpty(book.BookName))
                return new ServiceResult { Success = false, Message = "Tên sách rỗng!" };

            var exists = dbContext.Books.Any(b => b.BookName.ToLower() == book.BookName.ToLower());
            if (exists)
                return new ServiceResult { Success = false, Message = "Sách đã tồn tại!" };

            var newBook = new Book
            {
                BookName = book.BookName,
                CategoryId = book.CategoryId,
                PublisherId = book.PublisherId,
                Price = book.Price,
                FileImg = book.FileImg,     
                Description = book.Description,
                CreatedAt = DateTime.Now
            };

            try
            {
                dbContext.Books.Add(newBook);
                dbContext.SaveChanges();
                return new ServiceResult { Success = true, Message = "Thêm sách thành công!" };
            }
            catch (Exception ex)
            {
                return new ServiceResult { Success = false, Message = $"Lỗi khi thêm sách: {ex.Message}" };
            }
        }

        // ✅ Cập nhật sách
        public ServiceResult Update(BookDTO book)
        {
            var entity = dbContext.Books.SingleOrDefault(b => b.BookId == book.BookId);
            if (entity == null)
                return new ServiceResult { Success = false, Message = "Không tìm thấy sách cần cập nhật!" };

            var exists = dbContext.Books.Any(b =>
                b.BookId != book.BookId &&
                b.BookName.ToLower() == book.BookName.ToLower()
            );

            if (exists)
                return new ServiceResult { Success = false, Message = "Tên sách đã tồn tại!" };

            entity.BookName = book.BookName;
            entity.CategoryId = book.CategoryId;
            entity.PublisherId = book.PublisherId;
            entity.Price = book.Price;
            entity.FileImg = book.FileImg;
            entity.Description = book.Description;
            entity.UpdatedAt = DateTime.Now;

            try
            {
                dbContext.SaveChanges();
                return new ServiceResult { Success = true, Message = "Cập nhật sách thành công!" };
            }
            catch (Exception ex)
            {
                return new ServiceResult { Success = false, Message = $"Lỗi khi cập nhật: {ex.Message}" };
            }
        }

        // ✅ Xóa sách
        public ServiceResult Delete(int bookId)
        {
            var book = dbContext.Books.SingleOrDefault(b => b.BookId == bookId);
            if (book == null)
                return new ServiceResult { Success = false, Message = "Không tìm thấy sách cần xóa!" };

            bool isBorrowed = dbContext.Borrowbooks.Any(bb => bb.BookId == bookId);
            if (isBorrowed)
                return new ServiceResult { Success = false, Message = "Không thể xóa sách đang được mượn!" };

            dbContext.Books.Remove(book);
            dbContext.SaveChanges();
            return new ServiceResult { Success = true, Message = "Xóa sách thành công!" };
        }

        // ✅ Tìm kiếm theo ID hoặc tên sách
        public List<BookDTO> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return new List<BookDTO>();

            string kw = keyword.Trim();
            int? id = int.TryParse(kw, out var tmp) ? tmp : null;

            return dbContext.Books
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Where(b =>
                    (id.HasValue && b.BookId == id.Value) ||
                    EF.Functions.Like(b.BookName, $"%{kw}%")
                )
                .OrderBy(b => b.BookName)
                .Select(b => new BookDTO
                {
                    BookId = b.BookId,
                    BookName = b.BookName,
                    CategoryId = b.CategoryId,
                    CategoryName = b.Category != null ? b.Category.CateName : "",
                    PublisherId = b.PublisherId,
                    PublisherName = b.Publisher != null ? b.Publisher.PublisherName : "",
                    Price = b.Price,
                    Description = b.Description,
                    FileImg = b.FileImg
                })
                .ToList();
        }

        // ✔ Tìm theo thể loại
        public List<BookDTO> SearchByCategoryName(string cateName)
        {
            return dbContext.Books
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Where(b => b.Category != null &&
                            EF.Functions.Like(b.Category.CateName, $"%{cateName}%"))
                .Select(b => new BookDTO
                {
                    BookId = b.BookId,
                    BookName = b.BookName,
                    CategoryId = b.CategoryId,
                    CategoryName = b.Category.CateName,
                    PublisherId = b.PublisherId,
                    PublisherName = b.Publisher.PublisherName,
                    Price = b.Price,
                    Description = b.Description,
                    FileImg = b.FileImg
                })
                .ToList();
        }

        // ✔ Tìm theo NXB
        public List<BookDTO> SearchByPublisherName(string pubName)
        {
            return dbContext.Books
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Where(b => b.Publisher != null &&
                            EF.Functions.Like(b.Publisher.PublisherName, $"%{pubName}%"))
                .Select(b => new BookDTO
                {
                    BookId = b.BookId,
                    BookName = b.BookName,
                    CategoryId = b.CategoryId,
                    CategoryName = b.Category.CateName,
                    PublisherId = b.PublisherId,
                    PublisherName = b.Publisher.PublisherName,
                    Price = b.Price,
                    Description = b.Description,
                    FileImg = b.FileImg
                })
                .ToList();
        }
    }
}
