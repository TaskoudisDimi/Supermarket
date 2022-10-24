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
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.refreshButton = new System.Windows.Forms.Button();
            this.CatDGV = new System.Windows.Forms.DataGridView();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.name3Label = new System.Windows.Forms.Label();
            this.id3label = new System.Windows.Forms.Label();
            this.CatDescTb = new System.Windows.Forms.TextBox();
            this.CatNameTb = new System.Windows.Forms.TextBox();
            this.CatIdTb = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateLabel.Location = new System.Drawing.Point(1026, 369);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(67, 32);
            this.dateLabel.TabIndex = 89;
            this.dateLabel.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(1128, 369);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(273, 35);
            this.dateTimePicker.TabIndex = 88;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.deleteButton.Location = new System.Drawing.Point(1273, 450);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 40);
            this.deleteButton.TabIndex = 87;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editButton.Location = new System.Drawing.Point(1157, 450);
            this.editButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(73, 40);
            this.editButton.TabIndex = 86;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(1037, 450);
            this.addButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(73, 40);
            this.addButton.TabIndex = 85;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalLabel.Location = new System.Drawing.Point(14, 770);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(74, 29);
            this.totalLabel.TabIndex = 84;
            this.totalLabel.Text = "Total:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchButton.Location = new System.Drawing.Point(320, 143);
            this.searchButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(123, 30);
            this.searchButton.TabIndex = 83;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            this.searchButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchButton_KeyPress);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchTextBox.Location = new System.Drawing.Point(14, 143);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(296, 35);
            this.searchTextBox.TabIndex = 82;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(634, 147);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(118, 35);
            this.toDateTimePicker.TabIndex = 81;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(497, 147);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(127, 35);
            this.fromDateTimePicker.TabIndex = 80;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.refreshButton.Location = new System.Drawing.Point(780, 129);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(110, 44);
            this.refreshButton.TabIndex = 79;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // CatDGV
            // 
            this.CatDGV.AllowUserToAddRows = false;
            this.CatDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDGV.Location = new System.Drawing.Point(14, 189);
            this.CatDGV.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersWidth = 62;
            this.CatDGV.RowTemplate.Height = 30;
            this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDGV.Size = new System.Drawing.Size(876, 549);
            this.CatDGV.TabIndex = 78;
            this.CatDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellClick);
            this.CatDGV.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CatDGV_CellMouseUp);
            this.CatDGV.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.CatDGV_CellValidating);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.descriptionLabel.Location = new System.Drawing.Point(994, 303);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(146, 32);
            this.descriptionLabel.TabIndex = 77;
            this.descriptionLabel.Text = "Description";
            // 
            // name3Label
            // 
            this.name3Label.AutoSize = true;
            this.name3Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.name3Label.Location = new System.Drawing.Point(1016, 243);
            this.name3Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.name3Label.Name = "name3Label";
            this.name3Label.Size = new System.Drawing.Size(81, 32);
            this.name3Label.TabIndex = 76;
            this.name3Label.Text = "Name";
            // 
            // id3label
            // 
            this.id3label.AutoSize = true;
            this.id3label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.id3label.Location = new System.Drawing.Point(1025, 189);
            this.id3label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.id3label.Name = "id3label";
            this.id3label.Size = new System.Drawing.Size(40, 32);
            this.id3label.TabIndex = 75;
            this.id3label.Text = "ID";
            // 
            // CatDescTb
            // 
            this.CatDescTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CatDescTb.Location = new System.Drawing.Point(1128, 298);
            this.CatDescTb.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CatDescTb.Name = "CatDescTb";
            this.CatDescTb.Size = new System.Drawing.Size(273, 35);
            this.CatDescTb.TabIndex = 74;
            // 
            // CatNameTb
            // 
            this.CatNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CatNameTb.Location = new System.Drawing.Point(1128, 243);
            this.CatNameTb.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(273, 35);
            this.CatNameTb.TabIndex = 73;
            // 
            // CatIdTb
            // 
            this.CatIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CatIdTb.Location = new System.Drawing.Point(1128, 189);
            this.CatIdTb.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CatIdTb.Name = "CatIdTb";
            this.CatIdTb.Size = new System.Drawing.Size(283, 35);
            this.CatIdTb.TabIndex = 72;
            // 
            // exportButton
            // 
            this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exportButton.Location = new System.Drawing.Point(539, 753);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(102, 46);
            this.exportButton.TabIndex = 114;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.saveButton.Location = new System.Drawing.Point(789, 755);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 46);
            this.saveButton.TabIndex = 113;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // importButton
            // 
            this.importButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.importButton.Location = new System.Drawing.Point(660, 755);
            this.importButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(102, 46);
            this.importButton.TabIndex = 112;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 846);
            this.ControlBox = false;
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.CatDGV);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.name3Label);
            this.Controls.Add(this.id3label);
            this.Controls.Add(this.CatDescTb);
            this.Controls.Add(this.CatNameTb);
            this.Controls.Add(this.CatIdTb);
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

        private Label dateLabel;
        private DateTimePicker dateTimePicker;
        private Button deleteButton;
        private Button editButton;
        private Button addButton;
        private Label totalLabel;
        private Button searchButton;
        private TextBox searchTextBox;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private Button refreshButton;
        private DataGridView CatDGV;
        private Label descriptionLabel;
        private Label name3Label;
        private Label id3label;
        private TextBox CatDescTb;
        private TextBox CatNameTb;
        private TextBox CatIdTb;
        private Button exportButton;
        private Button saveButton;
        private Button importButton;
    }
}