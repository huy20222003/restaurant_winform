using System;
using System.Data;

namespace restaurant.DTO
{
    internal class Employee
    {
        public Employee(int id, string userName, string fullName, string password, string gender, string address, int age, string avatar, string phoneNumber, int roleID)
        {
            this.ID = id;
            this.UserName = userName;
            this.FullName = fullName;
            this.Password = password;
            this.Gender = gender;
            this.Address = address;
            this.Age = age;
            this.Avatar = avatar;
            this.PhoneNumber = phoneNumber;
            this.RoleID = roleID;
        }

        public Employee(DataRow row)
        {
            this.ID = Convert.ToInt32(row["id"]);
            this.UserName = row["userName"].ToString();
            this.FullName = row["fullName"].ToString();
            this.Password = row["password"].ToString();
            this.Gender = row["gender"].ToString();
            this.Address = row["address"].ToString();
            this.Age = Convert.ToInt32(row["age"]);
            this.Avatar = row["avatar"].ToString();
            this.PhoneNumber = row["phoneNumber"].ToString();
            this.RoleID = Convert.ToInt32(row["roleID"]);
        }

        public int ID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Avatar { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleID { get; set; }
    }
}
