using System;
using System.Data;

namespace restaurant.DTO
{
    internal class Category
    {
        public Category(int id, string name, string description, string image)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Image = image;
        }

        public Category(DataRow row)
        {
            this.ID = Convert.ToInt32(row["id"]);
            this.Name = row["name"].ToString();
            this.Description = row["description"].ToString();
            this.Image = row["image"].ToString();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
