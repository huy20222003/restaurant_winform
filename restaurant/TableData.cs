using MaterialSkin.Controls;
using restaurant.DAO;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant
{
    public partial class Main
    {
        private DataTable tableData;
        private void getListTableToDataGridView()
        {
            //Lấy danh sách các danh mục từ cơ sở dữ liệu
            tableData = TablesDAO.Instance.GetListTable();

            // dataGridViewTableList.Rows.Clear();

            // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu
            if (tableData != null && tableData.Rows.Count > 0)
            {
                dataGridViewTableList.DataSource = tableData;
                dataGridViewTableList.Refresh();
            }
            tableData?.Dispose();
        }


        private void buttonOpenFormAddTable_Click(object sender, EventArgs e)
        {
            FormTable formTable = new FormTable();
            formTable.TopMost = true;
            formTable.getListTable = this.getListTableToDataGridView;
            formTable.Show();
        }

        private void dataGridViewTableList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isEdit = true;
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridViewTableList.SelectedRows.Count > 0)
            {
                // Lấy dòng đầu tiên được chọn
                DataGridViewRow selectedRow = dataGridViewTableList.SelectedRows[0];

                // Kiểm tra xem cột "ID" có tồn tại không
                if (dataGridViewTableList.Columns.Contains("tableId"))
                {
                    // Lấy thông tin từ các cột của dòng được chọn
                    string id = selectedRow.Cells["tableId"].Value?.ToString(); // Kiểm tra null trước khi gọi ToString()
                    string name = selectedRow.Cells["tableName"].Value?.ToString();
                    string description = selectedRow.Cells["tableDescription"].Value?.ToString();
                    string status = selectedRow.Cells["tableStatus"].Value?.ToString();

                    // Kiểm tra giá trị có null không
                    if (id != null && name != null && description != null && status != null)
                    {
                        FormTable formTable = new FormTable(id, name, description, status, isEdit);
                        formTable.getListTable = this.getListTableToDataGridView;
                        formTable.Show();
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
        private void txtTableSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtTableSearch.Text;

            if (searchValue == "")
            {
                this.getListTableToDataGridView();
            }
            else
            {
                // Lấy danh sách các bàn từ cơ sở dữ liệu
                tableData = TablesDAO.Instance.GetTableByIdOrName(searchValue);

                // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu
                if (tableData != null && tableData.Rows.Count > 0)
                {
                    // Duyệt qua mỗi dòng dữ liệu trong DataTable
                    dataGridViewTableList.DataSource = tableData;

                    dataGridViewTableList.Refresh();
                }
                tableData?.Dispose();
            }
        }
    }
}
