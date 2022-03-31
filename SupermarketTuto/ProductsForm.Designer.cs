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
            this.refreshButton = new System.Windows.Forms.Button();
            this.selectCategory2ComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.manageProductsLabel = new System.Windows.Forms.Label();
            this.sellerButton = new System.Windows.Forms.Button();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.sellingButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.manageProductsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // manageProductsPanel
            // 
            this.manageProductsPanel.BackColor = System.Drawing.Color.LightGray;
            this.manageProductsPanel.Controls.Add(this.refreshButton);
            this.manageProductsPanel.Controls.Add(this.selectCategory2ComboBox);
            this.manageProductsPanel.Controls.Add(this.dataGridView1);
            this.manageProductsPanel.Controls.Add(this.categoriesLabel);
            this.manageProductsPanel.Controls.Add(this.priceLabel);
            this.manageProductsPanel.Controls.Add(this.quantityLabel);
            this.manageProductsPanel.Controls.Add(this.nameLabel);
            this.manageProductsPanel.Controls.Add(this.deleteButton);
            this.manageProductsPanel.Controls.Add(this.editButton);
            this.manageProductsPanel.Controls.Add(this.addButton);
            this.manageProductsPanel.Controls.Add(this.idLabel);
            this.manageProductsPanel.Controls.Add(this.CatCb);
            this.manageProductsPanel.Controls.Add(this.priceTextBox);
            this.manageProductsPanel.Controls.Add(this.quantityTextBox);
            this.manageProductsPanel.Controls.Add(this.nameTextBox);
            this.manageProductsPanel.Controls.Add(this.idTextBox);
            this.manageProductsPanel.Controls.Add(this.manageProductsLabel);
            this.manageProductsPanel.Location = new System.Drawing.Point(125, 42);
            this.manageProductsPanel.Name = "manageProductsPanel";
            this.manageProductsPanel.Size = new System.Drawing.Size(927, 571);
            this.manageProductsPanel.TabIndex = 0;
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(333, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(591, 499);
            this.dataGridView1.TabIndex = 14;
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoriesLabel.Location = new System.Drawing.Point(20, 278);
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
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(138, 365);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(33, 365);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
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
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(203, 226);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 23);
            this.priceTextBox.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(203, 183);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 23);
            this.quantityTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(203, 144);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 23);
            this.nameTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(203, 99);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 23);
            this.idTextBox.TabIndex = 1;
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
            // 
            // categoriesButton
            // 
            this.categoriesButton.FlatAppearance.BorderSize = 0;
            this.categoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoriesButton.Location = new System.Drawing.Point(2, 156);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(117, 53);
            this.categoriesButton.TabIndex = 2;
            this.categoriesButton.Text = "Categories";
            this.categoriesButton.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel manageProductsPanel;
        private Button sellerButton;
        private Button categoriesButton;
        private Button sellingButton;
        private Button exitButton;
        private Label manageProductsLabel;
        private TextBox priceTextBox;
        private TextBox quantityTextBox;
        private TextBox nameTextBox;
        private TextBox idTextBox;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private Label idLabel;
        private ComboBox CatCb;
        private Label nameLabel;
        private Label quantityLabel;
        private Label priceLabel;
        private Label categoriesLabel;
        private DataGridView dataGridView1;
        private Button refreshButton;
        private ComboBox selectCategory2ComboBox;
    }
}