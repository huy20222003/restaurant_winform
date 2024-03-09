using restaurant.DAO;
using restaurant.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows;
using System.Windows.Media;
using System.IO;
using System.Net;
using Microsoft.Win32;
using restaurant.Global;
using System.Reflection;
using CloudinaryDotNet.Actions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using Guna.UI2.WinForms;
using Sunny.UI;

namespace restaurant
{
    public partial class Main : MaterialForm
    {
        private string employee_username;
        private Employee currrent_employee;
        private FlowLayoutPanel flowLayoutPanel;
        private int itemsPerPage = 10; // Số lượng mục trên mỗi trang
        private int currentPage = 1; // Trang hiện tại
        public Main()
        {
            InitializeComponent();
            InitializeFlowLayoutPanel();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Main(string username)
        {
            InitializeComponent();
            InitializeFlowLayoutPanel();
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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.employee_username = username;
            Employee employee = EmployeeDAO.Instance.GetEmployeeByUserName(username);
            this.currrent_employee = employee;

            Load_Data();

        
        //--------------------------------------------------------------------------------------------------------
        }

        //---------------------------PHẦN BIỂU ĐỒ CHO TAB DASHBOARD-----------------------------------------------

        //--------------------------LINE CHART--------------------------------------------------------------------
        private void lineChart ()
        {
            int currentMonth = DateTime.Now.Month; // Lấy tháng hiện tại
            int currentYear = DateTime.Now.Year;   // Lấy năm hiện tại
            DataTable billCountByDay = BillDAO.Instance.GetBillCountByDate(currentMonth, currentYear);
            ChartValues<string> dayValues = new ChartValues<string>();
            ChartValues<int> billCountValues = new ChartValues<int>();
            foreach (DataRow row in billCountByDay.Rows)
            {
                int dayOfMonth = Convert.ToInt32(row["DayOfMonth"]);
                string formattedDate = dayOfMonth.ToString("00") + "/" + currentMonth.ToString("00");
                dayValues.Add(formattedDate);
                billCountValues.Add(Convert.ToInt32(row["TotalBills"]));
            }
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Ngày",
                Labels = dayValues
            });

            BillSeries = new LineSeries
            {
                Title = "Số lượng hoá đơn",
                Values = billCountValues
            };

            cartesianChart1.Series = new SeriesCollection
            {
                BillSeries
            };
        }

        public LineSeries BillSeries { get; set; }

        private void ToggleBillSeries(object sender, System.EventArgs e)
        {
            BillSeries.Visibility = BillSeries.Visibility == Visibility.Visible
                ? Visibility.Hidden
                : Visibility.Visible;
        }

        //-----------------------------PIE CHART-----------------------------------------------------------------
        private void pieChart()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable data = BillDetailDAO.Instance.GetTop5Products();

            // Tạo các series cho biểu đồ và thêm dữ liệu từ DataTable
            SeriesCollection seriesCollection = new SeriesCollection();
            foreach (DataRow row in data.Rows)
            {
                string productId = row["productId"].ToString();
                Product product = ProductDAO.Instance.GetProductById(int.Parse(productId));
                string percentageString = row["Percentage"].ToString();
                double percentage = double.Parse(percentageString.Substring(0, Math.Min(percentageString.Length, 4))); 


                PieSeries series = new PieSeries
                {
                    Title = product.Name,
                    Values = new ChartValues<double> { percentage },
                    DataLabels = true,
                    LabelPoint = labelPoint
                };

                seriesCollection.Add(series);
            }

            // Cập nhật biểu đồ với các series mới
            pieChart1.Series = seriesCollection;

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

    //-------------------------------------------------------------------------------------------------------

