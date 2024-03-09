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

        public bool InsertBillDetail(int billId, int productId, int quantity, string size, string color)
        {
            string query = string.Format("INSERT INTO BillDetail (billId, ProductId, Quantity, Size, Color) VALUES ({0}, {1}, {2}, N'{3}', N'{4}')", billId, productId, quantity, size, color);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public BillDetail GetBillDetailIfExists(int billId, int productId)
        {
            string query = string.Format("SELECT * FROM BillDetail WHERE billId = {0} AND ProductId = {1}", billId, productId);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                int id = Convert.ToInt32(row["Id"]);
                int billID = Convert.ToInt32(row["billId"]);
                int productID = Convert.ToInt32(row["ProductId"]);
                int quantity = Convert.ToInt32(row["Quantity"]);
                string size = row["Size"].ToString();
                string color = row["Color"].ToString();
                BillDetail billDetail = new BillDetail(id, billID, quantity, size, color, productID);
                return billDetail;
            }
            else
            {
                return null;
            }
        }

        public bool UpdateBillDetail(int billId, int productId, int quantity, string size, string color)
        {
            BillDetail billDetailExists = GetBillDetailIfExists(billId, productId);
            string query = string.Format("UPDATE BillDetail SET Quantity = {0}, Size = N'{1}', Color = N'{2}' WHERE Id = {3}", quantity, size, color, billDetailExists.ID);
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

        public DataTable GetTop5Products()
        {
            string query = @"SELECT TOP 5 productId, COUNT(*) * 100.0 / (SELECT COUNT(*) FROM BillDetail) AS Percentage FROM BillDetail GROUP BY productId ORDER BY Percentage DESC";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool DeleteProductFromBill(int id)
        {
            string query = string.Format("DELETE FROM BillDetail WHERE ID = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
