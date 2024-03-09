using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml.Linq;
using MaterialSkin;
using MaterialSkin.Controls;
using restaurant.DAO;
using restaurant.DTO;
using restaurant.Global;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace restaurant
{
    public partial class FormEmployee : MaterialForm
    {
        private bool isEdit = false;
        public Action getListEmployee;
        private int ID;
        public FormEmployee()
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

            DataTable roleDataTable = RoleDAO.Instance.GetListRole();

            // Đổ danh sách role vào comboboxRole
            foreach (DataRow row in roleDataTable.Rows)
            {
                comboBoxEmployeeRole.Items.Add(row["Name"]);
            }
        }

        public FormEmployee(string id, string fullName, string username, string imageUrl, string age, string address, string gender, string phoneNumber, string roleID, bool isEdit) 
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

            DataTable roleDataTable = RoleDAO.Instance.GetListRole();

            // Đổ danh sách danh mục vào comboboxCategory
            foreach (DataRow row in roleDataTable.Rows)
            {
                comboBoxEmployeeRole.Items.Add(row["Name"]);
            }

            this.isEdit = isEdit;
            this.ID = int.Parse(id);
            if (isEdit)
            {
                labelEmployeeTitle.Text = "Chỉnh sửa nhân viên";
                buttonEmployee.Text = "Chỉnh sửa";
                txtEmployeeFullName.Text = fullName;
                txtEmployeeUsername.Text = username;
                txtEmployeeAddress.Text = address;
                txtEmployeePhoneNumber.Text = phoneNumber;
                comboBoxEmployeeAge.SelectedItem = age;
                comboBoxEmployeeGender.SelectedItem = gender;
                comboBoxEmployeeRole.SelectedIndex = int.Parse(roleID) - 1;

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

        private void buttonEmployeeChooseImage_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                // Nếu hình ảnh chưa được chọn, hiển thị thông báo lỗi
                errorProvider.SetError(buttonEmployeeChooseImage, "Vui lòng chọn hình ảnh!");
            }
            else
            {
                // Nếu hình ảnh đã được chọn, xóa thông báo lỗi (nếu có)
                errorProvider.SetError(buttonEmployeeChooseImage, "");
                // Tiếp tục xử lý chọn hình ảnh
                openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    pictureBox.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void buttonEmployeeCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonEmployee_Click(object sender, EventArgs e)
        {
            string fullName = txtEmployeeFullName.Text;
            string username = txtEmployeeUsername.Text;
            string address = txtEmployeeAddress.Text;
            string age = comboBoxEmployeeAge.Text;
            string gender = comboBoxEmployeeGender.Text;
            string phoneNumber = txtEmployeePhoneNumber.Text;
            int roleId = comboBoxEmployeeRole.SelectedIndex + 1;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) || pictureBox.Image == null || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(phoneNumber))
            {
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Vui lòng nhập đầy đủ thông tin", ToolTipIcon.Warning);
            }
            else
            {
                // Chuyển đổi hình ảnh thành mảng byte trước khi lưu vào cơ sở dữ liệu
                string imageBase64 = Data.ConvertImageToBase64(pictureBox.Image);
                ImageServices imageServices = new ImageServices();
                string imageUrl = await imageServices.UploadImageAsync(imageBase64);

                if (isEdit)
                {
                    buttonEmployeeDelete.Visible = true;
                    DateTime updatedAt = DateTime.Now; // Đây là đối tượng DateTime cần chuyển đổi
                    string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fffffff");
                    bool response = EmployeeDAO.Instance.UpdateEmployee(this.ID, username, fullName, gender, address, int.Parse(age), imageUrl, phoneNumber, roleId, formattedDate);

                    if (response)
                    {
                        this.getListEmployee();
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật thông tin nhân viên thành công", ToolTipIcon.Info);
                        this.Close();
                    }
                    else
                    {
                        this.getListEmployee();
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật thông tin nhân viên thất bại", ToolTipIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    string password = "123";
                    string passwordHash = Data.HashPassword(password);
                    bool response = EmployeeDAO.Instance.InsertEmployee(username, fullName, passwordHash, gender, address, int.Parse(age), imageUrl, phoneNumber, roleId);

                    if (response)
                    {
                        this.getListEmployee();
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Thêm nhân viên thành công. Mật khẩu là 123", ToolTipIcon.Info);
                        this.Close();
                    }
                    else
                    {
                        this.getListEmployee();
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Thêm nhân viên thất bại", ToolTipIcon.Error);
                        this.Close();
                    }
                }
            }
        }

        private void buttonEmployeeDelete_Click(object sender, EventArgs e)
        {
            bool response = EmployeeDAO.Instance.DeleteEmployee(this.ID);
            if (response)
            {
                this.getListEmployee();
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Xoá nhân viên thành công", ToolTipIcon.Info);
                this.Close();
            }
            else
            {
                this.getListEmployee();
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Xoá nhân viên thất bại", ToolTipIcon.Error);
                this.Close();
            }
        }

        private void txtEmployeeFullName_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập họ và tên!");
            }
            else
            {
                errorProvider.SetError(textBox, ""); // Xóa thông báo lỗi nếu hợp lệ
            }
        }

        private void txtEmployeeUsername_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập tên đăng nhập!");
            }
            else
            {
                errorProvider.SetError(textBox, ""); // Xóa thông báo lỗi nếu hợp lệ
            }
        }

        private void txtEmployeeAddress_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập địa chỉ");
            }
            else
            {
                errorProvider.SetError(textBox, ""); // Xóa thông báo lỗi nếu hợp lệ
            }
        }

        private void ComboBoxEmployeeAge_Validating(object sender, CancelEventArgs e)
        {
            MaterialComboBox comboBox = sender as MaterialComboBox;
            if (comboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBox, "Vui lòng chọn tuổi!");
            }
            else
            {
                errorProvider.SetError(comboBox, ""); // Xóa thông báo lỗi nếu hợp lệ
            }
        }

        private void ComboBoxEmployeeGender_Validating(object sender, CancelEventArgs e)
        {
            MaterialComboBox comboBox = sender as MaterialComboBox;
            if (comboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBox, "Vui lòng chọn giới tính!");
            }
            else
            {
                errorProvider.SetError(comboBox, ""); // Xóa thông báo lỗi nếu hợp lệ
            }
        }

        private void ComboBoxEmployeeRole_Validating(object sender, CancelEventArgs e)
        {
            MaterialComboBox comboBox = sender as MaterialComboBox;
            if (comboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBox, "Vui lòng chọn vai trò!");
            }
            else
            {
                errorProvider.SetError(comboBox, ""); // Xóa thông báo lỗi nếu hợp lệ
            }
        }

        private void txtEmployeePhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập số điện thoại!");
            }
            else
            {
                errorProvider.SetError(textBox, ""); // Xóa thông báo lỗi nếu hợp lệ
            }
        }

        private void txtEmployeeFullName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), ""); // Xóa thông báo lỗi
        }

        private void txtEmployeeUsername_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), ""); // Xóa thông báo lỗi
        }

        private void txtEmployeeAddress_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), ""); // Xóa thông báo lỗi
        }

        private void ComboBoxEmployeeAge_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), ""); // Xóa thông báo lỗi
        }

        private void ComboBoxEmployeeGender_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), ""); // Xóa thông báo lỗi
        }

        private void ComboBoxEmployeeRole_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), ""); // Xóa thông báo lỗi
        }

        private void txtEmployeePhoneNumber_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), ""); // Xóa thông báo lỗi
        }
    }
}
