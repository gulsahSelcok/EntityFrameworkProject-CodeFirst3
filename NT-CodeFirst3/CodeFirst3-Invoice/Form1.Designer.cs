namespace CodeFirst3_Invoice
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.supportTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customeDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countyDefinitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvoiceTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvoiceViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportTablesToolStripMenuItem,
            this.ınvoiceTransactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // supportTablesToolStripMenuItem
            // 
            this.supportTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customeDefinitionsToolStripMenuItem,
            this.unitDefinitionsToolStripMenuItem,
            this.productDefinitionsToolStripMenuItem,
            this.cityDefinitionsToolStripMenuItem,
            this.countyDefinitionsToolStripMenuItem});
            this.supportTablesToolStripMenuItem.Name = "supportTablesToolStripMenuItem";
            this.supportTablesToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.supportTablesToolStripMenuItem.Text = "Support Tables";
            // 
            // customeDefinitionsToolStripMenuItem
            // 
            this.customeDefinitionsToolStripMenuItem.Name = "customeDefinitionsToolStripMenuItem";
            this.customeDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.customeDefinitionsToolStripMenuItem.Text = "Customer Definitions";
            this.customeDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.customeDefinitionsToolStripMenuItem_Click);
            // 
            // unitDefinitionsToolStripMenuItem
            // 
            this.unitDefinitionsToolStripMenuItem.Name = "unitDefinitionsToolStripMenuItem";
            this.unitDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.unitDefinitionsToolStripMenuItem.Text = "Unit Definitions";
            this.unitDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.unitDefinitionsToolStripMenuItem_Click);
            // 
            // productDefinitionsToolStripMenuItem
            // 
            this.productDefinitionsToolStripMenuItem.Name = "productDefinitionsToolStripMenuItem";
            this.productDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.productDefinitionsToolStripMenuItem.Text = "Product Definitions";
            this.productDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.productDefinitionsToolStripMenuItem_Click);
            // 
            // cityDefinitionsToolStripMenuItem
            // 
            this.cityDefinitionsToolStripMenuItem.Name = "cityDefinitionsToolStripMenuItem";
            this.cityDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cityDefinitionsToolStripMenuItem.Text = "City Definitions";
            this.cityDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.cityDefinitionsToolStripMenuItem_Click);
            // 
            // countyDefinitionsToolStripMenuItem
            // 
            this.countyDefinitionsToolStripMenuItem.Name = "countyDefinitionsToolStripMenuItem";
            this.countyDefinitionsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.countyDefinitionsToolStripMenuItem.Text = "County Definitions";
            this.countyDefinitionsToolStripMenuItem.Click += new System.EventHandler(this.countyDefinitionsToolStripMenuItem_Click);
            // 
            // ınvoiceTransactionsToolStripMenuItem
            // 
            this.ınvoiceTransactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ınvoiceViewToolStripMenuItem,
            this.createNewInvoiceToolStripMenuItem});
            this.ınvoiceTransactionsToolStripMenuItem.Name = "ınvoiceTransactionsToolStripMenuItem";
            this.ınvoiceTransactionsToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.ınvoiceTransactionsToolStripMenuItem.Text = "Invoice Transactions";
            // 
            // ınvoiceViewToolStripMenuItem
            // 
            this.ınvoiceViewToolStripMenuItem.Name = "ınvoiceViewToolStripMenuItem";
            this.ınvoiceViewToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ınvoiceViewToolStripMenuItem.Text = "Invoice View";
            // 
            // createNewInvoiceToolStripMenuItem
            // 
            this.createNewInvoiceToolStripMenuItem.Name = "createNewInvoiceToolStripMenuItem";
            this.createNewInvoiceToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.createNewInvoiceToolStripMenuItem.Text = "Create New Invoice";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supportTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customeDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countyDefinitionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvoiceTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvoiceViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewInvoiceToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

