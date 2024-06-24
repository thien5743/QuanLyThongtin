namespace QuanLyThongtin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtmaten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtnamsinh = new System.Windows.Forms.TextBox();
            this.txtquequan = new System.Windows.Forms.TextBox();
            this.Thoát = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtmaten
            // 
            this.txtmaten.Location = new System.Drawing.Point(138, 72);
            this.txtmaten.Name = "txtmaten";
            this.txtmaten.Size = new System.Drawing.Size(202, 20);
            this.txtmaten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quê quán";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(138, 102);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(202, 20);
            this.txthoten.TabIndex = 1;
            // 
            // txtnamsinh
            // 
            this.txtnamsinh.Location = new System.Drawing.Point(138, 128);
            this.txtnamsinh.Name = "txtnamsinh";
            this.txtnamsinh.Size = new System.Drawing.Size(202, 20);
            this.txtnamsinh.TabIndex = 1;
            // 
            // txtquequan
            // 
            this.txtquequan.Location = new System.Drawing.Point(138, 156);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.Size = new System.Drawing.Size(202, 20);
            this.txtquequan.TabIndex = 1;
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(794, 24);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(101, 64);
            this.Thoát.TabIndex = 3;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(794, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(794, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 64);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(794, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 64);
            this.button4.TabIndex = 3;
            this.button4.Text = "sửa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(794, 304);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 64);
            this.button5.TabIndex = 3;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(794, 374);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 64);
            this.button6.TabIndex = 3;
            this.button6.Text = "Tìm kiếm";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(794, 446);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 64);
            this.button7.TabIndex = 3;
            this.button7.Text = "Trở về";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(498, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 531);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtquequan);
            this.Controls.Add(this.txtnamsinh);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaten);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmaten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtnamsinh;
        private System.Windows.Forms.TextBox txtquequan;
        private System.Windows.Forms.Button Thoát;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
    }
}

