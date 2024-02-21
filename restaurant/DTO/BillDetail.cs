using System;
using System.Data;

namespace restaurant.DTO
{
    internal class BillDetail
    {
        public BillDetail(int id, int billId, int quantity, string size, string color, int productId)
        {
            this.ID = id;
            this.BillId = billId;
            this.Quantity = quantity;
            this.Size = size;
            this.Color = color;
            this.ProductId = productId;
        }

        public BillDetail(DataRow row)
        {
            this.ID = Convert.ToInt32(row["id"]);
            this.BillId = Convert.ToInt32(row["billId"]);
            this.Quantity = Convert.ToInt32(row["quantity"]);
            this.Size = row["size"].ToString();
            this.Color = row["color"].ToString();
            this.ProductId = Convert.ToInt32(row["productId"]);
        }

        public int ID { get; set; }
        public int BillId { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int ProductId { get; set; }

        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
