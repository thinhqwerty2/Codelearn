using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = (double.Parse(txtNhapM.Text) + double.Parse(txtNhapN.Text)).ToString();
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = (double.Parse(txtNhapM.Text) - double.Parse(txtNhapN.Text)).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Bạn có thực sự muốn thoát", "Thoát", MessageBoxButtons.OKCancel);
            switch (a)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    Close();
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
            
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = (double.Parse(txtNhapM.Text) * double.Parse(txtNhapN.Text)).ToString();

        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            if (double.Parse(txtNhapM.Text) == 0) txtKetQua.Text = "NaN";
            else
                txtKetQua.Text = (double.Parse(txtNhapM.Text) / double.Parse(txtNhapN.Text)).ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
                        txtKetQua.Text = "";
            txtNhapM.Text = "";
            txtNhapN.Text = "";
        }
    }
}
