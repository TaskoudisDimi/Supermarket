namespace SupermarketTuto
{
    partial class ProductsForm
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
            this.manageProductsPanel = new System.Windows.Forms.Panel();
            this.ProdDGV = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.selectCategory2ComboBox = new System.Windows.Forms.ComboBox();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.ProdId = new System.Windows.Forms.TextBox();
            this.manageProductsLabel = new System.Windows.Forms.Label();
            this.sellerButton = new System.Windows.Forms.Button();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.sellingButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.manageProductsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // manageProductsPanel
            // 
            this.manageProductsPanel.BackColor = System.Drawing.Color.LightGray;
            this.manageProductsPanel.Controls.Add(this.ProdDGV);
            this.manageProductsPanel.Controls.Add(this.refreshButton);
            this.manageProductsPanel.Controls.Add(this.selectCategory2ComboBox);
            this.manageProductsPanel.Controls.Add(this.categoriesLabel);
            this.manageProductsPanel.Controls.Add(this.priceLabel);
            this.manageProductsPanel.Controls.Add(this.quantityLabel);
            this.manageProductsPanel.Controls.Add(this.nameLabel);
            this.manageProductsPanel.Controls.Add(this.deleteButton);
            this.manageProductsPanel.Controls.Add(this.editButton);
            this.manageProductsPanel.Controls.Add(this.addButton);
            this.manageProductsPanel.Controls.Add(this.idLabel);
            this.manageProductsPanel.Controls.Add(this.CatCb);
            this.manageProductsPanel.Controls.Add(this.ProdPrice);
            this.manageProductsPanel.Controls.Add(this.ProdQty);
            this.manageProductsPanel.Controls.Add(this.ProdName);
            this.manageProductsPanel.Controls.Add(this.ProdId);
            this.manageProductsPanel.Controls.Add(this.manageProductsLabel);
            this.manageProductsPanel.Location = new System.Drawing.Point(134, 42);
            this.manageProductsPanel.Name = "manageProductsPanel";
            this.manageProductsPanel.Size = new System.Drawing.Size(918, 571);
            this.manageProductsPanel.TabIndex = 0;
            // 
            // ProdDGV
            // 
            this.ProdDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV.Location = new System.Drawing.Point(333, 89);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersWidth = 62;
            this.ProdDGV.RowTemplate.Height = 30;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(456, 479);
            this.ProdDGV.TabIndex = 17;
            this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(714, 41);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 16;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // selectCategory2ComboBox
            // 
            this.selectCategory2ComboBox.FormattingEnabled = true;
            this.selectCategory2ComboBox.Location = new System.Drawing.Point(575, 42);
            this.selectCategory2ComboBox.Name = "selectCategory2ComboBox";
            this.selectCategory2ComboBox.Size = new System.Drawing.Size(107, 23);
            this.selectCategory2ComboBox.TabIndex = 15;
            this.selectCategory2ComboBox.Text = "Select Category";
            this.selectCategory2ComboBox.SelectedIndexChanged += new System.EventHandler(this.selectCategory2ComboBox_SelectedIndexChanged);
            this.selectCategory2ComboBox.SelectionChangeCommitted += new System.EventHandler(this.selectCategory2ComboBox_SelectionChangeCommitted);
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoriesLabel.Location = new System.Drawing.Point(12, 278);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(91, 21);
            this.categoriesLabel.TabIndex = 13;
            this.categoriesLabel.Text = "Categories";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(12, 228);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 21);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Price";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(12, 183);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(77, 21);
            this.quantityLabel.TabIndex = 11;
            this.quantityLabel.Text = "Quantity";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(12, 142);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 21);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(252, 365);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(138, 365);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(33, 365);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(12, 101);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 21);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = "ID";
            // 
            // CatCb
            // 
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Location = new System.Drawing.Point(206, 276);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(107, 23);
            this.CatCb.TabIndex = 5;
            this.CatCb.Text = "Select Category";
            this.CatCb.SelectedIndexChanged += new System.EventHandler(this.CatCb_SelectedIndexChanged);
            this.CatCb.SelectionChangeCommitted += new System.EventHandler(this.CatCb_SelectionChangeCommitted);
            // 
            // ProdPrice
            // 
            this.ProdPrice.Location = new System.Drawing.Point(203, 226);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(100, 23);
            this.ProdPrice.TabIndex = 4;
            // 
            // ProdQty
            // 
            this.ProdQty.Location = new System.Drawing.Point(203, 183);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(100, 23);
            this.ProdQty.TabIndex = 3;
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.Color.White;
            this.ProdName.Location = new System.Drawing.Point(203, 144);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(100, 23);
            this.ProdName.TabIndex = 2;
            // 
            // ProdId
            // 
            this.ProdId.Location = new System.Drawing.Point(203, 99);
            this.ProdId.Name = "ProdId";
            this.ProdId.Size = new System.Drawing.Size(100, 23);
            this.ProdId.TabIndex = 1;
            // 
            // manageProductsLabel
            // 
            this.manageProductsLabel.AutoSize = true;
            this.manageProductsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageProductsLabel.Location = new System.Drawing.Point(348, 9);
            this.manageProductsLabel.Name = "manageProductsLabel";
            this.manageProductsLabel.Size = new System.Drawing.Size(215, 32);
            this.manageProductsLabel.TabIndex = 0;
            this.manageProductsLabel.Text = "Manage Products";
            // 
            // sellerButton
            // 
            this.sellerButton.FlatAppearance.BorderSize = 0;
            this.sellerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellerButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellerButton.Location = new System.Drawing.Point(12, 84);
            this.sellerButton.Name = "sellerButton";
            this.sellerButton.Size = new System.Drawing.Size(93, 53);
            this.sellerButton.TabIndex = 1;
            this.sellerButton.Text = "Seller";
            this.sellerButton.UseVisualStyleBackColor = true;
            this.sellerButton.Click += new System.EventHandler(this.sellerButton_Click);
            // 
            // categoriesButton
            // 
            this.categoriesButton.FlatAppearance.BorderSize = 0;
            this.categoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoriesButton.Location = new System.Drawing.Point(2, 156);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(127, 53);
            this.categoriesButton.TabIndex = 2;
            this.categoriesButton.Text = "Categories";
            this.categoriesButton.UseVisualStyleBackColor = true;
            this.categoriesButton.Click += new System.EventHandler(this.categoriesButton_Click);
            // 
            // sellingButton
            // 
            this.sellingButton.FlatAppearance.BorderSize = 0;
            this.sellingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellingButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellingButton.Location = new System.Drawing.Point(2, 225);
            this.sellingButton.Name = "sellingButton";
            this.sellingButton.Size = new System.Drawing.Size(117, 53);
            this.sellingButton.TabIndex = 3;
            this.sellingButton.Text = "Selling";
            this.sellingButton.UseVisualStyleBackColor = true;
            this.sellingButton.Click += new System.EventHandler(this.sellingButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(1016, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(47, 33);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 635);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sellingButton);
            this.Controls.Add(this.categoriesButton);
            this.Controls.Add(this.sellerButton);
            this.Controls.Add(this.manageProductsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.manageProductsPanel.ResumeLayout(false);
            this.manageProductsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel manageProductsPanel;
        private Button sellerButton;
        private Button categoriesButton;
        private Button sellingButton;
        private Button exitButton;
        private Label manageProductsLabel;
        private TextBox ProdPrice;
        private TextBox ProdQty;
        private TextBox ProdName;
        private TextBox ProdId;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private Label idLabel;
        private ComboBox CatCb;
        private Label nameLabel;
        private Label quantityLabel;
        private Label priceLabel;
        private Label categoriesLabel;
        private Button refreshButton;
        private ComboBox selectCategory2ComboBox;
        private DataGridView ProdDGV;
    }
}