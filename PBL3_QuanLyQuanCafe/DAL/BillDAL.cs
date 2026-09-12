using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DAL
{
    public class BillDAL
    {
        private static BillDAL instance;

        public static BillDAL Instance
        {
            get
            {
                if (instance == null) instance = new BillDAL();
                return instance;
            }
            private set => instance = value;
        }
        public BillDAL() { }
        public string LayIDBillChuaThanhToanTheoIDTable(string idtable)
        {
            string sql = "select * from Bill where status = 0 and idtable = '" + idtable + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(sql);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return row["id"].ToString();
            }
            return "-1";
        }
        public void ThemMontheo_IdTable(string idtable, string idfood, int count)
        {
            /* 
             - nếu LayIDBillChuaThanhToanTheoIDTable(int idtable) == -1 (không tồn tại bill chưa thanh toán) 
                    => thêm bill, thêm bill infor(thêm món vào bill đó):
             - nếu LayIDBillChuaThanhToanTheoIDTable(int idtable) != -1 (đã tồn tại bill chưa thanh toán)
                    =>    + không thêm bill, 
                          + chỉ thêm bill infor(thêm món vào bill đó):
                                
            Hàm thêm bill info:
            - nếu món thêm vào chưa tồn tại trong bill => thêm món bình thường
            - nếu món thêm vào đã tồn tại trong bill => thêm món theo số lượng, cập nhật lại món đó trong bill(số lượng, thành tiền)
                            
            */
            if (LayIDBillChuaThanhToanTheoIDTable(idtable) == "-1")
            {
                //string sql = "insert into Bill values(getdate(),null, @idtable ,0, 0)";
                string sql = "insert into Bill values(dbo.AUTO_IDBill(), getdate(),null, 0,'" + idtable+"', null, 0, 0)";
                DataProvider.Instance.ExcuteNonQuery(sql);
                InsertBillinfor(getIDBillMax(), idfood, count);
            }
            else
            {
                InsertBillinfor(LayIDBillChuaThanhToanTheoIDTable(idtable), idfood, count);
            }
            // cập nhật trạng thái bàn
            //DataProvider.Instance.ExcuteNonQuery("update TableFood set status = N'Có người' where id = " + idtable);
        }

        public string getIDBillMax()
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT TOP 1 id FROM Bill ORDER BY ID DESC");
            foreach(DataRow row in table.Rows)
            {
                string idmax = row["id"].ToString();
                return idmax;
            }
            return "-1";
        }

        public void InsertBillinfor(string idbill, string idfood, int count)
        {
            // nếu món thêm vào chưa tồn tại trong bill => thêm món bình thường
            string query = "select * from BillInfo where idBill = '" + idbill + "' and idFood = '" + idfood + "'";
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            if (table.Rows.Count == 0)
            {
                string sql = "insert into BillInfo values('" + idbill + "','" + idfood + "'," + count + ")";
                DataProvider.Instance.ExcuteNonQuery(sql);
            }
            else // nếu món thêm vào đã tồn tại trong bill => thêm món theo số lượng, cập nhật lại món đó trong bill(số lượng, thành tiền)
            {
                string sql1 = "update BillInfo set count = count + " + count + " where idFood = '" + idfood + "' and idBill = '" + idbill + "'";
                DataProvider.Instance.ExcuteNonQuery(sql1);
            }

        }
        public string GetIdFoodbyNameFood(string namefood)
        {
            string sql = "select id from Food where name = N'" + namefood + "' and exist = 1";
            DataTable table = DataProvider.Instance.ExcuteQuery(sql);
            foreach(DataRow row in table.Rows)
            {
                string foodid = row["id"].ToString();
                return foodid;
            }
            return null;
        }
        public int Soluongmontrongbillinfo(string idfood)
        {
            int res = DataProvider.Instance.ExcuteScalar("select count(*) from billinfo where idfood = '" +idfood+ "'");
            return res;
        }
        public void XoaBillInfor_XoaMon(string idbill, string idfood)
        {
            int t = Soluongmontrongbillinfo(idfood);
            //
            string sql = "delete from BillInfo where idBill = '" + idbill + "' and idFood = '" + idfood + "'";
            DataProvider.Instance.ExcuteNonQuery(sql);
            // 
            if(t == 1)
                DataProvider.Instance.ExcuteNonQuery("delete from food where id = '" + idfood + "' and exist = 0");

            // nếu xoá hết các món trong bill => xoá bill
            string sql1 = "select count(*) from BillInfo where idBill = '" + idbill + "'";
            int res = DataProvider.Instance.ExcuteScalar(sql1);
            if (res == 0)
            {
                string sql2 = "delete from Bill where id = '" + idbill+ "'";
                DataProvider.Instance.ExcuteNonQuery(sql2);
                // cập nhật trạng thái bàn
                //int idtable = DataProvider.Instance.ExcuteScalar("select tb.id from tablefood as tb, bill as b where tb.id = b.idtable and b.id = " + idbill);
                //DataProvider.Instance.ExcuteNonQuery("update TableFood set status = N'Trống' where id = " + idtable);
            }
        }
        public void HuyHoaDon(string idtable)
        {
            // xoá billinfo trong bill, ...
            string idbill = LayIDBillChuaThanhToanTheoIDTable(idtable);
            List<BillInfo> list = BillInfoDAL.Instance.GetListBillInfobyIDBill(idbill);
            foreach (BillInfo item in list)
            {
                int t = Soluongmontrongbillinfo(item.Idfood);

                DataProvider.Instance.ExcuteNonQuery("delete from billinfo where id = '" + item.Id + "'");

                if(t == 1)
                    DataProvider.Instance.ExcuteNonQuery("delete from food where id = '" + item.Idfood + "' and exist = 0");
            }
            // xoá bill
            DataProvider.Instance.ExcuteNonQuery("delete bill where id = '" + idbill + "'");
        }

        public void ThanhToan(string idtable, double totalprice, string username, int discount)
        {
            string idbill = LayIDBillChuaThanhToanTheoIDTable(idtable);
            if (idbill != "-1")//
            {
                string sql = "update Bill set status = 1, datecheckout = getdate(), totalPrice = " + totalprice + ",discount = " + discount + " ,userNameAccount = N'" + username + "' where id = '" + idbill + "'";
                DataProvider.Instance.ExcuteNonQuery(sql);
            }
        }

        public void CapNhatstatusTable(string idtable)
        {
            if (LayIDBillChuaThanhToanTheoIDTable(idtable) == "-1")
            {
                DataProvider.Instance.ExcuteNonQuery("update TableFood set status = N'Trống' where id = '" + idtable +"'");
            }
            else
            {
                DataProvider.Instance.ExcuteNonQuery("update TableFood set status = N'Có người' where id = '" + idtable + "'");
            }
        }
        public DataTable GetBillListByDate(DateTime checkin, DateTime checkout)
        {
            string sql = "exec USP_GetListBillByDate @checkIn = '" + checkin + "', @checkOut = '" + checkout + "'";
            DataTable table = DataProvider.Instance.ExcuteQuery(sql);
            return table;
        }
        public DataTable GetListBillFood(DateTime checkin, DateTime checkout)
        {
            string sql = "exec USP_GetListBillFood @checkIn = '" + checkin + "', @checkOut = '" + checkout + "'";
            DataTable table = DataProvider.Instance.ExcuteQuery(sql);
            return table;
        }
        public DataTable GetTotalRevenue(string year)
        {
            return DataProvider.Instance.ExecuteQuery($"select month(datecheckout) as Tháng, sum(totalPrice * (100-discount)/100) as 'Tổng thu'from Bill where year(datecheckout) = '{year}' group by month(datecheckout)");
        }
        public DataTable GetListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery("EXECUTE USP_GetListBillByDate1 @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
        public DataTable GetListBillByDate(DateTime date)
        {
            return DataProvider.Instance.ExecuteQuery($"SELECT Bill.id , TableFood.name 'Tên bàn', datecheckin as 'Giờ vào',datecheckout as 'Giờ ra', discount as 'Giảm giá (%)',Bill.totalPrice as 'Tổng tiền', ((100-discount)/100)*totalPrice AS 'Thành tiền' FROM Bill INNER JOIN TableFood ON Bill.idTable = TableFood.id WHERE ( Bill.datecheckout = @checkout ) and Bill.status = N'1'", new object[] { date });
        }
        public DataTable GetListBillById(string keyWord, DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery($"SELECT Bill.id , TableFood.name as 'Tên bàn', datecheckin as 'Giờ vào',datecheckout as 'Giờ ra', discount as 'Giảm giá (%)',Bill.totalPrice as 'Tổng tiền', ((100-discount)/100)*totalPrice AS 'Thành tiền' FROM Bill INNER JOIN TableFood ON Bill.idTable = TableFood.id WHERE Bill.id like '%{keyWord}%' and Bill.status = N'1' and (Bill.datecheckout >= '{checkIn}' and Bill.datecheckout <= '{checkOut}')");
        }
        public DataTable GetListBillByTable(string keyWord, DateTime checkIn, DateTime checkOut)
        {
            return DataProvider.Instance.ExecuteQuery($"SELECT Bill.id , TableFood.name 'Tên bàn', datecheckin as 'Giờ vào',datecheckout as 'Giờ ra', discount as 'Giảm giá (%)',Bill.totalPrice as 'Tổng tiền', ((100-discount)/100)*totalPrice AS 'Thành tiền' FROM Bill INNER JOIN TableFood ON Bill.idTable = TableFood.id WHERE TableFood.name like '%{keyWord}%' and Bill.status = N'1' and (Bill.datecheckout >= '{checkIn}' and Bill.datecheckout <= '{checkOut}')");
        }

    }
}
