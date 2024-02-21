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
using restaurant.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace restaurant
{
    public partial class FormRole : MaterialForm
    {
        public Action getListRole;
        private int ID;
        private bool isEdit = false;
        public FormRole()
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
        }

        public FormRole(string id, string name, string description, bool isEdit)
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
            this.ID = int.Parse(id);
            this.isEdit = isEdit;
            if (isEdit)
            {
                labelRoleTitle.Text = "Chỉnh sửa quyền";
                buttonRoleAdd.Text = "Sửa quyền";
                txtRoleName.Text = name;
                txtRoleDescription.Text = description;
            }
        }

        private void buttonRoleCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRoleAdd_Click(object sender, EventArgs e)
        {
            string name = txtRoleName.Text;
            string description = txtRoleDescription.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description))
            {
                CustomMessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (isEdit)
                {
                    buttonRoleDelete.Visible = true;
                    DateTime updatedAt = DateTime.Now; // Đây là đối tượng DateTime cần chuyển đổi
                    string formattedDate = updatedAt.ToString("yyyy-MM-dd HH:mm:ss.fffffff");

                    bool response = RoleDAO.Instance.UpdateRole(this.ID, name, description, formattedDate);

                    if (response)
                    {
                        this.getListRole();
                        CustomMessageBox.Show("Sửa quyền thành công");
                        this.Close();
                    }
                    else
                    {
                        this.getListRole();
                        CustomMessageBox.Show("Sửa quyền thất bại");
                        this.Close();
                    }
                }
                else
                {
                    bool response = RoleDAO.Instance.InsertRole(name, description);

                    if (response)
                    {
                        this.getListRole();
                        CustomMessageBox.Show("Thêm quyền thành công");
                        this.Close();
                    }
                    else
                    {
                        this.getListRole();
                        CustomMessageBox.Show("Thêm quyền thất bại");
                        this.Close();
                    }
                }
            }
        }

        private void buttonRoleDelete_Click(object sender, EventArgs e)
        {
            bool response = RoleDAO.Instance.DeleteRole(this.ID);
            if (response)
            {
                this.getListRole();
                CustomMessageBox.Show("Xoá quyền thành công");
                this.Close();
            }
            else
            {
                this.getListRole();
                CustomMessageBox.Show("Xoá quyền thất bại");
                this.Close();
            }
        }

        private void TxtRoleName_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập tên quyền!");
                 // Ngăn không cho focus ra control khác nếu dữ liệu không hợp lệ
            }
            else
            {
                errorProvider.SetError(textBox, ""); // Xóa thông báo lỗi nếu hợp lệ
            }
        }

        private void TxtRoleDescription_Validating(object sender, CancelEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "Vui lòng nhập mô tả quyền!");
                 // Ngăn không cho focus ra control khác nếu dữ liệu không hợp lệ
            }
            else
            {
                errorProvider.SetError(textBox, ""); // Xóa thông báo lỗi nếu hợp lệ
            }
        }
        private void TxtRoleName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), ""); // Xóa thông báo lỗi
        }

        private void TxtRoleDescription_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((sender as Control), ""); // Xóa thông báo lỗi
        }


    }
}
