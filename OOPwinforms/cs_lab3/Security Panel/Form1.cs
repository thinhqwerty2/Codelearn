using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<string> data = new List<string>();
        int code = 0;

        private void numberButton(object sender, EventArgs e)

        {

            Button temp = new Button();
            temp = (Button)sender;
            code = code * 10 + int.Parse(temp.Text);
            textBox1.Text = code.ToString() ;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            code = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            checkCode();
        }


        private void numberDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue <= 9 || e.KeyValue >= 0)
                code = code * 10 + e.KeyValue ;
            textBox1.Text = code.ToString();
        }


        private void checkCode()
        {
            if (textBox1.TextLength != 0)
                switch (textBox1.Text)
                {
                    case "1645":
                    case "1689":
                        data.Add(DateTime.Now + "\tTechnician");
                        break;
                    case "8345":
                        data.Add(DateTime.Now + "\tCustodians");
                        break;
                    case "9998":
                    case "1006":
                    case "1008":
                        data.Add(DateTime.Now + "\tScientist");
                        break;
                    default:
                        data.Add(DateTime.Now + "\tRestricted Access");
                        break;
                }
            textBox2.Lines = data.ToArray();
            textBox1.Text = "";
            code = 0;
        }
    }
}
