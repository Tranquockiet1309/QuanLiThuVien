using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using DTO;
using Data.Entities;

namespace Services
{
    public class CategoryService
    {
        private readonly LibraryContext dbContext;

        public CategoryService(LibraryContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Lấy danh sách tất cả loại sách
        /// </summary>
        public List<CategoryDTO> GetAll()
        {
            return dbContext.Categories
                .OrderBy(x => x.CateName)
                .Select(x => new CategoryDTO
                {
                    CateId = x.CateId,
                    CateName = x.CateName,
                    Description = x.Description,
                    Img = x.Img,
                    CreatedAt = x.CreatedAt,
                })
                .ToList();
        }

        /// <summary>
        /// Lấy loại theo Id
        /// </summary>
        public CategoryDTO? GetById(int id)
        {
            return dbContext.Categories
                .Where(x => x.CateId == id)
                .Select(x => new CategoryDTO
                {
                    CateId = x.CateId,
                    CateName = x.CateName,
                    Description = x.Description,
                    Img = x.Img,
                    CreatedAt = x.CreatedAt
                })
                .SingleOrDefault();
        }

        /// <summary>
        /// Thêm loại sách
        /// </summary>
        public ServiceResult Add(CategoryDTO cate)
        {
            if (string.IsNullOrWhiteSpace(cate.CateName))
            {
                return new ServiceResult { Success = false, Message = "Tên loại rỗng!" };
            }

            // Kiểm tra trùng tên
            var exists = dbContext.Categories.Any(c => c.CateName == cate.CateName);
            if (exists)
            {
                return new ServiceResult { Success = false, Message = "Tên loại đã tồn tại!" };
            }

            var cateEntity = new Category
            {
                CateName = cate.CateName.Trim(),
                Description = cate.Description?.Trim(),
                Img = cate.Img,
                CreatedAt = DateTime.Now
            };

            dbContext.Categories.Add(cateEntity);
            dbContext.SaveChanges();

            return new ServiceResult { Success = true, Message = "Thêm loại sách thành công!" };
        }

        /// <summary>
        /// Cập nhật loại sách
        /// </summary>
        public ServiceResult Update(CategoryDTO cate)
        {
            if (string.IsNullOrWhiteSpace(cate.CateName))
            {
                return new ServiceResult { Success = false, Message = "Tên loại rỗng!" };
            }

            var cateEntity = dbContext.Categories.SingleOrDefault(x => x.CateId == cate.CateId);
            if (cateEntity == null)
            {
                return new ServiceResult { Success = false, Message = "Không tồn tại loại cần cập nhật!" };
            }

            // Kiểm tra trùng tên với loại khác
            var exists = dbContext.Categories.Any(c => c.CateId != cate.CateId && c.CateName == cate.CateName);
            if (exists)
            {
                return new ServiceResult { Success = false, Message = "Tên loại đã tồn tại!" };
            }

            cateEntity.CateName = cate.CateName.Trim();
            cateEntity.Description = cate.Description?.Trim();
            cateEntity.Img = cate.Img;

            dbContext.SaveChanges();

            return new ServiceResult { Success = true, Message = "Cập nhật loại sách thành công!" };
        }

        /// <summary>
        /// Xóa loại sách
        /// </summary>
        public ServiceResult Delete(int cateId)
        {
            var cateEntity = dbContext.Categories.SingleOrDefault(x => x.CateId == cateId);
            if (cateEntity == null)
            {
                return new ServiceResult { Success = false, Message = "Không tồn tại loại cần xóa!" };
            }

            // Kiểm tra có sách liên quan không
            var hasBooks = dbContext.Books.Any(x => x.CategoryId == cateId);
            if (hasBooks)
            {
                return new ServiceResult { Success = false, Message = "Không thể xóa loại có sách!" };
            }

            dbContext.Categories.Remove(cateEntity);
            dbContext.SaveChanges();

            return new ServiceResult { Success = true, Message = "Xóa loại sách thành công!" };
        }
    }
}
