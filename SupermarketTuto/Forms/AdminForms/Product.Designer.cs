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
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.catComboBox = new System.Windows.Forms.ComboBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.catLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.pagingComboBox = new System.Windows.Forms.ComboBox();
            this.pagingCheckBox = new System.Windows.Forms.CheckBox();
            this.exportCombobox = new System.Windows.Forms.ComboBox();
            this.importCombobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalLabel.Location = new System.Drawing.Point(6, 603);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 106;
            this.totalLabel.Text = "Total:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchButton.Location = new System.Drawing.Point(254, 64);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(128, 35);
            this.searchButton.TabIndex = 105;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchTextBox.Location = new System.Drawing.Point(9, 64);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(222, 26);
            this.searchTextBox.TabIndex = 104;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // ProdDGV
            // 
            this.ProdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProdDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdDGV.Location = new System.Drawing.Point(9, 102);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersWidth = 62;
            this.ProdDGV.RowTemplate.Height = 30;
            this.ProdDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProdDGV.Size = new System.Drawing.Size(1576, 489);
            this.ProdDGV.TabIndex = 103;
            this.ProdDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProdDGV_CellFormatting);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteButton.Location = new System.Drawing.Point(1060, 602);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 37);
            this.deleteButton.TabIndex = 97;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editButton.Location = new System.Drawing.Point(949, 602);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(96, 34);
            this.editButton.TabIndex = 96;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(767, 602);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(165, 37);
            this.addButton.TabIndex = 95;
            this.addButton.Text = "Create New";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // catComboBox
            // 
            this.catComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.catComboBox.FormattingEnabled = true;
            this.catComboBox.Location = new System.Drawing.Point(825, 58);
            this.catComboBox.Name = "catComboBox";
            this.catComboBox.Size = new System.Drawing.Size(207, 28);
            this.catComboBox.TabIndex = 107;
            this.catComboBox.Text = "Select Category";
            this.catComboBox.SelectedIndexChanged += new System.EventHandler(this.catComboBox_SelectedIndexChanged);
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(1259, 57);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(179, 26);
            this.toDateTimePicker.TabIndex = 120;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(1081, 57);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(169, 26);
            this.fromDateTimePicker.TabIndex = 119;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.catLabel.Location = new System.Drawing.Point(862, 26);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(86, 20);
            this.catLabel.TabIndex = 121;
            this.catLabel.Text = "Categories";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextButton.Location = new System.Drawing.Point(600, 603);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(85, 34);
            this.nextButton.TabIndex = 124;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.prevButton.Location = new System.Drawing.Point(499, 602);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(96, 36);
            this.prevButton.TabIndex = 123;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Visible = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // pagingComboBox
            // 
            this.pagingComboBox.FormattingEnabled = true;
            this.pagingComboBox.Location = new System.Drawing.Point(401, 604);
            this.pagingComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.pagingComboBox.Name = "pagingComboBox";
            this.pagingComboBox.Size = new System.Drawing.Size(82, 21);
            this.pagingComboBox.TabIndex = 125;
            this.pagingComboBox.Visible = false;
            // 
            // pagingCheckBox
            // 
            this.pagingCheckBox.AutoSize = true;
            this.pagingCheckBox.Location = new System.Drawing.Point(326, 604);
            this.pagingCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.pagingCheckBox.Name = "pagingCheckBox";
            this.pagingCheckBox.Size = new System.Drawing.Size(59, 17);
            this.pagingCheckBox.TabIndex = 130;
            this.pagingCheckBox.Text = "Paging";
            this.pagingCheckBox.UseVisualStyleBackColor = true;
            this.pagingCheckBox.CheckedChanged += new System.EventHandler(this.pagingCheckBox_CheckedChanged);
            // 
            // exportCombobox
            // 
            this.exportCombobox.FormattingEnabled = true;
            this.exportCombobox.Location = new System.Drawing.Point(1477, 613);
            this.exportCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.exportCombobox.Name = "exportCombobox";
            this.exportCombobox.Size = new System.Drawing.Size(99, 21);
            this.exportCombobox.TabIndex = 132;
            this.exportCombobox.Text = "Export";
            this.exportCombobox.SelectedIndexChanged += new System.EventHandler(this.exportCombobox_SelectedIndexChanged);
            // 
            // importCombobox
            // 
            this.importCombobox.FormattingEnabled = true;
            this.importCombobox.Location = new System.Drawing.Point(1356, 613);
            this.importCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.importCombobox.Name = "importCombobox";
            this.importCombobox.Size = new System.Drawing.Size(99, 21);
            this.importCombobox.TabIndex = 133;
            this.importCombobox.Text = "Import";
            this.importCombobox.SelectedValueChanged += new System.EventHandler(this.importCombobox_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 134;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 693);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.importCombobox);
            this.Controls.Add(this.exportCombobox);
            this.Controls.Add(this.pagingCheckBox);
            this.Controls.Add(this.pagingComboBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.catLabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.catComboBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.ProdDGV);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
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
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private ComboBox catComboBox;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private Label catLabel;
        private Button nextButton;
        private Button prevButton;
        private ComboBox pagingComboBox;
        private CheckBox pagingCheckBox;
        private ComboBox exportCombobox;
        private ComboBox importCombobox;
        private Button button1;
    }
}