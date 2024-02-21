using System;
using System.Data;
using restaurant.DTO;

namespace restaurant.DAO
{
    class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            private set { instance = value; }
        }

        private EmployeeDAO() { }

        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM Employee WHERE Username = @username AND CAST(Password AS NVARCHAR(MAX)) = @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }

        public bool UpdatePasswordEmployee(string userName, string password, string newPassword)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @username , @password , @newPassword", new object[] { userName, password, newPassword });
            return result > 0;
        }

        public DataTable GetListEmployee()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT id, username, fullName, gender, address, age, avatar, phoneNumber, roleID FROM dbo.Employee");
        }

        public int GetEmployeeCount()
        {
            DataTable result = DataProvider.Instance.ExecuteQuery("SELECT COUNT(*) as employeeCount FROM dbo.Employee");
            return result.Rows.Count > 0 ? Convert.ToInt32(result.Rows[0]["employeeCount"]) : 0;
        }

        public Employee GetEmployeeByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Employee WHERE username = '" + username + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Employee(
                    Convert.ToInt32(item["id"]),
                    item["username"].ToString(),
                    item["fullName"].ToString(),
                    item["password"].ToString(),
                    item["gender"].ToString(),
                    item["address"].ToString(),
                    Convert.ToInt32(item["age"]),
                    item["avatar"].ToString(),
                    item["phoneNumber"].ToString(),
                    Convert.ToInt32(item["roleID"])
                );
            }
            return null;
        }

        public bool InsertEmployee(string username, string fullName, string password, string gender, string address, int age, string avatar, string phoneNumber, int roleID)
        {
            string query = string.Format("INSERT INTO dbo.Employee (UserName, FullName, Password, Gender, Address, Age, Avatar, PhoneNumber, RoleID) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', {5}, N'{6}', {7}, N'{8}')", username, fullName, password, gender, address, age, avatar, phoneNumber, roleID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateEmployee(int id, string username, string fullName, string gender, string address, int age, string avatar, string phoneNumber, int roleID, string updatedAt)
        {
            string query = string.Format("UPDATE dbo.Employee SET UserName = N'{1}', FullName = N'{2}', Gender = N'{3}', Address = N'{4}', Age = {5}, Avatar = N'{6}', PhoneNumber = N'{7} RoleID = {8}, UpdatedAt = N'{9}' WHERE ID = {0}", id, username, fullName, gender, address, age, avatar, phoneNumber, roleID, updatedAt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteEmployee(int id)
        {
            string query = string.Format("DELETE FROM Employee WHERE ID = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ResetPassword(int id, string newPassword)
        {
            string query = string.Format("UPDATE Employee SET Password = N'{1}' WHERE ID = {0}", id, newPassword);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateEmployeeAvatar(int id, string avatar)
        {
            string query = string.Format("UPDATE Employee SET Avatar = N'{1}' WHERE ID = {0}", id, avatar);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateEmployeeDetail(int id, string username, string fullName, string gender, string address, int age, string phoneNumber, string updatedAt)
        {
            string query = string.Format("UPDATE dbo.Employee SET UserName = N'{1}', FullName = N'{2}', Gender = N'{3}', Address = N'{4}', Age = {5}, PhoneNumber = N'{6}', UpdatedAt = N'{7}' WHERE ID = {0}", id, username, fullName, gender, address, age, phoneNumber, updatedAt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        //public DataTable GetNewEmployeeCountByDate(int month, int year)
        //{
        //    string query = "SELECT CAST(createdAt AS DATE) AS CreatedDate, COUNT(*) AS TotalEmployees FROM Employee WHERE MONTH(createdAt) = @Month AND YEAR(createdAt) = @Year GROUP BY CAST(createdAt AS DATE)";
        //    object[] parameters = { "@Month", month, "@Year", year };
        //    DataTable result = DataProvider.Instance.ExecuteQuery(query, parameters);

        //    return result;
        //}
    }
}
