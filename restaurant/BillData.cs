using MaterialSkin.Controls;
using MaterialSkin;
using restaurant.DAO;
using restaurant.DTO;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class Main
    {
        private int billIdSelected;
        private void showTableInTabBill()
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = (System.Windows.Forms.FlowDirection)System.Windows.FlowDirection.LeftToRight; // Hiển thị các thẻ theo chiều ngang
            flowLayoutPanel.WrapContents = true; // Cho phép các thẻ xuống dòng khi không còn đủ chỗ
            flowLayoutPanel.AutoScroll = true; // Hiển thị thanh cuộn nếu có quá nhiều thẻ
            //this.ClearCardItem();
            cardBillTable.Controls.Clear();
            // Xoá tất cả các panel trước trong flowLayoutPanel
            flowLayoutPanel.Controls.Clear();
            DataTable tableList = TablesDAO.Instance.GetListTable();

            // Lặp qua từng bản ghi trong DataTable
            foreach (DataRow row in tableList.Rows)
            {
                // Tạo một MaterialCard mới cho mỗi sản phẩm
                Panel panelTable = new Panel();
                panelTable.Width = 120; // Đặt độ rộng của thẻ sản phẩm
                panelTable.Height = 120;
                panelTable.Padding = new Padding(10); // Đặt padding cho thẻ sản phẩm
                panelTable.Margin = new Padding(10, 10, 30, 10);
                panelTable.Cursor = Cursors.Hand;

                // Tạo PictureBox để hiển thị hình ảnh sản phẩm
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new System.Drawing.Point(10, 10); // Đặt vị trí của PictureBox trong panel
                pictureBox.Width = panelTable.Width / 2;
                pictureBox.Height = panelTable.Height / 2;
                pictureBox.InitialImage = Properties.Resources.logo_ver_2;

                // Xác định trạng thái của bàn từ cột Status trong DataTable
                string tableStatus = row["Status"].ToString();
                if (tableStatus == "inactive")
                {
                    pictureBox.Image = Properties.Resources.table_inactive; // Hình ảnh cho trạng thái bàn "Không hoạt đọng"
                }
                else if (tableStatus == "active")
                {
                    pictureBox.Image = Properties.Resources.table_active; // Hình ảnh cho trạng thái bàn "hoạt động"
                }
                else if (tableStatus == "used")
                {
                    pictureBox.Image = Properties.Resources.table_used; // Hình ảnh cho trạng thái bàn "có người"
                }


                // Tạo các phần tử thông tin sản phẩm và đặt vị trí cho chúng
                MaterialLabel labelNameValue = new MaterialLabel() { Text = row["Name"].ToString(), AutoSize = true, FontType = MaterialSkinManager.fontType.Body1 };
                labelNameValue.Location = new System.Drawing.Point(20, 80); // Đặt vị trí của Label trong TableLayoutPanel
                                                                            // Tạo biểu tượng dấu ba chấm
                PictureBox moreOptionsPictureBox = new PictureBox();
                moreOptionsPictureBox.Image = Properties.Resources.more_option_icon; // Thay đổi hình ảnh theo nhu cầu
                moreOptionsPictureBox.Size = new System.Drawing.Size(25, 25);
                moreOptionsPictureBox.Location = new System.Drawing.Point(panelTable.Width - moreOptionsPictureBox.Width - 10, 10); // Đặt vị trí ở góc phải trên của panelTable
                moreOptionsPictureBox.Visible = true; // Ẩn biểu tượng ban đầu
                moreOptionsPictureBox.BringToFront();

                // Gắn sự kiện MouseHover vào panelTable để hiển thị biểu tượng dấu ba chấm
                //pictureBox.MouseEnter += (sender, e) =>
                //{
                //    moreOptionsPictureBox.Visible = true;
                //};
                //pictureBox.MouseLeave += (sender, e) =>
                //{
                //    moreOptionsPictureBox.Visible = false;
                //}; ;

                pictureBox.Tag = row;
                pictureBox.Click += showProductSelected;

                // Gắn sự kiện Click vào biểu tượng dấu ba chấm
                moreOptionsPictureBox.Click += (sender, e) =>
                {
                    // Tạo một ContextMenuStrip mới
                    ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

                    // Tạo một ToolStripMenuItem để thêm sản phẩm
                    ToolStripMenuItem buttonBill = new ToolStripMenuItem("Hoá đơn");
                    ToolStripMenuItem buttonBillAddProduct = new ToolStripMenuItem("Thêm sản phẩm");
                    ToolStripMenuItem buttonBillUpdateStatusTable = new ToolStripMenuItem("Cập nhật trạng thái bàn");
                    ToolStripMenuItem buttonBillAddBill = new ToolStripMenuItem("Tạo hoá đơn");
                    ToolStripMenuItem buttonBillRemoveBill = new ToolStripMenuItem("Xoá hoá đơn");

                    buttonBill.DropDownItems.Add(buttonBillAddBill);
                    buttonBill.DropDownItems.Add(buttonBillRemoveBill);

                    buttonBillAddProduct.Height = 50;
                    contextMenuStrip.Cursor = Cursors.Hand;
                    buttonBillUpdateStatusTable.Tag = row;
                    buttonBillUpdateStatusTable.Click += buttonBillUpdateStatusTable_Click;
                    buttonBillAddBill.Tag = row;
                    buttonBillRemoveBill.Tag = row;

                    // Kiểm tra trạng thái của bàn và thêm sự kiện cho ToolStripMenuItem
                    if (row["status"].ToString().ToLower() == "used")
                    {
                        buttonBillAddProduct.Tag = row;
                        buttonBillAddProduct.Click += buttonBillAddProduct_Click; // Gán sự kiện cho mục 1
                        buttonBillAddBill.ForeColor = System.Drawing.Color.DarkGray;
                        buttonBillRemoveBill.Click += buttonBillRemoveBill_Click;

                    }
                    else if(row["status"].ToString().ToLower() == "active")
                    {
                        buttonBillAddBill.Click += buttonBillAddBill_Click;
                        buttonBillRemoveBill.ForeColor = System.Drawing.Color.DarkGray;
                        buttonBillAddProduct.ForeColor = System.Drawing.Color.DarkGray;
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ góc bếp nhỏ", "Vui lòng tạo hoá đơn", ToolTipIcon.Warning);

                    } else
                    {
                        buttonBill.ForeColor = System.Drawing.Color.DarkGray;
                        buttonBillRemoveBill.ForeColor = System.Drawing.Color.DarkGray;
                        buttonBillAddBill.ForeColor = System.Drawing.Color.DarkGray;
                        buttonBillAddProduct.ForeColor = System.Drawing.Color.DarkGray;
                    }

                    // Thêm ToolStripMenuItem vào ContextMenuStrip
                    contextMenuStrip.Items.Add(buttonBill);
                    contextMenuStrip.Items.Add(buttonBillAddProduct);
                    contextMenuStrip.Items.Add(buttonBillUpdateStatusTable);

                    // Hiển thị menu tại vị trí của biểu tượng dấu ba chấm
                    contextMenuStrip.Show(moreOptionsPictureBox, new System.Drawing.Point(0, moreOptionsPictureBox.Height), ToolStripDropDownDirection.BelowRight);
                };

                // Thêm các controls vào panelTable
                panelTable.Controls.Add(pictureBox);
                panelTable.Controls.Add(labelNameValue);
                panelTable.Controls.Add(moreOptionsPictureBox);

                // Thêm panelTable vào FlowLayoutPanel
                flowLayoutPanel.Controls.Add(panelTable);
            }
            tableList?.Dispose();
            cardBillTable.Controls.Add(flowLayoutPanel);
        }

        private void buttonBillAddBill_Click(object sender, EventArgs e)
        {
            DataRow buttonAddBill = (sender as ToolStripItem).Tag as DataRow;
            int tableId = int.Parse(buttonAddBill["id"].ToString());
            decimal totalPrices = 0;
            string status = "unpaid";
            string paymentMethod = "";
            bool response = BillDAO.Instance.InsertBill(totalPrices, status, paymentMethod, tableId);
            if (response)
            {
                string tableStatus = "used";
                DateTime updatedAt = DateTime.Now; // Đây là đối tượng DateTime cần chuyển đổi
                string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fff");
                bool tableResponse = TablesDAO.Instance.UpdateTableStatus(tableId, tableStatus, formattedDate);
                if (tableResponse)
                {
                    this.showTableInTabBill();
                    notifyIcon.ShowBalloonTip(5000, "Thông báo từ Góc Bếp Nhỏ", "Tạo hoá đơn thành công", ToolTipIcon.Info);
                }
                else
                {
                    notifyIcon.ShowBalloonTip(5000, "Thông báo từ Góc Bếp Nhỏ", "Tạo hoá đơn thất bại", ToolTipIcon.Error);
                }
            }
            else
            {
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Tạo hoá đơn thất bại", ToolTipIcon.Error);
            }
        }

        private void buttonBillRemoveBill_Click(object sender, EventArgs e)
        {
            DataRow buttonRemoveBill = (sender as ToolStripItem).Tag as DataRow;
            int tableId = int.Parse(buttonRemoveBill["id"].ToString());
            string status = "active";
            DataTable getBillLastest = BillDAO.Instance.GetLatestBillByTableId(tableId);
            if(getBillLastest.Rows.Count > 0)
            {
                DataRow dataRow = getBillLastest.Rows[0];
                bool deleteBillDetailRespone = BillDetailDAO.Instance.DeleteBillDetailByBillId(int.Parse(dataRow["id"].ToString()));
                if (deleteBillDetailRespone)
                {
                    bool response = BillDAO.Instance.DeleteBillById(int.Parse(dataRow["id"].ToString()));
                    if (response)
                    {
                        DateTime updatedAt = DateTime.Now; // Đây là đối tượng DateTime cần chuyển đổi
                        string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        bool tableResponse = TablesDAO.Instance.UpdateTableStatus(tableId, status, formattedDate);
                        if (tableResponse)
                        {
                            this.showTableInTabBill();
                            notifyIcon.ShowBalloonTip(5000, "Thông báo từ Góc Bếp Nhỏ", "Xoá hoá đơn thành công", ToolTipIcon.Info);
                        }
                        else
                        {
                            notifyIcon.ShowBalloonTip(5000, "Thông báo từ Góc Bếp Nhỏ", "Xoá hoá đơn thất bại", ToolTipIcon.Error);
                        }
                    }
                    else
                    {
                        notifyIcon.ShowBalloonTip(5000, "Thông báo từ Góc Bếp Nhỏ", "Xoá hoá đơn thất bại", ToolTipIcon.Error);
                    }
                }
                else
                {
                    notifyIcon.ShowBalloonTip(5000, "Thông báo từ Góc Bếp Nhỏ", "Xoá hoá đơn thất bại", ToolTipIcon.Error);
                }
            } else
            {
                notifyIcon.ShowBalloonTip(5000, "Thông báo từ Góc Bếp Nhỏ", "Không tìm thấy hoá đơn", ToolTipIcon.Error);
            }  
        }

        private void buttonBillAddProduct_Click(object sender, EventArgs e)
        {
            DataRow tableInfo = (sender as ToolStripItem).Tag as DataRow;
            if (tableInfo != null)
            {
                int tableId;
                if (int.TryParse(tableInfo["ID"].ToString(), out tableId))
                {
                    DataTable dataTable = BillDAO.Instance.GetLatestBillByTableId(tableId);
                    if (dataTable.Rows.Count > 0)
                    {
                        // Lấy ra dòng đầu tiên từ DataTable
                        DataRow billInfo = dataTable.Rows[0];
                        FormAddProductToBill formAddProductToBill = new FormAddProductToBill(int.Parse(billInfo["id"].ToString()));
                        formAddProductToBill.TopMost = true;
                        formAddProductToBill.Show();
                    }
                    dataTable?.Dispose();
                }
            }
        }

        private void buttonBillUpdateStatusTable_Click(object sender, EventArgs e)
        {
            DataRow buttonUpdate = (sender as ToolStripItem).Tag as DataRow;
            string id = buttonUpdate["id"].ToString();
            string status = buttonUpdate["status"].ToString();

            FormUpdateTableStatus formUpdateTableStatus = new FormUpdateTableStatus(id, status);
            formUpdateTableStatus.TopMost = true;
            formUpdateTableStatus.showTableInBill = this.showTableInTabBill;
            formUpdateTableStatus.Show();
        }

        private void showProductSelected(object sender, EventArgs e)
        {
            DataRow tableInfo = (sender as PictureBox).Tag as DataRow;
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Width = cardBillProducts.Width;
            flowLayoutPanel.Height = cardBillProducts.Height - 100;
            flowLayoutPanel.Location = new System.Drawing.Point(0, 50);
            flowLayoutPanel.FlowDirection = (System.Windows.Forms.FlowDirection)System.Windows.FlowDirection.LeftToRight; // Hiển thị các thẻ theo chiều ngang
            flowLayoutPanel.WrapContents = true; // Cho phép các thẻ xuống dòng khi không còn đủ chỗ
            flowLayoutPanel.AutoScroll = true; // Hiển thị thanh cuộn nếu có quá nhiều thẻ
            if (tableInfo != null)
            {
                if (tableInfo["Status"].ToString() != "inactive")
                {
                    int tableId;
                    if (int.TryParse(tableInfo["ID"].ToString(), out tableId))
                    {
                        // Xoá tất cả các panel trước trong cardBillProducts
                        cardBillProducts.Controls.Clear();
                        // Xoá tất cả các panel trước trong flowLayoutPanel
                        flowLayoutPanel.Controls.Clear();
                        DataTable dataTable = BillDAO.Instance.GetLatestBillByTableId(tableId);

                        if (dataTable.Rows.Count > 0)
                        {
                            // Lấy ra dòng đầu tiên từ DataTable
                            DataRow firstRow = dataTable.Rows[0];
                            billIdSelected = int.Parse(firstRow["ID"].ToString());

                            DataTable productList = BillDetailDAO.Instance.GetBillDetailsByBillId(int.Parse(firstRow["id"].ToString()));

                            if (productList.Rows.Count > 0)
                            {
                                foreach (DataRow row in productList.Rows)
                                {
                                    Product product = ProductDAO.Instance.GetProductById(int.Parse(row["ProductId"].ToString()));
                                    // Tạo một MaterialCard mới cho mỗi sản phẩm
                                    Panel panelProduct = new Panel();
                                    panelProduct.Width = cardBillProducts.Width; // Đặt độ rộng của thẻ sản phẩm
                                    panelProduct.Height = 80;
                                    panelProduct.Margin = new Padding(10, 10, 30, 10);

                                    // Tạo PictureBox để hiển thị hình ảnh sản phẩm
                                    PictureBox pictureBox = new PictureBox();
                                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                    pictureBox.Location = new System.Drawing.Point(0, 0); // Đặt vị trí của PictureBox trong panel
                                    pictureBox.Width = 80;
                                    pictureBox.Height = panelProduct.Height;
                                    pictureBox.ImageLocation = product.ImageUrl;
                                    pictureBox.InitialImage = Properties.Resources.logo_ver_2;

                                    // Tạo các phần tử thông tin sản phẩm và đặt vị trí cho chúng
                                    MaterialLabel labelNameValue = new MaterialLabel() { Text = product.Name.ToString(), AutoSize = true, FontType = MaterialSkinManager.fontType.Subtitle1 };
                                    labelNameValue.Location = new System.Drawing.Point(92, 14); // Đặt vị trí của Label trong TableLayoutPanel
                                    labelNameValue.Margin = new Padding(5, 0, 5, 0);

                                    MaterialLabel labelSizeValue = new MaterialLabel() { Text = "size: " + row["Size"].ToString(), AutoSize = true, FontType = MaterialSkinManager.fontType.Caption };
                                    labelSizeValue.Location = new System.Drawing.Point(92, 48); // Đặt vị trí của Label trong TableLayoutPanel
                                    labelNameValue.Margin = new Padding(5, 0, 5, 0);

                                    MaterialLabel labeColorValue = new MaterialLabel() { Text = "color: " + row["Color"].ToString(), AutoSize = true, FontType = MaterialSkinManager.fontType.Caption };
                                    labeColorValue.Location = new System.Drawing.Point(170, 48); // Đặt vị trí của Label trong TableLayoutPanel
                                    labeColorValue.Margin = new Padding(5, 0, 5, 0);

                                    MaterialLabel labelQuantityValue = new MaterialLabel() { Text = "x" + row["Quantity"].ToString(), AutoSize = true, FontType = MaterialSkinManager.fontType.Body1 };
                                    labelQuantityValue.Location = new System.Drawing.Point(280, 32); // Đặt vị trí của Label trong TableLayoutPanel
                                    labelQuantityValue.Margin = new Padding(5, 0, 5, 0);

                                    MaterialLabel labelPriceValue = new MaterialLabel() { Text = product.Price + " đ", AutoSize = true, FontType = MaterialSkinManager.fontType.Body1 };
                                    labelPriceValue.Location = new System.Drawing.Point(320, 32); // Đặt vị trí của Label trong TableLayoutPanel
                                    labelPriceValue.Margin = new Padding(5, 0, 5, 0);

                                    PictureBox pictureBoxDeleteProduct = new PictureBox();
                                    pictureBoxDeleteProduct.SizeMode = PictureBoxSizeMode.StretchImage;
                                    pictureBoxDeleteProduct.Location = new System.Drawing.Point(380, 4); // Đặt vị trí của PictureBox trong panel
                                    pictureBoxDeleteProduct.Image = Properties.Resources.icon_close;
                                    pictureBoxDeleteProduct.Size = new System.Drawing.Size(16, 16);
                                    pictureBoxDeleteProduct.Cursor = Cursors.Hand;

                                    pictureBoxDeleteProduct.Tag = row;
                                    pictureBoxDeleteProduct.Click += PictureBoxDeleteProduct_Click;

                                    // Thêm các controls vào panelTable
                                    panelProduct.Controls.Add(pictureBox);
                                    panelProduct.Controls.Add(labelNameValue);
                                    panelProduct.Controls.Add(labelSizeValue);
                                    panelProduct.Controls.Add(labeColorValue);
                                    panelProduct.Controls.Add(labelQuantityValue);
                                    panelProduct.Controls.Add(labelPriceValue);
                                    panelProduct.Controls.Add(pictureBoxDeleteProduct);


                                    // Thêm panelTable vào FlowLayoutPanel
                                    flowLayoutPanel.Controls.Add(panelProduct);
                                }

                                MaterialLabel labelTotal = new MaterialLabel() { Text = "Tổng tiền: ", AutoSize = true, FontType = MaterialSkinManager.fontType.Body1 };
                                labelTotal.Location = new System.Drawing.Point(20, 560); // Đặt vị trí của Label trong TableLayoutPanel
                                labelTotal.Margin = new Padding(5, 0, 5, 0);

                                MaterialLabel labelTotalValue = new MaterialLabel() { Text = firstRow["totalPrices"].ToString() + " đ", AutoSize = true, FontType = MaterialSkinManager.fontType.H6, ForeColor = System.Drawing.Color.Blue };
                                labelTotalValue.Location = new System.Drawing.Point(320, 560); // Đặt vị trí của Label trong TableLayoutPanel
                                labelTotalValue.Margin = new Padding(5, 0, 5, 0);

                                cardBillProducts.Controls.Add(labelTotal);
                                cardBillProducts.Controls.Add(labelTotalValue);

                                cardBillProducts.Controls.Add(flowLayoutPanel);
                            }
                            else
                            {
                                MaterialLabel labelEmptyProduct = new MaterialLabel() { Text = "Chưa gọi món ăn", AutoSize = true, FontType = MaterialSkinManager.fontType.Body1 };
                                labelEmptyProduct.Location = new System.Drawing.Point(10, 250); // Đặt vị trí của Label trong TableLayoutPanel
                                labelEmptyProduct.Margin = new Padding(5, 0, 5, 0);
                                flowLayoutPanel.Controls.Add(labelEmptyProduct);
                                cardBillProducts.Controls.Add(flowLayoutPanel);
                            }
                        }
                        else
                        {
                            MaterialLabel labelEmptyProduct = new MaterialLabel() { Text = "Bàn này chưa sử dụng", AutoSize = true, FontType = MaterialSkinManager.fontType.Body1 };
                            labelEmptyProduct.Location = new System.Drawing.Point(10, 250); // Đặt vị trí của Label trong TableLayoutPanel
                            labelEmptyProduct.Margin = new Padding(5, 0, 5, 0);
                            flowLayoutPanel.Controls.Add(labelEmptyProduct);
                            cardBillProducts.Controls.Add(flowLayoutPanel);
                        }
                    }
                    else
                    {
                        notifyIcon.ShowBalloonTip(5000, "Thông báo từ Góc Bếp Nhỏ", "ID bàn không tồn tại!", ToolTipIcon.Error);
                    }
                }
                else
                {
                    flowLayoutPanel.Controls.Clear();
                    cardBillProducts.Controls.Clear();
                    // Hiển thị thông báo cho người dùng rằng bàn không có sẵn
                    notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Bàn này không phải là bàn đang hoạt động!", ToolTipIcon.Warning);
                }
            }
            else
            {
                notifyIcon.ShowBalloonTip(5000, "Thông báo từ Góc Bếp Nhỏ", "Không tìm thấy dữ liệu bàn này!", ToolTipIcon.Warning);
            }
        }

        private void PictureBoxDeleteProduct_Click(object sender, EventArgs e)
        {
            DataRow billDetailInfo = (sender as PictureBox).Tag as DataRow;
            if (billDetailInfo != null)
            {
                bool response = BillDetailDAO.Instance.DeleteProductFromBill(int.Parse(billDetailInfo["id"].ToString()));
                if (response)
                {
                    notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Xoá sản phẩm thành công", ToolTipIcon.Info);
                }
                else
                {
                    notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Xoá sản phẩm thất bại", ToolTipIcon.Error);
                }
            }
        }

        private void buttonBillPayment_Click(object sender, EventArgs e)
        {
            //DateTime updatedAt = DateTime.Now; // Đây là đối tượng DateTime cần chuyển đổi
            //string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //bool response = BillDAO.Instance.UpdateBillStatus(16, "paid", formattedDate);
            //if(response)
            //{
            //    notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Thanh toán thành công", ToolTipIcon.Info);
            //} else
            //{
            //    notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Thanh toán thất bại", ToolTipIcon.Error);
            //}
            CustomMessageBox.Show(billIdSelected.ToString());
            FormPayment formPayment = new FormPayment();
            formPayment.TopMost = true;
            formPayment.Show();
        }

    }
}
