using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DTO
{
    public class FoodCategory
    {
        private string id;
        private string name;

        
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }

        public FoodCategory(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public FoodCategory(DataRow row)
        {
            this.id = row["id"].ToString();
            this.name = row["name"].ToString();
        }
    }
}
