using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PBL3_QuanLyQuanCafe.DAL
{
    public class MenuDAL
    {
        private static MenuDAL instance;

        private MenuDAL() { }

        public static MenuDAL Instance
        {
            get { if (instance == null) instance = new MenuDAL(); return instance; }
            private set { instance = value; }
        }

        public List<Menu> GetListByTable(string idTable)
        {
            List<Menu> list = new List<Menu>();
            string query = "SELECT Food.name , Food.price , BillInfo.count , BillInfo.count * Food.price as TotalPrice FROM Bill INNER JOIN BillInfo ON Bill.id = BillInfo.idBill INNER JOIN Food ON BillInfo.idFood = Food.id WHERE idTable = @idTable AND Bill.status = N'0'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { idTable.ToString() });
            foreach (DataRow dr in dt.Rows)
            {
                Menu menu = new Menu(dr);
                list.Add(menu);
            }
            return list;
        }
        public List<Menu> GetListByIdBill(string idBill)
        {
            List<Menu> list = new List<Menu>();
            //string query = "SELECT Food.displayname , Food.price , BillInfo.foodNum , BillInfo.foodNum * Food.price as TotalPrice FROM Bill INNER JOIN BillInfo ON Bill.id = BillInfo.idBill INNER JOIN Food ON BillInfo.idFood = Food.id WHERE Bill.id = '@idBill' AND Bill.status = N'Đã thanh toán'";
            DataTable dt = DataProvider.Instance.ExecuteQuery($"SELECT Food.name , Food.price , BillInfo.count , BillInfo.count * Food.price as TotalPrice FROM Bill INNER JOIN BillInfo ON Bill.id = BillInfo.idBill INNER JOIN Food ON BillInfo.idFood = Food.id WHERE Bill.id = '{idBill}' AND Bill.status = N'1'");
            foreach (DataRow dr in dt.Rows)
            {
                Menu menu = new Menu(dr);
                list.Add(menu);
            }
            return list;
        }
    }
}
