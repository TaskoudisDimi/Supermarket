namespace SupermarketTuto.Forms
{
    partial class Product
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.ProdDGV = new System.Windows.Forms.DataGridView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.addCatCombobox = new System.Windows.Forms.ComboBox();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.ProdId = new System.Windows.Forms.TextBox();
            this.catComboBox = new System.Windows.Forms.ComboBox();
            this.APIButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalLabel.Location = new System.Drawing.Point(5, 611);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 106;
            this.totalLabel.Text = "Total:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchButton.Location = new System.Drawing.Point(218, 54);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 37);
            this.searchButton.TabIndex = 105;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchTextBox.Location = new System.Drawing.Point(9, 59);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(171, 26);
            this.searchTextBox.TabIndex = 104;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // ProdDGV
            // 
            this.ProdDGV.AllowUserToAddRows = false;
            this.ProdDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV.Location = new System.Drawing.Point(9, 102);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersWidth = 62;
            this.ProdDGV.RowTemplate.Height = 30;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(840, 489);
            this.ProdDGV.TabIndex = 103;
            this.ProdDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.refreshButton.Location = new System.Drawing.Point(734, 59);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(115, 37);
            this.refreshButton.TabIndex = 102;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.categoriesLabel.Location = new System.Drawing.Point(960, 332);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(91, 21);
            this.categoriesLabel.TabIndex = 101;
            this.categoriesLabel.Text = "Categories";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.priceLabel.Location = new System.Drawing.Point(972, 254);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 21);
            this.priceLabel.TabIndex = 100;
            this.priceLabel.Text = "Price";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.quantityLabel.Location = new System.Drawing.Point(965, 185);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(77, 21);
            this.quantityLabel.TabIndex = 99;
            this.quantityLabel.Text = "Quantity";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(965, 117);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 21);
            this.nameLabel.TabIndex = 98;
            this.nameLabel.Text = "Name";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteButton.Location = new System.Drawing.Point(1174, 465);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 40);
            this.deleteButton.TabIndex = 97;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editButton.Location = new System.Drawing.Point(1076, 465);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(64, 40);
            this.editButton.TabIndex = 96;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(986, 465);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 40);
            this.addButton.TabIndex = 95;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.idLabel.Location = new System.Drawing.Point(972, 54);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 21);
            this.idLabel.TabIndex = 94;
            this.idLabel.Text = "ID";
            // 
            // addCatCombobox
            // 
            this.addCatCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addCatCombobox.FormattingEnabled = true;
            this.addCatCombobox.Location = new System.Drawing.Point(1147, 328);
            this.addCatCombobox.Name = "addCatCombobox";
            this.addCatCombobox.Size = new System.Drawing.Size(143, 28);
            this.addCatCombobox.TabIndex = 93;
            this.addCatCombobox.Text = "Select Category";
            // 
            // ProdPrice
            // 
            this.ProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdPrice.Location = new System.Drawing.Point(1147, 252);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(143, 26);
            this.ProdPrice.TabIndex = 92;
            // 
            // ProdQty
            // 
            this.ProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdQty.Location = new System.Drawing.Point(1147, 183);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(143, 26);
            this.ProdQty.TabIndex = 91;
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.Color.White;
            this.ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdName.Location = new System.Drawing.Point(1147, 115);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(143, 26);
            this.ProdName.TabIndex = 90;
            // 
            // ProdId
            // 
            this.ProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdId.Location = new System.Drawing.Point(1147, 54);
            this.ProdId.Name = "ProdId";
            this.ProdId.Size = new System.Drawing.Size(143, 26);
            this.ProdId.TabIndex = 89;
            // 
            // catComboBox
            // 
            this.catComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.catComboBox.FormattingEnabled = true;
            this.catComboBox.Location = new System.Drawing.Point(429, 59);
            this.catComboBox.Name = "catComboBox";
            this.catComboBox.Size = new System.Drawing.Size(143, 28);
            this.catComboBox.TabIndex = 107;
            this.catComboBox.Text = "Select Category";
            this.catComboBox.SelectionChangeCommitted += new System.EventHandler(this.catComboBox_SelectionChangeCommitted);
            // 
            // APIButton
            // 
            this.APIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.APIButton.Location = new System.Drawing.Point(697, 611);
            this.APIButton.Name = "APIButton";
            this.APIButton.Size = new System.Drawing.Size(152, 40);
            this.APIButton.TabIndex = 108;
            this.APIButton.Text = "Load From API";
            this.APIButton.UseVisualStyleBackColor = true;
            this.APIButton.Click += new System.EventHandler(this.APIButton_Click);
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.importButton.Location = new System.Drawing.Point(218, 601);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(68, 30);
            this.importButton.TabIndex = 109;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 693);
            this.ControlBox = false;
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.APIButton);
            this.Controls.Add(this.catComboBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.ProdDGV);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.addCatCombobox);
            this.Controls.Add(this.ProdPrice);
            this.Controls.Add(this.ProdQty);
            this.Controls.Add(this.ProdName);
            this.Controls.Add(this.ProdId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label totalLabel;
        private Button searchButton;
        private TextBox searchTextBox;
        private DataGridView ProdDGV;
        private Button refreshButton;
        private Label categoriesLabel;
        private Label priceLabel;
        private Label quantityLabel;
        private Label nameLabel;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private Label idLabel;
        private ComboBox addCatCombobox;
        private TextBox ProdPrice;
        private TextBox ProdQty;
        private TextBox ProdName;
        private TextBox ProdId;
        private ComboBox catComboBox;
        private Button APIButton;
        private Button importButton;
    }
}