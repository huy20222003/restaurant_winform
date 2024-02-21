using MaterialSkin;
using MaterialSkin.Controls;
using restaurant.DAO;
using restaurant.DTO;
using restaurant.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace restaurant
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtUsername.Focus();
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

            // Di chuyển các cài đặt vào sự kiện Load để đảm bảo rằng chúng được áp dụng sau khi form đã được khởi tạo đầy đủ
            this.Load += Login_Load;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            txtPassword.UseSystemPasswordChar = true;
        }


        private void checkbox_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtPassword.UseSystemPasswordChar = !checkbox_showpassword.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text.Trim();

                // Thực hiện kiểm tra thông tin đăng nhập ở đây
                if (CheckCredentials(username, password))
                {
                    // Nếu thông tin đăng nhập đúng, mở form Main
                    Main mainForm = new Main(username);
                    mainForm.Show();
                    this.Hide(); // Ẩn form đăng nhập
                }
                else
                {
                    CustomMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }

        }

        private bool CheckCredentials(string username, string password)
        {
            return EmployeeDAO.Instance.Login(username, Data.HashPassword(password));
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button_login_Click(sender, e);
            }
        }
    }
}
