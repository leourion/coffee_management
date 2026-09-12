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
    public class HoaDonBLL
    {
        private static HoaDonBLL instance;

        public static HoaDonBLL Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonBLL();
                return instance;
            }
            private set => instance = value;
        }
        public HoaDonBLL() { }
        public List<HoaDon> GetlistHoaDon(string idtable)
        {
            return HoaDonDAL.Instance.GetlistHoaDon(idtable);
        }
    }
}
