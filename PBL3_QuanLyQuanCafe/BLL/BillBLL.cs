using PBL3_QuanLyQuanCafe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.BLL
{
    public class BillBLL
    {
        private static BillBLL instance;

        public static BillBLL Instance
        {
            get
            {
                if (instance == null) instance = new BillBLL();
                return instance;
            }
            private set => instance = value;
        }
        public BillBLL() { }
        public void ThemMontheo_IdTable(string idtable, string idfood, int count)
        {
            BillDAL.Instance.ThemMontheo_IdTable(idtable, idfood, count);
        }
        public string LayIDBillChuaThanhToanTheoIDTable(string idtable)
        {
            return BillDAL.Instance.LayIDBillChuaThanhToanTheoIDTable(idtable);
        }
        public string GetIdFoodbyNameFood(string namefood)
        {
            return BillDAL.Instance.GetIdFoodbyNameFood(namefood);
        }
        public void XoaBillInfor_XoaMon(string idbill, string idfood)
        {
            BillDAL.Instance.XoaBillInfor_XoaMon(idbill, idfood);
        }
        public void HuyHoaDon(string idtable)
        {
            BillDAL.Instance.HuyHoaDon(idtable);
        }
        public void ThanhToan(string idtable, double totalprice, string username, int discount)
        {
            BillDAL.Instance.ThanhToan(idtable, totalprice, username, discount);
        }
        public void CapNhatstatusTable(string idtable)
        {
            BillDAL.Instance.CapNhatstatusTable(idtable);
        }
        public DataTable GetBillByDate(DateTime checkin, DateTime checkout)
        {
            return BillDAL.Instance.GetBillListByDate(checkin, checkout);
        }
        public DataTable GetBillByFood(DateTime checkin, DateTime checkout)
        {
            return BillDAL.Instance.GetListBillFood(checkin, checkout);
        }
    }
}
