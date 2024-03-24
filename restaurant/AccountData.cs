using restaurant.DAO;
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
            if (txtAccountFullName.Text == "" || txtAccountUsername.Text == "" || txtAccountAddress.Text == "" || comboBoxAccountGender.SelectedItem == null || comboBoxAccountAge.SelectedItem == null || string.IsNullOrEmpty(txtAccountPhoneNumber.Text))
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
                }
                else
                {
                    notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cập nhật thông tin thất bại", ToolTipIcon.Error);
                }
            }
        }
    }
}
