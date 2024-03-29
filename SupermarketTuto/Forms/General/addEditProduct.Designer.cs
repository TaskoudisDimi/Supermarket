﻿namespace SupermarketTuto.Forms.General
{
    partial class addEditProduct
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
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.catCombobox = new System.Windows.Forms.ComboBox();
            this.ProdPrice = new System.Windows.Forms.TextBox();
            this.ProdQty = new System.Windows.Forms.TextBox();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.ProdId = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.categoryID = new System.Windows.Forms.Label();
            this.catIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.categoriesLabel.Location = new System.Drawing.Point(71, 427);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(91, 21);
            this.categoriesLabel.TabIndex = 111;
            this.categoriesLabel.Text = "Categories";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.priceLabel.Location = new System.Drawing.Point(71, 238);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(48, 21);
            this.priceLabel.TabIndex = 110;
            this.priceLabel.Text = "Price";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.quantityLabel.Location = new System.Drawing.Point(71, 169);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(77, 21);
            this.quantityLabel.TabIndex = 109;
            this.quantityLabel.Text = "Quantity";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.nameLabel.Location = new System.Drawing.Point(71, 101);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 21);
            this.nameLabel.TabIndex = 108;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.idLabel.Location = new System.Drawing.Point(71, 38);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 21);
            this.idLabel.TabIndex = 107;
            this.idLabel.Text = "ID";
            // 
            // catCombobox
            // 
            this.catCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.catCombobox.FormattingEnabled = true;
            this.catCombobox.Location = new System.Drawing.Point(277, 420);
            this.catCombobox.Name = "catCombobox";
            this.catCombobox.Size = new System.Drawing.Size(143, 28);
            this.catCombobox.TabIndex = 106;
            this.catCombobox.Text = "Select Category";
            this.catCombobox.SelectedIndexChanged += new System.EventHandler(this.catCombobox_SelectedIndexChanged);
            // 
            // ProdPrice
            // 
            this.ProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdPrice.Location = new System.Drawing.Point(277, 236);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(143, 26);
            this.ProdPrice.TabIndex = 105;
            // 
            // ProdQty
            // 
            this.ProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdQty.Location = new System.Drawing.Point(277, 167);
            this.ProdQty.Name = "ProdQty";
            this.ProdQty.Size = new System.Drawing.Size(143, 26);
            this.ProdQty.TabIndex = 104;
            // 
            // ProdName
            // 
            this.ProdName.BackColor = System.Drawing.Color.White;
            this.ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdName.Location = new System.Drawing.Point(277, 99);
            this.ProdName.Name = "ProdName";
            this.ProdName.Size = new System.Drawing.Size(143, 26);
            this.ProdName.TabIndex = 103;
            // 
            // ProdId
            // 
            this.ProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ProdId.Location = new System.Drawing.Point(277, 38);
            this.ProdId.Name = "ProdId";
            this.ProdId.Size = new System.Drawing.Size(143, 26);
            this.ProdId.TabIndex = 102;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.LightBlue;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editButton.Location = new System.Drawing.Point(266, 496);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(64, 40);
            this.editButton.TabIndex = 113;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightBlue;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(123, 496);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 40);
            this.addButton.TabIndex = 112;
            this.addButton.Text = "Create New";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(277, 303);
            this.DateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(143, 26);
            this.DateTimePicker.TabIndex = 120;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dateLabel.Location = new System.Drawing.Point(71, 308);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(46, 21);
            this.dateLabel.TabIndex = 121;
            this.dateLabel.Text = "Date";
            // 
            // categoryID
            // 
            this.categoryID.AutoSize = true;
            this.categoryID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.categoryID.Location = new System.Drawing.Point(71, 375);
            this.categoryID.Name = "categoryID";
            this.categoryID.Size = new System.Drawing.Size(101, 21);
            this.categoryID.TabIndex = 122;
            this.categoryID.Text = "Category ID";
            // 
            // catIDTextBox
            // 
            this.catIDTextBox.Enabled = false;
            this.catIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.catIDTextBox.Location = new System.Drawing.Point(277, 373);
            this.catIDTextBox.Name = "catIDTextBox";
            this.catIDTextBox.Size = new System.Drawing.Size(143, 26);
            this.catIDTextBox.TabIndex = 123;
            // 
            // addEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 548);
            this.Controls.Add(this.catIDTextBox);
            this.Controls.Add(this.categoryID);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.catCombobox);
            this.Controls.Add(this.ProdPrice);
            this.Controls.Add(this.ProdQty);
            this.Controls.Add(this.ProdName);
            this.Controls.Add(this.ProdId);
            this.Name = "addEditProduct";
            this.Text = "addProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label categoriesLabel;
        private Label priceLabel;
        private Label quantityLabel;
        private Label nameLabel;
        public TextBox ProdId;
        public TextBox ProdName;
        public TextBox ProdQty;
        public TextBox ProdPrice;
        public ComboBox catCombobox;
        private Label dateLabel;
        public DateTimePicker DateTimePicker;
        public Button editButton;
        public Button addButton;
        public Label idLabel;
        private Label categoryID;
        public TextBox catIDTextBox;
    }
}