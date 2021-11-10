using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        ListBox a = new ListBox();
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength == 0)
                MessageBox.Show("Chưa nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            GetPay();
        }
        private void GetPay()
        {
            decimal Total = 0;
            if (checkBox1.Checked) Total += 100000;
            if (checkBox2.Checked) Total += 1200000;
            if (checkBox3.Checked) Total += 200000;
            Total += numericUpDown1.Value * 80000;
            textBox1.Text = Total.ToString();
            
        }

    }
}
