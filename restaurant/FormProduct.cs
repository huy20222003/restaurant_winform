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
using Microsoft.Win32;
using restaurant.DAO;
using restaurant.DTO;
using restaurant.Global;

namespace restaurant
{
    public partial class FormProduct : MaterialForm
    {
        private int ID;
        private Action getProductList;
        private bool isEdit = false;
        public FormProduct()
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
            DataTable categoryDataTable = CategoryDAO.Instance.GetListCategory();

            // Đổ danh sách danh mục vào comboboxCategory
            foreach (DataRow row in categoryDataTable.Rows)
            {
                comboBoxProductCategoryID.Items.Add(row["Name"]);
            }
        }

        public FormProduct(string id, string name, string description, string imageUrl, string price, string priceSale, string categoryId, string status, string color, string size, string quantity, bool isEdit)
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
            DataTable categoryDataTable = CategoryDAO.Instance.GetListCategory();

            // Đổ danh sách danh mục vào comboboxCategory
            foreach (DataRow row in categoryDataTable.Rows)
            {
                comboBoxProductCategoryID.Items.Add(row["Name"]);
            }
            this.StartPosition = FormStartPosition.CenterScreen;
            this.isEdit = isEdit;
            this.ID = int.Parse(id);
            if (isEdit)
            {
                labelProductTitle.Text = "Chỉnh sửa sản phẩm";
                buttonProduct.Text = "Sửa sản phẩm";
                txtProductName.Text = name;
                txtProductDescription.Text = description;
                txtProductPrice.Text = price;
                txtProductPriceSale.Text = priceSale;
                txtProductSize.Text = size;
                txtProductColor.Text = color;
                txtProductQuantity.Text = quantity;
                comboBoxProductCategoryID.SelectedIndex = int.Parse(categoryId) - 1;
                comboBoxProductStatus.SelectedItem = status;
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

        public Action GetListProduct { get; set; }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void buttonProductCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonProduct_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text;
            string description = txtProductDescription.Text;
            string price = txtProductPrice.Text;
            string priceSale = txtProductPriceSale.Text;
            string color = txtProductColor.Text;
            string size = txtProductSize.Text;
            string status = comboBoxProductStatus.Text;
            int categoryId = comboBoxProductCategoryID.SelectedIndex + 1;
            string quantity = txtProductQuantity.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || pictureBox.Image == null || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(priceSale) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(size) || string.IsNullOrEmpty(color) || string.IsNullOrEmpty(quantity))
            {
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Vui lòng nhập đầy đủ thông tin!", ToolTipIcon.Warning);
            }
            else
            {
                // Chuyển đổi hình ảnh thành mảng byte trước khi lưu vào cơ sở dữ liệu
                string imageBase64 = Data.ConvertImageToBase64(pictureBox.Image);
                ImageServices imageServices = new ImageServices();
                string imageUrl = await imageServices.UploadImageAsync(imageBase64);

                if (isEdit)
                {
                    buttonProductDelete.Visible = true;
                    DateTime updatedAt = DateTime.Now; // Đây là đối tượng DateTime cần chuyển đổi
                    string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    bool response = ProductDAO.Instance.UpdateProduct(this.ID, name, description, imageUrl, status, categoryId, size, color, int.Parse(quantity), decimal.Parse(price), decimal.Parse(priceSale), formattedDate);

                    if (response)
                    {
                        this.GetListProduct();
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật sản phẩm thành công", ToolTipIcon.Info);
                        this.Close();
                    }
                    else
                    {
                        this.GetListProduct();
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật sản phẩm thất bại", ToolTipIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    bool response = ProductDAO.Instance.InsertProduct(name, description, imageUrl, status, categoryId, size, color, int.Parse(quantity), decimal.Parse(price), decimal.Parse(priceSale));

                    if (response)
                    {
                        this.GetListProduct();
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Thêm danh mục thành công", ToolTipIcon.Info);
                        this.Close();
                    }
                    else
                    {
                        this.GetListProduct();
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Thêm danh mục thất bại", ToolTipIcon.Error);
                        this.Close();
                    }
                }
            }
        }

        private void buttonProductDelete_Click(object sender, EventArgs e)
        {
            bool response = ProductDAO.Instance.DeleteProduct(this.ID);
            if (response)
            {
                this.GetListProduct();
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Xoá sản phẩm thành công", ToolTipIcon.Info);
                this.Close();
            }
            else
            {
                this.GetListProduct();
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Xoá sản phẩm thất bại", ToolTipIcon.Error);
                this.Close();
            }
        }

        private void TxtProductPrice_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (!decimal.TryParse(textBox.Text, out decimal price) || price <= 0)
            {
                errorProvider.SetError(textBox, "Giá sản phẩm không hợp lệ");
                
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }
        }

        private void TxtProductPriceSale_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (!decimal.TryParse(textBox.Text, out decimal priceSale) || priceSale >= decimal.Parse(txtProductPrice.Text) || priceSale < 0)
            {
                errorProvider.SetError(textBox, "Giá khuyến mãi không hợp lệ");
                
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }
        }

        private void TxtProductQuantity_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (!int.TryParse(textBox.Text, out int quantity) || quantity <= 0)
            {
                errorProvider.SetError(textBox, "Số lượng không hợp lệ");
                
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }
        }

        private void TxtProductName_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập tên sản phẩm");
                
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }
        }

        //private void TxtProductDescription_Validating(object sender, CancelEventArgs e)
        //{
        //    MaterialMultiLineTextBox2 textBox = sender as MaterialMultiLineTextBox2;
        //    if (string.IsNullOrWhiteSpace(textBox.Text))
        //    {
        //        errorProvider.SetError(textBox, "Vui lòng nhập mô tả sản phẩm");
                
        //    }
        //    else
        //    {
        //        errorProvider.SetError(textBox, "");
        //    }
        //}

        private void TxtProductColor_Validating(object sender, CancelEventArgs e)
        {
            MaterialMultiLineTextBox2 textBox = sender as MaterialMultiLineTextBox2;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập màu sắc sản phẩm");
                
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }
        }

        private void TxtProductSize_Validating(object sender, CancelEventArgs e)
        {
            MaterialMultiLineTextBox2 textBox = sender as MaterialMultiLineTextBox2;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập kích thước sản phẩm");
                
            }
            else
            {
                errorProvider.SetError(textBox, "");
            }
        }

        private void ComboBoxProductStatus_Validating(object sender, CancelEventArgs e)
        {
            MaterialComboBox comboBox = sender as MaterialComboBox;
            if (comboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBox, "Vui lòng chọn trạng thái sản phẩm");
                
            }
            else
            {
                errorProvider.SetError(comboBox, "");
            }
        }

        private void ComboBoxProductCategoryID_Validating(object sender, CancelEventArgs e)
        {
            MaterialComboBox comboBox = sender as MaterialComboBox;
            if (comboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBox, "Vui lòng chọn danh mục sản phẩm");
                
            }
            else
            {
                errorProvider.SetError(comboBox, "");
            }
        }

        private void TxtProductPrice_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), "");
        }

        private void TxtProductPriceSale_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), "");
        }

        private void TxtProductQuantity_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), "");
        }

        private void TxtProductName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), "");
        }

        private void TxtProductDescription_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), "");
        }

        private void TxtProductColor_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), "");
        }

        private void TxtProductSize_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), "");
        }
        private void ComboBoxProductStatus_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), "");
        }

        private void ComboBoxProductCategoryID_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), "");
        }

    }
}
