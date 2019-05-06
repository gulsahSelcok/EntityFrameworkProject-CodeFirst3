namespace CodeFirst3_Invoice
{
    partial class FormInvoiceView
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
            this.btnClean = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCustomerCounty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCustomerCity = new System.Windows.Forms.ComboBox();
            this.tbInvoiceID = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(494, 190);
            this.btnClean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(325, 52);
            this.btnClean.TabIndex = 10;
            this.btnClean.Text = "Temizle";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Müşteri";
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(247, 128);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(180, 28);
            this.cbCustomer.TabIndex = 7;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Müşteri İlçe";
            // 
            // cbCustomerCounty
            // 
            this.cbCustomerCounty.FormattingEnabled = true;
            this.cbCustomerCounty.Location = new System.Drawing.Point(611, 127);
            this.cbCustomerCounty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCustomerCounty.Name = "cbCustomerCounty";
            this.cbCustomerCounty.Size = new System.Drawing.Size(180, 28);
            this.cbCustomerCounty.TabIndex = 5;
            this.cbCustomerCounty.SelectedIndexChanged += new System.EventHandler(this.cbCustomerCounty_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri İl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fatura ID";
            // 
            // cbCustomerCity
            // 
            this.cbCustomerCity.FormattingEnabled = true;
            this.cbCustomerCity.Location = new System.Drawing.Point(611, 63);
            this.cbCustomerCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCustomerCity.Name = "cbCustomerCity";
            this.cbCustomerCity.Size = new System.Drawing.Size(180, 28);
            this.cbCustomerCity.TabIndex = 3;
            this.cbCustomerCity.SelectedIndexChanged += new System.EventHandler(this.cbCustomerCity_SelectedIndexChanged);
            // 
            // tbInvoiceID
            // 
            this.tbInvoiceID.Location = new System.Drawing.Point(247, 67);
            this.tbInvoiceID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbInvoiceID.Name = "tbInvoiceID";
            this.tbInvoiceID.Size = new System.Drawing.Size(180, 26);
            this.tbInvoiceID.TabIndex = 1;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(125, 190);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(325, 52);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Location = new System.Drawing.Point(42, 274);
            this.dgvInvoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.Size = new System.Drawing.Size(854, 317);
            this.dgvInvoice.TabIndex = 0;
            this.dgvInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoice_CellClick);
            // 
            // FormInvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 632);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCustomerCounty);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInvoiceID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCustomerCity);
            this.Name = "FormInvoiceView";
            this.Text = "FormInvoiceView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCustomerCounty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCustomerCity;
        private System.Windows.Forms.TextBox tbInvoiceID;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dgvInvoice;
    }
}