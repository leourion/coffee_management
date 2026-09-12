using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DAL
{
    public class TableDAL
    {
        private static TableDAL instance;

        public static TableDAL Instance 
        { 
            get
            {
                if (instance == null) instance = new TableDAL();
                return instance;
            } 
            private set => instance = value; 
        }
        public TableDAL() { }

        public List<Table> Getlisttable()
        {
            List<Table> list = new List<Table>();
            DataTable datatable = DataProvider.Instance.ExcuteQuery("select * from tablefood where exist = 1");
            foreach (DataRow row in datatable.Rows)
            {
                string id = row["id"].ToString();
                string name = row["name"].ToString();
                string status = row["status"].ToString();
                int exist = (int)row["exist"];
                Table table = new Table(id, name, status, exist);
                list.Add(table);
            }
            return list;
        }
        /*public DataTable GetListStatusTable()
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select status from tablefood where exist = 1 group by status");
            return table;
        }*/

        public DataTable TimKiemBan(string nameorId, string status)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from tablefood where concat(id, name) like N'%" + nameorId + "%' and status like N'%" + status + "%'");
            return table;
        }
        /*public bool checknameTableExist(string name)
        {
            int res = DataProvider.Instance.ExcuteScalar("select count(*) from tablefood where exist = 1 and name = N'" + name + "'");
            return res > 0;
        }
        public void ThemBan(string name)
        {
            DataProvider.Instance.ExcuteNonQuery("insert into tablefood(name) values(N'" + name + "')");
        }*/
        public int SoLuongBanHienTai()
        {
            int res = DataProvider.Instance.ExcuteScalar("select count(*) from tablefood where exist = 1");
            return res;
        }
        public int GetNumberTableMax()
        {
            int maxnumber = -1;
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT TOP 1 name FROM tablefood where exist = 1 ORDER BY ID DESC");
            foreach (DataRow row in table.Rows)
            {
                string name = row["name"].ToString();
                string[] arr = name.Split(' ');
                maxnumber = int.Parse(arr[1]);
            }
            return maxnumber;
        }
        public void ThemBan(int soluong)
        {
            int number;
            if(SoLuongBanHienTai() == 0)
                number = 0;
            else
                number = GetNumberTableMax();
            for (int i = 1; i <= soluong; i++)
            {
                number++;
                string nametable = "Bàn " + number;
                DataProvider.Instance.ExcuteNonQuery("insert into tablefood(name) values(N'" + nametable + "')");
            }                         
        }
        public Table GetTablebyIDTable(string id)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from tablefood where exist = 1 and id = '" + id + "'");
            foreach (DataRow row in table.Rows)
            {
                string nametable = row["name"].ToString();
                string status = row["status"].ToString();
                int exist = (int)row["exist"];

                return new Table(id, nametable, status, exist);
            }
            return null;
        }
        public bool checkTableExistinBill(string idtable)
        {
            int res = DataProvider.Instance.ExcuteScalar("select count(*) from bill where idtable = '" + idtable + "'");
            return res > 0;
        }
        public void XoaBan(Table table)
        {
            if(!checkTableExistinBill(table.Id))
            {
                DataProvider.Instance.ExcuteNonQuery("delete tablefood where id = '" + table.Id + "'");
            }
            else
            {
                DataProvider.Instance.ExcuteNonQuery("update tablefood set exist = 0 where id = '" + table.Id + "'");
            }

        }
        public DataTable GetAllBillTable(string idTable)
        {
            return DataProvider.Instance.ExecuteQuery($"SELECT id, datecheckin as 'Giờ vào', datecheckout 'Giờ ra',[status] as 'Tình trạng',discount as 'Giảm giá(%)', totalPrice as 'Tổng tiền'from Bill where idTable = {idTable}");
        }
        public List<Table> LoadTableList()
        {
            List<Table> list = new List<Table>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("execute USP_GetTableList");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                list.Add(new Table(dr));
            }
            return list;
        }
    }
}
