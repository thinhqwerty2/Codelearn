
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhapSoN = new System.Windows.Forms.Label();
            this.lblNhapSoM = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtNhapN = new System.Windows.Forms.TextBox();
            this.txtNhapM = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(115, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            // 
            // lblNhapSoN
            // 
            this.lblNhapSoN.AutoSize = true;
            this.lblNhapSoN.Location = new System.Drawing.Point(66, 86);
            this.lblNhapSoN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapSoN.Name = "lblNhapSoN";
            this.lblNhapSoN.Size = new System.Drawing.Size(73, 17);
            this.lblNhapSoN.TabIndex = 1;
            this.lblNhapSoN.Text = "Nhập số n";
            // 
            // lblNhapSoM
            // 
            this.lblNhapSoM.AutoSize = true;
            this.lblNhapSoM.Location = new System.Drawing.Point(66, 141);
            this.lblNhapSoM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapSoM.Name = "lblNhapSoM";
            this.lblNhapSoM.Size = new System.Drawing.Size(77, 17);
            this.lblNhapSoM.TabIndex = 2;
            this.lblNhapSoM.Text = "Nhập số m";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(66, 189);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(60, 17);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.Text = "Kết quả";
            // 
            // txtNhapN
            // 
            this.txtNhapN.Location = new System.Drawing.Point(171, 86);
            this.txtNhapN.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapN.Name = "txtNhapN";
            this.txtNhapN.Size = new System.Drawing.Size(253, 25);
            this.txtNhapN.TabIndex = 4;
            // 
            // txtNhapM
            // 
            this.txtNhapM.Location = new System.Drawing.Point(171, 133);
            this.txtNhapM.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhapM.Name = "txtNhapM";
            this.txtNhapM.Size = new System.Drawing.Size(253, 25);
            this.txtNhapM.TabIndex = 5;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(171, 186);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(253, 25);
            this.txtKetQua.TabIndex = 6;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(40, 243);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(70, 30);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(120, 243);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(70, 30);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(198, 243);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(4);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(70, 30);
            this.btnMulti.TabIndex = 9;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDevide
            // 
            this.btnDevide.Location = new System.Drawing.Point(276, 243);
            this.btnDevide.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(70, 30);
            this.btnDevide.TabIndex = 10;
            this.btnDevide.Text = "/";
            this.btnDevide.UseVisualStyleBackColor = true;
            this.btnDevide.Click += new System.EventHandler(this.btnDevide_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(354, 243);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 30);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(433, 243);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 30);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 328);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDevide);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNhapM);
            this.Controls.Add(this.txtNhapN);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblNhapSoM);
            this.Controls.Add(this.lblNhapSoN);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TÍNH TOÁN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhapSoN;
        private System.Windows.Forms.Label lblNhapSoM;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtNhapN;
        private System.Windows.Forms.TextBox txtNhapM;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDevide;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

