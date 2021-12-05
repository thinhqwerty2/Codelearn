using System;
using System.Data;
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
            data.Columns.Add(lblTitle.Text);
            data.Columns.Add(lblAuthor.Text);
            data.Columns.Add(lblYear.Text);
            data.Columns.Add(lblPublisher.Text);
            data.Columns.Add(lblISBN.Text);

        }
        // BookList.BookList list = new BookList.BookList();
        //List<BookList.Book> listbook = new List<BookList.Book>();

        DataTable data = new DataTable("Book");
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtTitle.Text == "") errorProvider1.SetError(txtTitle, "Không được để trống tên sách");
            else
            {
                DataRow r = data.NewRow();
                errorProvider1.Clear();
                r[0] = txtTitle.Text;
                r[1] = txtAuthor.Text;
                r[2] = txtYear.Text;
                r[3] = txtPublisher.Text;
                r[4] = txtISBN.Text;

                data.Rows.Add(r);

                dataGridView1.DataSource = data;
            }
        }
        private void resetAllTextBox()
        {
            this.txtTitle.Text = "";
            this.txtAuthor.Text = "";
            this.txtPublisher.Text = "";
            this.txtYear.Text = "";
            this.txtISBN.Text = "";



        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (removeIndex == -1)
            {
                errorProvider1.SetError((Control)sender, "Chọn một hàng để xoá");
                return;
            }
            if (MessageBox.Show("Bạn thực sự muốn xoá dòng này?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                data.Rows.RemoveAt(removeIndex);
                resetAllTextBox();
                removeIndex = -1;
            }



        }
        int removeIndex = -1;
        bool checkClickView = false;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            checkClickView = true;
            dataGridView1.Rows[e.RowIndex].Selected = true;
            if (e.RowIndex <= data.Rows.Count - 1)
            {
                removeIndex = e.RowIndex;
                errorProvider1.Clear();
            txtTitle.Text = data.Rows[removeIndex][0].ToString();
            txtAuthor.Text = data.Rows[removeIndex][1].ToString();
            txtYear.Text = data.Rows[removeIndex][2].ToString();
            txtPublisher.Text = data.Rows[removeIndex][3].ToString();
            txtISBN.Text = data.Rows[removeIndex][4].ToString();

            }
            else removeIndex = -1;


        }


        private void btnMod_Click(object sender, EventArgs e)
        {

            data.Rows[removeIndex][0] = txtTitle.Text;
            data.Rows[removeIndex][1] = txtAuthor.Text;
            data.Rows[removeIndex][2] = txtYear.Text;
            data.Rows[removeIndex][3] = txtPublisher.Text;
            data.Rows[removeIndex][4] = txtISBN.Text;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                this.Close();
            data.WriteXmlSchema("BookList");

        }


        DataTable temp = new DataTable();

        private void txt_Changed(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            
            temp = data.Copy();
            if (data.Rows.Count >= 2)
            {
                for (int i = data.Rows.Count-1; i >=0; i--)
                {
                    if (!data.Rows[i][lblAuthor.Text].ToString().Contains(txtAuthor.Text.Trim())|| 
                        !data.Rows[i][lblTitle.Text].ToString().Contains(txtTitle.Text.Trim())||
                        !data.Rows[i][lblISBN.Text].ToString().Contains(txtISBN.Text.Trim()) ||
                        !data.Rows[i][lblPublisher.Text].ToString().Contains(txtPublisher.Text.Trim()) ||
                        !data.Rows[i][lblYear.Text].ToString().Contains(txtYear.Text.Trim()) 
                        )
                    {
                        temp.Rows.RemoveAt(i);
                    }
                }
            }
            dataGridView1.DataSource = temp;
            if (txtAuthor.Text == "" && txtISBN.Text == "" && txtTitle.Text == "" && txtPublisher.Text == "" && txtYear.Text == "")
            { dataGridView1.DataSource = data; };
        }






    }
}
