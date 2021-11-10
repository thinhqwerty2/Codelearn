using System;
using System.Windows.Forms;

namespace frmUocboi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }
        private int BSCNN(int a, int b)
        {
            return a * b / USCLN(a, b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                textBox3.Text = USCLN(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
            else
                textBox3.Text = BSCNN(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var b=MessageBox.Show("Bạn có thực sự muốn thoát", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            switch (b)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    this.Close();
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
    }
}
