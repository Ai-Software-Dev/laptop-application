using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
namespace Component
{
    public class Cloundinary
    {
        private readonly Cloudinary _cloudinary;
        public Cloundinary()
        {
            var account = new Account(
               "dypftrmtl",   // Thay bằng Cloud Name của bạn
               "425717823811326",      // Thay bằng API Key của bạn
               "4Qmdz9LWEj7S0yFYWgpr9z4J770"    // Thay bằng API Secret của bạn
            );

            _cloudinary = new Cloudinary(account);
        }
        public string UploadImage(string filePath)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(filePath)
            };

            var uploadResult = _cloudinary.Upload(uploadParams);
            return uploadResult.Url.ToString();
        }
    }
}
