using System;
using System.Windows.Forms;

namespace frmNhanvien
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
        private  void resetAllTextBox()
        {
            this.txtAddress.Text = "";
            this.txtName.Text = "";
            this.txtPhoneNumber.Text = "";


        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "") errorProvider1.SetError(txtName, "Không được để trống họ tên");
            else
            {
                errorProvider1.Clear();
                ListViewItem item = new ListViewItem();
                item = listView1.Items.Add(txtName.Text);
                item.SubItems.Add(dateTimePicker1.Value.ToString());
                item.SubItems.Add(txtPhoneNumber.Text);
                item.SubItems.Add(txtAddress.Text);
                resetAllTextBox();
                
            }
        }



        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                if (DialogResult.OK == MessageBox.Show("Bạn thực sự muốn xoá", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    foreach (ListViewItem item in listView1.SelectedItems)
                    {
                        listView1.Items.Remove(item);
                    }
                    resetAllTextBox();
                }

            }
            else
                MessageBox.Show("chọn 1 dòng đi", "thông báo", MessageBoxButtons.OK);

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtName.Text;
                listView1.SelectedItems[0].SubItems[1].Text = dateTimePicker1.Value.ToString();
                listView1.SelectedItems[0].SubItems[2].Text = txtPhoneNumber.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtAddress.Text;
                resetAllTextBox();
            }
            else
                MessageBox.Show("Chọn 1 dòng đi", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                this.Close();

        }

        ListView tempListView = new ListView();
        
        ListView backup = new ListView();

        private void txt_Changed(object sender, EventArgs e)
        {
            backup = listView1;
            TextBox temp = (TextBox)sender;
            if ((txtAddress.Text == "" && txtName.Text == "" && txtPhoneNumber.Text == ""))
            {
                listView1 = backup;
            }
            //else
            //{
            //    for (int i = listview1.items.count - 1; i >= 0; i++)
            //    {
            //        if (listview1.items[i].text.contains(txtname.text))
            //            templistview.items.add(listview1.items[i]);
            //    }
            //    listview1 = templistview;
            //    templistview.clear();
            //}


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                txtName.Text = listView1.SelectedItems[0].SubItems[0].Text;
                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtPhoneNumber.Text = listView1.SelectedItems[0].SubItems[2].Text;
                txtAddress.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
    