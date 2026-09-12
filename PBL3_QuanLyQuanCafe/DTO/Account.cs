using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DTO
{
    public class Account
    {
        private string username;
        private string displayname;
        private string password;
        private string sex;
        private string phonenumber;
        private string address;
        private string type;
        private int salary;
        private int exist;
        private DateTime? birth;

        public string Username { get => username; set => username = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Address { get => address; set => address = value; }
        public int Salary { get => salary; set => salary = value; }
        public DateTime? Birth { get => birth; set => birth = value; }

        public Account(string username, string displayname, string password, string sex, string phonenumber, string address, string type,int salary,DateTime? birth)
        {
            this.username = username;
            this.displayname = displayname;
            this.password = password;
            this.sex = sex;
            this.phonenumber = phonenumber;
            this.address = address;
            this.type = type;
            this.birth = birth;
            this.salary = salary;
        }
    }
}
