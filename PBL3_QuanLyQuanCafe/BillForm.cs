using PBL3_QuanLyQuanCafe.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = PBL3_QuanLyQuanCafe.DTO.Menu;

namespace PBL3_QuanLyQuanCafe
{
    public partial class BillForm : Form
    {
        BindingSource billBinding = new BindingSource();
        public BillForm()
        {
            InitializeComponent();
            LoadData();
            AddBinding();
            LoadDateTimePickerBill();
            LoadTableBill();
        }
        private void LoadData()
        {
            LoadTableBill();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkDateFrom.Value = new DateTime(today.Year, today.Month, 1);
            dtpkDateTo.Value = dtpkDateFrom.Value.AddMonths(1).AddDays(-1);
        }
        private void LoadTableBill()
        {
            drvBill.DataSource = billBinding;

            if (dtpkDateFrom.Value != dtpkDateTo.Value)
                billBinding.DataSource = BillDAL.Instance.GetListBillByDate(dtpkDateFrom.Value, dtpkDateTo.Value);
            else
                billBinding.DataSource = BillDAL.Instance.GetListBillByDate(dtpkDateTo.Value);
        }
        private void AddBinding()
        {
            txtIdBill.DataBindings.Add(new Binding("Text", drvBill.DataSource, "id"));
        }
        private string GetCashier(string idBill)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery($"select * from Bill where id = '{idBill}'");
            DataRow row = dt.Rows[0];
            string userName = (string)row["userNameAccount"];
            DataTable dt1 = DataProvider.Instance.ExecuteQuery($"select * from Account");
            foreach (DataRow dr in dt1.Rows)
            {
                if (userName.Equals((string)dr["userName"])) return (string)dr["displayName"];
            }
            return (string)row["displayName"];
        }
        private void ShowBill(string idBill)
        {
            float totalPrice = 0;
            lsvBill.Items.Clear();
            DataTable dt = DataProvider.Instance.ExecuteQuery($"select * from Bill where id = '{idBill}'");
            DataRow row = dt.Rows[0];
            List<Menu> menuList = MenuDAL.Instance.GetListByIdBill(idBill);
            foreach (Menu item in menuList)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());

                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                lsvBill.Items.Add(lsvItem);
                totalPrice += item.TotalPrice;
            }
            txtTotalPrice.Text = totalPrice.ToString();
            txtDiscount.Text = ((double)row["discount"]).ToString();
            txtCashierName.Text = GetCashier(idBill);
        }
        
        private void txtFill_TextChanged(object sender, EventArgs e)
        {
            if (radIdBill.Checked)
            {
                billBinding.DataSource = BillDAL.Instance.GetListBillById(txtFill.Text, dtpkDateFrom.Value, dtpkDateTo.Value);
            }
            else
            {
                billBinding.DataSource = BillDAL.Instance.GetListBillByTable(txtFill.Text, dtpkDateFrom.Value, dtpkDateTo.Value);
            }
        }

        private void radIdBill_Click(object sender, EventArgs e)
        {
            billBinding.DataSource = BillDAL.Instance.GetListBillById(txtFill.Text, dtpkDateFrom.Value, dtpkDateTo.Value);
        }

        private void radTable_Click(object sender, EventArgs e)
        {
            billBinding.DataSource = BillDAL.Instance.GetListBillByTable(txtFill.Text, dtpkDateFrom.Value, dtpkDateTo.Value);
        }

        private void txtIdBill_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdBill.Text))
            {
                return;
            }
            else
            {
                string idBill = txtIdBill.Text;
                ShowBill(idBill);
            }
        }


        private void Search_Click(object sender, EventArgs e)
        {
            LoadTableBill();
        }
    }
}
