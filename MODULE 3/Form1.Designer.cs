namespace MODULE_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_from = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_return = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Button();
            this.dateTime_out = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rd_oneWay = new System.Windows.Forms.RadioButton();
            this.rd_return = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_out = new System.Windows.Forms.CheckBox();
            this.dgv_out = new System.Windows.Forms.DataGridView();
            this.form = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_return = new System.Windows.Forms.CheckBox();
            this.dgv_return = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Passengers = new System.Windows.Forms.TextBox();
            this.btn_book = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cb_to = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_cabinType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_return)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_cabinType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_to);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_from);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTime_return);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_apply);
            this.groupBox1.Controls.Add(this.dateTime_out);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rd_oneWay);
            this.groupBox1.Controls.Add(this.rd_return);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Parameters";
            // 
            // cb_from
            // 
            this.cb_from.FormattingEnabled = true;
            this.cb_from.Location = new System.Drawing.Point(126, 34);
            this.cb_from.Name = "cb_from";
            this.cb_from.Size = new System.Drawing.Size(121, 21);
            this.cb_from.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "From";
            // 
            // dateTime_return
            // 
            this.dateTime_return.CustomFormat = "dd/MM/yyyy";
            this.dateTime_return.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_return.Location = new System.Drawing.Point(520, 76);
            this.dateTime_return.Name = "dateTime_return";
            this.dateTime_return.Size = new System.Drawing.Size(97, 20);
            this.dateTime_return.TabIndex = 12;
            this.dateTime_return.Value = new System.DateTime(2018, 10, 5, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Return";
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(655, 73);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 10;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // dateTime_out
            // 
            this.dateTime_out.CustomFormat = "dd/MM/yyyy";
            this.dateTime_out.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_out.Location = new System.Drawing.Point(353, 76);
            this.dateTime_out.Name = "dateTime_out";
            this.dateTime_out.Size = new System.Drawing.Size(97, 20);
            this.dateTime_out.TabIndex = 9;
            this.dateTime_out.Value = new System.DateTime(2018, 10, 4, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(285, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Outbound";
            // 
            // rd_oneWay
            // 
            this.rd_oneWay.AutoSize = true;
            this.rd_oneWay.Location = new System.Drawing.Point(199, 79);
            this.rd_oneWay.Name = "rd_oneWay";
            this.rd_oneWay.Size = new System.Drawing.Size(67, 17);
            this.rd_oneWay.TabIndex = 7;
            this.rd_oneWay.TabStop = true;
            this.rd_oneWay.Text = "One way";
            this.rd_oneWay.UseVisualStyleBackColor = true;
            this.rd_oneWay.CheckedChanged += new System.EventHandler(this.rd_oneWay_CheckedChanged);
            // 
            // rd_return
            // 
            this.rd_return.AutoSize = true;
            this.rd_return.Location = new System.Drawing.Point(98, 79);
            this.rd_return.Name = "rd_return";
            this.rd_return.Size = new System.Drawing.Size(57, 17);
            this.rd_return.TabIndex = 6;
            this.rd_return.TabStop = true;
            this.rd_return.Text = "Return";
            this.rd_return.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Outbound flight details";
            // 
            // cb_out
            // 
            this.cb_out.AutoSize = true;
            this.cb_out.Location = new System.Drawing.Point(576, 184);
            this.cb_out.Name = "cb_out";
            this.cb_out.Size = new System.Drawing.Size(190, 17);
            this.cb_out.TabIndex = 2;
            this.cb_out.Text = "Display three days before and after";
            this.cb_out.UseVisualStyleBackColor = true;
            this.cb_out.CheckedChanged += new System.EventHandler(this.cb_out_CheckedChanged);
            // 
            // dgv_out
            // 
            this.dgv_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_out.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.form,
            this.to,
            this.date,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_out.Location = new System.Drawing.Point(12, 200);
            this.dgv_out.Name = "dgv_out";
            this.dgv_out.Size = new System.Drawing.Size(740, 150);
            this.dgv_out.TabIndex = 3;
            this.dgv_out.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_out_CellClick);
            this.dgv_out.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_out_CellContentClick);
            this.dgv_out.SelectionChanged += new System.EventHandler(this.dgv_out_SelectionChanged);
            // 
            // form
            // 
            this.form.HeaderText = "From";
            this.form.Name = "form";
            // 
            // to
            // 
            this.to.HeaderText = "To";
            this.to.Name = "to";
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Time";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Flight Number(s)";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cabin Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Number of stops";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "scheduleid";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Return flight details";
            // 
            // cb_return
            // 
            this.cb_return.AutoSize = true;
            this.cb_return.Location = new System.Drawing.Point(576, 371);
            this.cb_return.Name = "cb_return";
            this.cb_return.Size = new System.Drawing.Size(190, 17);
            this.cb_return.TabIndex = 5;
            this.cb_return.Text = "Display three days before and after";
            this.cb_return.UseVisualStyleBackColor = true;
            this.cb_return.CheckedChanged += new System.EventHandler(this.cb_return_CheckedChanged);
            // 
            // dgv_return
            // 
            this.dgv_return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_return.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column6});
            this.dgv_return.Location = new System.Drawing.Point(12, 394);
            this.dgv_return.Name = "dgv_return";
            this.dgv_return.Size = new System.Drawing.Size(740, 150);
            this.dgv_return.TabIndex = 6;
            this.dgv_return.SelectionChanged += new System.EventHandler(this.dgv_return_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "From";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "To";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Flight Number(s)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cabin Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Number of stops";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "scheduleid";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Passengers);
            this.groupBox2.Controls.Add(this.btn_book);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(138, 568);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 85);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirm booking for";
            // 
            // txt_Passengers
            // 
            this.txt_Passengers.Location = new System.Drawing.Point(31, 39);
            this.txt_Passengers.Name = "txt_Passengers";
            this.txt_Passengers.Size = new System.Drawing.Size(109, 20);
            this.txt_Passengers.TabIndex = 1;
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(249, 37);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(75, 23);
            this.btn_book.TabIndex = 10;
            this.btn_book.Text = "Book Flight";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(159, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Passengers";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(576, 605);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cb_to
            // 
            this.cb_to.FormattingEnabled = true;
            this.cb_to.Location = new System.Drawing.Point(343, 34);
            this.cb_to.Name = "cb_to";
            this.cb_to.Size = new System.Drawing.Size(121, 21);
            this.cb_to.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "To";
            // 
            // cb_cabinType
            // 
            this.cb_cabinType.FormattingEnabled = true;
            this.cb_cabinType.Location = new System.Drawing.Point(609, 29);
            this.cb_cabinType.Name = "cb_cabinType";
            this.cb_cabinType.Size = new System.Drawing.Size(121, 21);
            this.cb_cabinType.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cabin Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 732);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_return);
            this.Controls.Add(this.cb_return);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_out);
            this.Controls.Add(this.cb_out);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Search for flights";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_return)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.DateTimePicker dateTime_out;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rd_oneWay;
        private System.Windows.Forms.RadioButton rd_return;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_out;
        private System.Windows.Forms.DataGridView dgv_out;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_return;
        private System.Windows.Forms.DataGridView dgv_return;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.DateTimePicker dateTime_return;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Passengers;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cb_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn form;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox cb_cabinType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_to;
        private System.Windows.Forms.Label label2;
    }
}