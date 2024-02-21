using System;
using System.Data;

namespace restaurant.DTO
{
    internal class Product
    {
        public Product(int id, string name, string description, string imageUrl, string status, int categoryId, string size, string color, int quantity, decimal price, decimal priceSale)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.ImageUrl = imageUrl;
            this.Status = status;
            this.CategoryId = categoryId;
            this.Size = size;
            this.Color = color;
            this.Quantity = quantity;
            this.Price = price;
            this.PriceSale = priceSale;
        }

        public Product(DataRow row)
        {
            this.ID = Convert.ToInt32(row["id"]);
            this.Name = row["name"].ToString();
            this.Description = row["description"].ToString();
            this.ImageUrl = row["imageUrl"].ToString();
            this.Status = row["status"].ToString();
            this.CategoryId = Convert.ToInt32(row["categoryId"]);
            this.Size = row["size"].ToString();
            this.Color = row["color"].ToString();
            this.Quantity = Convert.ToInt32(row["quantity"]);
            this.Price = Convert.ToDecimal(row["price"]);
            this.PriceSale = Convert.ToDecimal(row["priceSale"]);
            //this.CreatedAt = row["createdAt"].ToString();
            //this.UpdatedAt = row["updatedAt"].ToString();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }
        public int CategoryId { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal PriceSale { get; set; }

        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
