﻿namespace SupermarketTuto.Forms.SellingForms
{
    partial class Categories_Products
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
            this.ProdDGV = new System.Windows.Forms.DataGridView();
            this.CatDGV = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.delete2Button = new System.Windows.Forms.Button();
            this.edit2Button = new System.Windows.Forms.Button();
            this.add2Button = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.catComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.from2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.to2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.search2Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.refresh2Button = new System.Windows.Forms.Button();
            this.total2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdDGV
            // 
            this.ProdDGV.AllowUserToAddRows = false;
            this.ProdDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV.Location = new System.Drawing.Point(36, 119);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersWidth = 62;
            this.ProdDGV.RowTemplate.Height = 30;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(883, 258);
            this.ProdDGV.TabIndex = 104;
            // 
            // CatDGV
            // 
            this.CatDGV.AllowUserToAddRows = false;
            this.CatDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDGV.Location = new System.Drawing.Point(36, 490);
            this.CatDGV.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersWidth = 62;
            this.CatDGV.RowTemplate.Height = 30;
            this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDGV.Size = new System.Drawing.Size(883, 282);
            this.CatDGV.TabIndex = 105;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteButton.Location = new System.Drawing.Point(946, 291);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(68, 40);
            this.deleteButton.TabIndex = 112;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editButton.Location = new System.Drawing.Point(946, 224);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(64, 40);
            this.editButton.TabIndex = 111;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(946, 158);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 40);
            this.addButton.TabIndex = 110;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // delete2Button
            // 
            this.delete2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.delete2Button.Location = new System.Drawing.Point(946, 677);
            this.delete2Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.delete2Button.Name = "delete2Button";
            this.delete2Button.Size = new System.Drawing.Size(73, 35);
            this.delete2Button.TabIndex = 115;
            this.delete2Button.Text = "Delete";
            this.delete2Button.UseVisualStyleBackColor = true;
            // 
            // edit2Button
            // 
            this.edit2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.edit2Button.Location = new System.Drawing.Point(946, 602);
            this.edit2Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.edit2Button.Name = "edit2Button";
            this.edit2Button.Size = new System.Drawing.Size(73, 40);
            this.edit2Button.TabIndex = 114;
            this.edit2Button.Text = "Edit";
            this.edit2Button.UseVisualStyleBackColor = true;
            // 
            // add2Button
            // 
            this.add2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.add2Button.Location = new System.Drawing.Point(946, 539);
            this.add2Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.add2Button.Name = "add2Button";
            this.add2Button.Size = new System.Drawing.Size(73, 40);
            this.add2Button.TabIndex = 113;
            this.add2Button.Text = "Add";
            this.add2Button.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalLabel.Location = new System.Drawing.Point(44, 392);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 116;
            this.totalLabel.Text = "Total:";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(667, 72);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(118, 26);
            this.toDateTimePicker.TabIndex = 126;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(530, 72);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(127, 26);
            this.fromDateTimePicker.TabIndex = 125;
            // 
            // catComboBox
            // 
            this.catComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.catComboBox.FormattingEnabled = true;
            this.catComboBox.Location = new System.Drawing.Point(361, 72);
            this.catComboBox.Name = "catComboBox";
            this.catComboBox.Size = new System.Drawing.Size(143, 28);
            this.catComboBox.TabIndex = 124;
            this.catComboBox.Text = "Select Category";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchButton.Location = new System.Drawing.Point(227, 74);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 26);
            this.searchButton.TabIndex = 123;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchTextBox.Location = new System.Drawing.Point(48, 74);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(159, 26);
            this.searchTextBox.TabIndex = 122;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.refreshButton.Location = new System.Drawing.Point(823, 69);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(96, 29);
            this.refreshButton.TabIndex = 121;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // from2DateTimePicker
            // 
            this.from2DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.from2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from2DateTimePicker.Location = new System.Drawing.Point(503, 454);
            this.from2DateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.from2DateTimePicker.Name = "from2DateTimePicker";
            this.from2DateTimePicker.Size = new System.Drawing.Size(127, 26);
            this.from2DateTimePicker.TabIndex = 106;
            // 
            // to2DateTimePicker
            // 
            this.to2DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.to2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to2DateTimePicker.Location = new System.Drawing.Point(640, 454);
            this.to2DateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.to2DateTimePicker.Name = "to2DateTimePicker";
            this.to2DateTimePicker.Size = new System.Drawing.Size(118, 26);
            this.to2DateTimePicker.TabIndex = 107;
            // 
            // search2Button
            // 
            this.search2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.search2Button.Location = new System.Drawing.Point(227, 456);
            this.search2Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.search2Button.Name = "search2Button";
            this.search2Button.Size = new System.Drawing.Size(92, 28);
            this.search2Button.TabIndex = 131;
            this.search2Button.Text = "Search";
            this.search2Button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox1.Location = new System.Drawing.Point(48, 456);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 26);
            this.textBox1.TabIndex = 130;
            // 
            // refresh2Button
            // 
            this.refresh2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.refresh2Button.Location = new System.Drawing.Point(823, 450);
            this.refresh2Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.refresh2Button.Name = "refresh2Button";
            this.refresh2Button.Size = new System.Drawing.Size(96, 30);
            this.refresh2Button.TabIndex = 127;
            this.refresh2Button.Text = "Refresh";
            this.refresh2Button.UseVisualStyleBackColor = true;
            // 
            // total2Label
            // 
            this.total2Label.AutoSize = true;
            this.total2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.total2Label.Location = new System.Drawing.Point(44, 789);
            this.total2Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.total2Label.Name = "total2Label";
            this.total2Label.Size = new System.Drawing.Size(48, 20);
            this.total2Label.TabIndex = 132;
            this.total2Label.Text = "Total:";
            // 
            // Categories_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 818);
            this.ControlBox = false;
            this.Controls.Add(this.total2Label);
            this.Controls.Add(this.search2Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.refresh2Button);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.catComboBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.delete2Button);
            this.Controls.Add(this.edit2Button);
            this.Controls.Add(this.add2Button);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.to2DateTimePicker);
            this.Controls.Add(this.from2DateTimePicker);
            this.Controls.Add(this.CatDGV);
            this.Controls.Add(this.ProdDGV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Categories_Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Categories_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ProdDGV;
        private DataGridView CatDGV;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private Button delete2Button;
        private Button edit2Button;
        private Button add2Button;
        private Label totalLabel;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private ComboBox catComboBox;
        private Button searchButton;
        private TextBox searchTextBox;
        private Button refreshButton;
        private DateTimePicker from2DateTimePicker;
        private DateTimePicker to2DateTimePicker;
        private Button search2Button;
        private TextBox textBox1;
        private Button refresh2Button;
        private Label total2Label;
    }
}