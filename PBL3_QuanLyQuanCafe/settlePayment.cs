using PBL3_QuanLyQuanCafe.BLL;
using PBL3_QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyQuanCafe
{
    public partial class settlePayment : Form
    {
        fBanHang bh;
        Account account;
        public settlePayment(fBanHang tongtien, Account acc)
        {
            InitializeComponent();
            bh = tongtien;
            this.account = acc;
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtcafe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double charge = double.Parse(txtcash.Text)-double.Parse(txtSale.Text);
                txtChange.Text = charge.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                txtChange.Text = "0.00";
            }
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn00.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtcash.Text += btnPoint.Text;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtcash.Clear();
            txtcash.Focus();//
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn3.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn2.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn6.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn0.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn5.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn1.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn9.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn4.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn8.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn7.Text;
        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtcash.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập số tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (double.Parse(txtChange.Text) < 0 || txtcash.Text.Equals(""))
                {
                    MessageBox.Show("Chưa nhập số tiền!","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (bh.listViewHoadon.Tag == null)
                        return;
                    Table table = bh.listViewHoadon.Tag as Table;
                    string idbill = BillBLL.Instance.LayIDBillChuaThanhToanTheoIDTable(table.Id);
                    int discount = (int)bh.nmDiscount.Value;
                    double totalPrice = double.Parse(bh.txtTongTien.Text);
                    double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
                    if (idbill != "-1")
                    {
                        if (MessageBox.Show(String.Format("Bạn có chắc muốn thanh toán bàn {0} không?\nGiảm giá: {1}%\nTổng tiền: {2}đ", table.Name, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            //double totalprice = Convert.ToDouble(txtTongTien.Text.Split(',')[0]);
                            //MessageBox.Show(txtTongTien.Text);
                            receipt modunle = new receipt(bh,account);
                            modunle.loadMoney(txtcash.Text, txtChange.Text);
                            modunle.ShowDialog();
                            BillBLL.Instance.ThanhToan(table.Id, totalPrice, account.Username, discount);
                            BillBLL.Instance.CapNhatstatusTable(table.Id);
                            bh.HienThiBanLenPanel();
                            bh.HienThiHoaDon(table.Id);
                            MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                    }
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void settlePayment_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnEnter.PerformClick();//nhan enter ban phim

            }else if(e.KeyCode == Keys.Escape)
            {
                this.Dispose(true);
            }
        }
    }
}
