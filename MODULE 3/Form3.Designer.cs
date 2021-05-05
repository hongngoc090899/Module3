namespace MODULE_3
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lable_total_amount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_creditcard = new System.Windows.Forms.RadioButton();
            this.radio_cash = new System.Windows.Forms.RadioButton();
            this.radio_voucher = new System.Windows.Forms.RadioButton();
            this.btn_Issue_tickets = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total amount:";
            // 
            // lable_total_amount
            // 
            this.lable_total_amount.AutoSize = true;
            this.lable_total_amount.Location = new System.Drawing.Point(132, 49);
            this.lable_total_amount.Name = "lable_total_amount";
            this.lable_total_amount.Size = new System.Drawing.Size(13, 13);
            this.lable_total_amount.TabIndex = 1;
            this.lable_total_amount.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paid using:";
            // 
            // radio_creditcard
            // 
            this.radio_creditcard.AutoSize = true;
            this.radio_creditcard.Location = new System.Drawing.Point(114, 112);
            this.radio_creditcard.Name = "radio_creditcard";
            this.radio_creditcard.Size = new System.Drawing.Size(77, 17);
            this.radio_creditcard.TabIndex = 3;
            this.radio_creditcard.TabStop = true;
            this.radio_creditcard.Text = "Credit Card";
            this.radio_creditcard.UseVisualStyleBackColor = true;
            // 
            // radio_cash
            // 
            this.radio_cash.AutoSize = true;
            this.radio_cash.Location = new System.Drawing.Point(114, 147);
            this.radio_cash.Name = "radio_cash";
            this.radio_cash.Size = new System.Drawing.Size(49, 17);
            this.radio_cash.TabIndex = 4;
            this.radio_cash.TabStop = true;
            this.radio_cash.Text = "Cash";
            this.radio_cash.UseVisualStyleBackColor = true;
            // 
            // radio_voucher
            // 
            this.radio_voucher.AutoSize = true;
            this.radio_voucher.Location = new System.Drawing.Point(114, 182);
            this.radio_voucher.Name = "radio_voucher";
            this.radio_voucher.Size = new System.Drawing.Size(65, 17);
            this.radio_voucher.TabIndex = 5;
            this.radio_voucher.TabStop = true;
            this.radio_voucher.Text = "Voucher";
            this.radio_voucher.UseVisualStyleBackColor = true;
            // 
            // btn_Issue_tickets
            // 
            this.btn_Issue_tickets.Location = new System.Drawing.Point(59, 251);
            this.btn_Issue_tickets.Name = "btn_Issue_tickets";
            this.btn_Issue_tickets.Size = new System.Drawing.Size(104, 38);
            this.btn_Issue_tickets.TabIndex = 6;
            this.btn_Issue_tickets.Text = "Issue tickets";
            this.btn_Issue_tickets.UseVisualStyleBackColor = true;
            this.btn_Issue_tickets.Click += new System.EventHandler(this.btn_Issue_tickets_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(208, 251);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 37);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 331);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Issue_tickets);
            this.Controls.Add(this.radio_voucher);
            this.Controls.Add(this.radio_cash);
            this.Controls.Add(this.radio_creditcard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lable_total_amount);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Billing Confirmation";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable_total_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_creditcard;
        private System.Windows.Forms.RadioButton radio_cash;
        private System.Windows.Forms.RadioButton radio_voucher;
        private System.Windows.Forms.Button btn_Issue_tickets;
        private System.Windows.Forms.Button btn_Cancel;
    }
}