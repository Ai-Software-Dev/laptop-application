using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudService
{
    public class CloudIService
    {
        private Cloudinary _cloudinary;

        // Constructor để khởi tạo Cloudinary với tài khoản của bạn
        public CloudIService()
        {
            var account = new Account(ServiceConfig.CloudinaryCloudName, ServiceConfig.CloudinaryApiKey, ServiceConfig.CloudinaryApiSecret);
            _cloudinary = new Cloudinary(account);
            _cloudinary.Api.Secure = true; // Đảm bảo sử dụng HTTPS
        }

        // Upload hình ảnh cho danh mục vào thư mục IMG_PTPM/Category
        public string UploadImageCategory(string filePath)
        {
            try
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(filePath),
                    Folder = "IMG_PTPM/Category"  // Chỉ định thư mục con Category
                };
                var uploadResult = _cloudinary.Upload(uploadParams);
                return uploadResult.SecureUrl.AbsoluteUri; // Trả về URL bảo mật của hình ảnh
            }
            catch (Exception)
            {
                return "default";  // Trả về hình ảnh mặc định nếu có lỗi
            }
        }

        // Upload hình ảnh cho sản phẩm vào thư mục IMG_PTPM/Products
        public string UploadImageProduct(string filePath)
        {
            try
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(filePath),
                    Folder = "IMG_PTPM/Products"  // Chỉ định thư mục con Products
                };
                var uploadResult = _cloudinary.Upload(uploadParams);
                return uploadResult.SecureUrl.AbsoluteUri; // Trả về URL bảo mật của hình ảnh
            }
            catch (Exception)
            {
                return "default";  // Trả về hình ảnh mặc định nếu có lỗi
            }
        }
        public bool DeleteImage(string publicId, string folder = "")
        {
            try
            {
                // Thêm thư mục vào publicId nếu có
                if (!string.IsNullOrEmpty(folder))
                {
                    publicId = $"{folder}/{publicId}";
                }

                var deletionParams = new DeletionParams(publicId);
                var deletionResult = _cloudinary.Destroy(deletionParams);

                return deletionResult.Result == "ok"; // Kiểm tra nếu xóa thành công
            }
            catch
            {
                return false; // Trả về false nếu có lỗi
            }
        }
    }
}
