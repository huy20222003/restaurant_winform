using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using restaurant.DAO;
using restaurant.Global;

namespace restaurant
{
    public partial class FormCategory : MaterialForm
    {
        private bool isEdit = false;
        public Action getListCategory;
        private int ID;
        public FormCategory()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public FormCategory(string id, string name, string description, string imageUrl, bool isEdit)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
            this.StartPosition = FormStartPosition.CenterScreen;
            this.isEdit = isEdit;
            this.ID = int.Parse(id);
            if (isEdit)
            {
                labelCategoryTitle.Text = "Chỉnh sửa danh mục";
                buttonAddCategory.Text = "Sửa danh mục";
                txtCategoryName.Text = name;
                txtCategoryDescription.Text = description;
                if (imageUrl.StartsWith("https://"))
                {
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageData = webClient.DownloadData(imageUrl);
                        using (MemoryStream stream = new MemoryStream(imageData))
                        {
                            Image image = Image.FromStream(stream);
                            pictureBox.Image = image;
                        }
                    }
                }
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                // Nếu hình ảnh chưa được chọn, hiển thị thông báo lỗi
                errorProvider.SetError(btnChooseImage, "Vui lòng chọn hình ảnh!");
            }
            else
            {
                // Nếu hình ảnh đã được chọn, xóa thông báo lỗi (nếu có)
                errorProvider.SetError(btnChooseImage, "");
                // Tiếp tục xử lý chọn hình ảnh
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonAddCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            string description = txtCategoryDescription.Text;

            // Kiểm tra các trường thông tin có được nhập đầy đủ và hình ảnh có được chọn hay không
            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider.SetError(txtCategoryName, "Vui lòng nhập tên danh mục!");
            }
            else
            {
                errorProvider.SetError(txtCategoryName, ""); // Xóa thông báo lỗi nếu hợp lệ
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                errorProvider.SetError(txtCategoryDescription, "Vui lòng nhập mô tả danh mục!");
            }
            else
            {
                errorProvider.SetError(txtCategoryDescription, ""); // Xóa thông báo lỗi nếu hợp lệ
            }

            if (pictureBox.Image == null)
            {
                errorProvider.SetError(btnChooseImage, "Vui lòng chọn hình ảnh!");
            }
            else
            {
                errorProvider.SetError(btnChooseImage, ""); // Xóa thông báo lỗi nếu hợp lệ
            }

            // Kiểm tra nếu có bất kỳ thông báo lỗi nào từ ErrorProvider
            if (errorProvider.GetError(txtCategoryName) != "" || errorProvider.GetError(txtCategoryDescription) != "" || errorProvider.GetError(btnChooseImage) != "")
            {
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Vui lòng điền đầy đủ thông tin", ToolTipIcon.Warning);
                return; // Dừng lại nếu dữ liệu không hợp lệ
            }
            else
            {
                // Chuyển đổi hình ảnh thành mảng byte trước khi lưu vào cơ sở dữ liệu
                string imageBase64 = Data.ConvertImageToBase64(pictureBox.Image);
                ImageServices imageServices = new ImageServices();
                string imageUrl = await imageServices.UploadImageAsync(imageBase64);

                if (isEdit)
                {
                    buttonCategoryDelete.Visible = true;
                    DateTime updatedAt = DateTime.Now; // Đây là đối tượng DateTime cần chuyển đổi
                    string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fffffff");
                    bool response = CategoryDAO.Instance.UpdateCategory(this.ID, name, description, imageUrl, formattedDate);

                    if (response)
                    {
                        this.getListCategory();
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật danh mục thành công", ToolTipIcon.Info);
                        this.Close();
                    }
                    else
                    {
                        this.getListCategory();
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật danh mục thất bại", ToolTipIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    bool response = CategoryDAO.Instance.InsertCategory(name, description, imageUrl);

                    if (response)
                    {
                        this.getListCategory();
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Thêm danh mục thành công", ToolTipIcon.Info);
                        this.Close();
                    }
                    else
                    {
                        this.getListCategory();
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Thêm danh mục thất bại", ToolTipIcon.Error);
                        this.Close();
                    }
                }
            }
        }

        private void buttonCategoryDelete_Click(object sender, EventArgs e)
        {
            bool response = CategoryDAO.Instance.DeleteCategory(this.ID);
            if(response)
            {
                this.getListCategory();
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Xoá danh mục thành công", ToolTipIcon.Info);
                this.Close();
            } else
            {
                this.getListCategory();
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Xoá danh mục thất bại", ToolTipIcon.Error);
                this.Close();
            }
        }
    }
}
