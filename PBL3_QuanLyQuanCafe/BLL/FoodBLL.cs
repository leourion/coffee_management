using PBL3_QuanLyQuanCafe.DAL;
using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.BLL
{
    public class FoodBLL
    {
        private static FoodBLL instance;

        public static FoodBLL Instance
        {
            get
            {
                if (instance == null) instance = new FoodBLL();
                return instance;
            }
            private set => instance = value;
        }
        public FoodBLL() { }
        public List<Food> GetlistFoodexist1byIdCategory(string iddanhmuc)
        {
            return FoodDAL.Instance.GetlistFoodexist1byIdCategory(iddanhmuc);
        }
        
        /*public Food GetFoodbyID(int id)
        {
            return FoodDAL.Instance.GetFoodbyID(id);
        }*/
        public Food GetFoodbyIDFood(string id)
        {
            return FoodDAL.Instance.GetFoodbyIDFood(id);
        }
         public DataTable GetListFood()
         {
             return FoodDAL.Instance.GetListFood();

         }
        /*  public List<Food> GetListFood()
          {
              return FoodDAL.Instance.GetListFood();
          }
        */

        public void ThemSanPham(string name, string idcate, string unit, int price, byte[] image = null)
        {
            FoodDAL.Instance.ThemSanPham(name, idcate, unit, price, image);
        }
        public bool checknamefoodexist(string name)
        {
            return FoodDAL.Instance.checknamefoodexist(name);
        }
        public bool checkfoodexistinbillinfor(string id)
        {
            return FoodDAL.Instance.checkfoodexistinbillinfor(id);
        }
        public void CapNhatSanPham(Food food, string name, string idcate, string unit, int price, byte[] image = null)
        {
            FoodDAL.Instance.CapNhatSanPham(food, name, idcate, unit, price, image);
        }
        public void XoaSanPham(Food food)
        {
            FoodDAL.Instance.XoaSanPham(food);
        }
        public DataTable TimKiemSanPham(string namefood, string namecategory)
        {
            return FoodDAL.Instance.TimKiemSanPham(namefood, namecategory);
        }
        public int GetFoodcountbyIDCategory(string idcate)
        {
            return FoodDAL.Instance.GetFoodcountbyIDCategory(idcate);
        }
    }
}
