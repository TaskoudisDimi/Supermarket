namespace SupermarketTuto.Forms.SellingForms
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
            this.CatDGV = new System.Windows.Forms.DataGridView();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.editProductButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.editCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.toProductDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromProductDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.catComboBox = new System.Windows.Forms.ComboBox();
            this.searchProductButton = new System.Windows.Forms.Button();
            this.searchProductTextBox = new System.Windows.Forms.TextBox();
            this.fromCategoryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toCategoryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchCategoryButton = new System.Windows.Forms.Button();
            this.searchCategoryTextBox = new System.Windows.Forms.TextBox();
            this.total2Label = new System.Windows.Forms.Label();
            this.ProdDGV = new System.Windows.Forms.DataGridView();
            this.importProductCombobox = new System.Windows.Forms.ComboBox();
            this.exportProductCombobox = new System.Windows.Forms.ComboBox();
            this.importCategoryCombobox = new System.Windows.Forms.ComboBox();
            this.exportCategoryCombobox = new System.Windows.Forms.ComboBox();
            this.pagingProductCheckBox = new System.Windows.Forms.CheckBox();
            this.pagingProductCombobox = new System.Windows.Forms.ComboBox();
            this.nextProductButton = new System.Windows.Forms.Button();
            this.prevProductButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pagingCategoryCheckBox = new System.Windows.Forms.CheckBox();
            this.pagingCategoryCombobox = new System.Windows.Forms.ComboBox();
            this.nextCategoryButton = new System.Windows.Forms.Button();
            this.prevCategoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CatDGV
            // 
            this.CatDGV.AllowUserToAddRows = false;
            this.CatDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CatDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CatDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDGV.Location = new System.Drawing.Point(36, 514);
            this.CatDGV.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersWidth = 62;
            this.CatDGV.RowTemplate.Height = 30;
            this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDGV.Size = new System.Drawing.Size(789, 282);
            this.CatDGV.TabIndex = 105;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteProductButton.Location = new System.Drawing.Point(850, 279);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(68, 40);
            this.deleteProductButton.TabIndex = 112;
            this.deleteProductButton.Text = "Delete";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // editProductButton
            // 
            this.editProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editProductButton.Location = new System.Drawing.Point(850, 211);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(64, 40);
            this.editProductButton.TabIndex = 111;
            this.editProductButton.Text = "Edit";
            this.editProductButton.UseVisualStyleBackColor = true;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addProductButton.Location = new System.Drawing.Point(850, 146);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(101, 40);
            this.addProductButton.TabIndex = 110;
            this.addProductButton.Text = "Create New";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteCategoryButton.Location = new System.Drawing.Point(850, 699);
            this.deleteCategoryButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(73, 35);
            this.deleteCategoryButton.TabIndex = 115;
            this.deleteCategoryButton.Text = "Delete";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // editCategoryButton
            // 
            this.editCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editCategoryButton.Location = new System.Drawing.Point(850, 630);
            this.editCategoryButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.editCategoryButton.Name = "editCategoryButton";
            this.editCategoryButton.Size = new System.Drawing.Size(73, 40);
            this.editCategoryButton.TabIndex = 114;
            this.editCategoryButton.Text = "Edit";
            this.editCategoryButton.UseVisualStyleBackColor = true;
            this.editCategoryButton.Click += new System.EventHandler(this.editCategoryButton_Click);
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addCategoryButton.Location = new System.Drawing.Point(850, 562);
            this.addCategoryButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(101, 40);
            this.addCategoryButton.TabIndex = 113;
            this.addCategoryButton.Text = "Create New";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
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
            // toProductDateTimePicker
            // 
            this.toProductDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toProductDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toProductDateTimePicker.Location = new System.Drawing.Point(587, 74);
            this.toProductDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.toProductDateTimePicker.Name = "toProductDateTimePicker";
            this.toProductDateTimePicker.Size = new System.Drawing.Size(118, 26);
            this.toProductDateTimePicker.TabIndex = 126;
            this.toProductDateTimePicker.ValueChanged += new System.EventHandler(this.toProductDateTimePicker_ValueChanged);
            // 
            // fromProductDateTimePicker
            // 
            this.fromProductDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fromProductDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromProductDateTimePicker.Location = new System.Drawing.Point(450, 74);
            this.fromProductDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.fromProductDateTimePicker.Name = "fromProductDateTimePicker";
            this.fromProductDateTimePicker.Size = new System.Drawing.Size(127, 26);
            this.fromProductDateTimePicker.TabIndex = 125;
            this.fromProductDateTimePicker.ValueChanged += new System.EventHandler(this.fromProductDateTimePicker_ValueChanged);
            // 
            // catComboBox
            // 
            this.catComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.catComboBox.FormattingEnabled = true;
            this.catComboBox.Location = new System.Drawing.Point(299, 74);
            this.catComboBox.Name = "catComboBox";
            this.catComboBox.Size = new System.Drawing.Size(143, 28);
            this.catComboBox.TabIndex = 124;
            this.catComboBox.Text = "Select Category";
            this.catComboBox.SelectionChangeCommitted += new System.EventHandler(this.catComboBox_SelectionChangeCommitted);
            // 
            // searchProductButton
            // 
            this.searchProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchProductButton.Location = new System.Drawing.Point(201, 74);
            this.searchProductButton.Name = "searchProductButton";
            this.searchProductButton.Size = new System.Drawing.Size(92, 26);
            this.searchProductButton.TabIndex = 123;
            this.searchProductButton.Text = "Search";
            this.searchProductButton.UseVisualStyleBackColor = true;
            this.searchProductButton.Click += new System.EventHandler(this.searchProductButton_Click);
            // 
            // searchProductTextBox
            // 
            this.searchProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchProductTextBox.Location = new System.Drawing.Point(36, 74);
            this.searchProductTextBox.Name = "searchProductTextBox";
            this.searchProductTextBox.Size = new System.Drawing.Size(159, 26);
            this.searchProductTextBox.TabIndex = 122;
            this.searchProductTextBox.TextChanged += new System.EventHandler(this.searchProductTextBox_TextChanged);
            // 
            // fromCategoryDateTimePicker
            // 
            this.fromCategoryDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fromCategoryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromCategoryDateTimePicker.Location = new System.Drawing.Point(373, 477);
            this.fromCategoryDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.fromCategoryDateTimePicker.Name = "fromCategoryDateTimePicker";
            this.fromCategoryDateTimePicker.Size = new System.Drawing.Size(127, 26);
            this.fromCategoryDateTimePicker.TabIndex = 106;
            this.fromCategoryDateTimePicker.ValueChanged += new System.EventHandler(this.fromCategoryDateTimePicker_ValueChanged);
            // 
            // toCategoryDateTimePicker
            // 
            this.toCategoryDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toCategoryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toCategoryDateTimePicker.Location = new System.Drawing.Point(510, 477);
            this.toCategoryDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.toCategoryDateTimePicker.Name = "toCategoryDateTimePicker";
            this.toCategoryDateTimePicker.Size = new System.Drawing.Size(118, 26);
            this.toCategoryDateTimePicker.TabIndex = 107;
            this.toCategoryDateTimePicker.ValueChanged += new System.EventHandler(this.toCategoryDateTimePicker_ValueChanged);
            // 
            // searchCategoryButton
            // 
            this.searchCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchCategoryButton.Location = new System.Drawing.Point(217, 480);
            this.searchCategoryButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchCategoryButton.Name = "searchCategoryButton";
            this.searchCategoryButton.Size = new System.Drawing.Size(92, 28);
            this.searchCategoryButton.TabIndex = 131;
            this.searchCategoryButton.Text = "Search";
            this.searchCategoryButton.UseVisualStyleBackColor = true;
            this.searchCategoryButton.Click += new System.EventHandler(this.searchCategoryButton_Click);
            // 
            // searchCategoryTextBox
            // 
            this.searchCategoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchCategoryTextBox.Location = new System.Drawing.Point(48, 480);
            this.searchCategoryTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchCategoryTextBox.Name = "searchCategoryTextBox";
            this.searchCategoryTextBox.Size = new System.Drawing.Size(159, 26);
            this.searchCategoryTextBox.TabIndex = 130;
            this.searchCategoryTextBox.TextChanged += new System.EventHandler(this.searchCategoryTextBox_TextChanged);
            // 
            // total2Label
            // 
            this.total2Label.AutoSize = true;
            this.total2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.total2Label.Location = new System.Drawing.Point(44, 812);
            this.total2Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.total2Label.Name = "total2Label";
            this.total2Label.Size = new System.Drawing.Size(48, 20);
            this.total2Label.TabIndex = 132;
            this.total2Label.Text = "Total:";
            // 
            // ProdDGV
            // 
            this.ProdDGV.AllowUserToAddRows = false;
            this.ProdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProdDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV.Location = new System.Drawing.Point(36, 118);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersWidth = 62;
            this.ProdDGV.RowTemplate.Height = 30;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(789, 294);
            this.ProdDGV.TabIndex = 133;
            // 
            // importProductCombobox
            // 
            this.importProductCombobox.FormattingEnabled = true;
            this.importProductCombobox.Location = new System.Drawing.Point(607, 417);
            this.importProductCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.importProductCombobox.Name = "importProductCombobox";
            this.importProductCombobox.Size = new System.Drawing.Size(99, 21);
            this.importProductCombobox.TabIndex = 142;
            this.importProductCombobox.Text = "Import";
            // 
            // exportProductCombobox
            // 
            this.exportProductCombobox.FormattingEnabled = true;
            this.exportProductCombobox.Location = new System.Drawing.Point(728, 417);
            this.exportProductCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exportProductCombobox.Name = "exportProductCombobox";
            this.exportProductCombobox.Size = new System.Drawing.Size(99, 21);
            this.exportProductCombobox.TabIndex = 141;
            this.exportProductCombobox.Text = "Export";
            // 
            // importCategoryCombobox
            // 
            this.importCategoryCombobox.FormattingEnabled = true;
            this.importCategoryCombobox.Location = new System.Drawing.Point(607, 801);
            this.importCategoryCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.importCategoryCombobox.Name = "importCategoryCombobox";
            this.importCategoryCombobox.Size = new System.Drawing.Size(99, 21);
            this.importCategoryCombobox.TabIndex = 144;
            this.importCategoryCombobox.Text = "Import";
            // 
            // exportCategoryCombobox
            // 
            this.exportCategoryCombobox.FormattingEnabled = true;
            this.exportCategoryCombobox.Location = new System.Drawing.Point(728, 801);
            this.exportCategoryCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exportCategoryCombobox.Name = "exportCategoryCombobox";
            this.exportCategoryCombobox.Size = new System.Drawing.Size(99, 21);
            this.exportCategoryCombobox.TabIndex = 143;
            this.exportCategoryCombobox.Text = "Export";
            // 
            // pagingProductCheckBox
            // 
            this.pagingProductCheckBox.AutoSize = true;
            this.pagingProductCheckBox.Location = new System.Drawing.Point(129, 425);
            this.pagingProductCheckBox.Name = "pagingProductCheckBox";
            this.pagingProductCheckBox.Size = new System.Drawing.Size(59, 17);
            this.pagingProductCheckBox.TabIndex = 148;
            this.pagingProductCheckBox.Text = "Paging";
            this.pagingProductCheckBox.UseVisualStyleBackColor = true;
            this.pagingProductCheckBox.CheckedChanged += new System.EventHandler(this.pagingProductCheckBox_CheckedChanged);
            // 
            // pagingProductCombobox
            // 
            this.pagingProductCombobox.FormattingEnabled = true;
            this.pagingProductCombobox.Location = new System.Drawing.Point(194, 421);
            this.pagingProductCombobox.Name = "pagingProductCombobox";
            this.pagingProductCombobox.Size = new System.Drawing.Size(121, 21);
            this.pagingProductCombobox.TabIndex = 147;
            this.pagingProductCombobox.Visible = false;
            // 
            // nextProductButton
            // 
            this.nextProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextProductButton.Location = new System.Drawing.Point(428, 421);
            this.nextProductButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextProductButton.Name = "nextProductButton";
            this.nextProductButton.Size = new System.Drawing.Size(82, 32);
            this.nextProductButton.TabIndex = 146;
            this.nextProductButton.Text = "Next";
            this.nextProductButton.UseVisualStyleBackColor = true;
            this.nextProductButton.Visible = false;
            this.nextProductButton.Click += new System.EventHandler(this.nextProductButton_Click);
            // 
            // prevProductButton
            // 
            this.prevProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.prevProductButton.Location = new System.Drawing.Point(322, 419);
            this.prevProductButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prevProductButton.Name = "prevProductButton";
            this.prevProductButton.Size = new System.Drawing.Size(98, 35);
            this.prevProductButton.TabIndex = 145;
            this.prevProductButton.Text = "Previous";
            this.prevProductButton.UseVisualStyleBackColor = true;
            this.prevProductButton.Visible = false;
            this.prevProductButton.Click += new System.EventHandler(this.prevProductButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(32, 426);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 149;
            this.label1.Text = "Total:";
            // 
            // pagingCategoryCheckBox
            // 
            this.pagingCategoryCheckBox.AutoSize = true;
            this.pagingCategoryCheckBox.Location = new System.Drawing.Point(211, 801);
            this.pagingCategoryCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pagingCategoryCheckBox.Name = "pagingCategoryCheckBox";
            this.pagingCategoryCheckBox.Size = new System.Drawing.Size(59, 17);
            this.pagingCategoryCheckBox.TabIndex = 153;
            this.pagingCategoryCheckBox.Text = "Paging";
            this.pagingCategoryCheckBox.UseVisualStyleBackColor = true;
            this.pagingCategoryCheckBox.CheckedChanged += new System.EventHandler(this.pagingCategoryCheckBox_CheckedChanged);
            // 
            // pagingCategoryCombobox
            // 
            this.pagingCategoryCombobox.FormattingEnabled = true;
            this.pagingCategoryCombobox.Location = new System.Drawing.Point(286, 801);
            this.pagingCategoryCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pagingCategoryCombobox.Name = "pagingCategoryCombobox";
            this.pagingCategoryCombobox.Size = new System.Drawing.Size(82, 21);
            this.pagingCategoryCombobox.TabIndex = 152;
            this.pagingCategoryCombobox.Visible = false;
            // 
            // nextCategoryButton
            // 
            this.nextCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextCategoryButton.Location = new System.Drawing.Point(485, 800);
            this.nextCategoryButton.Name = "nextCategoryButton";
            this.nextCategoryButton.Size = new System.Drawing.Size(85, 34);
            this.nextCategoryButton.TabIndex = 151;
            this.nextCategoryButton.Text = "Next";
            this.nextCategoryButton.UseVisualStyleBackColor = true;
            this.nextCategoryButton.Visible = false;
            this.nextCategoryButton.Click += new System.EventHandler(this.nextCategoryButton_Click);
            // 
            // prevCategoryButton
            // 
            this.prevCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.prevCategoryButton.Location = new System.Drawing.Point(384, 799);
            this.prevCategoryButton.Name = "prevCategoryButton";
            this.prevCategoryButton.Size = new System.Drawing.Size(96, 36);
            this.prevCategoryButton.TabIndex = 150;
            this.prevCategoryButton.Text = "Previous";
            this.prevCategoryButton.UseVisualStyleBackColor = true;
            this.prevCategoryButton.Visible = false;
            this.prevCategoryButton.Click += new System.EventHandler(this.prevCategoryButton_Click);
            // 
            // Categories_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 859);
            this.ControlBox = false;
            this.Controls.Add(this.pagingCategoryCheckBox);
            this.Controls.Add(this.pagingCategoryCombobox);
            this.Controls.Add(this.nextCategoryButton);
            this.Controls.Add(this.prevCategoryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pagingProductCheckBox);
            this.Controls.Add(this.pagingProductCombobox);
            this.Controls.Add(this.nextProductButton);
            this.Controls.Add(this.prevProductButton);
            this.Controls.Add(this.importCategoryCombobox);
            this.Controls.Add(this.exportCategoryCombobox);
            this.Controls.Add(this.importProductCombobox);
            this.Controls.Add(this.exportProductCombobox);
            this.Controls.Add(this.ProdDGV);
            this.Controls.Add(this.total2Label);
            this.Controls.Add(this.searchCategoryButton);
            this.Controls.Add(this.searchCategoryTextBox);
            this.Controls.Add(this.toProductDateTimePicker);
            this.Controls.Add(this.fromProductDateTimePicker);
            this.Controls.Add(this.catComboBox);
            this.Controls.Add(this.searchProductButton);
            this.Controls.Add(this.searchProductTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.deleteCategoryButton);
            this.Controls.Add(this.editCategoryButton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.editProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.toCategoryDateTimePicker);
            this.Controls.Add(this.fromCategoryDateTimePicker);
            this.Controls.Add(this.CatDGV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Categories_Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Categories_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView CatDGV;
        private Button deleteProductButton;
        private Button editProductButton;
        private Button addProductButton;
        private Button deleteCategoryButton;
        private Button editCategoryButton;
        private Button addCategoryButton;
        private Label totalLabel;
        private DateTimePicker toProductDateTimePicker;
        private DateTimePicker fromProductDateTimePicker;
        private ComboBox catComboBox;
        private Button searchProductButton;
        private TextBox searchProductTextBox;
        private DateTimePicker fromCategoryDateTimePicker;
        private DateTimePicker toCategoryDateTimePicker;
        private Button searchCategoryButton;
        private TextBox searchCategoryTextBox;
        private Label total2Label;
        private DataGridView ProdDGV;
        private ComboBox importProductCombobox;
        private ComboBox exportProductCombobox;
        private ComboBox importCategoryCombobox;
        private ComboBox exportCategoryCombobox;
        private CheckBox pagingProductCheckBox;
        private ComboBox pagingProductCombobox;
        private Button nextProductButton;
        private Button prevProductButton;
        private Label label1;
        private CheckBox pagingCategoryCheckBox;
        private ComboBox pagingCategoryCombobox;
        private Button nextCategoryButton;
        private Button prevCategoryButton;
    }
}