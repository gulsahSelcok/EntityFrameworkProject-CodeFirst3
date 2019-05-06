namespace CodeFirst3_Invoice
{
    partial class FormCounty
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbCountyName = new System.Windows.Forms.TextBox();
            this.cbCityName = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewCounty = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMultipleDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCounty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "County Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "City Name";
            // 
            // tbCountyName
            // 
            this.tbCountyName.Location = new System.Drawing.Point(136, 62);
            this.tbCountyName.Name = "tbCountyName";
            this.tbCountyName.Size = new System.Drawing.Size(121, 20);
            this.tbCountyName.TabIndex = 2;
            // 
            // cbCityName
            // 
            this.cbCityName.FormattingEnabled = true;
            this.cbCityName.Location = new System.Drawing.Point(136, 106);
            this.cbCityName.Name = "cbCityName";
            this.cbCityName.Size = new System.Drawing.Size(121, 21);
            this.cbCityName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(279, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "INSERT";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewCounty
            // 
            this.dataGridViewCounty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCounty.Location = new System.Drawing.Point(54, 174);
            this.dataGridViewCounty.Name = "dataGridViewCounty";
            this.dataGridViewCounty.Size = new System.Drawing.Size(524, 192);
            this.dataGridViewCounty.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(279, 104);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(432, 59);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnMultipleDelete
            // 
            this.btnMultipleDelete.Location = new System.Drawing.Point(432, 106);
            this.btnMultipleDelete.Name = "btnMultipleDelete";
            this.btnMultipleDelete.Size = new System.Drawing.Size(128, 23);
            this.btnMultipleDelete.TabIndex = 8;
            this.btnMultipleDelete.Text = "MULTIPLE DELETE";
            this.btnMultipleDelete.UseVisualStyleBackColor = true;
            // 
            // FormCounty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.btnMultipleDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridViewCounty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCityName);
            this.Controls.Add(this.tbCountyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCounty";
            this.Text = "FormCounty";
            this.Load += new System.EventHandler(this.FormCounty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCounty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCountyName;
        private System.Windows.Forms.ComboBox cbCityName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewCounty;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMultipleDelete;
    }
}