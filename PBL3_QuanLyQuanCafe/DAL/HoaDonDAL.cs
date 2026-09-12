using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DAL
{
    public class HoaDonDAL
    {
        private static HoaDonDAL instance;

        public static HoaDonDAL Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonDAL();
                return instance;
            }
            private set => instance = value;
        }
        public HoaDonDAL() { }
        public List<HoaDon> GetlistHoaDon(string idtable)
        {
            List<HoaDon> list = new List<HoaDon>();
            string query = "select f.id, f.name, bi.count, f.price, f.price*bi.count as Thanhtien from Bill as b, BillInfo as bi, Food as f where b.id = bi.idBill and bi.idFood = f.id and b.status = 0 and b.idTable = '" +idtable+ "'";
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                string idmon = row["id"].ToString();
                string tenmon = row["name"].ToString();
                int soluong = (int)row["count"];
                int dongia = (int)row["price"];
                int thanhtien = (int)row["thanhtien"];

                HoaDon hd = new HoaDon(idmon, tenmon, soluong, dongia, thanhtien);
                list.Add(hd);
            }
            return list;
        }
    }
}
