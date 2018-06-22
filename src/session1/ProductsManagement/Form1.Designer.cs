namespace ProductsManagement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.productTypesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeAllToolStripMenuItem,
            this.createToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.productsToolStripMenuItem.Text = "Posts";
            // 
            // seeAllToolStripMenuItem
            // 
            this.seeAllToolStripMenuItem.Name = "seeAllToolStripMenuItem";
            this.seeAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seeAllToolStripMenuItem.Text = "See all";
            this.seeAllToolStripMenuItem.Click += new System.EventHandler(this.seeAllToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // productTypesToolStripMenuItem
            // 
            this.productTypesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeAllToolStripMenuItem1,
            this.createToolStripMenuItem1});
            this.productTypesToolStripMenuItem.Name = "productTypesToolStripMenuItem";
            this.productTypesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.productTypesToolStripMenuItem.Text = "Comments";
            // 
            // seeAllToolStripMenuItem1
            // 
            this.seeAllToolStripMenuItem1.Name = "seeAllToolStripMenuItem1";
            this.seeAllToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.seeAllToolStripMenuItem1.Text = "See all";
            this.seeAllToolStripMenuItem1.Click += new System.EventHandler(this.seeAllToolStripMenuItem1_Click);
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem1.Text = "Create";
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(13, 28);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.Size = new System.Drawing.Size(775, 410);
            this.MainGrid.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.DataGridView MainGrid;
    }
}

