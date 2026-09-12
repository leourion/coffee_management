using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;

        public static AccountDAL Instance 
        { 
            get
            {
                if(instance == null) instance = new AccountDAL();
                return instance;
            }
            private set => instance = value; 
        }


        private AccountDAL() { }
        public bool Login(string username, string password)
        {
            string sql = "exec UseProc_Login @userName , @passWord";
            DataTable table = DataProvider.Instance.ExcuteQuery(sql, new object[] { username, password });
            return table.Rows.Count > 0;
        }
        public Account GetAccountByUsername(string username)
        {
            string sql = "select * from account where username = N'" + username + "'";
            DataTable table = DataProvider.Instance.ExcuteQuery(sql);
            foreach (DataRow row in table.Rows)
            {
                string user = row["username"].ToString();
                string disp = row["displayname"].ToString();
                string pass = row["password"].ToString();
                string sex = row["sex"].ToString();
                string phone = row["phonenumber"].ToString();
                string addr = row["address"].ToString();
                string type = row["type"].ToString();
                int salary = (int)row["Salary"];
                DateTime? birth = (DateTime?)row["DateOfBirth"];
                return new Account(user, disp, pass, sex, phone, addr, type, salary ,birth);
            }
            return null;
        }  
        public DataTable GetAccount()
        {
            string sql = "SELECT * FROM dbo.Account where exist = 1";
            DataTable table = DataProvider.Instance.ExcuteQuery(sql);
            return table;
        }
        public DataTable GetAccountBySearch(string username)
        {
            string sql = "SELECT * FROM dbo.Account WHERE CONCAT (UserName, DisplayName, PhoneNumber) LIKE N'%" + username + "%' AND exist = 1";
            DataTable table = DataProvider.Instance.ExcuteQuery(sql);
            return table;
        }
        public bool DeleteAccount(string name)
        {
            string query = string.Format("DELETE FROM dbo.Account WHERE UserName LIKE'"+name+"'");
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount1(string name)
        {
            string query = string.Format("Update dbo.Account SET exist = 0 WHERE UserName LIKE'" + name + "'");
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool InsertAccount(string displayName, string phone, string address, string sex, string type, int salary, string username, string password, DateTime? birth)
        {
            string query = string.Format("INSERT dbo.Account ( DisplayName, PhoneNumber, Address, Sex, Type, Salary, UserName, PassWord, DateOfBirth) VALUES  ( N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')", displayName, phone, address,sex,type,salary, username,password,birth);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(string displayName, string phone, string address, string sex, string type, int salary, string username, string password, DateTime? birth, string username1)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{0}', PhoneNumber = N'{1}', Address = N'{2}', Sex = N'{3}', Type = N'{4}', Salary = N'{5}', UserName = N'{6}', PassWord = N'{7}', DateOfBirth = N'{8}' WHERE  UserName = N'{9}'", displayName, phone, address, sex, type, salary, username, password, birth, username1);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public int CheckBill(string name)
        {
            string query = "SELECT COUNT(*) FROM dbo.Bill Where userNameAccount = '" + name + "'";
            int result = DataProvider.Instance.ExcuteScalar(query);
            return result ;
        }
        public bool UpdateAccount(string taikhoan, string sdt, string matkhau, string newmatkhau)
        {
            string query = "exec USP_UpdateAccount @TaiKhoan = '"+taikhoan+"', @Sdt = '" +sdt+ "', @MatKhau = '" +matkhau+"', @NewMatKhau ='"+newmatkhau+"'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public int KtTK(string userName)
        {
            string query = "select COUNT(*) FROM dbo.Account Where UserName = '" + userName + "'";
            int result = DataProvider.Instance.ExcuteScalar(query);
            return result;
        }
        public List<string> GetlistChucvu()
        {
            List<string> list = new List<string>();
            DataTable table = DataProvider.Instance.ExcuteQuery("select type from account where exist = 1 group by type");
            foreach (DataRow row in table.Rows)
            {
                list.Add(row["type"].ToString());
            }
            return list;
        }
        public DataTable GetListAccount()
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from account where exist = 1");
            return table;
        }
        public DataTable Timkiemnhanvien(string ten, string vaitro)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from account where exist = 1 and displayname like N'%" + ten + "%' and type like N'%" + vaitro + "%'");
            return table;
        }
        public int GetFoodcountbyIDCategory(string idcate)
        {
            int res = DataProvider.Instance.ExcuteScalar("select count(*) from food where exist = 1 and idcategory = '" + idcate + "'");
            return res;
        }
    }
}
