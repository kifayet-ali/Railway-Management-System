namespace Raillway
{
    partial class TravelMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelMaster));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.TravelDGV = new System.Windows.Forms.DataGridView();
            this.DestCb = new System.Windows.Forms.ComboBox();
            this.SrcCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TCode = new System.Windows.Forms.ComboBox();
            this.TravDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TCostTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TravelDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.TravelDGV);
            this.panel1.Controls.Add(this.DestCb);
            this.panel1.Controls.Add(this.SrcCb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TCode);
            this.panel1.Controls.Add(this.TravDate);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.TCostTb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 681);
            this.panel1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(525, 609);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 40);
            this.button3.TabIndex = 39;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TravelDGV
            // 
            this.TravelDGV.BackgroundColor = System.Drawing.Color.White;
            this.TravelDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TravelDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TravelDGV.GridColor = System.Drawing.Color.Green;
            this.TravelDGV.Location = new System.Drawing.Point(47, 335);
            this.TravelDGV.Name = "TravelDGV";
            this.TravelDGV.RowHeadersWidth = 62;
            this.TravelDGV.RowTemplate.Height = 28;
            this.TravelDGV.Size = new System.Drawing.Size(1152, 254);
            this.TravelDGV.TabIndex = 38;
            this.TravelDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TravelDGV_CellContentClick);
            // 
            // DestCb
            // 
            this.DestCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DestCb.FormattingEnabled = true;
            this.DestCb.Items.AddRange(new object[] {
            "Karachi",
            "",
            "",
            "Lahore",
            "",
            "",
            "Islamabad",
            "",
            "",
            "Rawalpindi",
            "",
            "",
            "Peshawar",
            "",
            "",
            "Quetta",
            "",
            "",
            "Multan",
            "",
            "",
            "Faisalabad",
            "",
            "",
            "Hyderabad",
            "",
            "",
            "Sialkot",
            "",
            "",
            "Gujranwala",
            "",
            "",
            "Gujrat",
            "",
            "",
            "Bahawalpur",
            "",
            "",
            "",
            "Larkana",
            "",
            "",
            "Sargodha",
            "",
            "",
            "Jhelum",
            "",
            "",
            "Okara",
            "",
            "",
            "Rahim Yar Khan",
            "",
            "",
            "Dera Ghazi Khan",
            "",
            "",
            "Mianwali",
            "",
            "",
            "",
            "",
            "Kasur",
            "",
            "",
            "Narowal",
            "",
            "",
            "Attock",
            "",
            "",
            "Khanewal",
            "",
            "",
            "Lodhran",
            "",
            "",
            "Toba Tek Singh",
            "",
            "",
            "Sahiwal",
            "",
            "",
            "Vehari",
            "",
            "",
            "Jhang",
            "",
            "",
            "Mandi Bahauddin",
            "",
            "",
            "Chakwal",
            "",
            "",
            "Hafizabad",
            "",
            "",
            "Nowshera",
            "",
            "",
            "Kohat",
            "",
            "",
            "Dera Ismail Khan",
            "",
            "",
            "Chaman",
            "",
            "",
            "Sibi"});
            this.DestCb.Location = new System.Drawing.Point(797, 154);
            this.DestCb.Name = "DestCb";
            this.DestCb.Size = new System.Drawing.Size(203, 33);
            this.DestCb.TabIndex = 37;
            // 
            // SrcCb
            // 
            this.SrcCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SrcCb.FormattingEnabled = true;
            this.SrcCb.Items.AddRange(new object[] {
            "Karachi",
            "",
            "",
            "Lahore",
            "",
            "",
            "Islamabad",
            "",
            "",
            "Rawalpindi",
            "",
            "",
            "Peshawar",
            "",
            "",
            "Quetta",
            "",
            "",
            "Multan",
            "",
            "",
            "Faisalabad",
            "",
            "",
            "Hyderabad",
            "",
            "",
            "Sialkot",
            "",
            "",
            "Gujranwala",
            "",
            "",
            "Gujrat",
            "",
            "",
            "Bahawalpur",
            "",
            "",
            "",
            "Larkana",
            "",
            "",
            "Sargodha",
            "",
            "",
            "Jhelum",
            "",
            "",
            "Okara",
            "",
            "",
            "Rahim Yar Khan",
            "",
            "",
            "Dera Ghazi Khan",
            "",
            "",
            "Mianwali",
            "",
            "",
            "",
            "",
            "Kasur",
            "",
            "",
            "Narowal",
            "",
            "",
            "Attock",
            "",
            "",
            "Khanewal",
            "",
            "",
            "Lodhran",
            "",
            "",
            "Toba Tek Singh",
            "",
            "",
            "Sahiwal",
            "",
            "",
            "Vehari",
            "",
            "",
            "Jhang",
            "",
            "",
            "Mandi Bahauddin",
            "",
            "",
            "Chakwal",
            "",
            "",
            "Hafizabad",
            "",
            "",
            "Nowshera",
            "",
            "",
            "Kohat",
            "",
            "",
            "Dera Ismail Khan",
            "",
            "",
            "Chaman",
            "",
            "",
            "Sibi"});
            this.SrcCb.Location = new System.Drawing.Point(583, 154);
            this.SrcCb.Name = "SrcCb";
            this.SrcCb.Size = new System.Drawing.Size(203, 33);
            this.SrcCb.TabIndex = 36;
            this.SrcCb.SelectedIndexChanged += new System.EventHandler(this.SrcCb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(791, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(577, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "Source";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TCode
            // 
            this.TCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TCode.FormattingEnabled = true;
            this.TCode.Location = new System.Drawing.Point(353, 154);
            this.TCode.Name = "TCode";
            this.TCode.Size = new System.Drawing.Size(203, 33);
            this.TCode.TabIndex = 33;
            // 
            // TravDate
            // 
            this.TravDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TravDate.Location = new System.Drawing.Point(13, 154);
            this.TravDate.Name = "TravDate";
            this.TravDate.Size = new System.Drawing.Size(334, 30);
            this.TravDate.TabIndex = 32;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(675, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(138, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // TCostTb
            // 
            this.TCostTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCostTb.Location = new System.Drawing.Point(1026, 152);
            this.TCostTb.Name = "TCostTb";
            this.TCostTb.Size = new System.Drawing.Size(186, 35);
            this.TCostTb.TabIndex = 30;
            this.TCostTb.TextChanged += new System.EventHandler(this.TCostTb_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(1020, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 32);
            this.label9.TabIndex = 29;
            this.label9.Text = "Travel Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(360, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 32);
            this.label8.TabIndex = 27;
            this.label8.Text = "Train Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(540, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 39);
            this.label5.TabIndex = 25;
            this.label5.Text = "Travels";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(829, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 40);
            this.button4.TabIndex = 24;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(204, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(525, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(445, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Travel Master";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Green;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(486, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 39);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pak RailWay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1171, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 39);
            this.label6.TabIndex = 4;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TravelMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1241, 795);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TravelMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelMaster";
            this.Load += new System.EventHandler(this.TravelMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TravelDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TCostTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TCode;
        private System.Windows.Forms.DateTimePicker TravDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DestCb;
        private System.Windows.Forms.ComboBox SrcCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView TravelDGV;
        private System.Windows.Forms.Button button3;
    }
}