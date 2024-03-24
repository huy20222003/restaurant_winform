using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MaterialSkin;
using MaterialSkin.Controls;
using restaurant.DAO;
using restaurant.DTO;
using Sunny.UI;

namespace restaurant
{
    public partial class FormAddProductToBill : MaterialForm
    {
        private FlowLayoutPanel flowLayoutPanel;
        private int billID;
        private int quantityValue;
        private string selectedSize;
        private string selectedColor;
        private Guna2CircleButton buttonAddProduct;

        public Action showProduct;

        public FormAddProductToBill(int billId)
        {
            InitializeComponent();
            InitializeMaterialSkinManager();
            billID = billId;
            DisplayProductList();
        }

        private void InitializeMaterialSkinManager()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void FormAddProductToBill_Load(object sender, EventArgs e)
        {
            DisplayProductList();
        }

        private void DisplayProductList()
        {
            string searchValue = txtProductSearchValue.Text;
            DataTable productList;
            flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                WrapContents = true,
                AutoScroll = true
            };

            if (string.IsNullOrEmpty(searchValue))
                productList = ProductDAO.Instance.GetListProduct();
            else
                productList = ProductDAO.Instance.GetProductByName(searchValue);

            foreach (DataRow row in productList.Rows)
            {
                Panel panelProductItem = new Panel
                {
                    Width = 1100,
                    Height = 80,
                    Padding = new Padding(10),
                    Margin = new Padding(10)
                };

                PictureBox pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = row["ImageUrl"].ToString(),
                    Location = new Point(10, 10),
                    Width = 80,
                    Height = 80,
                    InitialImage = Properties.Resources.logo_ver_2
                };

                MaterialLabel labelNameValue = new MaterialLabel
                {
                    Text = row["Name"].ToString(),
                    AutoSize = true,
                    FontType = MaterialSkinManager.fontType.Body1,
                    Location = new Point(100, 14)
                };

                MaterialLabel labelPriceValue = new MaterialLabel
                {
                    Text = "Giá tiền: " + row["Price"] + "VND",
                    AutoSize = true,
                    FontType = MaterialSkinManager.fontType.Body1,
                    Location = new Point(100, 55)
                };

                MaterialLabel labelPriceSaleValue = new MaterialLabel
                {
                    Text = "Giá tiền: " + row["PriceSale"] + "VND",
                    AutoSize = true,
                    FontType = MaterialSkinManager.fontType.Body1,
                    Location = new Point(100, 55)
                };

                buttonAddProduct = new Guna2CircleButton
                {
                    Size = new Size(50, 50),
                    Animated = true,
                    Image = Properties.Resources.icon_add,
                    Location = new Point(1000, 8),
                    Cursor = Cursors.Hand,
                    Tag = row // Lưu thông tin sản phẩm vào Tag
                };

                buttonAddProduct.Click += ButtonAddProduct_Click;

                Font font = new Font("Segoe UI", 14, FontStyle.Regular);

                UIIntegerUpDown quantity = new UIIntegerUpDown { Location = new Point(400, 14), Font = font };
                quantity.ValueChanged += (s, e) => { quantityValue = (int)quantity.Value; };

                UIComboBox chooseSize = new UIComboBox { Location = new Point(600, 14), Text = "Chọn kích cỡ" };
                string[] sizeArr = row["Size"].ToString().Split(',');
                chooseSize.Items.AddRange(sizeArr);
                chooseSize.SelectedIndexChanged += (s, e) => { selectedSize = chooseSize.SelectedItem.ToString(); };

                UIComboBox chooseColor = new UIComboBox { Location = new Point(800, 14), Text = "Chọn màu" };
                string[] colorArr = row["Color"].ToString().Split(',');
                chooseColor.Items.AddRange(colorArr);
                chooseColor.SelectedIndexChanged += (s, e) => { selectedColor = chooseColor.SelectedItem.ToString(); };

