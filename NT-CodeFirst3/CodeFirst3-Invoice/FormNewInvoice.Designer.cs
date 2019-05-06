namespace CodeFirst3_Invoice
{
    partial class FormNewInvoice
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
            this.dgvNewInvoice = new System.Windows.Forms.DataGridView();
            this.btnListClear = new System.Windows.Forms.Button();
            this.btnInvoiceAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.tbProductTax = new System.Windows.Forms.TextBox();
            this.tbProductUnit = new System.Windows.Forms.TextBox();
            this.cbProductName = new System.Windows.Forms.ComboBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.tbWaybillNumber = new System.Windows.Forms.TextBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbCustomerCounty = new System.Windows.Forms.ComboBox();
            this.cbCustomerCity = new System.Windows.Forms.ComboBox();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewInvoice)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNewInvoice
            // 
            this.dgvNewInvoice.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvNewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewInvoice.Location = new System.Drawing.Point(33, 338);
            this.dgvNewInvoice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvNewInvoice.Name = "dgvNewInvoice";
            this.dgvNewInvoice.Size = new System.Drawing.Size(1302, 296);
            this.dgvNewInvoice.TabIndex = 7;
            this.dgvNewInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewInvoice_CellClick);
            // 
            // btnListClear
            // 
            this.btnListClear.Location = new System.Drawing.Point(1138, 182);
            this.btnListClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListClear.Name = "btnListClear";
            this.btnListClear.Size = new System.Drawing.Size(188, 72);
            this.btnListClear.TabIndex = 5;
            this.btnListClear.Text = "Liste Temizle";
            this.btnListClear.UseVisualStyleBackColor = true;
            this.btnListClear.Click += new System.EventHandler(this.btnListClear_Click);
            // 
            // btnInvoiceAdd
            // 
            this.btnInvoiceAdd.Location = new System.Drawing.Point(1138, 86);
            this.btnInvoiceAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInvoiceAdd.Name = "btnInvoiceAdd";
            this.btnInvoiceAdd.Size = new System.Drawing.Size(188, 72);
            this.btnInvoiceAdd.TabIndex = 6;
            this.btnInvoiceAdd.Text = "Fatura Kaydet";
            this.btnInvoiceAdd.UseVisualStyleBackColor = true;
            this.btnInvoiceAdd.Click += new System.EventHandler(this.btnInvoiceAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudProductQuantity);
            this.groupBox2.Controls.Add(this.tbProductPrice);
            this.groupBox2.Controls.Add(this.tbProductTax);
            this.groupBox2.Controls.Add(this.tbProductUnit);
            this.groupBox2.Controls.Add(this.cbProductName);
            this.groupBox2.Controls.Add(this.btnProductAdd);
            this.groupBox2.Controls.Add(this.btnProductDelete);
            this.groupBox2.Controls.Add(this.btnProductUpdate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(596, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(512, 291);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // nudProductQuantity
            // 
            this.nudProductQuantity.Location = new System.Drawing.Point(222, 194);
            this.nudProductQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudProductQuantity.Name = "nudProductQuantity";
            this.nudProductQuantity.Size = new System.Drawing.Size(237, 26);
            this.nudProductQuantity.TabIndex = 4;
            this.nudProductQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Enabled = false;
            this.tbProductPrice.Location = new System.Drawing.Point(222, 72);
            this.tbProductPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(237, 26);
            this.tbProductPrice.TabIndex = 3;
            // 
            // tbProductTax
            // 
            this.tbProductTax.Location = new System.Drawing.Point(222, 150);
            this.tbProductTax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbProductTax.Name = "tbProductTax";
            this.tbProductTax.Size = new System.Drawing.Size(237, 26);
            this.tbProductTax.TabIndex = 3;
            // 
            // tbProductUnit
            // 
            this.tbProductUnit.Enabled = false;
            this.tbProductUnit.Location = new System.Drawing.Point(222, 112);
            this.tbProductUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbProductUnit.Name = "tbProductUnit";
            this.tbProductUnit.Size = new System.Drawing.Size(237, 26);
            this.tbProductUnit.TabIndex = 3;
            // 
            // cbProductName
            // 
            this.cbProductName.FormattingEnabled = true;
            this.cbProductName.Location = new System.Drawing.Point(222, 29);
            this.cbProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(237, 28);
            this.cbProductName.TabIndex = 2;
            this.cbProductName.SelectedIndexChanged += new System.EventHandler(this.cbProductName_SelectedIndexChanged);
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(357, 234);
            this.btnProductAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(132, 35);
            this.btnProductAdd.TabIndex = 1;
            this.btnProductAdd.Text = "Ürün Ekle";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(26, 234);
            this.btnProductDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(132, 35);
            this.btnProductDelete.TabIndex = 1;
            this.btnProductDelete.Text = "Ürün Sil";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(193, 234);
            this.btnProductUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(132, 35);
            this.btnProductUpdate.TabIndex = 1;
            this.btnProductUpdate.Text = "Ürün Güncelle";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 194);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ürün Miktarı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ürün Birimi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ürün Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ürün Fiyatı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ürün KDV:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpPaymentDate);
            this.groupBox1.Controls.Add(this.tbWaybillNumber);
            this.groupBox1.Controls.Add(this.cbCustomer);
            this.groupBox1.Controls.Add(this.cbCustomerCounty);
            this.groupBox1.Controls.Add(this.cbCustomerCity);
            this.groupBox1.Controls.Add(this.lblInvoiceID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(518, 291);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri ve İrsaliye";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(225, 239);
            this.dtpPaymentDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(234, 26);
            this.dtpPaymentDate.TabIndex = 4;
            // 
            // tbWaybillNumber
            // 
            this.tbWaybillNumber.Location = new System.Drawing.Point(225, 201);
            this.tbWaybillNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWaybillNumber.Name = "tbWaybillNumber";
            this.tbWaybillNumber.Size = new System.Drawing.Size(234, 26);
            this.tbWaybillNumber.TabIndex = 3;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(225, 154);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(234, 28);
            this.cbCustomer.TabIndex = 2;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // cbCustomerCounty
            // 
            this.cbCustomerCounty.FormattingEnabled = true;
            this.cbCustomerCounty.Location = new System.Drawing.Point(225, 116);
            this.cbCustomerCounty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCustomerCounty.Name = "cbCustomerCounty";
            this.cbCustomerCounty.Size = new System.Drawing.Size(234, 28);
            this.cbCustomerCounty.TabIndex = 2;
            // 
            // cbCustomerCity
            // 
            this.cbCustomerCity.FormattingEnabled = true;
            this.cbCustomerCity.Location = new System.Drawing.Point(225, 72);
            this.cbCustomerCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCustomerCity.Name = "cbCustomerCity";
            this.cbCustomerCity.Size = new System.Drawing.Size(234, 28);
            this.cbCustomerCity.TabIndex = 2;
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Location = new System.Drawing.Point(221, 39);
            this.lblInvoiceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(18, 20);
            this.lblInvoiceID.TabIndex = 1;
            this.lblInvoiceID.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ödeme Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Müşteri İlçesi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "İrsaliye No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Müşteri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Şehri:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura No:";
            // 
            // FormNewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 799);
            this.Controls.Add(this.dgvNewInvoice);
            this.Controls.Add(this.btnListClear);
            this.Controls.Add(this.btnInvoiceAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNewInvoice";
            this.Text = "FormNewInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewInvoice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNewInvoice;
        private System.Windows.Forms.Button btnListClear;
        private System.Windows.Forms.Button btnInvoiceAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudProductQuantity;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductTax;
        private System.Windows.Forms.TextBox tbProductUnit;
        private System.Windows.Forms.ComboBox cbProductName;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.TextBox tbWaybillNumber;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbCustomerCounty;
        private System.Windows.Forms.ComboBox cbCustomerCity;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}