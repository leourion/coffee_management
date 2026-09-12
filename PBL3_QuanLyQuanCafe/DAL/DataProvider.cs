using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyQuanCafe.DAL
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance 
        {
            get
            {
                if(instance == null) instance = new DataProvider();
                return instance;
            } 
            private set => instance = value; 
        }
        private DataProvider() { }
        private string strconnection = @"Data Source =L30; Database = QLCF; Integrated Security = True";
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            SqlConnection con = new SqlConnection(strconnection);
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandType = CommandType.Text;
            sqlcom.CommandText = query;
            sqlcom.Connection = con;
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        sqlcom.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(strconnection))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] element = query.Split(' ');
                    int i = 0;
                    foreach (string item in element)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                conn.Close();
            }

            return table;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int count = 0;
            using (SqlConnection conn = new SqlConnection(strconnection))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] element = query.Split(' ');
                    int i = 0;
                    foreach (string item in element)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                count = command.ExecuteNonQuery();
                conn.Close();
            }
            return count;
        }
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            SqlConnection con = new SqlConnection(strconnection);
            con.Open();
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandType = CommandType.Text;
            sqlcom.CommandText = query;
            sqlcom.Connection = con;
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;

                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        sqlcom.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
            data = sqlcom.ExecuteNonQuery();
            con.Close();
            return data;
        }
        public int ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            SqlConnection con = new SqlConnection(strconnection);
            con.Open();
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.CommandType = CommandType.Text;
            sqlcom.CommandText = query;
            sqlcom.Connection = con;
            if (parameter != null)
            {
                string[] listPara = query.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        sqlcom.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom);
            data = sqlcom.ExecuteScalar();
            con.Close();
            return (int)data;
        }
    }
}
