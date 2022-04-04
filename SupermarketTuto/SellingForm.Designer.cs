namespace SupermarketTuto
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SellingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SellingQuantity = new System.Windows.Forms.TextBox();
            this.SellingPrice = new System.Windows.Forms.TextBox();
            this.SellingProdName = new System.Windows.Forms.TextBox();
            this.BillId = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SearchCb = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SellingDGV = new System.Windows.Forms.DataGridView();
            this.BillsDGV = new System.Windows.Forms.DataGridView();
            this.SellingPanel = new System.Windows.Forms.Panel();
            this.SellsListLabel = new System.Windows.Forms.Label();
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmtLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AddProductbutton = new System.Windows.Forms.Button();
            this.SellerNameLabel = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.logOutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SellingDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).BeginInit();
            this.SellingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(849, 1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(35, 37);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(619, 15);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(46, 21);
            this.DateLabel.TabIndex = 14;
            this.DateLabel.Text = "Date";
            // 
            // SellingLabel
            // 
            this.SellingLabel.AutoSize = true;
            this.SellingLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SellingLabel.Location = new System.Drawing.Point(305, 15);
            this.SellingLabel.Name = "SellingLabel";
            this.SellingLabel.Size = new System.Drawing.Size(91, 32);
            this.SellingLabel.TabIndex = 15;
            this.SellingLabel.Text = "Selling";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Build";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "ProdName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantity";
            // 
            // SellingQuantity
            // 
            this.SellingQuantity.Location = new System.Drawing.Point(103, 221);
            this.SellingQuantity.Name = "SellingQuantity";
            this.SellingQuantity.Size = new System.Drawing.Size(100, 23);
            this.SellingQuantity.TabIndex = 24;
            // 
            // SellingPrice
            // 
            this.SellingPrice.Enabled = false;
            this.SellingPrice.Location = new System.Drawing.Point(103, 178);
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(100, 23);
            this.SellingPrice.TabIndex = 23;
            // 
            // SellingProdName
            // 
            this.SellingProdName.BackColor = System.Drawing.Color.White;
            this.SellingProdName.Enabled = false;
            this.SellingProdName.Location = new System.Drawing.Point(103, 139);
            this.SellingProdName.Name = "SellingProdName";
            this.SellingProdName.Size = new System.Drawing.Size(100, 23);
            this.SellingProdName.TabIndex = 22;
            // 
            // BillId
            // 
            this.BillId.Location = new System.Drawing.Point(103, 94);
            this.BillId.Name = "BillId";
            this.BillId.Size = new System.Drawing.Size(100, 23);
            this.BillId.TabIndex = 21;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(590, 507);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(497, 507);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 27;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(399, 507);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // SearchCb
            // 
            this.SearchCb.FormattingEnabled = true;
            this.SearchCb.Location = new System.Drawing.Point(29, 329);
            this.SearchCb.Name = "SearchCb";
            this.SearchCb.Size = new System.Drawing.Size(107, 23);
            this.SearchCb.TabIndex = 29;
            this.SearchCb.Text = "Select Category";
            this.SearchCb.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(176, 328);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 30;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // SellingDGV
            // 
            this.SellingDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.SellingDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellingDGV.Location = new System.Drawing.Point(29, 358);
            this.SellingDGV.Name = "SellingDGV";
            this.SellingDGV.RowHeadersWidth = 62;
            this.SellingDGV.RowTemplate.Height = 30;
            this.SellingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellingDGV.Size = new System.Drawing.Size(273, 172);
            this.SellingDGV.TabIndex = 31;
            this.SellingDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellingDGV1_CellContentClick);
            // 
            // BillsDGV
            // 
            this.BillsDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.BillsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillsDGV.Location = new System.Drawing.Point(324, 358);
            this.BillsDGV.Name = "BillsDGV";
            this.BillsDGV.RowHeadersWidth = 62;
            this.BillsDGV.RowTemplate.Height = 30;
            this.BillsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillsDGV.Size = new System.Drawing.Size(398, 139);
            this.BillsDGV.TabIndex = 32;
            this.BillsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillsDGV_CellContentClick);
            // 
            // SellingPanel
            // 
            this.SellingPanel.BackColor = System.Drawing.Color.LightGray;
            this.SellingPanel.Controls.Add(this.logOutLabel);
            this.SellingPanel.Controls.Add(this.SellsListLabel);
            this.SellingPanel.Controls.Add(this.OrderDGV);
            this.SellingPanel.Controls.Add(this.AmtLabel);
            this.SellingPanel.Controls.Add(this.AmountLabel);
            this.SellingPanel.Controls.Add(this.AddProductbutton);
            this.SellingPanel.Controls.Add(this.SellerNameLabel);
            this.SellingPanel.Controls.Add(this.SellingLabel);
            this.SellingPanel.Controls.Add(this.DateLabel);
            this.SellingPanel.Controls.Add(this.BillsDGV);
            this.SellingPanel.Controls.Add(this.SellingProdName);
            this.SellingPanel.Controls.Add(this.deleteButton);
            this.SellingPanel.Controls.Add(this.SellingDGV);
            this.SellingPanel.Controls.Add(this.PrintButton);
            this.SellingPanel.Controls.Add(this.addButton);
            this.SellingPanel.Controls.Add(this.label1);
            this.SellingPanel.Controls.Add(this.refreshButton);
            this.SellingPanel.Controls.Add(this.SearchCb);
            this.SellingPanel.Controls.Add(this.label2);
            this.SellingPanel.Controls.Add(this.label3);
            this.SellingPanel.Controls.Add(this.label4);
            this.SellingPanel.Controls.Add(this.BillId);
            this.SellingPanel.Controls.Add(this.SellingPrice);
            this.SellingPanel.Controls.Add(this.SellingQuantity);
            this.SellingPanel.Location = new System.Drawing.Point(37, 44);
            this.SellingPanel.Name = "SellingPanel";
            this.SellingPanel.Size = new System.Drawing.Size(847, 556);
            this.SellingPanel.TabIndex = 33;
            this.SellingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SellingPanel_Paint);
            // 
            // SellsListLabel
            // 
            this.SellsListLabel.AutoSize = true;
            this.SellsListLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SellsListLabel.Location = new System.Drawing.Point(497, 328);
            this.SellsListLabel.Name = "SellsListLabel";
            this.SellsListLabel.Size = new System.Drawing.Size(75, 21);
            this.SellsListLabel.TabIndex = 38;
            this.SellsListLabel.Text = "Sells List";
            // 
            // OrderDGV
            // 
            this.OrderDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.OrderDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProdName,
            this.Price,
            this.Quantity,
            this.Total});
            this.OrderDGV.Location = new System.Drawing.Point(270, 119);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.RowHeadersWidth = 62;
            this.OrderDGV.RowTemplate.Height = 30;
            this.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDGV.Size = new System.Drawing.Size(574, 115);
            this.OrderDGV.TabIndex = 37;
            // 
            // Id
            // 
            this.Id.HeaderText = "SellingId";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 150;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProdName";
            this.ProdName.MinimumWidth = 8;
            this.ProdName.Name = "ProdName";
            this.ProdName.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.Width = 150;
            // 
            // AmtLabel
            // 
            this.AmtLabel.AutoSize = true;
            this.AmtLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmtLabel.Location = new System.Drawing.Point(579, 237);
            this.AmtLabel.Name = "AmtLabel";
            this.AmtLabel.Size = new System.Drawing.Size(27, 21);
            this.AmtLabel.TabIndex = 36;
            this.AmtLabel.Text = "Rs";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountLabel.Location = new System.Drawing.Point(451, 237);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(93, 21);
            this.AmountLabel.TabIndex = 35;
            this.AmountLabel.Text = "Amount Rs";
            // 
            // AddProductbutton
            // 
            this.AddProductbutton.Location = new System.Drawing.Point(82, 276);
            this.AddProductbutton.Name = "AddProductbutton";
            this.AddProductbutton.Size = new System.Drawing.Size(121, 23);
            this.AddProductbutton.TabIndex = 34;
            this.AddProductbutton.Text = "Add Product";
            this.AddProductbutton.UseVisualStyleBackColor = true;
            this.AddProductbutton.Click += new System.EventHandler(this.AddProductbutton_Click);
            // 
            // SellerNameLabel
            // 
            this.SellerNameLabel.AutoSize = true;
            this.SellerNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SellerNameLabel.Location = new System.Drawing.Point(10, 15);
            this.SellerNameLabel.Name = "SellerNameLabel";
            this.SellerNameLabel.Size = new System.Drawing.Size(53, 21);
            this.SellerNameLabel.TabIndex = 33;
            this.SellerNameLabel.Text = "Seller";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // logOutLabel
            // 
            this.logOutLabel.AutoSize = true;
            this.logOutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutLabel.Location = new System.Drawing.Point(777, 0);
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Size = new System.Drawing.Size(70, 21);
            this.logOutLabel.TabIndex = 39;
            this.logOutLabel.Text = "Log Out";
            this.logOutLabel.Click += new System.EventHandler(this.logOutLabel_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(893, 610);
            this.Controls.Add(this.SellingPanel);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.Text = "Selling Form";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellingDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsDGV)).EndInit();
            this.SellingPanel.ResumeLayout(false);
            this.SellingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button exitButton;
        private Label DateLabel;
        private Label SellingLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox SellingQuantity;
        private TextBox SellingPrice;
        private TextBox SellingProdName;
        private TextBox BillId;
        private Button deleteButton;
        private Button PrintButton;
        private Button addButton;
        private ComboBox SearchCb;
        private Button refreshButton;
        private DataGridView SellingDGV;
        private DataGridView BillsDGV;
        private Panel SellingPanel;
        private Label SellerNameLabel;
        private Button AddProductbutton;
        private Label AmountLabel;
        private Label AmtLabel;
        private Label SellsListLabel;
        private DataGridView OrderDGV;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ProdName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label logOutLabel;
    }
}