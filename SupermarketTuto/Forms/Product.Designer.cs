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
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.ProdId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(841, 225);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(181, 35);
            this.toDateTimePicker.TabIndex = 108;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(611, 225);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(181, 35);
            this.fromDateTimePicker.TabIndex = 107;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalLabel.Location = new System.Drawing.Point(13, 1100);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(74, 29);
            this.totalLabel.TabIndex = 106;
            this.totalLabel.Text = "Total:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchButton.Location = new System.Drawing.Point(333, 224);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(155, 36);
            this.searchButton.TabIndex = 105;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchTextBox.Location = new System.Drawing.Point(18, 224);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(255, 35);
            this.searchTextBox.TabIndex = 104;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // ProdDGV
            // 
            this.ProdDGV.AllowUserToAddRows = false;
            this.ProdDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV.Location = new System.Drawing.Point(13, 314);
            this.ProdDGV.Margin = new System.Windows.Forms.Padding(4);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersWidth = 62;
            this.ProdDGV.RowTemplate.Height = 30;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(1525, 752);
            this.ProdDGV.TabIndex = 103;
            this.ProdDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.refreshButton.Location = new System.Drawing.Point(1397, 225);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(122, 40);
            this.refreshButton.TabIndex = 102;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.categoriesLabel.Location = new System.Drawing.Point(1659, 764);
            this.categoriesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(135, 32);
            this.categoriesLabel.TabIndex = 101;
            this.categoriesLabel.Text = "Categories";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.priceLabel.Location = new System.Drawing.Point(1677, 645);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(71, 32);
            this.priceLabel.TabIndex = 100;
            this.priceLabel.Text = "Price";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.quantityLabel.Location = new System.Drawing.Point(1667, 538);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(113, 32);
            this.quantityLabel.TabIndex = 99;
            this.quantityLabel.Text = "Quantity";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(1667, 434);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(81, 32);
            this.nameLabel.TabIndex = 98;
            this.nameLabel.Text = "Name";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteButton.Location = new System.Drawing.Point(1980, 969);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 36);
            this.deleteButton.TabIndex = 97;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editButton.Location = new System.Drawing.Point(1833, 969);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(96, 36);
            this.editButton.TabIndex = 96;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(1698, 969);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 36);
            this.addButton.TabIndex = 95;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.idLabel.Location = new System.Drawing.Point(1677, 337);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(40, 32);
            this.idLabel.TabIndex = 94;
            this.idLabel.Text = "ID";
            // 
            // CatCb
            // 
            this.CatCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Location = new System.Drawing.Point(1939, 759);
            this.CatCb.Margin = new System.Windows.Forms.Padding(4);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(212, 37);
            this.CatCb.TabIndex = 93;
            this.CatCb.Text = "Select Category";
            // 
            // ProdPrice
            // 
            this.ProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdPrice.Location = new System.Drawing.Point(1939, 642);
            this.ProdPrice.Margin = new System.Windows.Forms.Padding(4);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(212, 35);
            this.ProdPrice.TabIndex = 92;
            // 
            // ProdQty
            // 
            this.ProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdQty.Location = new System.Drawing.Point(1939, 535);
            this.ProdQty.Margin = new System.Windows.Forms.Padding(4);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(212, 35);
            this.ProdQty.TabIndex = 91;
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.Color.White;
            this.ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdName.Location = new System.Drawing.Point(1939, 431);
            this.ProdName.Margin = new System.Windows.Forms.Padding(4);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(212, 35);
            this.ProdName.TabIndex = 90;
            // 
            // ProdId
            // 
            this.ProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdId.Location = new System.Drawing.Point(1939, 337);
            this.ProdId.Margin = new System.Windows.Forms.Padding(4);
            this.ProdId.Name = "ProdId";
            this.ProdId.Size = new System.Drawing.Size(212, 35);
            this.ProdId.TabIndex = 89;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2330, 1185);
            this.ControlBox = false;
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
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
            this.Controls.Add(this.CatCb);
            this.Controls.Add(this.ProdPrice);
            this.Controls.Add(this.ProdQty);
            this.Controls.Add(this.ProdName);
            this.Controls.Add(this.ProdId);
            this.Name = "Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
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
        private ComboBox CatCb;
        private TextBox ProdPrice;
        private TextBox ProdQty;
        private TextBox ProdName;
        private TextBox ProdId;
    }
}