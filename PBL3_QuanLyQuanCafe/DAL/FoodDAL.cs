using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DAL
{
    public class FoodDAL
    {
        private static FoodDAL instance;

        public static FoodDAL Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAL();
                return instance;
            }
            private set => instance = value;
        }
        public FoodDAL() { }
        public List<Food> GetlistFoodexist1byIdCategory(string iddanhmuc)
        {
            List<Food> listFood = new List<Food>();
            string query = "select * from Food where idCategory = '" + iddanhmuc + "' and exist = 1";
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                string id = row["id"].ToString();
                string name = row["name"].ToString();
                string madm = row["idCategory"].ToString();
                string unit = row["unit"].ToString();
                int gia = (int)row["price"];
                if (row["image"] != DBNull.Value)
                {
                    byte[] image = (byte[])row["image"];
                    Food food = new Food(id, name, madm, unit, gia, 1, image);
                    listFood.Add(food);
                }
                else
                {
                    Food food = new Food(id, name, madm, unit, gia, 1);
                    listFood.Add(food);
                }
            }
            return listFood;
        }
        public List<Food> GetFullListFoodByIDcategory(string idcate)
        {
            List<Food> listFood = new List<Food>();
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from Food where idCategory = '" + idcate + "'");
            foreach (DataRow row in table.Rows)
            {
                string id = row["id"].ToString();
                string name = row["name"].ToString();
                string madm = row["idCategory"].ToString();
                string unit = row["unit"].ToString();
                int gia = (int)row["price"];
                int exist =(int)row["exist"];
                
                if (row["image"] != DBNull.Value)
                {
                    byte[] image = (byte[])row["image"];
                    Food food = new Food(id, name, madm, unit, gia, exist, image);
                    listFood.Add(food);
                }
                else
                {
                    Food food = new Food(id, name, madm, unit, gia, exist);
                    listFood.Add(food);
                }
            }
            return listFood;
        }
        /*public Food GetFoodbyID(int id)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from food where exist = 1 and id = " + id);
            foreach(DataRow row in table.Rows)
            {
                string name = row["name"].ToString();
                int madm = (int)row["idCategory"];
                string unit = row["unit"].ToString();
                int gia = (int)row["price"];
                if (row["image"] != DBNull.Value)
                {         
                    byte[] image = (byte[])row["image"];
                    Food food = new Food(id, name, madm, unit, gia, image);
                    return food;
                }
                else
                {
                    Food food = new Food(id, name, madm, unit, gia);
                    return food;
                }
            }
            return null;
        }*/
        public Food GetFoodbyIDFood(string id)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from food where exist = 1 and id = '" + id+"'");
            foreach (DataRow row in table.Rows)
            {
                string name = row["name"].ToString();
                string madm = row["idCategory"].ToString();
                string unit = row["unit"].ToString();
                int gia = (int)row["price"];
                int exist = (int)row["exist"];
                if (row["image"] != DBNull.Value)
                {
                    byte[] image = (byte[])row["image"];
                    Food food = new Food(id, name, madm, unit, gia, exist, image);
                    return food;
                }
                else
                {
                    Food food = new Food(id, name, madm, unit, gia, exist);
                    return food;
                }
            }
            return null;
        }

        public DataTable GetListFood()
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from food where exist = 1");
            return table;
        }
       
       /* public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from food where exist = 1");
            foreach(DataRow row in table.Rows)
            {
                int id = (int)row["id"];
                string name = row["name"].ToString();
                int idcate = (int)row["idCategory"];
                string unit = row["unit"].ToString();
                int price = (int)row["price"];
                Food food = new Food(id, name,idcate,unit,price);    
                list.Add(food);
            }
            return list;
        } */
        public void ThemSanPham(string name, string idcate, string unit, int price, byte[] image = null)
        {
            if(image != null)
                DataProvider.Instance.ExcuteNonQuery("insert into food(name , idcategory , unit , price, image) values( @name , @idcategory , @unit , @price , @image )", new object[] { name, idcate, unit, price, image });
            else
                DataProvider.Instance.ExcuteNonQuery("insert into food(name , idcategory , unit , price) values( @name , @idcategory , @unit , @price )", new object[] { name, idcate, unit, price });

        }
        public bool checknamefoodexist(string name)
        {
            int res = DataProvider.Instance.ExcuteScalar("select count(*) from food where exist = 1 and name = N'" + name + "'");
            return res > 0;
        }
        public bool checkfoodexistinbillinfor(string id)
        {
            int res = DataProvider.Instance.ExcuteScalar("select count(*) from billinfo where idfood = '" +id+ "'");
            return res > 0;
        }
        public void CapNhatSanPham(Food food, string name, string idcate, string unit, int price, byte[] image = null)
        {
            if(!checkfoodexistinbillinfor(food.Id))   // nếu món không tồn tại trong billinfor -> cập nhật bình thường
            {
                if (image != null)
                    DataProvider.Instance.ExcuteNonQuery("update food set name = @name , idcategory = @idcategory , unit = @unit , price = @price , image = @image where id = @foodid", new object[] { name, idcate, unit, price, image, food.Id });
                else
                {
                    DataProvider.Instance.ExcuteNonQuery("update food set image = null where id = '" +food.Id+ "'");
                    DataProvider.Instance.ExcuteNonQuery("update food set name = @name , idcategory = @idcategory , unit = @unit , price = @price , image = null where id = @foodid", new object[] { name, idcate, unit, price, food.Id });
                }
            }
            else // set exist của món hiện tại bằng 0, rồi insert món mới y như món cũ (trừ các trường muốn update)
            {
                DataProvider.Instance.ExcuteNonQuery("update food set exist = 0 where id = '" + food.Id + "'");
                if (image != null)
                    DataProvider.Instance.ExcuteNonQuery("insert into food(name, idcategory, unit, price, image, exist) values( @name , @idcategory , @unit , @price , @image , @exist )", new object[] {name, idcate, unit, price, image, 1});
                else
                    DataProvider.Instance.ExcuteNonQuery("insert into food(name, idcategory, unit, price, exist) values( @name , @idcategory , @unit , @price , @exist )", new object[] { name, idcate, unit, price, 1 });
            }
        }
        public void XoaSanPham(Food food)
        {
            if(!checkfoodexistinbillinfor(food.Id)) // nếu món không tồn tại trong billinfo ->xoá bình thường
            {
                DataProvider.Instance.ExcuteNonQuery("delete food where id = '" + food.Id + "'");
            }
            else // nếu món tồn tại trong billinfor -> cập nhật exist món này bằng 0
            {
                DataProvider.Instance.ExcuteNonQuery("update food set exist = 0 where id = '" + food.Id + "'");
            }
        }
        public DataTable TimKiemSanPham(string namefood, string namecategory)
        {
            //DataTable table = DataProvider.Instance.ExcuteQuery("select * from food where name like N'%" +namefood+ "%' and idcategory like N'%" +namecategory+ "%' and exist = 1");
            DataTable table = DataProvider.Instance.ExcuteQuery("select f.id, f.name, f.idCategory, f.unit, f.price, f.image from food as f, FoodCategory as fc where f.idCategory = fc.id and f.exist = 1 and concat(f.id, f.name) like N'%" + namefood + "%' and fc.name like N'%" + namecategory + "%'");
            return table;
        }
        public int GetFoodcountbyIDCategory(string idcate)
        {
            int res = DataProvider.Instance.ExcuteScalar("select count(*) from food where exist = 1 and idcategory = '" + idcate + "'");
            return res;
        }
    }
}