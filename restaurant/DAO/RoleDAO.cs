using System;
using System.Data;
using restaurant.DTO;

namespace restaurant.DAO
{
    internal class RoleDAO
    {
        private static RoleDAO instance;

        public static RoleDAO Instance
        {
            get { if (instance == null) instance = new RoleDAO(); return instance; }
            private set { instance = value; }
        }

        private RoleDAO() { }

        public DataTable GetListRole()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM Role");
        }

        public Role GetRoleById(int roleId)
        {
            string query = "SELECT * FROM Role WHERE ID = @roleId";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { roleId });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                int id = Convert.ToInt32(row["ID"]);
                string name = row["Name"].ToString();
                string description = row["Description"].ToString();
                return new Role(id, name, description);
            }

            return null;
        }

        public DataTable GetRoleByIdOrName(string searchValue)
        {
            string query = string.Format("SELECT * FROM Role WHERE name LIKE N'%{0}%' OR id LIKE '{1}'", searchValue, searchValue);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool InsertRole(string name, string description)
        {
            string query = string.Format("INSERT INTO Role (Name, Description) VALUES (N'{0}', N'{1}')", name, description);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateRole(int roleId, string name, string description, string updatedAt)
        {
            string query = string.Format("UPDATE Role SET Name = N'{0}', Description = N'{1}', UpdatedAt = N'{2}' WHERE ID = {3}", name, description, updatedAt, roleId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteRole(int roleId)
        {
            string query = string.Format("DELETE FROM Role WHERE ID = {0}", roleId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
