using System;
using System.Data;
using restaurant.DTO;

namespace restaurant.DAO
{
    internal class TablesDAO
    {
        private static TablesDAO instance;

        public static TablesDAO Instance
        {
            get { if (instance == null) instance = new TablesDAO(); return instance; }
            private set { instance = value; }
        }

        private TablesDAO() { }

        public DataTable GetListTable()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM Tables");
        }

        public Tables GetTableById(int tableId)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Tables WHERE ID = " + tableId);

            foreach (DataRow row in data.Rows)
            {
                return new Tables(
                    Convert.ToInt32(row["id"]),
                    row["name"].ToString(),
                    row["description"].ToString(),
                    row["status"].ToString()
                );
            }

            return null;
        }

        public DataTable GetTableByIdOrName(string searchValue)
        {
            string query = string.Format("SELECT * FROM Tables WHERE name LIKE N'%{0}%' OR id LIKE '{1}'", searchValue, searchValue);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool InsertTable(string name, string description, string status)
        {
            string query = string.Format("INSERT INTO Tables (Name, Description, Status) VALUES (N'{0}', N'{1}', N'{2}')", name, description, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTable(int tableId, string name, string description, string status, string updatedAt)
        {
            string query = string.Format("UPDATE Tables SET Name = N'{0}', Description = N'{1}', Status = N'{2}', UpdatedAt = N'{3}' WHERE ID = {4}", name, description, status, updatedAt, tableId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateTableStatus(int tableId, string status, string updatedAt)
        {
            string query = string.Format("UPDATE Tables SET Status = N'{0}', UpdatedAt = N'{1}' WHERE ID = {2}", status, updatedAt, tableId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteTable(int tableId)
        {
            string query = string.Format("DELETE FROM Tables WHERE ID = {0}", tableId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
