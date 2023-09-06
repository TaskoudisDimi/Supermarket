namespace SupermarketTuto.Forms
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
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteButton.Location = new System.Drawing.Point(1258, 640);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 41);
            this.deleteButton.TabIndex = 87;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editButton.Location = new System.Drawing.Point(1152, 642);
            this.editButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(83, 39);
            this.editButton.TabIndex = 86;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(975, 640);
            this.addButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(158, 41);
            this.addButton.TabIndex = 85;
            this.addButton.Text = "Create New";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalLabel.Location = new System.Drawing.Point(9, 640);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 84;
            this.totalLabel.Text = "Total:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchButton.Location = new System.Drawing.Point(210, 23);
            this.searchButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(114, 40);
            this.searchButton.TabIndex = 83;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchTextBox.Location = new System.Drawing.Point(14, 25);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(175, 26);
            this.searchTextBox.TabIndex = 82;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(1362, 22);
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
            this.fromDateTimePicker.Location = new System.Drawing.Point(1156, 22);
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
            this.CatDGV.Size = new System.Drawing.Size(1695, 549);
            this.CatDGV.TabIndex = 78;
            this.CatDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.CatDGV_CellFormatting);
            // 
            // showSelectedProductsButton
            // 
            this.showSelectedProductsButton.Location = new System.Drawing.Point(896, 19);
            this.showSelectedProductsButton.Name = "showSelectedProductsButton";
            this.showSelectedProductsButton.Size = new System.Drawing.Size(237, 36);
            this.showSelectedProductsButton.TabIndex = 118;
            this.showSelectedProductsButton.Text = "Show Selected Products";
            this.showSelectedProductsButton.UseVisualStyleBackColor = true;
            this.showSelectedProductsButton.Click += new System.EventHandler(this.showSelectedProductsButton_Click);
            // 
            // pagingCheckBox
            // 
            this.pagingCheckBox.AutoSize = true;
            this.pagingCheckBox.Location = new System.Drawing.Point(186, 646);
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
            this.pagingCombobox.Location = new System.Drawing.Point(307, 646);
            this.pagingCombobox.Name = "pagingCombobox";
            this.pagingCombobox.Size = new System.Drawing.Size(121, 28);
            this.pagingCombobox.TabIndex = 133;
            this.pagingCombobox.Visible = false;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextButton.Location = new System.Drawing.Point(605, 643);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(128, 52);
            this.nextButton.TabIndex = 132;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.prevButton.Location = new System.Drawing.Point(453, 642);
            this.prevButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(144, 55);
            this.prevButton.TabIndex = 131;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Visible = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // selectAllCheckBox
            // 
            this.selectAllCheckBox.AutoSize = true;
            this.selectAllCheckBox.Location = new System.Drawing.Point(351, 28);
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
            this.importCombobox.Location = new System.Drawing.Point(1380, 640);
            this.importCombobox.Name = "importCombobox";
            this.importCombobox.Size = new System.Drawing.Size(146, 28);
            this.importCombobox.TabIndex = 140;
            this.importCombobox.Text = "Import";
            this.importCombobox.SelectedValueChanged += new System.EventHandler(this.importCombobox_SelectedValueChanged);
            // 
            // exportCombobox
            // 
            this.exportCombobox.FormattingEnabled = true;
            this.exportCombobox.Location = new System.Drawing.Point(1562, 640);
            this.exportCombobox.Name = "exportCombobox";
            this.exportCombobox.Size = new System.Drawing.Size(146, 28);
            this.exportCombobox.TabIndex = 139;
            this.exportCombobox.Text = "Export";
            this.exportCombobox.SelectedValueChanged += new System.EventHandler(this.exportCombobox_SelectedValueChanged);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1756, 846);
            this.ControlBox = false;
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
    }
}