using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DTO
{
    public class Food
    {
        private string id;
        private string name;
        private string idCategory;
        private string unit;
        private int price;
        private int exist;
        private byte[] image;


        public string Name { get => name; set => name = value; }
        
        public int Price { get => price; set => price = value; }
       
     
        public string Unit { get => unit; set => unit = value; }
        public byte[] Image { get => image; set => image = value; }
        public int Exist { get => exist; set => exist = value; }
        public string Id { get => id; set => id = value; }
        public string IdCategory { get => idCategory; set => idCategory = value; }

        public Food(string id, string name, string idCategory, string unit, int price, int exist, byte[] image = null)
        {
            this.id = id;
            this.name = name;
            this.idCategory = idCategory;
            this.unit = unit;
            this.price = price;
            this.exist = exist;
            this.image = image;
        }
    }
}
