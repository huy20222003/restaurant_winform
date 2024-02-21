using System;
using System.Data;

namespace restaurant.DTO
{
    internal class Role
    {
        public Role(DataRow row)
        {
            Row = row;
        }

        public Role(int id, string name, string description)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DataRow Row { get; }
    }
}
