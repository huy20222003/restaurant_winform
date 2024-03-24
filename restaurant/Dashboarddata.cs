using restaurant.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant
{
    public partial class Main
    {
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
    }
}
