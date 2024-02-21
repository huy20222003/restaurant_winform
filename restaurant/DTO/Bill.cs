using System;
using System.Data;

namespace restaurant.DTO
{
    internal class Bill
    {
        public Bill(int id, string fullName, string phoneNumber, decimal totalPrices, string status, string paymentMethod)
        {
            this.ID = id;
            this.FullName = fullName;
            this.PhoneNumber = phoneNumber;
            this.TotalPrices = totalPrices;
            this.Status = status;
            this.PaymentMethod = paymentMethod;
        }

        public Bill(DataRow row)
        {
            this.ID = Convert.ToInt32(row["id"]);
            this.FullName = row["fullName"].ToString();
            this.PhoneNumber = row["phoneNumber"].ToString();
            this.TotalPrices = Convert.ToDecimal(row["totalPrices"]);
            this.Status = row["status"].ToString();
            this.PaymentMethod = row["paymentMethod"].ToString();
        }

        public int ID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal TotalPrices { get; set; }
        public string Status { get; set; }
        public string PaymentMethod { get; set; }

        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}
