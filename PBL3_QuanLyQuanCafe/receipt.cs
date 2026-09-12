using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PBL3_QuanLyQuanCafe.BLL;
using PBL3_QuanLyQuanCafe.DTO;

namespace PBL3_QuanLyQuanCafe
{
    public partial class receipt : Form
    {
        fBanHang bh;
        private Account accountLogin;
        settlePayment payment;
        public Account AccountLogin
        {
            get => accountLogin;
            set
            {
                accountLogin = value;
                //LockTabAdmin_PhanQuyen(accountLogin.Type);
            }
        }
        public receipt(fBanHang fbh, Account acc)
        {
            InitializeComponent();
            bh = fbh;
            this.AccountLogin = acc;
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
        public void loadMoney(string pcash, string pchange)
        {
            ReportDataSource rptDataSource;
            try
            {
                int discount = (int)bh.nmDiscount.Value;
                double totalPrice = double.Parse(bh.txtTongTien.Text);
                double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptReceipt.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();

                DataSet1 ds = new DataSet1();
                var sqlconnectstring = @"Data Source = ADMIN-PC; Database = QLCF; Integrated Security = True";
                var connection = new SqlConnection(sqlconnectstring);
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                Table table = bh.listViewHoadon.Tag as Table;
                string idbill = BillBLL.Instance.LayIDBillChuaThanhToanTheoIDTable(table.Id);
                da.SelectCommand = new SqlCommand("select f.name as tensp, bi.count as soluong, f.price as dongia ,f.price * bi.count as thanhtien from Bill as b, BillInfo as bi, Food as f where b.id = bi.idBill and bi.idFood = f.id and b.status = 0 and b.idTable = '" + table.Id+ "'",connection);
                da.Fill(ds.Tables["dtReceipt"]);
                connection.Close();

                ReportParameter pidBill = new ReportParameter("pidBill",idbill);
                ReportParameter pMaBan = new ReportParameter("pMaBan",table.Id);
                ReportParameter pTenNV = new ReportParameter("pTenNV",accountLogin.Displayname);
                ReportParameter pTotal= new ReportParameter("pTotal", finalTotalPrice.ToString());
                ReportParameter pChanel= new ReportParameter("pChanel",pchange);
                ReportParameter pCash = new ReportParameter("pCash",pcash);


                //add to the local reportView
                reportViewer1.LocalReport.SetParameters(pidBill);
                reportViewer1.LocalReport.SetParameters(pMaBan);
                reportViewer1.LocalReport.SetParameters(pTenNV);
                reportViewer1.LocalReport.SetParameters(pTotal);
                reportViewer1.LocalReport.SetParameters(pChanel);
                reportViewer1.LocalReport.SetParameters(pCash);

                rptDataSource = new ReportDataSource("DataSet1", ds.Tables["dtReceipt"]);
                reportViewer1.LocalReport.DataSources.Add(rptDataSource);
                reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.FullPage;
                reportViewer1.ZoomPercent = 30;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warring!");
            }
        }
    }
}
