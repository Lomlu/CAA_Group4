using System;
namespace SE307PrG4GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.LightGray;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.No;
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(724, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.CausesValidation = false;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.MaximumSize = new System.Drawing.Size(380, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "KITCHEN ADVISORY UTILITY PROGRAM\r\n              SE307 GR4 PROJECT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "By Group 4 (In Alphabetical Order):\r\n1- Berk Kocaman 2-Meriç Lomlu 3- Zeynep Tokg" +
    "özlü";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "SelectCategory";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "ListMenu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "DisplayOptions";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "AddMenu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 363);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "EditMenu";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 403);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "DeleteMenu";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 442);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "ClearMenus";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(11, 480);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "SaveToDisk";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 521);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "ReloadFromDisk";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(12, 165);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(97, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Exit";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(13, 592);
            this.label3.MaximumSize = new System.Drawing.Size(100, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 562);
            this.label4.MaximumSize = new System.Drawing.Size(100, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Category";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 165);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(713, 457);
            this.textBox1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(400, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 150);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 647);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

