using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DTO
{
    public class Menu
    {
        private string foodName;
        private int count;
        private float price;
        private float totalPrice;
        public Menu(string foodName, int count, float price, float totalPrice = 0)
        {
            this.foodName = foodName;
            this.count = count;
            this.price = price;
            this.totalPrice = count * price;
        }
        public Menu(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Price = float.Parse(row["price"].ToString());
            this.Count = Convert.ToInt32(row["count"].ToString());
            this.TotalPrice = float.Parse(row["totalPrice"].ToString());
        }
        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
