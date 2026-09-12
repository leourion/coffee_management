using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DAL
{
    public class FoodCategoryDAL
    {
        private static FoodCategoryDAL instance;

        public static FoodCategoryDAL Instance 
        { 
            get
            {
                if (instance == null) instance = new FoodCategoryDAL();
                return instance;
            }
            private set => instance = value; 
        }
        public FoodCategoryDAL() { }

        public List<FoodCategory> GetListFoodCategory()
        {
            List<FoodCategory> list = new List<FoodCategory>();
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from foodcategory where exist = 1");
            foreach (DataRow row in table.Rows)
            {
                string id = row["ID"].ToString();
                string name = (row["Name"]).ToString();
                FoodCategory fc = new FoodCategory(id, name);
                list.Add(fc);
            }
            return list;
        }
        public string GetNameCategorybyIDcate(string idcategory)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select name from foodcategory where exist = 1 and id = '" +idcategory+ "'");
            foreach(DataRow row in table.Rows)
            {
                string namecate = (row["Name"]).ToString();
                return namecate;
            }
            return null;
        }
        public bool checkCategoryExist(string name)
        {
            int res = DataProvider.Instance.ExcuteScalar("select count(*) from foodcategory where exist = 1 and name = N'" + name+"'");
            return res > 0;
        }
        public void ThemDanhMuc(string name)
        {
            DataProvider.Instance.ExcuteNonQuery("insert into foodcategory(name) values(N'" + name + "')");
        }
        public void CapNhatDanhMuc(string name, string id)
        {
            DataProvider.Instance.ExcuteNonQuery("update foodcategory set name = N'" +name+ "' where id = '" + id + "'");
        }
        public FoodCategory GetFoodCategorybyIDCate(string id)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from foodcategory where id = '" + id + "'");
            foreach(DataRow row in table.Rows)
            {
                string idcate = row["id"].ToString();
                string namecate = (string)row["Name"];
                return new FoodCategory(idcate, namecate);
            }
            return null;
        }
        public bool checkDanhMucCoChuaMon(string idcate)
        {
            int res = DataProvider.Instance.ExcuteScalar("select count(*) from food where idcategory = '" + idcate + "'");
            return res > 0;
        }
        public void XoaDanhMuc(string idcate)
        {
            /* - kiểm tra xem danh mục này có chứa món nào hay không
                + nếu không chứa món -> xoá danh mục bình thường
                + nếu chứa món: 
                    duyệt từng món, kiểm tra exist món này có = 1 hay không
                    - nếu bằng 1:(nếu bằng 0 thì món này chắc chắn có trong billinfo)
                        + (kiểm tra từng món này có trong billinfo chưa,
		                    nếu chưa-> xoá bt, nếu có cập nhật exist món = 0) ->hàm XoaMon trong foodDAL
                    Kiểm tra lại danh mục này có món nào chưa(exist món = 0 và = 1)
                        + nếu chưa xoá luôn danh mục
	                    + nếu có set exist danh mục = 0
            */
            if (!checkDanhMucCoChuaMon(idcate))  
            {
                DataProvider.Instance.ExcuteNonQuery("delete foodcategory where id = '" + idcate + "'");
            }
            else
            {
                List<Food> listfood = FoodDAL.Instance.GetFullListFoodByIDcategory(idcate);
                foreach (Food item in listfood)
                {
                    if(item.Exist == 1)
                    {
                        FoodDAL.Instance.XoaSanPham(item);
                    }
                }
                if (!checkDanhMucCoChuaMon(idcate))
                    DataProvider.Instance.ExcuteNonQuery("delete foodcategory where id = '" + idcate + "'");
                else
                    DataProvider.Instance.ExcuteNonQuery("update foodcategory set exist = 0 where id = '" + idcate + "'");
            }
        }
        public DataTable TimKiemDanhMuc(string name)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from foodcategory where concat(id, name) like N'%" + name + "%' and exist = 1");
            return table;            
        }
        public List<FoodCategory> GetListCategory()
        {
            List<FoodCategory> list = new List<FoodCategory>();
            DataTable tableCate = DataProvider.Instance.ExecuteQuery("select * from FoodCategory");

            for (int i = 0; i < tableCate.Rows.Count; i++)
            {
                list.Add(new FoodCategory(tableCate.Rows[i]));
            }

            return list;
        }
    }
}
