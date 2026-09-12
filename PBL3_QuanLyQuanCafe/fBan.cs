using PBL3_QuanLyQuanCafe.BLL;
using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyQuanCafe
{
    public partial class fBan : Form
    {
        public fBan()
        {
            InitializeComponent();
            LoadDataGrid();
            LoadComboboxStatus();
        }

        public void LoadDataGrid()
        {
            dataGridViewBan.Rows.Clear();
            List<Table> listtable = TableBLL.Instance.Getlisttable();
            int i = 0;
            foreach (Table item in listtable)
            {
                dataGridViewBan.Rows.Add(item.Id, item.Name, item.Status);
                if (item.Status == "Có người")
                    dataGridViewBan[2, i].Style.ForeColor = Color.OrangeRed;
                i++;
            }
        }
        private void LoadComboboxStatus()
        {
            comboBoxTrangThai.Items.Add("Tất cả");
            comboBoxTrangThai.Items.Add("Có người");
            comboBoxTrangThai.Items.Add("Trống");
            comboBoxTrangThai.Text = "Tất cả";
            
        }
        private void textBoxTableName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTableName.Text != "Nhập ID hoặc tên bàn")
            {
                if (textBoxTableName.Text.Contains("Nhập ID hoặc tên bàn"))
                {
                    textBoxTableName.Text = textBoxTableName.Text.Replace("Nhập ID hoặc tên bàn", "");
                    textBoxTableName.SelectionStart = 1;
                }
            }
            if (textBoxTableName.Text == "")
            {
                textBoxTableName.Text = "Nhập ID hoặc tên bàn";
                textBoxTableName.ForeColor = Color.Gray;
                return;
            }
            textBoxTableName.ForeColor = Color.Black;
        }

        private void textBoxTableName_Click(object sender, EventArgs e)
        {
            if (textBoxTableName.Text == "Nhập ID hoặc tên bàn")
                textBoxTableName.SelectionStart = 0;
        }

        private void iconButtonTimkiem_Click(object sender, EventArgs e)
        {
            string nameorid = textBoxTableName.Text.Trim();
            string status = comboBoxTrangThai.Text.Trim();
            if (nameorid.Equals("Nhập ID hoặc tên bàn")) nameorid = "";
            if (status.Equals("Tất cả")) status = "";
            dataGridViewBan.Rows.Clear();


            DataTable table = TableBLL.Instance.TimKiemBan(nameorid, status);
            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                dataGridViewBan.Rows.Add(row["Id"], row["name"], row["status"]);
                if (row["status"].ToString() == "Có người")
                    dataGridViewBan[2, i].Style.ForeColor = Color.OrangeRed;
                i++;
            }
        }

        private void iconButtonThemBan_Click(object sender, EventArgs e)
        {
            fThemBan f = new fThemBan(this);
            f.ShowDialog();
        }

        private void iconButtonXoaBan_Click(object sender, EventArgs e)
        {
            if(dataGridViewBan.SelectedCells.Count > 0)
            {
                string id = dataGridViewBan.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
                Table table = TableBLL.Instance.GetTablebyIDTable(id); 
                if (table.Status == "Có người")
                {
                    MessageBox.Show("Bạn không thể xoá bàn đang có người", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if(MessageBox.Show("Bạn muốn xoá " +table.Name +"?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    TableBLL.Instance.XoaBan(table);
                    LoadDataGrid();
                    MessageBox.Show("Xoá bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
