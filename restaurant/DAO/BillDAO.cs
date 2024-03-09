using restaurant.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.DAO
{
    internal class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }

        private BillDAO() { }

        public int GetBillCount()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT COUNT(*) as billCount FROM Bill");
            return result.Rows.Count > 0 ? Convert.ToInt32(result.Rows[0]["billCount"]) : 0;
        }

        public int GetRevenue()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT SUM(totalPrices) as revenue FROM Bill");
            return result.Rows.Count > 0 ? Convert.ToInt32(result.Rows[0]["revenue"]) : 0;
        }

        public bool InsertBill(decimal totalPrices, string status, string paymentMethod, int tableId)
        {
            string query = string.Format("INSERT INTO Bill (totalPrices, status, paymentMethod, tableId) " +
                   "VALUES ('{0}', N'{1}', N'{2}', '{3}')", totalPrices, status, paymentMethod, tableId);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateBillStatus(int id, string status, string updatedAt)
        {
            string query = string.Format("UPDATE Bill SET status = N'{0}', UpdatedAt = '{1}' WHERE ID = '{2}'", status, updatedAt, id);

            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable GetLatestBillByTableId(int tableId)
        {
            string query = string.Format("SELECT TOP 1 * FROM Bill WHERE tableId = '{0}' ORDER BY CreatedAt DESC", tableId);

            // Thực hiện truy vấn bằng DataProvider
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { tableId });

            return data;
        }


        public DataTable GetBillCountByDate(int month, int year)
        {
            string query = "SELECT DAY(CreatedAt) AS DayOfMonth, COUNT(*) AS TotalBills " +
                           "FROM Bill " +
                           "WHERE MONTH(CreatedAt) = " + month + " AND YEAR(CreatedAt) = " + year + " " +
                           "GROUP BY DAY(CreatedAt)";

            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
