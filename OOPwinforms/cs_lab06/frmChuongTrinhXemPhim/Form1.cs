using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Text = "     Chào mừng anh Thịnh đẹp trai      ";


            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy");
            s = s + " - Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
            toolStripStatusLabel1.Text = s;
            
            this.Text = this.Text.Substring(1, this.Text.Length - 1) + this.Text.Substring(0, 1);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Tạo hộp thoại mở file
            OpenFileDialog dlg = new OpenFileDialog();
            //lọc hiện thị các loại file
            dlg.Filter = "AVI file| *.avi | MPEG File | *.mpeg | Wav File | *.Wav | Midi File | *.midi | Mp4 File | *.mp4";
            //hien thi openDialog
            if (dlg.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = dlg.FileName; //Lấy tên file cần mở
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
