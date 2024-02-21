using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.IO;
using System.Threading.Tasks;

namespace restaurant.Global {

    public  class ImageServices
    {
        private static Cloudinary _cloudinary;

        public ImageServices()
        {
            _cloudinary = new Cloudinary(new Account("restaurant-webapp", "948119799369811", "VFuANIjZvlokLkMBgBr4OtNQbrk"));

        }

        public async Task<string> UploadImageAsync(string base64Image)
        {
            try
            {
                // Khởi tạo một MemoryStream từ mã Base64 của hình ảnh
                using (MemoryStream stream = new MemoryStream(Convert.FromBase64String(base64Image)))
                {
                    // Khởi tạo FileDescription từ MemoryStream
                    var fileDescription = new FileDescription("image.jpg", stream);

                    // Tạo các tham số tải lên hình ảnh
                    var uploadParams = new ImageUploadParams()
                    {
                        File = fileDescription,
                        Folder = "restaurant_winform"
                    };

                    // Thực hiện tải lên hình ảnh và nhận lại kết quả từ Cloudinary
                    var imageUploadResult = await _cloudinary.UploadAsync(uploadParams);

                    // Trả về URL của hình ảnh đã tải lên
                    return imageUploadResult.SecureUrl.ToString();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (nếu có)
                Console.WriteLine($"Error uploading image: {ex.Message}");
                return null; // hoặc trả về một giá trị mặc định khác tùy thuộc vào logic của bạn
            }
        }

    }

}