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

namespace restaurant
{
    public partial class Main : MaterialForm
    {
        private string employee_username;
        private Employee currrent_employee;
        private FlowLayoutPanel flowLayoutPanel;
        private PictureBox moreOptionsPictureBox;
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
            materialSkinManager.ColorScheme = new ColorScheme(
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
            getEmployeeCount();
            getProductSelledCount();
            getRevenue();
            getBillCount();
            lineChart();
            pieChart();
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
                    }
                }
            }

            labelAccountFullName.Text = this.currrent_employee.FullName;
            labelAccountUsername.Text = this.currrent_employee.UserName;
            txtAccountFullName.Text = this.currrent_employee.FullName;
            txtAccountUsername.Text = this.currrent_employee.UserName;
            txtAccountAddress.Text = this.currrent_employee.Address;
            txtAccountPhoneNumber.Text = this.currrent_employee.PhoneNumber;
            comboBoxAccountGender.SelectedItem = this.currrent_employee.Gender;
            comboBoxAccountAge.SelectedItem = this.currrent_employee.Age;
            this.reportViewer1.RefreshReport();
            timer.Interval = 1000; // Cập nhật mỗi giây
            timer.Tick += Timer_Tick;
            timer.Start();
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
        private void getListCategoryToListView()
        {
            // Lấy danh sách các danh mục từ cơ sở dữ liệu
            DataTable dataTable = CategoryDAO.Instance.GetListCategory();

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


        //hàm gọi form thêm danh mục
        private void buttonOpenFormAddCategory_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.TopMost = true;
            formCategory.getListCategory = getListCategoryToListView;
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
                formCategory.getListCategory = getListCategoryToListView;
                formCategory.Show();
            }
        }

        private void buttonCategorySearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtCategorySearch.Text;

            if (searchValue == "")
            {
                this.getListCategoryToListView();
            }
            else
            {
                // Lấy danh sách các danh mục từ cơ sở dữ liệu
                DataTable dataTable = CategoryDAO.Instance.SearchCategoryByName(searchValue);

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

        private void showProductItem()
        {
            ClearCardItem();

            // Hiển thị hiệu ứng loader
            progressIndicatorProduct.Visible = true;

            DataTable productList = ProductDAO.Instance.GetListProduct();

            // Lặp qua từng bản ghi trong DataTable
            foreach (DataRow row in productList.Rows)
            {
                // Tạo một MaterialCard mới cho mỗi sản phẩm
                MaterialCard cardProductItem = new MaterialCard();
                cardProductItem.Width = 280; // Đặt độ rộng của thẻ sản phẩm
                cardProductItem.Height = 360;
                cardProductItem.Padding = new Padding(10); // Đặt padding cho thẻ sản phẩm
                cardProductItem.Margin = new Padding(40, 150, 10, 10);

                // Tạo PictureBox để hiển thị hình ảnh sản phẩm
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.ImageLocation = row["ImageUrl"].ToString();
                pictureBox.Location = new System.Drawing.Point(10, 10); // Đặt vị trí của PictureBox trong MaterialCard
                pictureBox.Width = cardProductItem.Width;
                pictureBox.Height = cardProductItem.Height / 3;
                pictureBox.InitialImage = Properties.Resources.logo_ver_2;

                // Tạo các phần tử thông tin sản phẩm và đặt vị trí cho chúng
                MaterialLabel labelNameValue = new MaterialLabel() { Text = row["Name"].ToString(), AutoSize = true, FontType = MaterialSkinManager.fontType.Body1 };
                labelNameValue.Location = new System.Drawing.Point(10, 200); // Đặt vị trí của Label trong TableLayoutPanel

                MaterialLabel labelPriceValue = new MaterialLabel() { Text = row["Price"].ToString() + "VND", AutoSize = true, FontType = MaterialSkinManager.fontType.Body1 };
                labelPriceValue.Location = new System.Drawing.Point(10, 240); // Đặt vị trí của Label trong TableLayoutPane


                MaterialButton buttonViewDetailProduct = new MaterialButton() { Text = "Xem chi tiết", AutoSize = true, Cursor = Cursors.Hand };
                buttonViewDetailProduct.Location = new System.Drawing.Point(80, 280);

                buttonViewDetailProduct.Click += buttonViewDetailProduct_Click;
                buttonViewDetailProduct.Tag = row;

                cardProductItem.Controls.Add(pictureBox);
                cardProductItem.Controls.Add(labelNameValue);
                cardProductItem.Controls.Add(labelPriceValue);
                cardProductItem.Controls.Add(buttonViewDetailProduct);

                // Thêm thẻ sản phẩm vào FlowLayoutPanel
                flowLayoutPanel.Controls.Add(cardProductItem);
            }

            // Ẩn hiệu ứng loader khi đã thêm xong các card sản phẩm
            progressIndicatorProduct.Visible = false;

            // Thêm FlowLayoutPanel vào TabPage hoặc Panel tương ứng
            tabProduct.Controls.Add(flowLayoutPanel);
        }


        private void buttonViewDetailProduct_Click(object sender, EventArgs e)
        {
            bool isEdit = true;
            DataRow productInfo = (sender as MaterialButton).Tag as DataRow;

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
            formProduct.GetListProduct = this.showProductItem;
            formProduct.ShowDialog();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.TopMost = true;
            formProduct.GetListProduct = this.showProductItem;
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

        private void buttonTableSearch_Click(object sender, EventArgs e)
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
                CustomMessageBox.Show("Mật khẩu cũ không đúng");
            }
            else if (newPassword != confirmNewPassword)
            {
                CustomMessageBox.Show("Mật khẩu nhập lại không khớp");
            }
            else if (oldPassword == "" || newPassword == "" || confirmNewPassword == "")
            {
                CustomMessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                bool response = EmployeeDAO.Instance.ResetPassword(this.currrent_employee.ID, Data.HashPassword(newPassword));
                if (response)
                {
                    CustomMessageBox.Show("Cập nhật mật khẩu thành công");
                    // Làm mới các trường nhập liệu
                    txtSettingOldPassword.Text = "";
                    txtSettingNewPassword.Text = "";
                    txtSettingConfirmNewPassword.Text = "";
                }
                else
                {
                    CustomMessageBox.Show("Cập nhật mật khẩu thất bại");
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
                cardEmployeeItem.Margin = new Padding(40, 150, 10, 10);

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
                CustomMessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            } 
            else
            {
                DateTime updatedAt = DateTime.Now; // Đây là đối tượng DateTime cần chuyển đổi
                string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fffffff");
                bool response = EmployeeDAO.Instance.UpdateEmployeeDetail(this.currrent_employee.ID, txtAccountUsername.Text, txtAccountFullName.Text, comboBoxAccountGender.SelectedItem.ToString(), txtAccountAddress.Text, int.Parse(comboBoxAccountAge.SelectedItem.ToString()), txtAccountPhoneNumber.Text, formattedDate);
                if (response)
                {
                    CustomMessageBox.Show("Cập nhật thông tin thành công");
                } else
                {
                    CustomMessageBox.Show("Cập nhật thông tin thất bại");
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
            FormRole formRole = new FormRole();
            formRole.TopMost = true;
            formRole.getListRole = this.getListRoleToListView;
            formRole.Show();
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

        private void buttonRoleSearch_Click(object sender, EventArgs e)
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

        //-----------------------------------------------------------------------------------------------------------------------

        //-----------------------------TAB BILL----------------------------------------------------------------------------------

        private void showTableInTabBill()
        {
            ClearCardItem();
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
                if (tableStatus == "Inactive")
                {
                    pictureBox.Image = Properties.Resources.table_inactive; // Hình ảnh cho trạng thái bàn "Không hoạt đọng"
                }
                else if (tableStatus == "Active")
                {
                    pictureBox.Image = Properties.Resources.table_active; // Hình ảnh cho trạng thái bàn "hoạt động"
                } else if(tableStatus == "Used") 
                {
                    pictureBox.Image = Properties.Resources.table_used; // Hình ảnh cho trạng thái bàn "có người"
                }


                // Tạo các phần tử thông tin sản phẩm và đặt vị trí cho chúng
                MaterialLabel labelNameValue = new MaterialLabel() { Text = row["Name"].ToString(), AutoSize = true, FontType = MaterialSkinManager.fontType.Body1 };
                labelNameValue.Location = new System.Drawing.Point(20, 80); // Đặt vị trí của Label trong TableLayoutPanel
                                                                            // Tạo biểu tượng dấu ba chấm
                moreOptionsPictureBox = new PictureBox();
                moreOptionsPictureBox.Image = Properties.Resources.more_option_icon; // Thay đổi hình ảnh theo nhu cầu
                moreOptionsPictureBox.Size = new System.Drawing.Size(25, 25);
                moreOptionsPictureBox.Location = new System.Drawing.Point(panelTable.Width - moreOptionsPictureBox.Width - 10, 10); // Đặt vị trí ở góc phải trên của panelTable
                moreOptionsPictureBox.Visible = true; // Ẩn biểu tượng ban đầu
                moreOptionsPictureBox.BringToFront();

                // Gắn sự kiện MouseHover vào panelTable để hiển thị biểu tượng dấu ba chấm
                pictureBox.MouseEnter += PictureBox_MouseEnter;
                panelTable.MouseHover += PictureBox_MouseEnter;
                pictureBox.MouseLeave += PictureBox_MouseLeave;
                panelTable.MouseLeave += PictureBox_MouseLeave;

                pictureBox.Tag = row;
                pictureBox.Click += showProductSelected;

                // Gắn sự kiện Click vào biểu tượng dấu ba chấm
                moreOptionsPictureBox.Click += MoreOptionsPictureBox_Click;

                // Thêm các controls vào panelTable
                panelTable.Controls.Add(pictureBox);
                panelTable.Controls.Add(labelNameValue);
                panelTable.Controls.Add(moreOptionsPictureBox);

                // Thêm panelTable vào FlowLayoutPanel
                flowLayoutPanel.Controls.Add(panelTable);
            }
            cardBillTable.Controls.Add(flowLayoutPanel);
        }

        // Sự kiện MouseHover của panelTable
        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            // Hiển thị biểu tượng dấu ba chấm khi di chuột qua panelTable
            Panel panelTable = sender as Panel;
            moreOptionsPictureBox.Visible = true;
        }

        // Sự kiện MouseLeave của panelTable
        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            // Ẩn biểu tượng dấu ba chấm khi chuột rời khỏi panelTable
            moreOptionsPictureBox.Visible = false;
        }

        // Sự kiện Click của biểu tượng dấu ba chấm
        private void MoreOptionsPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox moreOptionsPictureBox = sender as PictureBox;
            // Mở menu tùy chọn khi nhấp vào biểu tượng dấu ba chấm
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem buttonBillAddProduct = new ToolStripMenuItem("Thêm sản phẩm");
            buttonBillAddProduct.Height = 100;
            buttonBillAddProduct.Click += buttonBillAddProduct_Click; // Gán sự kiện cho mục 1
            contextMenuStrip.Items.Add(buttonBillAddProduct);

            // Hiển thị menu tại vị trí của biểu tượng dấu ba chấm
            moreOptionsPictureBox.ContextMenuStrip = contextMenuStrip;
            contextMenuStrip.Cursor = Cursors.Hand;
            contextMenuStrip.Show(moreOptionsPictureBox, new System.Drawing.Point(0, moreOptionsPictureBox.Height), ToolStripDropDownDirection.BelowLeft);
        }

        private void buttonBillAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProductToBill formAddProductToBill = new FormAddProductToBill();
            formAddProductToBill.TopMost = true;
            formAddProductToBill.Show();
        }

        private void showProductSelected(object sender, EventArgs e)
        {
            ClearCardItem();
            DataRow tableInfo = (sender as PictureBox).Tag as DataRow;
            if(tableInfo != null)
            {
                if (tableInfo["Status"].ToString() == "Active")
                {
                    int defaultId = 1;
                    int id;
                    if (int.TryParse(tableInfo["ID"].ToString(), out id))
                    {
                        DataTable productList = BillDetailDAO.Instance.GetProductsByTableId(id != null ? defaultId : id);

                        if(productList != null)
                        {
                            foreach (DataRow row in productList.Rows)
                            {
                                Product product = ProductDAO.Instance.GetProductById(int.Parse(row["ProductId"].ToString()));
                                // Tạo một MaterialCard mới cho mỗi sản phẩm
                                Panel panelTable = new Panel();
                                panelTable.Width = cardBillProducts.Width; // Đặt độ rộng của thẻ sản phẩm
                                panelTable.Height = 80;
                                panelTable.Margin = new Padding(10, 10, 30, 10);
                                panelTable.Cursor = Cursors.Hand;

                                // Tạo PictureBox để hiển thị hình ảnh sản phẩm
                                PictureBox pictureBox = new PictureBox();
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox.Location = new System.Drawing.Point(0, 0); // Đặt vị trí của PictureBox trong panel
                                pictureBox.Width = 80;
                                pictureBox.Height = panelTable.Height;
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
                                labeColorValue.Location = new System.Drawing.Point(150, 48); // Đặt vị trí của Label trong TableLayoutPanel
                                labeColorValue.Margin = new Padding(5, 0, 5, 0);

                                MaterialLabel labelQuantityValue = new MaterialLabel() { Text = "x" + row["Quantity"].ToString(), AutoSize = true, FontType = MaterialSkinManager.fontType.Body1 };
                                labelQuantityValue.Location = new System.Drawing.Point(324, 32); // Đặt vị trí của Label trong TableLayoutPanel
                                labelQuantityValue.Margin = new Padding(5, 0, 5, 0);

                                MaterialLabel labelPriceValue = new MaterialLabel() { Text = product.Price + "đ", AutoSize = true, FontType = MaterialSkinManager.fontType.Body1 };
                                labelPriceValue.Location = new System.Drawing.Point(360, 32); // Đặt vị trí của Label trong TableLayoutPanel
                                labelPriceValue.Margin = new Padding(5, 0, 5, 0);

                                // Thêm các controls vào panelTable
                                panelTable.Controls.Add(pictureBox);
                                panelTable.Controls.Add(labelNameValue);
                                panelTable.Controls.Add(labelSizeValue);
                                panelTable.Controls.Add(labeColorValue);
                                panelTable.Controls.Add(labelQuantityValue);
                                panelTable.Controls.Add(labelPriceValue);

                                // Thêm panelTable vào FlowLayoutPanel
                                flowLayoutPanel.Controls.Add(panelTable);
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
                    }
                    else
                    {
                        CustomMessageBox.Show("ID bàn không tồn tại!");
                    }
                }
                else
                {
                    // Hiển thị thông báo cho người dùng rằng bàn không có sẵn
                    CustomMessageBox.Show("Bàn này không phải là bàn đang hoạt động!");
                }
            }
            else
            {
                CustomMessageBox.Show("Không tìm thấy dữ liệu bàn này!");
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
                    this.getBillCount();
                    this.getRevenue();
                    break;
                case 1:
                    this.getListCategoryToListView();
                    break;
                case 2:
                    this.showProductItem();
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
            labelTimeNow.Text = string.Format("Thời gian hiện tại: {0:00}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}",
                                                now.Day, now.Month, now.Year, 
                                                now.Hour, now.Minute, now.Second);
        }
    }
}