                panelProductItem.Controls.Add(pictureBox);
                panelProductItem.Controls.Add(labelNameValue);
                panelProductItem.Controls.Add(labelPriceValue);
                panelProductItem.Controls.Add(labelPriceSaleValue);
                panelProductItem.Controls.Add(buttonAddProduct);
                panelProductItem.Controls.Add(quantity);
                panelProductItem.Controls.Add(chooseSize);
                panelProductItem.Controls.Add(chooseColor);

                flowLayoutPanel.Controls.Add(panelProductItem);
            }
            productList?.Dispose();
            cardFormAddProduct.Controls.Clear();
            cardFormAddProduct.Controls.Add(flowLayoutPanel);
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            DataRow productInfo = ((sender as Guna2CircleButton)?.Tag as DataRow);

            if (productInfo != null)
            {
                if (quantityValue > 0 && (!string.IsNullOrEmpty(selectedSize) || !string.IsNullOrEmpty(selectedColor)))
                {
                    // Kiểm tra xem sản phẩm đã tồn tại trong hóa đơn chưa
                    BillDetail billDetailExists = BillDetailDAO.Instance.GetBillDetailIfExists(billID, Convert.ToInt32(productInfo["id"]));

                    // Thực hiện thêm hoặc cập nhật sản phẩm trong hóa đơn
                    bool actionResponse;
                    if (billDetailExists != null)
                    {
                        DateTime updatedAt = DateTime.Now;
                        string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        // Cập nhật sản phẩm trong hóa đơn
                        actionResponse = BillDetailDAO.Instance.UpdateBillDetail(billID, Convert.ToInt32(productInfo["id"]), quantityValue, selectedSize, selectedColor, formattedDate);
                    }
                    else
                    {
                        // Thêm mới sản phẩm vào hóa đơn
                        actionResponse = BillDetailDAO.Instance.InsertBillDetail(billID, Convert.ToInt32(productInfo["id"]), quantityValue, selectedSize, selectedColor);
                    }

                    // Hiển thị thông báo phản hồi dựa trên kết quả thực hiện
                    if (actionResponse)
                    {
                        decimal totalPrices = CaculateSumTotalPrice();
                        if (totalPrices != 0)
                        {
                            DateTime updatedAt = DateTime.Now;
                            string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fff");
                            bool updateBillResponse = BillDAO.Instance.UpdateBillTotalPrice(billID, totalPrices, formattedDate);
                            if (updateBillResponse)
                            {
                                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Thêm sản phẩm vào hóa đơn thành công.", ToolTipIcon.Info);
                            }
                            else
                            {
                                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật tổng tiền thất bại.", ToolTipIcon.Error);
                            }
                        }
                        else
                        {
                            notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Tổng tiền thanh toán phải khác 0.", ToolTipIcon.Error);
                        }
                    }
                    else
                    {
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Thao tác không thành công. Vui lòng thử lại sau.", ToolTipIcon.Error);
                    }
                }
                else
                {
                    notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Vui lòng chọn số lượng và thuộc tính cho sản phẩm.", ToolTipIcon.Warning);
                }
            }
        }

        private void txtProductSearchValue_TextChanged(object sender, EventArgs e)
        {
            DisplayProductList();
        }

        private decimal CaculateSumTotalPrice()
        {
            decimal totalPrices = 0;
            DataTable billDetailList = BillDetailDAO.Instance.GetBillDetailsByBillId(billID);
            foreach (DataRow row in billDetailList.Rows)
            {
                int productId = Convert.ToInt32(row["ProductId"]);
                int quantity = Convert.ToInt32(row["Quantity"]);

                // Lấy thông tin sản phẩm từ DAO
                Product product = ProductDAO.Instance.GetProductById(productId);

                if (product != null)
                {
                    // Tính giá tiền dựa trên giá gốc hoặc giá giảm nếu có
                    decimal price = (product.PriceSale != 0) ? product.PriceSale : product.Price;

                    // Tính tổng giá cho số lượng sản phẩm đã chọn
                    totalPrices += price * quantity;
                }
            }
            return totalPrices;
        }
    }
}
