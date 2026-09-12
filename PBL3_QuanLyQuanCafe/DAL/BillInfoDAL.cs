using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DAL
{
    public class BillInfoDAL
    {
        private static BillInfoDAL instance;

        public static BillInfoDAL Instance 
        {
            get
            {
                if (instance == null) instance = new BillInfoDAL();
                return instance;
            } 
            private set => instance = value; 
        }
        public BillInfoDAL() { }

        public List<BillInfo> GetListBillInfobyIDBill(string idbill)
        {
            List<BillInfo> list = new List<BillInfo>();
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from billinfo where idbill = '" + idbill + "'");
            foreach (DataRow row in table.Rows)
            {
                int id = (int)row["id"];
                string idbi = row["idBill"].ToString();
                string idf = row["idFood"].ToString();
                int count = (int)row["count"];
                
                BillInfo billinfo = new BillInfo(id, idbi, idf, count);
                list.Add(billinfo);
            }
            return list;
        }
        public DataTable GetNumberFood(string idCategory)
        {
            if (idCategory == "")
            {
                return DataProvider.Instance.ExecuteQuery($"select Food.id,Food.name as 'Tên món ăn', COALESCE(SUM(BillInfo.count),0) as 'Số lần gọi' from Food left JOIN BillInfo ON Food.id = BillInfo.idFood WHERE Food.exist =  1 GROUP BY Food.id,Food.name");
            }
            else
            {
                return DataProvider.Instance.ExecuteQuery($"select Food.id,Food.name as 'Tên món ăn', COALESCE(SUM(BillInfo.count),0) as 'Số lần gọi' from Food left JOIN BillInfo ON Food.id = BillInfo.idFood WHERE Food.exist =  1 and Food.idCategory = '{idCategory}' GROUP BY Food.id, Food.name");
            }
        }
    }
}
