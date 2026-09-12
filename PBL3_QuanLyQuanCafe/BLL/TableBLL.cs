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
    public class TableBLL
    {
        private static TableBLL instance;

        public static TableBLL Instance
        {
            get
            {
                if (instance == null) instance = new TableBLL();
                return instance;
            }
            private set => instance = value;
        }
        public TableBLL() { }

        public List<Table> Getlisttable()
        {
            return TableDAL.Instance.Getlisttable();
        }
        /*public DataTable GetListStatusTable()
        {
            return TableDAL.Instance.GetListStatusTable();
        }*/
        public DataTable TimKiemBan(string nameorId, string status)
        {
            return TableDAL.Instance.TimKiemBan(nameorId, status);
        }
        /*public bool checknameTableExist(string name)
        {
            return TableDAL.Instance.checknameTableExist(name);
        }
        public void ThemBan(string name)
        {
            TableDAL.Instance.ThemBan(name);    
        }*/
        public int SoLuongBanHienTai()
        {
            return TableDAL.Instance.SoLuongBanHienTai();
        }
        public void ThemBan(int soluong)
        {
            TableDAL.Instance.ThemBan(soluong);
        }
        public Table GetTablebyIDTable(string id)
        {
            return TableDAL.Instance.GetTablebyIDTable(id);
        }
        public void XoaBan(Table table)
        {
            TableDAL.Instance.XoaBan(table);
        }
    }
}
