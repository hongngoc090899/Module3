namespace MODULE_3
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_flightnumber_outbound = new System.Windows.Forms.Label();
            this.lb_date_outbound = new System.Windows.Forms.Label();
            this.lb_cabintype_outbound = new System.Windows.Forms.Label();
            this.lb_to_outbound = new System.Windows.Forms.Label();
            this.lb_from_outbound = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gr_return = new System.Windows.Forms.GroupBox();
            this.lb_flightnumber_return = new System.Windows.Forms.Label();
            this.lb_date_return = new System.Windows.Forms.Label();
            this.lb_cabintype_return = new System.Windows.Forms.Label();
            this.lb_to_return = new System.Windows.Forms.Label();
            this.lb_from_return = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dt_birthDate = new System.Windows.Forms.DateTimePicker();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.cb_passportCountry = new System.Windows.Forms.ComboBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_passportNumber = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.dgv_passengersList = new System.Windows.Forms.DataGridView();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_coubtry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gr_return.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_passengersList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_flightnumber_outbound);
            this.groupBox1.Controls.Add(this.lb_date_outbound);
            this.groupBox1.Controls.Add(this.lb_cabintype_outbound);
            this.groupBox1.Controls.Add(this.lb_to_outbound);
            this.groupBox1.Controls.Add(this.lb_from_outbound);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outbound flight details";
            // 
            // lb_flightnumber_outbound
            // 
            this.lb_flightnumber_outbound.AutoSize = true;
            this.lb_flightnumber_outbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_flightnumber_outbound.Location = new System.Drawing.Point(641, 35);
            this.lb_flightnumber_outbound.Name = "lb_flightnumber_outbound";
            this.lb_flightnumber_outbound.Size = new System.Drawing.Size(41, 13);
            this.lb_flightnumber_outbound.TabIndex = 9;
            this.lb_flightnumber_outbound.Text = "lable1";
            // 
            // lb_date_outbound
            // 
            this.lb_date_outbound.AutoSize = true;
            this.lb_date_outbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date_outbound.Location = new System.Drawing.Point(453, 35);
            this.lb_date_outbound.Name = "lb_date_outbound";
            this.lb_date_outbound.Size = new System.Drawing.Size(41, 13);
            this.lb_date_outbound.TabIndex = 8;
            this.lb_date_outbound.Text = "lable1";
            // 
            // lb_cabintype_outbound
            // 
            this.lb_cabintype_outbound.AutoSize = true;
            this.lb_cabintype_outbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cabintype_outbound.Location = new System.Drawing.Point(331, 35);
            this.lb_cabintype_outbound.Name = "lb_cabintype_outbound";
            this.lb_cabintype_outbound.Size = new System.Drawing.Size(41, 13);
            this.lb_cabintype_outbound.TabIndex = 7;
            this.lb_cabintype_outbound.Text = "lable1";
            // 
            // lb_to_outbound
            // 
            this.lb_to_outbound.AutoSize = true;
            this.lb_to_outbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_to_outbound.Location = new System.Drawing.Point(182, 35);
            this.lb_to_outbound.Name = "lb_to_outbound";
            this.lb_to_outbound.Size = new System.Drawing.Size(41, 13);
            this.lb_to_outbound.TabIndex = 6;
            this.lb_to_outbound.Text = "lable1";
            // 
            // lb_from_outbound
            // 
            this.lb_from_outbound.AutoSize = true;
            this.lb_from_outbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_from_outbound.Location = new System.Drawing.Point(94, 35);
            this.lb_from_outbound.Name = "lb_from_outbound";
            this.lb_from_outbound.Size = new System.Drawing.Size(41, 13);
            this.lb_from_outbound.TabIndex = 5;
            this.lb_from_outbound.Text = "lable1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Flight number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cabin Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // gr_return
            // 
            this.gr_return.Controls.Add(this.lb_flightnumber_return);
            this.gr_return.Controls.Add(this.lb_date_return);
            this.gr_return.Controls.Add(this.lb_cabintype_return);
            this.gr_return.Controls.Add(this.lb_to_return);
            this.gr_return.Controls.Add(this.lb_from_return);
            this.gr_return.Controls.Add(this.label16);
            this.gr_return.Controls.Add(this.label17);
            this.gr_return.Controls.Add(this.label18);
            this.gr_return.Controls.Add(this.label19);
            this.gr_return.Controls.Add(this.label20);
            this.gr_return.Location = new System.Drawing.Point(38, 110);
            this.gr_return.Name = "gr_return";
            this.gr_return.Size = new System.Drawing.Size(714, 60);
            this.gr_return.TabIndex = 1;
            this.gr_return.TabStop = false;
            this.gr_return.Text = "Return flight details";
            // 
            // lb_flightnumber_return
            // 
            this.lb_flightnumber_return.AutoSize = true;
            this.lb_flightnumber_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_flightnumber_return.Location = new System.Drawing.Point(641, 35);
            this.lb_flightnumber_return.Name = "lb_flightnumber_return";
            this.lb_flightnumber_return.Size = new System.Drawing.Size(41, 13);
            this.lb_flightnumber_return.TabIndex = 9;
            this.lb_flightnumber_return.Text = "lable1";
            // 
            // lb_date_return
            // 
            this.lb_date_return.AutoSize = true;
            this.lb_date_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date_return.Location = new System.Drawing.Point(453, 35);
            this.lb_date_return.Name = "lb_date_return";
            this.lb_date_return.Size = new System.Drawing.Size(41, 13);
            this.lb_date_return.TabIndex = 8;
            this.lb_date_return.Text = "lable1";
            // 
            // lb_cabintype_return
            // 
            this.lb_cabintype_return.AutoSize = true;
            this.lb_cabintype_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cabintype_return.Location = new System.Drawing.Point(331, 35);
            this.lb_cabintype_return.Name = "lb_cabintype_return";
            this.lb_cabintype_return.Size = new System.Drawing.Size(34, 13);
            this.lb_cabintype_return.TabIndex = 7;
            this.lb_cabintype_return.Text = "lable";
            // 
            // lb_to_return
            // 
            this.lb_to_return.AutoSize = true;
            this.lb_to_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_to_return.Location = new System.Drawing.Point(182, 35);
            this.lb_to_return.Name = "lb_to_return";
            this.lb_to_return.Size = new System.Drawing.Size(34, 13);
            this.lb_to_return.TabIndex = 6;
            this.lb_to_return.Text = "lable";
            // 
            // lb_from_return
            // 
            this.lb_from_return.AutoSize = true;
            this.lb_from_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_from_return.Location = new System.Drawing.Point(94, 35);
            this.lb_from_return.Name = "lb_from_return";
            this.lb_from_return.Size = new System.Drawing.Size(41, 13);
            this.lb_from_return.TabIndex = 5;
            this.lb_from_return.Text = "lable1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(562, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Flight number:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(414, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Date:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(261, 35);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Cabin Type:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(153, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "To:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(54, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "From:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbID);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dt_birthDate);
            this.groupBox3.Controls.Add(this.txt_phone);
            this.groupBox3.Controls.Add(this.cb_passportCountry);
            this.groupBox3.Controls.Add(this.txt_lastName);
            this.groupBox3.Controls.Add(this.txt_passportNumber);
            this.groupBox3.Controls.Add(this.txt_firstName);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(38, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(714, 147);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Passenger details";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add passenger";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dt_birthDate
            // 
            this.dt_birthDate.CustomFormat = "dd/MM/yyyy";
            this.dt_birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_birthDate.Location = new System.Drawing.Point(571, 44);
            this.dt_birthDate.Name = "dt_birthDate";
            this.dt_birthDate.Size = new System.Drawing.Size(105, 20);
            this.dt_birthDate.TabIndex = 12;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(571, 85);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(105, 20);
            this.txt_phone.TabIndex = 11;
            // 
            // cb_passportCountry
            // 
            this.cb_passportCountry.FormattingEnabled = true;
            this.cb_passportCountry.Location = new System.Drawing.Point(371, 81);
            this.cb_passportCountry.Name = "cb_passportCountry";
            this.cb_passportCountry.Size = new System.Drawing.Size(114, 21);
            this.cb_passportCountry.TabIndex = 9;
            this.cb_passportCountry.SelectedIndexChanged += new System.EventHandler(this.cb_passportCountry_SelectedIndexChanged);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(343, 41);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(142, 20);
            this.txt_lastName.TabIndex = 8;
            // 
            // txt_passportNumber
            // 
            this.txt_passportNumber.Location = new System.Drawing.Point(156, 82);
            this.txt_passportNumber.Name = "txt_passportNumber";
            this.txt_passportNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_passportNumber.TabIndex = 7;
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(115, 39);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(141, 20);
            this.txt_firstName.TabIndex = 6;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(523, 88);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 5;
            this.label26.Text = "Phone";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(512, 44);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Birthdate";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(284, 88);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "Pasport country";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(284, 44);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Lastname";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(57, 89);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 13);
            this.label22.TabIndex = 1;
            this.label22.Text = "Passport number";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(57, 44);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Firstname";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(38, 380);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 13);
            this.label27.TabIndex = 3;
            this.label27.Text = "Passengers list";
            // 
            // dgv_passengersList
            // 
            this.dgv_passengersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_passengersList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstname,
            this.lastname,
            this.birthdate,
            this.passport_number,
            this.passport_coubtry,
            this.phone,
            this.Column1});
            this.dgv_passengersList.Location = new System.Drawing.Point(41, 411);
            this.dgv_passengersList.Name = "dgv_passengersList";
            this.dgv_passengersList.Size = new System.Drawing.Size(711, 150);
            this.dgv_passengersList.TabIndex = 4;
            this.dgv_passengersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_passengersList_CellClick);
            // 
            // firstname
            // 
            this.firstname.HeaderText = "Firstname";
            this.firstname.Name = "firstname";
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Lastname";
            this.lastname.Name = "lastname";
            // 
            // birthdate
            // 
            this.birthdate.HeaderText = "Birthdate";
            this.birthdate.Name = "birthdate";
            // 
            // passport_number
            // 
            this.passport_number.HeaderText = "Passport number";
            this.passport_number.Name = "passport_number";
            this.passport_number.Width = 150;
            // 
            // passport_coubtry
            // 
            this.passport_coubtry.HeaderText = "Passport Country";
            this.passport_coubtry.Name = "passport_coubtry";
            this.passport_coubtry.Width = 150;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "userID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Remove passenger";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 592);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 38);
            this.button3.TabIndex = 6;
            this.button3.Text = "Back to search for flights";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(381, 592);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 38);
            this.button4.TabIndex = 7;
            this.button4.Text = "Confirm Booking";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(115, 20);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 13);
            this.lbID.TabIndex = 14;
            this.lbID.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 657);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv_passengersList);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gr_return);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Booking confimation";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gr_return.ResumeLayout(false);
            this.gr_return.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_passengersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_flightnumber_outbound;
        private System.Windows.Forms.Label lb_date_outbound;
        private System.Windows.Forms.Label lb_cabintype_outbound;
        private System.Windows.Forms.Label lb_to_outbound;
        private System.Windows.Forms.Label lb_from_outbound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gr_return;
        private System.Windows.Forms.Label lb_flightnumber_return;
        private System.Windows.Forms.Label lb_date_return;
        private System.Windows.Forms.Label lb_cabintype_return;
        private System.Windows.Forms.Label lb_to_return;
        private System.Windows.Forms.Label lb_from_return;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.ComboBox cb_passportCountry;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_passportNumber;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dt_birthDate;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView dgv_passengersList;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_coubtry;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lbID;
    }
}