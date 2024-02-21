using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant.Global
{
    public partial class Data
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool VerifyPassword(string inputPassword, string hashedPassword)
        {
            string inputPasswordHashed = HashPassword(inputPassword);
            return inputPasswordHashed.Equals(hashedPassword);
        }
        public static byte[] ConvertImageToByte(Image img)
        {
            MemoryStream mem = new MemoryStream();
            img.Save(mem, System.Drawing.Imaging.ImageFormat.Bmp);
            return mem.ToArray();
        }

        // Phương thức chuyển đổi dữ liệu mã Base64 thành hình ảnh
        public Image GetImageFromBase64(string base64Image)
        {
            // Kiểm tra dữ liệu không rỗng
            if (!string.IsNullOrEmpty(base64Image))
            {
                // Chuyển đổi dữ liệu từ mã Base64 sang mảng byte
                byte[] imageBytes = Convert.FromBase64String(base64Image);

                // Tạo đối tượng hình ảnh từ mảng byte
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            return null;
        }

        public static string ConvertImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Chuyển đổi hình ảnh thành mã Base64
                image.Save(ms, image.RawFormat);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
    }
}
