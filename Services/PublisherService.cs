using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Data.Entities;
using DTO;

namespace Services
{
    public class PublisherService
    {
        private readonly LibraryContext dbContext;

        public PublisherService(LibraryContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<PublisherDTO> GetAll()
        {
            return dbContext.Publishers
                .OrderBy(p => p.PublisherName)
                .Select(p => new PublisherDTO
                {
                    PublisherId = p.PublisherId,
                    PublisherName = p.PublisherName,
                    Address = p.Address,
                    Phone = p.Phone,
                    Email = p.Email,
                    Logo = p.Logo,          
                    CreatedAt = p.CreatedAt,
                    UpdatedAt = p.UpdatedAt
                }).ToList();
        }

        public ServiceResult Add(PublisherDTO dto)
        {
            if (string.IsNullOrEmpty(dto.PublisherName))
                return new ServiceResult { Success = false, Message = "Tên NXB rỗng!" };

            if (dbContext.Publishers.Any(p => p.PublisherName.ToLower() == dto.PublisherName.ToLower()))
                return new ServiceResult { Success = false, Message = "NXB đã tồn tại!" };

            var entity = new Publisher
            {
                PublisherName = dto.PublisherName,
                Address = dto.Address,
                Phone = dto.Phone,
                Email = dto.Email,
                CreatedAt = DateTime.Now
            };

            dbContext.Publishers.Add(entity);
            dbContext.SaveChanges();

            return new ServiceResult { Success = true, Message = "Thêm NXB thành công!" };
        }

        public ServiceResult Update(PublisherDTO dto)
        {
            var entity = dbContext.Publishers.SingleOrDefault(p => p.PublisherId == dto.PublisherId);
            if (entity == null)
                return new ServiceResult { Success = false, Message = "Không tìm thấy NXB cần cập nhật!" };

            // Cập nhật thông tin cơ bản
            entity.PublisherName = dto.PublisherName;
            entity.Address = dto.Address;
            entity.Phone = dto.Phone;
            entity.Email = dto.Email;
            entity.Logo = dto.Logo;

            entity.UpdatedAt = DateTime.Now;

            dbContext.SaveChanges();
            return new ServiceResult { Success = true, Message = "Cập nhật NXB thành công!" };
        }



        public ServiceResult Delete(int id)
        {
            var entity = dbContext.Publishers.SingleOrDefault(p => p.PublisherId == id);
            if (entity == null)
                return new ServiceResult { Success = false, Message = "Không tìm thấy NXB cần xóa!" };

            bool hasBooks = dbContext.Books.Any(b => b.PublisherId == id);
            if (hasBooks)
                return new ServiceResult { Success = false, Message = "Không thể xóa NXB có sách liên quan!" };

            dbContext.Publishers.Remove(entity);
            dbContext.SaveChanges();

            return new ServiceResult { Success = true, Message = "Xóa NXB thành công!" };
        }
    }
}
