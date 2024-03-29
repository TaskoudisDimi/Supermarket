﻿namespace SupermarketTuto.Forms
{
    partial class Category
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CatDGV = new System.Windows.Forms.DataGridView();
            this.showSelectedProductsButton = new System.Windows.Forms.Button();
            this.pagingCheckBox = new System.Windows.Forms.CheckBox();
            this.pagingCombobox = new System.Windows.Forms.ComboBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.selectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.importCombobox = new System.Windows.Forms.ComboBox();
            this.exportCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.callAPIButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Tomato;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteButton.Location = new System.Drawing.Point(791, 406);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(102, 34);
            this.deleteButton.TabIndex = 87;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.LightBlue;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editButton.Location = new System.Drawing.Point(679, 406);
            this.editButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(102, 34);
            this.editButton.TabIndex = 86;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightBlue;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(567, 406);
            this.addButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 34);
            this.addButton.TabIndex = 85;
            this.addButton.Text = "Create New";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalLabel.Location = new System.Drawing.Point(8, 420);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 84;
            this.totalLabel.Text = "Total:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.LightBlue;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchButton.Location = new System.Drawing.Point(263, 26);
            this.searchButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(68, 29);
            this.searchButton.TabIndex = 83;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchTextBox.Location = new System.Drawing.Point(14, 25);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(222, 26);
            this.searchTextBox.TabIndex = 82;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(899, 25);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(176, 26);
            this.toDateTimePicker.TabIndex = 81;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(705, 26);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(186, 26);
            this.fromDateTimePicker.TabIndex = 80;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
            // 
            // CatDGV
            // 
            this.CatDGV.AllowUserToAddRows = false;
            this.CatDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDGV.Location = new System.Drawing.Point(14, 71);
            this.CatDGV.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.ReadOnly = true;
            this.CatDGV.RowHeadersWidth = 62;
            this.CatDGV.RowTemplate.Height = 30;
            this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDGV.Size = new System.Drawing.Size(1089, 329);
            this.CatDGV.TabIndex = 78;
            this.CatDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.CatDGV_CellFormatting);
            // 
            // showSelectedProductsButton
            // 
            this.showSelectedProductsButton.BackColor = System.Drawing.Color.LightBlue;
            this.showSelectedProductsButton.Location = new System.Drawing.Point(476, 22);
            this.showSelectedProductsButton.Name = "showSelectedProductsButton";
            this.showSelectedProductsButton.Size = new System.Drawing.Size(221, 36);
            this.showSelectedProductsButton.TabIndex = 118;
            this.showSelectedProductsButton.Text = "Show Selected Products";
            this.showSelectedProductsButton.UseVisualStyleBackColor = false;
            this.showSelectedProductsButton.Click += new System.EventHandler(this.showSelectedProductsButton_Click);
            // 
            // pagingCheckBox
            // 
            this.pagingCheckBox.AutoSize = true;
            this.pagingCheckBox.Location = new System.Drawing.Point(125, 416);
            this.pagingCheckBox.Name = "pagingCheckBox";
            this.pagingCheckBox.Size = new System.Drawing.Size(77, 24);
            this.pagingCheckBox.TabIndex = 137;
            this.pagingCheckBox.Text = "Paging";
            this.pagingCheckBox.UseVisualStyleBackColor = true;
            this.pagingCheckBox.CheckedChanged += new System.EventHandler(this.pagingCheckBox_CheckedChanged);
            // 
            // pagingCombobox
            // 
            this.pagingCombobox.FormattingEnabled = true;
            this.pagingCombobox.Location = new System.Drawing.Point(209, 414);
            this.pagingCombobox.Name = "pagingCombobox";
            this.pagingCombobox.Size = new System.Drawing.Size(82, 28);
            this.pagingCombobox.TabIndex = 133;
            this.pagingCombobox.Visible = false;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.LightBlue;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextButton.Location = new System.Drawing.Point(419, 410);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(102, 34);
            this.nextButton.TabIndex = 132;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.Color.LightBlue;
            this.prevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.prevButton.Location = new System.Drawing.Point(309, 410);
            this.prevButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(102, 34);
            this.prevButton.TabIndex = 131;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Visible = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.AutoSize = true;
            this.selectAllCheckBox.Location = new System.Drawing.Point(376, 28);
            this.selectAllCheckBox.Name = "selectAllCheckBox";
            this.selectAllCheckBox.Size = new System.Drawing.Size(94, 24);
            this.selectAllCheckBox.TabIndex = 138;
            this.selectAllCheckBox.Text = "Select All";
            this.selectAllCheckBox.UseVisualStyleBackColor = true;
            this.selectAllCheckBox.CheckedChanged += new System.EventHandler(this.selectAllCheckBox_CheckedChanged);
            // 
            // importCombobox
            // 
            this.importCombobox.FormattingEnabled = true;
            this.importCombobox.Location = new System.Drawing.Point(899, 437);
            this.importCombobox.Name = "importCombobox";
            this.importCombobox.Size = new System.Drawing.Size(99, 28);
            this.importCombobox.TabIndex = 140;
            this.importCombobox.SelectedValueChanged += new System.EventHandler(this.importCombobox_SelectedValueChanged);
            // 
            // exportCombobox
            // 
            this.exportCombobox.FormattingEnabled = true;
            this.exportCombobox.Location = new System.Drawing.Point(1004, 437);
            this.exportCombobox.Name = "exportCombobox";
            this.exportCombobox.Size = new System.Drawing.Size(99, 28);
            this.exportCombobox.TabIndex = 139;
            this.exportCombobox.SelectedValueChanged += new System.EventHandler(this.exportCombobox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(918, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 141;
            this.label1.Text = "Import";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1020, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 142;
            this.label2.Text = "Export";
            // 
            // callAPIButton
            // 
            this.callAPIButton.BackColor = System.Drawing.Color.LightBlue;
            this.callAPIButton.Location = new System.Drawing.Point(567, 446);
            this.callAPIButton.Name = "callAPIButton";
            this.callAPIButton.Size = new System.Drawing.Size(148, 35);
            this.callAPIButton.TabIndex = 143;
            this.callAPIButton.Text = "Get External Data";
            this.callAPIButton.UseVisualStyleBackColor = false;
            this.callAPIButton.Click += new System.EventHandler(this.callAPIButton_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 515);
            this.ControlBox = false;
            this.Controls.Add(this.callAPIButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.importCombobox);
            this.Controls.Add(this.exportCombobox);
            this.Controls.Add(this.selectAllCheckBox);
            this.Controls.Add(this.pagingCheckBox);
            this.Controls.Add(this.pagingCombobox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.showSelectedProductsButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.CatDGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Category";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private Label totalLabel;
        private Button searchButton;
        private TextBox searchTextBox;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        public DataGridView CatDGV;
        private Button showSelectedProductsButton;
        private CheckBox pagingCheckBox;
        private ComboBox pagingCombobox;
        private Button nextButton;
        private Button prevButton;
        private CheckBox selectAllCheckBox;
        private ComboBox importCombobox;
        private ComboBox exportCombobox;
        private Label label1;
        private Label label2;
        private Button callAPIButton;
    }
}