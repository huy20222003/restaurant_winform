using MaterialSkin.Controls;
using restaurant.DAO;
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
        private DataTable roleData;
        private void getListRoleToDataGirdView()
        {
            // Lấy danh sách các danh mục từ cơ sở dữ liệu
            roleData = RoleDAO.Instance.GetListRole();

            // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu
            if (roleData != null && roleData.Rows.Count > 0)
            {
                dataGridViewRoleList.DataSource = roleData;
            }
            roleData?.Dispose();
        }
        private void buttonOpenFormAddRole_Click(object sender, EventArgs e)
        {
            MaterialForm materialForm = new MaterialForm();
            using (FormRole formRole = new FormRole())
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
                formRole.TopMost = true;
                formRole.ShowDialog();
                materialForm.Dispose();
            }
        }

        private void dataGridViewRoleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isEdit = true;
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridViewRoleList.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dataGridViewRoleList.SelectedRows[0];

                // Kiểm tra xem cột "ID" có tồn tại không
                if (dataGridViewRoleList.Columns.Contains("roleId"))
                {
                    // Lấy thông tin từ các cột của dòng được chọn
                    string id = selectedRow.Cells["roleId"].Value?.ToString(); // Kiểm tra null trước khi gọi ToString()
                    string name = selectedRow.Cells["roleName"].Value?.ToString();
                    string description = selectedRow.Cells["roleDescription"].Value?.ToString();

                    // Kiểm tra giá trị có null không
                    if (id != null && name != null && description != null)
                    {
                        FormRole formRole = new FormRole(id, name, description, isEdit);
                        formRole.getListRole = this.getListBillToDatagridview;
                        formRole.Show();
                    }
                    else
                    {
                        notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Dữ liệu không hợp lệ", ToolTipIcon.Error);
                    }
                }
                else
                {
                    notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Cột ID không tồn tại", ToolTipIcon.Error);
                }
            }
            else
            {
                notifyIcon.ShowBalloonTip(10000, "Thông báo từ Góc Bếp Nhỏ", "Không có dòng nào được chọn", ToolTipIcon.Error);
            }
        }

        private void txtRoleSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtRoleSearch.Text;

            if (searchValue == "")
            {
                this.getListRoleToDataGirdView();
            }
            else
            {
                // Lấy danh sách các bàn từ cơ sở dữ liệu
                roleData = RoleDAO.Instance.GetRoleByIdOrName(searchValue);

                // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu
                if (roleData != null && roleData.Rows.Count > 0)
                {
                    // Duyệt qua mỗi dòng dữ liệu trong DataTable
                    dataGridViewRoleList.DataSource = roleData;

                    dataGridViewRoleList.Refresh();
                }
                roleData?.Dispose();
            }
        }
    }
}