        private void Load_Data()
        {

            DTO.Role role = RoleDAO.Instance.GetRoleById(currrent_employee.RoleID);
            string roleName = role.Name;
            // Ẩn tabEmployee nếu vai trò là "admin"
            if (roleName == "admin")
            {
                tabEmployee.Show();
            }
            else
            {
                tabEmployee.Hide();
            }

            //gọi hàm
            this.getEmployeeCount();
            this.getProductSelledCount();
            this.getRevenue();
            this.getBillCount();
            this.lineChart();
            this.pieChart();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (this.currrent_employee.Avatar.StartsWith("https://"))
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(this.currrent_employee.Avatar);
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(stream);
                        pictureBoxAccountAvatar.Image = image;
                        pictureBoxDashboardEmployeeAvatar.Image = image;
                        pictureBoxDashboardEmployeeAvatar1.Image = image;
                        pictureBoxDashboardEmployeeAvatar3.Image = image;
                        pictureBoxDashboardEmployeeAvatar4.Image = image;
                        pictureBoxDashboardEmployeeAvatar5.Image = image;
                        pictureBoxDashboardEmployeeAvatar6.Image = image;
                        pictureBoxDashboardEmployeeAvatar7.Image = image;
                        pictureBoxDashboardEmployeeAvatar8.Image = image;
                        pictureBoxDashboardEmployeeAvatar9.Image = image;
                        pictureBoxDashboardEmployeeAvatar10.Image = image;
                    }
                }
            }

            labelAccountFullName.Text = this.currrent_employee.FullName;
            labelAccountUsername.Text = this.currrent_employee.UserName;
            txtAccountFullName.Text = this.currrent_employee.FullName;
            txtAccountUsername.Text = this.currrent_employee.UserName;
            txtAccountAddress.Text = this.currrent_employee.Address;
            txtAccountPhoneNumber.Text = this.currrent_employee.PhoneNumber;
            comboBoxAccountGender.Text = this.currrent_employee.Gender;
            comboBoxAccountAge.Text = this.currrent_employee.Age.ToString();

            labelDashboardEmployeeUsername.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername1.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername3.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername4.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername5.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername6.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername7.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername8.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername9.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername10.Text = this.currrent_employee.UserName;

            buttonDashboardLogout.Click += buttonLogout_Click;
            buttonDashboardLogout1.Click += buttonLogout_Click;
            buttonDashboardLogout3.Click += buttonLogout_Click;
            buttonDashboardLogout4.Click += buttonLogout_Click;
            buttonDashboardLogout5.Click += buttonLogout_Click;
            buttonDashboardLogout6.Click += buttonLogout_Click;
            buttonDashboardLogout7.Click += buttonLogout_Click;
            buttonDashboardLogout8.Click += buttonLogout_Click;
            buttonDashboardLogout9.Click += buttonLogout_Click;
            buttonDashboardLogout10.Click += buttonLogout_Click;

            timer.Interval = 1000; // Cập nhật mỗi giây
            timer.Tick += Timer_Tick;
            timer.Start();

            for (int i = 1; i <= 100; i++)
            {
                comboBoxAccountAge.Items.Add(i);
            }

            //uiToolTip1.SetToolTip(buttonAddProduct, "Thêm sản phẩm");
            guna2HtmlToolTip1.SetToolTip(buttonAddProduct, "Thêm sản phẩm");
            this.reportViewer1.RefreshReport();
        }

        private void InitializeFlowLayoutPanel()
        {
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = (System.Windows.Forms.FlowDirection)System.Windows.FlowDirection.LeftToRight; // Hiển thị các thẻ theo chiều ngang
            flowLayoutPanel.WrapContents = true; // Cho phép các thẻ xuống dòng khi không còn đủ chỗ
            flowLayoutPanel.AutoScroll = true; // Hiển thị thanh cuộn nếu có quá nhiều thẻ
        }

        //-----------------------------------TAB DASHBOARD---------------------------------------------------------------------
        private void getEmployeeCount()
        {
            int count = EmployeeDAO.Instance.GetEmployeeCount();
            labelDashboardCountEmployee.Text = count.ToString();
        }

        private void getProductSelledCount()
        {
            int count = BillDetailDAO.Instance.GetProductSelledCount();
            labelDashboardCountProductSelled.Text = count.ToString();
        }

        private void getBillCount()
        {
            int count = BillDAO.Instance.GetBillCount();
            labelDashboardCountBill.Text = count.ToString();
        }

        private void getRevenue()
        {
            int count = BillDAO.Instance.GetRevenue();
            labelDashboardRevenue.Text = count.ToString();
        }
        //----------------------------------------------------------------------------------------------------------------------

        //------------------------------------TAB CATEGORY----------------------------------------------------------------------
        //hàm lấy ra tất cả danh mục và hiển thị ra listview
        private void getListCategoryToListView(int page)
        {
            // Tính chỉ số bắt đầu và kết thúc của dữ liệu trên trang hiện tại
            int startIndex = (page - 1) * itemsPerPage;
            int endIndex = Math.Min(startIndex + itemsPerPage - 1, categoryListView.Items.Count - 1);

            CustomMessageBox.Show(startIndex.ToString() + endIndex.ToString());

            // Lấy danh sách các danh mục từ cơ sở dữ liệu
            DataTable dataTable = CategoryDAO.Instance.GetListCategory();

            // Xóa danh sách hiện tại trước khi thêm mới
            categoryListView.Items.Clear();

            // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu và chỉ hiển thị dữ liệu trên trang hiện tại
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    // Tạo một ListViewItem mới và thêm các dữ liệu vào
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["image"].ToString());
                    item.SubItems.Add(row["name"].ToString());
                    item.SubItems.Add(row["description"].ToString());
                    item.SubItems.Add(row["createdAt"].ToString());
                    item.SubItems.Add(row["updatedAt"].ToString());
                    item.SubItems.Add("Sửa | Xoá");

                    // Thêm ListViewItem vào ListView
                    categoryListView.Items.Add(item);
                }
            }
        }

        // Xử lý sự kiện PageChanged của UIMiniPagination
        private void UpdateCategoryListView()
        {
            getListCategoryToListView(currentPage);
            // Cập nhật lại trạng thái của UIMiniPagination
            int totalItems = CategoryDAO.Instance.GetTotalCategories(); // Lấy tổng số danh mục từ cơ sở dữ liệu
            int totalPages = (int)Math.Ceiling((double)totalItems / itemsPerPage);
            categoryPagnation.TotalCount = totalPages;
            // Không có phương thức trực tiếp để cập nhật trang hiện tại, nên chúng ta cần cập nhật biến currentPage
        }

        // Xử lý sự kiện PageChanged của UIMiniPagination
        private void categoryPagnation_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            currentPage = pageIndex + 1; // pageIndex bắt đầu từ 0, nên cần cộng thêm 1
            UpdateCategoryListView();
        }


        //hàm gọi form thêm danh mục
        private void buttonOpenFormAddCategory_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.TopMost = true;
            formCategory.getListCategory = UpdateCategoryListView;
            formCategory.Show();
        }

        private void categoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isEdit = true;
            // Kiểm tra xem có phần tử nào được chọn không
            if (categoryListView.SelectedItems.Count > 0)
            {
                // Lấy phần tử đầu tiên được chọn
                ListViewItem selectedItem = categoryListView.SelectedItems[0];

                // Lấy thông tin từ các cột của phần tử được chọn
                string id = selectedItem.SubItems[0].Text;
                string name = selectedItem.SubItems[2].Text;
                string description = selectedItem.SubItems[3].Text;
                string imageUrl = selectedItem.SubItems[1].Text;
                FormCategory formCategory = new FormCategory(id, name, description, imageUrl, isEdit);
                formCategory.getListCategory = UpdateCategoryListView;
                formCategory.Show();
            }
        }

        private void txtCategorySearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtCategorySearch.Text;

            if (searchValue == "")
            {
                this.UpdateCategoryListView();
            }
            else
            {
                // Lấy danh sách các danh mục từ cơ sở dữ liệu
                DataTable dataTable = CategoryDAO.Instance.SearchCategoryByNameOrId(searchValue);

                categoryListView.Items.Clear();

                // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    // Duyệt qua mỗi dòng dữ liệu trong DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Tạo một ListViewItem mới và thêm các dữ liệu vào
                        ListViewItem item = new ListViewItem(row["id"].ToString());
                        item.SubItems.Add(row["image"].ToString());
                        item.SubItems.Add(row["name"].ToString());
                        item.SubItems.Add(row["description"].ToString());
                        item.SubItems.Add(row["createdAt"].ToString());
                        item.SubItems.Add(row["updatedAt"].ToString());
                        item.SubItems.Add("Sửa | Xoá");

                        // Thêm ListViewItem vào ListView
                        categoryListView.Items.Add(item);
                    }
                }
            }
        }



        //------------------------------------------------------------------------------------------------------------------------------

        //---------------------------------------TAB PRODUCT----------------------------------------------------------------------------

        private void ShowProductItems(DataTable productList)
        {
            // Hiển thị hiệu ứng loader
            progressIndicatorProduct.Visible = true;

            // Tạo mới FlowLayoutPanel
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Controls.Clear();
            flowLayoutPanel.FlowDirection = (System.Windows.Forms.FlowDirection)System.Windows.FlowDirection.LeftToRight;
            flowLayoutPanel.WrapContents = true;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new System.Drawing.Point(10, 200);
            flowLayoutPanel.Width = tabProduct.Width;
            flowLayoutPanel.Height = tabProduct.Height;

            flowLayoutPanel.Controls.Clear();
            // Lặp qua từng bản ghi trong DataTable
            foreach (DataRow row in productList.Rows)
            {
                // Tạo một MaterialCard mới cho mỗi sản phẩm
                MaterialCard cardProductItem = new MaterialCard();
                cardProductItem.Width = 340;
                cardProductItem.Height = 180;
                cardProductItem.Padding = new Padding(5);
                cardProductItem.Margin = new Padding(10);

                // Tạo PictureBox để hiển thị hình ảnh sản phẩm
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.ImageLocation = row["ImageUrl"].ToString();
                pictureBox.Location = new System.Drawing.Point(170, 0);
                pictureBox.Width = cardProductItem.Width / 2;
                pictureBox.Height = cardProductItem.Height;
                pictureBox.InitialImage = Properties.Resources.logo_ver_2;

                // Tạo các phần tử thông tin sản phẩm và đặt vị trí cho chúng
                MaterialLabel labelNameValue = new MaterialLabel() { Text = row["Name"].ToString(), AutoSize = true, FontType = MaterialSkinManager.fontType.Body1 };
                labelNameValue.Location = new System.Drawing.Point(10, 20);

                MaterialLabel labelPriceValue = new MaterialLabel() { Text = row["Price"].ToString() + "VND", AutoSize = true, FontType = MaterialSkinManager.fontType.H6 };
                labelPriceValue.ForeColor = System.Drawing.Color.Blue;
                labelPriceValue.Location = new System.Drawing.Point(10, 140);

                cardProductItem.Cursor = Cursors.Hand;
                cardProductItem.DoubleClick += cardProductItem_DoubleClick;
                cardProductItem.Tag = row;

                cardProductItem.Controls.Add(pictureBox);
                cardProductItem.Controls.Add(labelNameValue);
                cardProductItem.Controls.Add(labelPriceValue);

                // Thêm thẻ sản phẩm vào FlowLayoutPanel
                flowLayoutPanel.Controls.Add(cardProductItem);
            }

            // Ẩn hiệu ứng loader khi đã thêm xong các card sản phẩm
            progressIndicatorProduct.Visible = false;

            // Thêm FlowLayoutPanel vào TabPage hoặc Panel tương ứng
            tabProduct.Controls.Add(flowLayoutPanel);
        }

        private void ShowAllProducts()
        {
            DataTable productList = ProductDAO.Instance.GetListProduct();
            this.ShowProductItems(productList);
        }

        private void txtProductSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductSearch.Text))
            {
                this.ShowAllProducts();
            }
            else
            {
                DataTable productList = ProductDAO.Instance.GetProductByName(txtProductSearch.Text);
                this.ShowProductItems(productList);
            }
        }


        private void cardProductItem_DoubleClick(object sender, EventArgs e)
        {
            bool isEdit = true;
            DataRow productInfo = (sender as MaterialCard).Tag as DataRow;

            string id = productInfo["ID"].ToString();
            string name = productInfo["Name"].ToString();
            string description = productInfo["Description"].ToString();
            string imageUrl = productInfo["imageUrl"].ToString();
            string price = productInfo["Price"].ToString();
            string priceSale = productInfo["PriceSale"].ToString();
            string status = productInfo["Status"].ToString();
            string color = productInfo["Color"].ToString();
            string size = productInfo["Size"].ToString();
            string quantity = productInfo["Quantity"].ToString();
            string categoryId = productInfo["CategoryId"].ToString();

            FormProduct formProduct = new FormProduct(id, name, description, imageUrl, price, priceSale, categoryId, status, color, size, quantity, isEdit);
            formProduct.TopMost = true;
            formProduct.GetListProduct = this.ShowAllProducts;
            formProduct.ShowDialog();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.TopMost = true;
            formProduct.GetListProduct = this.ShowAllProducts;
            formProduct.ShowDialog();
        }

        //-----------------------------------------------------------------------------------------------------------------------------------

        //-------------------------------------------TAB TABLE-------------------------------------------------------------------------------

        private void getListTableToListView()
        {
            // Lấy danh sách các danh mục từ cơ sở dữ liệu
            DataTable dataTable = TablesDAO.Instance.GetListTable();

            tableListView.Items.Clear();

            // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Duyệt qua mỗi dòng dữ liệu trong DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    // Tạo một ListViewItem mới và thêm các dữ liệu vào
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["name"].ToString());
                    item.SubItems.Add(row["description"].ToString());
                    item.SubItems.Add(row["status"].ToString());
                    item.SubItems.Add(row["createdAt"].ToString());
                    item.SubItems.Add(row["updatedAt"].ToString());
                    item.SubItems.Add("Sửa | Xoá");

                    // Thêm ListViewItem vào ListView
                    tableListView.Items.Add(item);
                }
            }
        }

        private void buttonOpenFormAddTable_Click(object sender, EventArgs e)
        {
            FormTable formTable = new FormTable();
            formTable.TopMost = true;
            formTable.getListTable = this.getListTableToListView;
            formTable.Show();
        }

        private void tableListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isEdit = true;
            // Kiểm tra xem có phần tử nào được chọn không
            if (tableListView.SelectedItems.Count > 0)
            {
                // Lấy phần tử đầu tiên được chọn
                ListViewItem selectedItem = tableListView.SelectedItems[0];

                // Lấy thông tin từ các cột của phần tử được chọn
                string id = selectedItem.SubItems[0].Text;
                string name = selectedItem.SubItems[1].Text;
                string description = selectedItem.SubItems[2].Text;
                string status = selectedItem.SubItems[3].Text;
                FormTable formTable = new FormTable(id, name, description, status, isEdit);
                formTable.getListTable = this.getListTableToListView;
                formTable.Show();
            }
        }

        private void txtTableSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtTableSearch.Text;

            if (searchValue == "")
            {
                this.getListTableToListView();
            }
            else
            {
                // Lấy danh sách các bàn từ cơ sở dữ liệu
                DataTable dataTable = TablesDAO.Instance.GetTableByIdOrName(searchValue);

                tableListView.Items.Clear();

                // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    // Duyệt qua mỗi dòng dữ liệu trong DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Tạo một ListViewItem mới và thêm các dữ liệu vào
                        ListViewItem item = new ListViewItem(row["id"].ToString());
                        item.SubItems.Add(row["name"].ToString());
                        item.SubItems.Add(row["description"].ToString());
                        item.SubItems.Add(row["createdAt"].ToString());
                        item.SubItems.Add(row["updatedAt"].ToString());
                        item.SubItems.Add("Sửa | Xoá");

                        // Thêm ListViewItem vào ListView
                        tableListView.Items.Add(item);
                    }
                }
            }
        }

        //----------------------------------------------------------------------------------------------------------------------

        //---------------------------------------TAB SETTING--------------------------------------------------------------------

        private void buttonSettingChangePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = txtSettingOldPassword.Text.Trim();
            string newPassword = txtSettingNewPassword.Text.Trim();
            string confirmNewPassword = txtSettingConfirmNewPassword.Text.Trim();

            if (!Data.VerifyPassword(oldPassword, this.currrent_employee.Password))
            {
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Mật khẩu không đúng", ToolTipIcon.Error);
            }
            else if (newPassword != confirmNewPassword)
            {
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Mật khẩu nhập lại không khớp", ToolTipIcon.Error);
            }
            else if (string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
            {
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Vui lòng nhập đầy đủ thông tin", ToolTipIcon.Warning);
            }
            else
            {
                bool response = EmployeeDAO.Instance.ResetPassword(this.currrent_employee.ID, Data.HashPassword(newPassword));
                if (response)
                {
                    notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật mật khẩu thành công", ToolTipIcon.Info);
                    // Làm mới các trường nhập liệu
                    txtSettingOldPassword.Text = "";
                    txtSettingNewPassword.Text = "";
                    txtSettingConfirmNewPassword.Text = "";
                }
                else
                {
                    notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật mật khẩu thất bại", ToolTipIcon.Error);
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------TAB EMPLOYEE------------------------------------------------------------------------

        private void showEmployeeItem()
        {
            ClearCardItem();
            DataTable employeeList = EmployeeDAO.Instance.GetListEmployee();
            // Lặp qua từng bản ghi trong DataTable
            foreach (DataRow row in employeeList.Rows)
            {
                // Tạo một MaterialCard mới cho mỗi sản phẩm
                MaterialCard cardEmployeeItem = new MaterialCard();
                cardEmployeeItem.Width = 600; // Đặt độ rộng của thẻ sản phẩm
                cardEmployeeItem.Height = 250;
                cardEmployeeItem.Padding = new Padding(10); // Đặt padding cho thẻ sản phẩm
                cardEmployeeItem.Margin = new Padding(20, 150, 10, 10);

                // Tạo PictureBox để hiển thị hình ảnh sản phẩm
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = cardEmployeeItem.Width / 3; // Chiếm 1/3 chiều rộng của cardEmployeeItem
                pictureBox.Height = cardEmployeeItem.Height; // Chiều cao bằng cardEmployeeItem
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.ImageLocation = row["avatar"].ToString();


                // Thêm các thông tin sản phẩm vào TableLayoutPanel
                MaterialLabel labelFullName = new MaterialLabel() { Text = "Tên đầy đủ: ", AutoSize = true, FontType = MaterialSkinManager.fontType.Subtitle1 };
                labelFullName.Location = new System.Drawing.Point(220, 20);
                MaterialLabel labelFullNameValue = new MaterialLabel() { Text = row["FullName"].ToString(), AutoSize = true };
                labelFullNameValue.Location = new System.Drawing.Point(350, 20);

                MaterialLabel labelUsername = new MaterialLabel() { Text = "Tên đăng nhập: ", AutoSize = true, FontType = MaterialSkinManager.fontType.Subtitle1 };
                labelUsername.Location = new System.Drawing.Point(220, 50);
                MaterialLabel labelUsernameValue = new MaterialLabel() { Text = row["Username"].ToString(), AutoSize = true };
                labelUsernameValue.Location = new System.Drawing.Point(350, 50);

                MaterialLabel labelGender = new MaterialLabel() { Text = "Giới tính: ", AutoSize = true, FontType = MaterialSkinManager.fontType.Subtitle1 };
                labelGender.Location = new System.Drawing.Point(220, 80);
                MaterialLabel labelGenderValue = new MaterialLabel() { Text = row["Gender"].ToString(), AutoSize = true };
                labelGenderValue.Location = new System.Drawing.Point(350, 80);

                MaterialLabel labelAddress = new MaterialLabel() { Text = "Địa chỉ: ", AutoSize = true, FontType = MaterialSkinManager.fontType.Subtitle1 };
                labelAddress.Location = new System.Drawing.Point(220, 110);
                MaterialLabel labelAddressValue = new MaterialLabel() { Text = row["Address"].ToString(), AutoSize = true };
                labelAddressValue.Location = new System.Drawing.Point(350, 110);

                MaterialLabel labelAge = new MaterialLabel() { Text = "Tuổi: ", AutoSize = true, FontType = MaterialSkinManager.fontType.Subtitle1 };
                labelAge.Location = new System.Drawing.Point(220, 140);
                MaterialLabel labelAgeValue = new MaterialLabel() { Text = row["Age"].ToString(), AutoSize = true };
                labelAgeValue.Location = new System.Drawing.Point(350, 140);

                MaterialLabel labelPosition = new MaterialLabel() { Text = "Chức vụ: ", AutoSize = true, FontType = MaterialSkinManager.fontType.Subtitle1 };
                labelPosition.Location = new System.Drawing.Point(220, 170);
                int roleID = int.Parse(row["roleID"].ToString());
                DTO.Role role = RoleDAO.Instance.GetRoleById(roleID);
                MaterialLabel labelPositionValue = new MaterialLabel() { Text = role.Name, AutoSize = true };
                labelPositionValue.Location = new System.Drawing.Point(350, 170);

                MaterialButton buttonViewDetailEmployee = new MaterialButton() { Text = "Xem chi tiết", AutoSize = true, Cursor = Cursors.Hand };
                buttonViewDetailEmployee.Location = new System.Drawing.Point(400, 200);


                cardEmployeeItem.Controls.Add(pictureBox);
                cardEmployeeItem.Controls.Add(labelFullName);
                cardEmployeeItem.Controls.Add(labelFullNameValue);
                cardEmployeeItem.Controls.Add(labelUsername);
                cardEmployeeItem.Controls.Add(labelUsernameValue);
                cardEmployeeItem.Controls.Add(labelGender);
                cardEmployeeItem.Controls.Add(labelGenderValue);
                cardEmployeeItem.Controls.Add(labelAddress);
                cardEmployeeItem.Controls.Add(labelAddressValue);
                cardEmployeeItem.Controls.Add(labelAge);
                cardEmployeeItem.Controls.Add(labelAgeValue);
                cardEmployeeItem.Controls.Add(labelPosition);
                cardEmployeeItem.Controls.Add(labelPositionValue);
                cardEmployeeItem.Controls.Add(buttonViewDetailEmployee);

                buttonViewDetailEmployee.Click += buttonViewDetailEmployee_Click;
                buttonViewDetailEmployee.Tag = row;

                // Thêm thẻ sản phẩm vào FlowLayoutPanel
                flowLayoutPanel.Controls.Add(cardEmployeeItem);
            }

            // Thêm FlowLayoutPanel vào TabPage hoặc Panel tương ứng
            tabEmployee.Controls.Add(flowLayoutPanel);
        }

        private void buttonViewDetailEmployee_Click(object sender, EventArgs e)
        {
            bool isEdit = true;
            DataRow employeeInfo = (sender as MaterialButton).Tag as DataRow;

            string id = employeeInfo["ID"].ToString();
            string fullName = employeeInfo["FullName"].ToString();
            string username = employeeInfo["Username"].ToString();
            string avatar = employeeInfo["Avatar"].ToString();
            string gender = employeeInfo["Gender"].ToString();
            string age = employeeInfo["Age"].ToString();
            string address = employeeInfo["Address"].ToString();
            string roleId = employeeInfo["RoleID"].ToString();
            string phoneNumber = employeeInfo["PhoneNumber"].ToString();

            FormEmployee formEmployee = new FormEmployee(id, fullName, username, avatar, age, address, gender, phoneNumber, roleId, isEdit);
            formEmployee.TopMost = true;
            formEmployee.getListEmployee = this.showEmployeeItem;
            formEmployee.Show();
        }

        private void buttonEmployeeAdd_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.TopMost = true;
            formEmployee.getListEmployee = this.showEmployeeItem;
            formEmployee.Show();
        }

        //--------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------TAB ACCOUNT-------------------------------------------------------------------------

        private void buttonAccountChooseImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                FormAvatar formAvatar = new FormAvatar(this.currrent_employee.ID, imagePath);
                formAvatar.TopMost = true;
                formAvatar.Show();
            }
        }

        private void buttonAccountChangeInfo_Click(object sender, EventArgs e)
        {
            if(txtAccountFullName.Text == "" || txtAccountUsername.Text == "" || txtAccountAddress.Text == "" || comboBoxAccountGender.SelectedItem == null || comboBoxAccountAge.SelectedItem == null || string.IsNullOrEmpty(txtAccountPhoneNumber.Text)) 
            {
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Vui lòng nhập đầy đủ thông tin!", ToolTipIcon.Warning);
            } 
            else
            {
                DateTime updatedAt = DateTime.Now; // Đây là đối tượng DateTime cần chuyển đổi
                string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fffffff");
                bool response = EmployeeDAO.Instance.UpdateEmployeeDetail(this.currrent_employee.ID, txtAccountUsername.Text, txtAccountFullName.Text, comboBoxAccountGender.SelectedItem.ToString(), txtAccountAddress.Text, int.Parse(comboBoxAccountAge.SelectedItem.ToString()), txtAccountPhoneNumber.Text, formattedDate);
                if (response)
                {
                    notifyIcon.ShowBalloonTip(5000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật thông tin thành công", ToolTipIcon.Info);
                } else
                {
                    notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật thông tin thất bại", ToolTipIcon.Error);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------

        //-------------------------------------TAB ROLE---------------------------------------------------------------
        private void getListRoleToListView()
        {
            // Lấy danh sách các danh mục từ cơ sở dữ liệu
            DataTable dataTable = RoleDAO.Instance.GetListRole();

            roleListView.Items.Clear();

            // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Duyệt qua mỗi dòng dữ liệu trong DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    // Tạo một ListViewItem mới và thêm các dữ liệu vào
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["name"].ToString());
                    item.SubItems.Add(row["description"].ToString());
                    item.SubItems.Add(row["createdAt"].ToString());
                    item.SubItems.Add(row["updatedAt"].ToString());
                    item.SubItems.Add("Sửa | Xoá");

                    // Thêm ListViewItem vào ListView
                    roleListView.Items.Add(item);
                }
            }
        }
        private void buttonOpenFormAddRole_Click(object sender, EventArgs e)
        {
            MaterialForm materialForm = new MaterialForm();
            using(FormRole formRole = new FormRole())
            {
                materialForm.StartPosition = FormStartPosition.Manual;
                materialForm.FormBorderStyle = FormBorderStyle.None;
                materialForm.Opacity = 0.5d;
                materialForm.BackColor = System.Drawing.Color.Black;
                materialForm.Size = this.Size;
                materialForm.Location = this.Location;
                materialForm.ShowInTaskbar = false;
                materialForm.Show();
                formRole.Owner = materialForm;
                formRole.ShowDialog();
                materialForm.Dispose();
            }
        }

        private void roleListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isEdit = true;
            // Kiểm tra xem có phần tử nào được chọn không
            if (roleListView.SelectedItems.Count > 0)
            {
                // Lấy phần tử đầu tiên được chọn
                ListViewItem selectedItem = roleListView.SelectedItems[0];

                // Lấy thông tin từ các cột của phần tử được chọn
                string id = selectedItem.SubItems[0].Text;
                string name = selectedItem.SubItems[1].Text;
                string description = selectedItem.SubItems[2].Text;
                FormRole formRole = new FormRole(id, name, description, isEdit);
                formRole.getListRole = this.getListRoleToListView;
                formRole.Show();
            }
        }

        private void txtRoleSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtRoleSearch.Text;

            if (searchValue == "")
            {
                this.getListRoleToListView();
            }
            else
            {
                // Lấy danh sách các bàn từ cơ sở dữ liệu
                DataTable dataTable = RoleDAO.Instance.GetRoleByIdOrName(searchValue);
                roleListView.Items.Clear();

                // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    // Duyệt qua mỗi dòng dữ liệu trong DataTable
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Tạo một ListViewItem mới và thêm các dữ liệu vào
                        ListViewItem item = new ListViewItem(row["id"].ToString());
                        item.SubItems.Add(row["name"].ToString());
                        item.SubItems.Add(row["description"].ToString());
                        item.SubItems.Add(row["createdAt"].ToString());
                        item.SubItems.Add(row["updatedAt"].ToString());
                        item.SubItems.Add("Sửa | Xoá");

                        // Thêm ListViewItem vào ListView
                        roleListView.Items.Add(item);
                    }
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------------------

        //-----------------------------TAB BILL----------------------------------------------------------------------------------

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
                    ToolStripMenuItem buttonBillAddBill = new ToolStripMenuItem("Tạo hoá đơn");
                    ToolStripMenuItem buttonBillAddProduct = new ToolStripMenuItem("Thêm sản phẩm");
                    ToolStripMenuItem buttonBillUpdateStatusTable = new ToolStripMenuItem("Cập nhật trạng thái bàn");
                    buttonBillAddProduct.Height = 50;
                    contextMenuStrip.Cursor = Cursors.Hand;
                    buttonBillUpdateStatusTable.Tag = row;
                    buttonBillUpdateStatusTable.Click += buttonBillUpdateStatusTable_Click;
                    buttonBillAddBill.Tag = row;

                    // Kiểm tra trạng thái của bàn và thêm sự kiện cho ToolStripMenuItem
                    if (row["status"].ToString().ToLower() == "used")
                    {
                        buttonBillAddProduct.Tag = row;
                        buttonBillAddProduct.Click += buttonBillAddProduct_Click; // Gán sự kiện cho mục 1

                    }
                    else
                    {
                        buttonBillAddProduct.ForeColor = System.Drawing.Color.DarkGray;

                    }

                    if (row["status"].ToString().ToLower() == "active")
                    {
                        buttonBillAddBill.Click += buttonBillAddBill_Click;
                    }
                    else
                    {
                        buttonBillAddBill.ForeColor = System.Drawing.Color.DarkGray;
                    }

                    // Thêm ToolStripMenuItem vào ContextMenuStrip
                    contextMenuStrip.Items.Add(buttonBillAddBill);
                    contextMenuStrip.Items.Add(buttonBillAddProduct);
                    contextMenuStrip.Items.Add(buttonBillUpdateStatusTable);

                    // Hiển thị menu tại vị trí của biểu tượng dấu ba chấm
                    contextMenuStrip.Show(moreOptionsPictureBox, new System.Drawing.Point(0, moreOptionsPictureBox.Height), ToolStripDropDownDirection.BelowLeft);
                };

                // Thêm các controls vào panelTable
                panelTable.Controls.Add(pictureBox);
                panelTable.Controls.Add(labelNameValue);
                panelTable.Controls.Add(moreOptionsPictureBox);

                // Thêm panelTable vào FlowLayoutPanel
                flowLayoutPanel.Controls.Add(panelTable);
            }
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
            if(response)
            {
                string tableStatus = "used";
                DateTime updatedAt = DateTime.Now; // Đây là đối tượng DateTime cần chuyển đổi
                string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fff");
                bool tableResponse = TablesDAO.Instance.UpdateTableStatus(tableId, tableStatus, formattedDate);
                if(tableResponse)
                {
                    this.showTableInTabBill();
                    notifyIcon.ShowBalloonTip(5000, "Thông báo từ Góc Bếp Nhỏ", "Tạo hoá đơn thành công", ToolTipIcon.Info);
                } else
                {
                    notifyIcon.ShowBalloonTip(5000, "Thông báo từ Góc Bếp Nhỏ", "Tạo hoá đơn thất bại", ToolTipIcon.Error);
                }
            } else
            {
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Tạo hoá đơn thất bại", ToolTipIcon.Error);
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
            if(tableInfo != null)
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
                                    labelQuantityValue.Location = new System.Drawing.Point(300, 32); // Đặt vị trí của Label trong TableLayoutPanel
                                    labelQuantityValue.Margin = new Padding(5, 0, 5, 0);

                                    MaterialLabel labelPriceValue = new MaterialLabel() { Text = product.Price + "đ", AutoSize = true, FontType = MaterialSkinManager.fontType.Body1 };
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
                        } else
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
            if(billDetailInfo != null)
            {
                bool response = BillDetailDAO.Instance.DeleteProductFromBill(int.Parse(billDetailInfo["id"].ToString()));
                if(response)
                {
                    notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Xoá sản phẩm thành công", ToolTipIcon.Info);
                } else
                {
                    notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Xoá sản phẩm thất bại", ToolTipIcon.Error);
                }
            }
        }

        private void buttonBillPayment_Click(object sender, EventArgs e)
        {
            DateTime updatedAt = DateTime.Now; // Đây là đối tượng DateTime cần chuyển đổi
            string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fff");
            bool response = BillDAO.Instance.UpdateBillStatus(16, "paid", formattedDate);
            if(response)
            {
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Thanh toán thành công", ToolTipIcon.Info);
            } else
            {
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Thanh toán thất bại", ToolTipIcon.Error);
            }
        }


        //----------------------------------------------------------------------------------------------------------------------

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    this.getEmployeeCount();
                    this.getProductSelledCount();
                    this.getRevenue();
                    this.getBillCount();
                    this.lineChart();
                    this.pieChart();
                    break;
                case 1:
                    this.UpdateCategoryListView();
                    break;
                case 2:
                    this.ShowAllProducts();
                    break;
                case 3:
                    this.getListTableToListView();
                    break;
                case 4:
                    this.showTableInTabBill();
                    break;
                case 6:
                    this.showEmployeeItem();
                    break;
                case 7:
                    this.getListRoleToListView();
                    break;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
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
                    if (control is MaterialCard || control is Panel)
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại
            DateTime now = DateTime.Now;

            // Hiển thị ngày tháng thứ giờ phút giây hiện tại trên label
            string time = string.Format("Thời gian hiện tại: {0:00}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}",
                                                now.Day, now.Month, now.Year, 
                                                now.Hour, now.Minute, now.Second);
            labelTimeNow.Text = time;
            labelTimeNow1.Text = time;
            labelTimeNow2.Text = time;
            labelTimeNow3.Text = time;
            labelTimeNow4.Text = time;
            labelTimeNow5.Text = time;
            labelTimeNow6.Text = time;
            labelTimeNow7.Text = time;
            labelTimeNow8.Text = time;
            labelTimeNow9.Text = time;
        }
    }
}