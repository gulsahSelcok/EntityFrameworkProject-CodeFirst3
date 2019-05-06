namespace CodeFirst3_Invoice
{
    partial class FormUnit
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
            this.btnMultipleDelete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewUnit = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbUnitName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMultipleDelete
            // 
            this.btnMultipleDelete.Location = new System.Drawing.Point(435, 99);
            this.btnMultipleDelete.Name = "btnMultipleDelete";
            this.btnMultipleDelete.Size = new System.Drawing.Size(128, 23);
            this.btnMultipleDelete.TabIndex = 17;
            this.btnMultipleDelete.Text = "MULTIPLE DELETE";
            this.btnMultipleDelete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(435, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(291, 97);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUnit
            // 
            this.dataGridViewUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnit.Location = new System.Drawing.Point(57, 167);
            this.dataGridViewUnit.Name = "dataGridViewUnit";
            this.dataGridViewUnit.Size = new System.Drawing.Size(524, 192);
            this.dataGridViewUnit.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(291, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "INSERT";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbUnitName
            // 
            this.tbUnitName.Location = new System.Drawing.Point(57, 83);
            this.tbUnitName.Multiline = true;
            this.tbUnitName.Name = "tbUnitName";
            this.tbUnitName.Size = new System.Drawing.Size(178, 36);
            this.tbUnitName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Unit Name";
            // 
            // FormUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.btnMultipleDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridViewUnit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbUnitName);
            this.Controls.Add(this.label1);
            this.Name = "FormUnit";
            this.Text = "FormUnit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMultipleDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewUnit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbUnitName;
        private System.Windows.Forms.Label label1;
    }
}