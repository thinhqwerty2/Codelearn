using System;
using System.Windows.Forms;

namespace ThaoTacSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctrSonguyen = (Control)sender;
            if (ctrSonguyen.Text.Length > 0)
                if (!char.IsDigit(ctrSonguyen.Text[ctrSonguyen.Text.Length - 1]))
                    this.errorProvider1.SetError(ctrSonguyen, "Vui lòng nhập số nguyên");
                else
                    this.errorProvider1.Clear();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count; //Số mục trong lst
            for (int i = 0; i < n; i++)
            {
                int tam = int.Parse(lstKetqua.Items[i].ToString()) + 2;
                lstKetqua.Items.RemoveAt(i);
                lstKetqua.Items.Insert(i, tam.ToString());
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count; //Số mục trong lst
            for (int i = 0; i < n - 1; i++)
            {
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 0)
                {
                    string s = lstKetqua.Items[i].ToString();//Lay gia tri muc gia tri chan
                    lstKetqua.SelectedItem = s;//Chon muc co gia tri chan
                    break; //Thuc hien duoc so chn dau thi ket thuc vong lap
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int n = lstKetqua.Items.Count; //Số mục trong lst
            for (int i = n - 1; i >= 0; i--)
            {
                if (int.Parse(lstKetqua.Items[i].ToString()) % 2 == 1)
                {
                    string s = lstKetqua.Items[i].ToString();//Lay gia tri muc gia tri lẻ
                    lstKetqua.SelectedItem = s;//Chon muc co gia tri le
                    break; //Thuc hien duoc so le dau (tu duoi len) thi ket thuc vong lap
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.SelectedItems.Count; //Số mục dang duoc chon trong lstKetqua
            for (int i = n - 1; i >= 0; i--)
                lstKetqua.Items.Remove(lstKetqua.SelectedItems[i].ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.Remove(lstKetqua.Items[0].ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int n = lstKetqua.Items.Count;
            lstKetqua.Items.Remove(lstKetqua.Items[n - 1].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstKetqua.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }
    }
    
}
