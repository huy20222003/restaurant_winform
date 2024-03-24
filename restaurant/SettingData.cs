using restaurant.DAO;
using restaurant.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class Main
    {
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
    }
}
