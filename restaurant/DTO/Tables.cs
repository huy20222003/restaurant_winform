using System;
using System.Data;

namespace restaurant.DTO
{
    internal class Tables
    {
        public Tables(DataRow row)
        {
            Row = row;
        }

        public Tables(int id, string name, string description, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Status = status;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DataRow Row { get; }
    }
}
