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

namespace restaurant
{
    public partial class Main
    {
        private DataTable billListData;
        private void getListBillToDatagridview()
        {
            billListData = BillDAO.Instance.GetListBill();

            // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu
            if (billListData != null && billListData.Rows.Count > 0)
            {
                dataGridViewBillList.DataSource= billListData;


            }

        // Dispose of the DataTable if it's disposable
        billListData?.Dispose();
        }

        private void txtBillListSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtBillListSearch.Text;

            if (searchValue == "")
            {
                this.getListBillToDatagridview();
            }
            else
            {
                // Lấy danh sách các bàn từ cơ sở dữ liệu
               billListData = BillDAO.Instance.GetBillById(searchValue);

                // Kiểm tra nếu có dữ liệu trả về từ cơ sở dữ liệu
                if (billListData != null && billListData.Rows.Count > 0)
                {
                    dataGridViewBillList.DataSource = billListData;

                    dataGridViewBillList.Refresh();
                }
                billListData?.Dispose();
            }
        }
    }
}
