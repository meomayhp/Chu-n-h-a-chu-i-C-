namespace ChuanHoaChuoi
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
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.btnthuchien = new System.Windows.Forms.Button();
            this.txtds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtchuanhoa = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(115, 19);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(153, 20);
            this.txtnhap.TabIndex = 0;
            // 
            // btnthuchien
            // 
            this.btnthuchien.Location = new System.Drawing.Point(21, 54);
            this.btnthuchien.Name = "btnthuchien";
            this.btnthuchien.Size = new System.Drawing.Size(92, 30);
            this.btnthuchien.TabIndex = 1;
            this.btnthuchien.Text = "Thực hiện";
            this.btnthuchien.UseVisualStyleBackColor = true;
            this.btnthuchien.Click += new System.EventHandler(this.btnthuchien_Click);
            // 
            // txtds
            // 
            this.txtds.Location = new System.Drawing.Point(115, 148);
            this.txtds.Multiline = true;
            this.txtds.Name = "txtds";
            this.txtds.Size = new System.Drawing.Size(153, 89);
            this.txtds.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập chuỗi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chuỗi chuẩn hóa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng từ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Danh sách các từ:";
            // 
            // txtchuanhoa
            // 
            this.txtchuanhoa.Location = new System.Drawing.Point(115, 98);
            this.txtchuanhoa.Name = "txtchuanhoa";
            this.txtchuanhoa.ReadOnly = true;
            this.txtchuanhoa.Size = new System.Drawing.Size(153, 20);
            this.txtchuanhoa.TabIndex = 7;
            this.txtchuanhoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(115, 122);
            this.txtsl.Name = "txtsl";
            this.txtsl.ReadOnly = true;
            this.txtsl.Size = new System.Drawing.Size(153, 20);
            this.txtsl.TabIndex = 8;
            this.txtsl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 256);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txtchuanhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtds);
            this.Controls.Add(this.btnthuchien);
            this.Controls.Add(this.txtnhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.Button btnthuchien;
        private System.Windows.Forms.TextBox txtds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtchuanhoa;
        private System.Windows.Forms.TextBox txtsl;
    }
}

