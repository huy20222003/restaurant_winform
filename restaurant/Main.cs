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
        private Employee currrent_employee;
        private FlowLayoutPanel flowLayoutPanel;
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
            Employee employee = EmployeeDAO.Instance.GetEmployeeByUserName(username);
            this.currrent_employee = employee;

            Load_Data();

        
        //--------------------------------------------------------------------------------------------------------
        }

        //-------------------------------------------------------------------------------------------------------

        private void Load_Data()
        {

            DTO.Role role = RoleDAO.Instance.GetRoleById(currrent_employee.RoleID);
            string roleName = role.Name;
            // Ẩn tabEmployee nếu vai trò là "admin"
            if (roleName != "admin")
            {
                tabControl.TabPages.Remove(tabEmployee);
                tabControl.TabPages.Remove(tabRole);
            }
            //gọi hàm
            this.getEmployeeCount();
            this.getProductSelledCount();
            this.getRevenue();
            this.getBillCount();
            this.lineChart();
            this.pieChart();
            this.DynamicVisibiltyExample();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.restaurantDataSet.Role);
            // TODO: This line of code loads data into the 'restaurantDataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.restaurantDataSet.Bill);
            if (this.currrent_employee.Avatar.StartsWith("https://"))
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = webClient.DownloadData(this.currrent_employee.Avatar);
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(stream);
                        pictureBoxAccountAvatar.Image = image;
                        pictureBoxDashboardEmployeeAvatar1.Image = image;
                        pictureBoxDashboardEmployeeAvatar3.Image = image;
                        pictureBoxDashboardEmployeeAvatar4.Image = image;
                        pictureBoxDashboardEmployeeAvatar5.Image = image;
                        pictureBoxDashboardEmployeeAvatar6.Image = image;
                        pictureBoxDashboardEmployeeAvatar7.Image = image;
                        pictureBoxDashboardEmployeeAvatar8.Image = image;
                        pictureBoxDashboardEmployeeAvatar9.Image = image;
                        pictureBoxDashboardEmployeeAvatar10.Image = image;
                        pictureBoxDashboardEmployeeAvatar11.Image = image;
                        pictureBoxDashboardEmployeeAvatar12.Image = image;
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

            labelDashboardEmployeeUsername12.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername1.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername3.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername4.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername5.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername6.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername7.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername8.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername9.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername10.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername11.Text = this.currrent_employee.UserName;
            labelDashboardEmployeeUsername12.Text = this.currrent_employee.UserName;

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
            buttonDashboardLogout11.Click += buttonLogout_Click;

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
                    this.getListTableToDataGridView();
                    break;
                case 4:
                    this.showTableInTabBill();
                    break;
                case 5:
                    this.getListBillToDatagridview();
                    break;
                case 7:
                    this.showEmployeeItem();
                    break;
                case 8:
                    this.getListRoleToDataGirdView();
                    break;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            labelTimeNow10.Text = time;
            labelTimeNow11.Text = time;
        }

        private void buttonBillPayment_Click(object sender, EventArgs e)
        {

        }
    }
}