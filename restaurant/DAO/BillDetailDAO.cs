using System;
using System.Data;
using restaurant.DTO;

namespace restaurant.DAO
{
    internal class BillDetailDAO
    {
        private static BillDetailDAO instance;

        public static BillDetailDAO Instance
        {
            get { if (instance == null) instance = new BillDetailDAO(); return instance; }
            private set { instance = value; }
        }

        private BillDetailDAO() { }

        public bool InsertBillDetail(int id, int productId, int quantity, string size, string color)
        {
            string query = string.Format("INSERT INTO BillDetail (Id, ProductId, Quantity, Size, Color) VALUES ({0}, {1}, {2}, N'{3}', N'{4}')", id, productId, quantity, size, color);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable GetBillDetailsByBillId(int billId)
        {
            string query = string.Format("SELECT * FROM BillDetail WHERE BillId = {0}", billId);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int GetProductSelledCount()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT SUM(Quantity) as productCount FROM BillDetail");
            return result.Rows.Count > 0 ? Convert.ToInt32(result.Rows[0]["productCount"]) : 0;
        }
    }
}
