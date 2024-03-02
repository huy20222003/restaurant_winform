using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MaterialSkin;
using MaterialSkin.Controls;
using restaurant.DAO;

namespace restaurant
{
    public partial class FormAddProductToBill : MaterialForm
    {
        private FlowLayoutPanel flowLayoutPanel;
        public FormAddProductToBill()
        {
            InitializeComponent();
            // Khởi tạo MaterialSkinManager để thiết lập giao diện
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Thiết lập màu sắc chính và phụ
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
            buttonSearch.Click += buttonSearch_Click;
        }

        // Xử lý sự kiện khi form được tải
        private void FormAddProductToBill_Load(object sender, EventArgs e)
        {
            // Gọi hàm hiển thị danh sách sản phẩm khi form được tải
            DisplayProductList();
        }

        // Hàm để hiển thị danh sách sản phẩm
        private void DisplayProductList()
        {
            // Lấy giá trị tìm kiếm từ textbox
            string searchValue = txtProductSearchValue.Text;
            DataTable productList;
            // Tạo FlowLayoutPanel để chứa các sản phẩm
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.WrapContents = true;
            flowLayoutPanel.AutoScroll = true;

            // Hiển thị hiệu ứng loader
            progressIndicatorProduct.Visible = true;

            // Kiểm tra xem người dùng đã nhập từ khóa tìm kiếm chưa
            if (string.IsNullOrEmpty(searchValue))
            {
                // Nếu chưa, lấy danh sách tất cả sản phẩm
                ClearCardItem();
                productList = ProductDAO.Instance.GetListProduct();
            }
            else
            {
                // Nếu đã nhập, lấy danh sách sản phẩm theo từ khóa tìm kiếm
                ClearCardItem();
                productList = ProductDAO.Instance.GetProductByName(searchValue);
            }

            // Duyệt qua từng sản phẩm trong danh sách
            foreach (DataRow row in productList.Rows)
            {
                // Tạo một Panel để chứa thông tin sản phẩm
                Panel panelProductItem = new Panel();
                panelProductItem.Width = 1100;
                panelProductItem.Height = 80;
                panelProductItem.Padding = new Padding(10);
                panelProductItem.Margin = new Padding(10);

                // Tạo PictureBox để hiển thị hình ảnh sản phẩm
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.ImageLocation = row["ImageUrl"].ToString();
                pictureBox.Location = new System.Drawing.Point(10, 10);
                pictureBox.Width = 80;
                pictureBox.Height = 80;
                pictureBox.InitialImage = Properties.Resources.logo_ver_2;

                // Tạo các label để hiển thị thông tin sản phẩm
                MaterialLabel labelNameValue = new MaterialLabel()
                {
                    Text = row["Name"].ToString(),
                    AutoSize = true,
                    FontType = MaterialSkinManager.fontType.Body1,
                    Location = new System.Drawing.Point(100, 14)
                };

                MaterialLabel labelPriceValue = new MaterialLabel()
                {
                    Text = "Giá tiền: " + row["Price"].ToString() + "VND",
                    AutoSize = true,
                    FontType = MaterialSkinManager.fontType.Body1,
                    Location = new System.Drawing.Point(100, 55)
                };

                // Tạo nút để thêm sản phẩm vào hóa đơn
                Guna2CircleButton buttonAddProduct = new Guna2CircleButton();
                buttonAddProduct.Size = new Size(50, 50);
                buttonAddProduct.Animated = true;
                buttonAddProduct.Image = Properties.Resources.icon_add;
                buttonAddProduct.Location = new System.Drawing.Point(1000, 8);
                buttonAddProduct.Cursor = Cursors.Hand;
                buttonAddProduct.Tag = row; // Đặt Tag cho nút để lưu thông tin sản phẩm

                // Thêm sự kiện khi nút thêm sản phẩm được nhấn
                buttonAddProduct.Click += ButtonAddProduct_Click;

                // Tạo control cho số lượng sản phẩm và các thuộc tính khác
                Guna2NumericUpDown quantity = new Guna2NumericUpDown() { Location = new Point(400, 14) };
                Guna2ComboBox chooseSize = new Guna2ComboBox() { Location = new Point(600, 14) };
                Guna2ComboBox chooseColor = new Guna2ComboBox() { Location = new Point(800, 14) };

                // Thêm các control vào panel sản phẩm
                panelProductItem.Controls.Add(pictureBox);
                panelProductItem.Controls.Add(labelNameValue);
                panelProductItem.Controls.Add(labelPriceValue);
                panelProductItem.Controls.Add(buttonAddProduct);
                panelProductItem.Controls.Add(quantity);
                panelProductItem.Controls.Add(chooseSize);
                panelProductItem.Controls.Add(chooseColor);

                // Thêm panel sản phẩm vào FlowLayoutPanel
                flowLayoutPanel.Controls.Add(panelProductItem);
            }

            // Ẩn hiệu ứng loader khi đã tạo xong các sản phẩm
            progressIndicatorProduct.Visible = false;

            // Thêm FlowLayoutPanel vào form
            cardFormAddProduct.Controls.Add(flowLayoutPanel);
        }

        // Xử lý sự kiện khi nút thêm sản phẩm được nhấn
        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            // Lấy thông tin sản phẩm từ Tag của nút
            DataRow productInfo = ((sender as Guna2CircleButton).Tag as DataRow);
            // Thêm logic xử lý khi nhấn nút thêm sản phẩm vào hóa đơn
            // ...
        }

        // Xử lý sự kiện khi textbox tìm kiếm được nhấn
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Hiển thị danh sách sản phẩm khi người dùng nhấn vào textbox tìm kiếm
            DisplayProductList();
        }

        private void ClearCardItem()
        {
            if (flowLayoutPanel != null)
            {
                // Tạo một danh sách tạm thời để lưu trữ các control cần loại bỏ
                List<Control> controlsToRemove = new List<Control>();

                // Duyệt qua tất cả các cardEmployeeItem và thêm chúng vào danh sách controlsToRemove
                foreach (Control control in flowLayoutPanel.Controls)
                {
                    if ( control is Panel)
                    {
                        controlsToRemove.Add(control);
                    }
                }

                // Loại bỏ các control được lưu trữ trong danh sách controlsToRemove
                foreach (Control controlToRemove in controlsToRemove)
                {
                    flowLayoutPanel.Controls.Remove(controlToRemove);
                    controlToRemove.Dispose(); // Giải phóng tài nguyên 
                }
            }
        }
    }
}
