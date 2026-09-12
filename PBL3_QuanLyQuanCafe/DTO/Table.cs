using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DTO
{
    public class Table
    {
        private string id;
        private string name;
        private string status;
        private int exist;

        
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int Exist { get => exist; set => exist = value; }
        public string Id { get => id; set => id = value; }
        public Table(string id, string name, string status, int exist)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.exist = exist;
        }
        public Table(DataRow data)
        {
            this.id = data["id"].ToString();
            this.name = data["displayName"].ToString();
            this.status = data["status"].ToString();
        }
    }
}
