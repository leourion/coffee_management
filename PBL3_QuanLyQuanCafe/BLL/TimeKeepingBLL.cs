using PBL3_QuanLyQuanCafe.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.BLL
{
    public class TimeKeepingBLL
    {
        private static TimeKeepingBLL instance;
        private TimeKeepingBLL() { }

        public static TimeKeepingBLL Instance
        { get { if (instance == null) instance = new TimeKeepingBLL(); return instance; } private set => instance = value; }
        public void InsertTimeKeeping(string userName, string salary, DateTime dateLogin, DateTime dateLogout)
        {
            DataProvider.Instance.ExecuteNonQuery($"insert into TimeKeeping (userName,dateLogin,dateLogout,salary) values ('{userName}','{dateLogin}','{dateLogout}',N'{salary}')");
        }
        public List<string> GetListYear()
        {
            List<string> years = new List<string>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("select distinct year(datelogin) from TimeKeeping union select distinct year(datelogout) from TimeKeeping ");
            foreach (DataRow dr in dt.Rows)
            {
                years.Add(dr[0].ToString());
            }
            return years;
        }
        public DataTable GetTotalSalary(string month, string year)
        {
            return DataProvider.Instance.ExecuteQuery($"select Account.UserName,Account.DisplayName as 'Tên nhân viên', SUM(dentaT) as 'Phút', SUM(totalSalary) as 'Lương' from Account,TimeKeeping where Account.UserName = TimeKeeping.userName and Account.userName != 'Quản Lý' and month(dateLogout) = '{month}' and year(dateLogout) = '{year}' group by Account.UserName,Account.DisplayName");
        }
        public DataTable GetTimeKeepingByUserName(string userName, string month, string year)
        {
            return DataProvider.Instance.ExecuteQuery($"select TimeKeeping.id,dateLogin as 'Giờ đăng nhập',dateLogout as 'Giờ đăng xuất', dentaT as 'Số phút',TimeKeeping.salary as 'Lương theo giờ',totalSalary as 'Lương của lượt đăng nhập' from TimeKeeping WHERE TimeKeeping.userName = '{userName}' and month(dateLogout) = '{month}' and year(dateLogout) = '{year}'");
        }
    }
}
