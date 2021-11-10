using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = "0";
        }

        int number;
        
        double foodprice(string s)
        {
            switch (s)
            {
                case "Burger Phô mai Bò":
                    return 200000;
                case "Burger Phô mai Gà":
                    return 300000;
                case "Burger Phô mai Tôm":
                    return 140000;
                case "Burger Phô mai Cá":
                    return 190000;
                case "Tôm viên Cola":
                    return 5000;
                case "Gà viên Cola":
                    return 3200;
                case "Gà rán phần":
                    return 4000;
                case "Cơm Gà Tender":
                    return 50000;
                case "Khoai tây chiên":
                    return 10000;
                case "Cafe":
                case "7 up":
                case "Pepsi":
                case "Coca":
                case "Lipton":
                case "Cam":
                    return 10000;
                default:
                    return 0;
            }


        }
        DataSet slot = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                DataTable sloti = new DataTable();
                
                sloti.Columns.Add("FoodName", typeof(String));
                sloti.Columns.Add("Quantity", typeof(Int32));
                sloti.Columns.Add("Price", typeof(Double));
                sloti.Columns.Add("Total", typeof(Double));
                slot.Tables.Add(sloti);
                comboBox1.Items.Add("slot" + (i+1));
            }

        }
        private void Order(object sender, EventArgs e)
        {
            bool flag = false;
            DataRow r = slot.Tables[number].NewRow();
            Control food = (Control)sender;
            if (comboBox1.SelectedItem != null)
                if (slot.Tables[number].Rows.Count == 0)
                {
                    r["FoodName"] = food.Text;
                    r["Quantity"] = 1;
                    r["Price"] = foodprice(food.Text);
                    r["Total"] = foodprice(food.Text);
                    slot.Tables[number].Rows.Add(r);

                }
                else
                {
                    for (int i = slot.Tables[number].Rows.Count - 1; i >= 0; i--)
                    {
                        if ((string)slot.Tables[number].Rows[i][0] == (food.Text))
                        {
                            flag = true;
                            int dem = int.Parse(slot.Tables[number].Rows[i][1].ToString());
                            dem++;
                            slot.Tables[number].Rows[i][1] = dem;
                        }
                        slot.Tables[number].Rows[i]["Total"] = (int)slot.Tables[number].Rows[i]["Quantity"] * (double)slot.Tables[number].Rows[i]["Price"];

                    }
                    if (flag == false)
                    {
                        DataRow l = slot.Tables[number].NewRow();
                        l["FoodName"] = food.Text;
                        l["Quantity"] = 1;
                        l["Price"] = foodprice(food.Text);
                        l["Total"] = foodprice(food.Text);
                        slot.Tables[number].Rows.Add(l);

                    }
                }
            double thanhtien = 0;
            foreach (DataRow item in slot.Tables[number].Rows)
            {
                thanhtien += (double)item["Total"];
            }
            label4.Text = thanhtien.ToString();
        }
        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            number = comboBox1.SelectedIndex;
            dataGridView1.DataSource = slot.Tables[number];
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (removeIndex == -1) return;
            if (MessageBox.Show("Bạn thực sự muốn xoá dòng này?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                slot.Tables[number].Rows.RemoveAt(removeIndex);
                removeIndex = -1;
            }
            double thanhtien = 0;
            foreach (DataRow item in slot.Tables[number].Rows)
            {
                thanhtien += (double)item["Total"];
            }
            label4.Text = thanhtien.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true ;
        }

        int  removeIndex=-1;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex <= slot.Tables[number].Rows.Count - 1)
                removeIndex = e.RowIndex;
            else removeIndex = -1;
                                        
        }
    }

}
