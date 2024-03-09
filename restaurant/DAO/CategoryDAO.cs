using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using restaurant.DTO;

namespace restaurant.DAO
{
    internal class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }

        private CategoryDAO() { }

        public DataTable GetListCategory()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM Category");
        }

        public int GetTotalCategories()
        {
            int totalCategories = 0;
            try
            {
                string query = "SELECT COUNT(*) FROM Category";
                totalCategories = (int)DataProvider.Instance.ExecuteScalar(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting total categories: " + ex.Message);
            }
            return totalCategories;
        }

        public Category GetCategoryById(int categoryId)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Category WHERE ID = " + categoryId);

            foreach (DataRow row in data.Rows)
            {
                return new Category(row);
            }

            return null;
        }

        public DataTable SearchCategoryByNameOrId(string searchValue)
        {
            string query = string.Format("SELECT * FROM Category WHERE name LIKE N'%{0}%' OR id LIKE '{1}'", searchValue, searchValue);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);


            return data;
        }

        public Category GetCategoryByName(string name)
        {
            // Tạo câu truy vấn SQL an toàn với tham số
            string query = "SELECT * FROM Category WHERE Name = @name";

            // Thực hiện truy vấn SQL và lấy dữ liệu
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { name });

            // Kiểm tra xem có kết quả trả về không
            if (dataTable.Rows.Count > 0)
            {
                // Lấy dữ liệu từ dòng đầu tiên của DataTable
                DataRow row = dataTable.Rows[0];

                // Tạo đối tượng Category từ dữ liệu trong dòng đó
                Category category = new Category(
                 Convert.ToInt32(row["ID"]),
                 row["Name"].ToString(),
                 row["Description"].ToString(),
                 row["ImageUrl"].ToString()
                 );

                // Trả về đối tượng Category
                return category;
            }
            else
            {
                // Nếu không có kết quả, trả về null hoặc thông báo lỗi,
                return null;
            }
        }


        public bool InsertCategory(string name, string description, string image)
        {
            string query = string.Format("INSERT INTO Category (Name, Description, Image) VALUES (N'{0}', N'{1}', N'{2}')", name, description, image);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory(int categoryId, string name, string description, string image, string updatedAt)
        {
            string query = string.Format("UPDATE Category SET Name = N'{0}', Description = N'{1}', Image = N'{2}', UpdatedAt = N'{3}' WHERE ID = {4}", name, description, image, updatedAt, categoryId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCategory(int categoryId)
        {
            string query = string.Format("DELETE FROM Category WHERE ID = {0}", categoryId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
