
namespace laba6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_x = new System.Windows.Forms.ListBox();
            this.listBox_y = new System.Windows.Forms.ListBox();
            this.res_textbox = new System.Windows.Forms.TextBox();
            this.file_listBox = new System.Windows.Forms.ListBox();
            this.XYButton = new System.Windows.Forms.Button();
            this.ResButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_res = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(75, 48);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(309, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_x
            // 
            this.listBox_x.FormattingEnabled = true;
            this.listBox_x.ItemHeight = 15;
            this.listBox_x.Location = new System.Drawing.Point(158, 324);
            this.listBox_x.Name = "listBox_x";
            this.listBox_x.Size = new System.Drawing.Size(61, 94);
            this.listBox_x.TabIndex = 3;
            // 
            // listBox_y
            // 
            this.listBox_y.FormattingEnabled = true;
            this.listBox_y.ItemHeight = 15;
            this.listBox_y.Location = new System.Drawing.Point(225, 324);
            this.listBox_y.Name = "listBox_y";
            this.listBox_y.Size = new System.Drawing.Size(61, 94);
            this.listBox_y.TabIndex = 4;
            // 
            // res_textbox
            // 
            this.res_textbox.Location = new System.Drawing.Point(323, 395);
            this.res_textbox.Name = "res_textbox";
            this.res_textbox.Size = new System.Drawing.Size(102, 23);
            this.res_textbox.TabIndex = 5;
            // 
            // file_listBox
            // 
            this.file_listBox.FormattingEnabled = true;
            this.file_listBox.ItemHeight = 15;
            this.file_listBox.Location = new System.Drawing.Point(12, 198);
            this.file_listBox.Name = "file_listBox";
            this.file_listBox.Size = new System.Drawing.Size(413, 94);
            this.file_listBox.TabIndex = 6;
            // 
            // XYButton
            // 
            this.XYButton.Location = new System.Drawing.Point(323, 324);
            this.XYButton.Name = "XYButton";
            this.XYButton.Size = new System.Drawing.Size(102, 23);
            this.XYButton.TabIndex = 7;
            this.XYButton.Text = "Координаты";
            this.XYButton.UseVisualStyleBackColor = true;
            this.XYButton.Click += new System.EventHandler(this.XYButton_Click);
            // 
            // ResButton
            // 
            this.ResButton.Location = new System.Drawing.Point(323, 353);
            this.ResButton.Name = "ResButton";
            this.ResButton.Size = new System.Drawing.Size(102, 23);
            this.ResButton.TabIndex = 8;
            this.ResButton.Text = "Результат";
            this.ResButton.UseVisualStyleBackColor = true;
            this.ResButton.Click += new System.EventHandler(this.ResButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество наборов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Файлы:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "G = ";
            // 
            // listBox_res
            // 
            this.listBox_res.FormattingEnabled = true;
            this.listBox_res.ItemHeight = 15;
            this.listBox_res.Location = new System.Drawing.Point(13, 324);
            this.listBox_res.Name = "listBox_res";
            this.listBox_res.Size = new System.Drawing.Size(120, 94);
            this.listBox_res.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 460);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox_res);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResButton);
            this.Controls.Add(this.XYButton);
            this.Controls.Add(this.file_listBox);
            this.Controls.Add(this.res_textbox);
            this.Controls.Add(this.listBox_y);
            this.Controls.Add(this.listBox_x);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_x;
        private System.Windows.Forms.ListBox listBox_y;
        private System.Windows.Forms.TextBox res_textbox;
        private System.Windows.Forms.ListBox file_listBox;
        private System.Windows.Forms.Button XYButton;
        private System.Windows.Forms.Button ResButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox_res;
        private System.Windows.Forms.Label label7;
    }
}

