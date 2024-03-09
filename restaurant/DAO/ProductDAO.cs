using System;
using System.Collections.Generic;
using System.Data;
using restaurant.DTO;

namespace restaurant.DAO
{
    internal class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return instance; }
            private set { instance = value; }
        }

        private ProductDAO() { }

        public DataTable GetListProduct()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM Product");
        }

        public Product GetProductById(int productId)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Product WHERE ID = " + productId);

            foreach (DataRow row in data.Rows)
            {
                return new Product(row);
            }

            return null;
        }

        public DataTable GetProductByName(string name)
        {
            string query = string.Format("SELECT * FROM Product WHERE name LIKE N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable GetProductByCategoryId(int categoryId)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM Product WHERE CategoryId = " + categoryId);
        }

        public bool InsertProduct(string name, string description, string imageUrl, string status, int categoryId, string size, string color, int quantity, decimal price, decimal priceSale)
        {
            string query = string.Format("INSERT INTO Product (Name, Description, ImageUrl, Status, CategoryId, Size, Color, Quantity, Price, PriceSale) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', {4}, N'{5}', N'{6}', {7}, {8}, {9})", name, description, imageUrl, status, categoryId, size, color, quantity, price, priceSale);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateProduct(int productId, string name, string description, string imageUrl, string status, int categoryId, string size, string color, int quantity, decimal price, decimal priceSale, string updatedAt)
        {
            string query = string.Format("UPDATE Product SET Name = N'{0}', Description = N'{1}', ImageUrl = N'{2}', Status = N'{3}', CategoryId = {4}, Size = N'{5}', Color = N'{6}', Quantity = {7}, Price = {8}, PriceSale = {9}, UpdatedAt = N'{10}' WHERE ID = {11}", name, description, imageUrl, status, categoryId, size, color, quantity, price, priceSale, updatedAt, productId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteProduct(int productId)
        {
            string query = string.Format("DELETE FROM Product WHERE ID = {0}", productId);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
