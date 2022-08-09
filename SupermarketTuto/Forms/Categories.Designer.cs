namespace SupermarketTuto.Forms
{
    partial class Categories
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
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.refreshButton = new System.Windows.Forms.Button();
            this.CatDGV = new System.Windows.Forms.DataGridView();
            this.delete3Button = new System.Windows.Forms.Button();
            this.edit3Button = new System.Windows.Forms.Button();
            this.add3Button = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.name3Label = new System.Windows.Forms.Label();
            this.id3label = new System.Windows.Forms.Label();
            this.CatDescTb = new System.Windows.Forms.TextBox();
            this.CatNameTb = new System.Windows.Forms.TextBox();
            this.CatIdTb = new System.Windows.Forms.TextBox();
            this.logOutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(48, 821);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(53, 25);
            this.totalLabel.TabIndex = 65;
            this.totalLabel.Text = "Total:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(269, 87);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(107, 34);
            this.searchButton.TabIndex = 64;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(48, 89);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(213, 31);
            this.searchTextBox.TabIndex = 63;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(575, 85);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(135, 31);
            this.toDateTimePicker.TabIndex = 62;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(429, 85);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(135, 31);
            this.fromDateTimePicker.TabIndex = 61;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1443, 78);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(107, 38);
            this.refreshButton.TabIndex = 60;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // CatDGV
            // 
            this.CatDGV.AllowUserToAddRows = false;
            this.CatDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDGV.Location = new System.Drawing.Point(48, 126);
            this.CatDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersWidth = 62;
            this.CatDGV.RowTemplate.Height = 30;
            this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDGV.Size = new System.Drawing.Size(1502, 675);
            this.CatDGV.TabIndex = 59;
            // 
            // delete3Button
            // 
            this.delete3Button.Location = new System.Drawing.Point(2227, 413);
            this.delete3Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete3Button.Name = "delete3Button";
            this.delete3Button.Size = new System.Drawing.Size(107, 38);
            this.delete3Button.TabIndex = 58;
            this.delete3Button.Text = "Delete";
            this.delete3Button.UseVisualStyleBackColor = true;
            // 
            // edit3Button
            // 
            this.edit3Button.Location = new System.Drawing.Point(2111, 413);
            this.edit3Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit3Button.Name = "edit3Button";
            this.edit3Button.Size = new System.Drawing.Size(107, 38);
            this.edit3Button.TabIndex = 57;
            this.edit3Button.Text = "Edit";
            this.edit3Button.UseVisualStyleBackColor = true;
            // 
            // add3Button
            // 
            this.add3Button.Location = new System.Drawing.Point(1995, 413);
            this.add3Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add3Button.Name = "add3Button";
            this.add3Button.Size = new System.Drawing.Size(107, 38);
            this.add3Button.TabIndex = 56;
            this.add3Button.Text = "Add";
            this.add3Button.UseVisualStyleBackColor = true;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(2007, 300);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(102, 25);
            this.descriptionLabel.TabIndex = 55;
            this.descriptionLabel.Text = "Description";
            // 
            // name3Label
            // 
            this.name3Label.AutoSize = true;
            this.name3Label.Location = new System.Drawing.Point(2033, 230);
            this.name3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name3Label.Name = "name3Label";
            this.name3Label.Size = new System.Drawing.Size(59, 25);
            this.name3Label.TabIndex = 54;
            this.name3Label.Text = "Name";
            // 
            // id3label
            // 
            this.id3label.AutoSize = true;
            this.id3label.Location = new System.Drawing.Point(2033, 156);
            this.id3label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id3label.Name = "id3label";
            this.id3label.Size = new System.Drawing.Size(30, 25);
            this.id3label.TabIndex = 53;
            this.id3label.Text = "ID";
            // 
            // CatDescTb
            // 
            this.CatDescTb.Location = new System.Drawing.Point(2125, 286);
            this.CatDescTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatDescTb.Name = "CatDescTb";
            this.CatDescTb.Size = new System.Drawing.Size(141, 31);
            this.CatDescTb.TabIndex = 52;
            // 
            // CatNameTb
            // 
            this.CatNameTb.Location = new System.Drawing.Point(2125, 216);
            this.CatNameTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(141, 31);
            this.CatNameTb.TabIndex = 51;
            // 
            // CatIdTb
            // 
            this.CatIdTb.Location = new System.Drawing.Point(2125, 151);
            this.CatIdTb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatIdTb.Name = "CatIdTb";
            this.CatIdTb.Size = new System.Drawing.Size(141, 31);
            this.CatIdTb.TabIndex = 50;
            // 
            // logOutLabel
            // 
            this.logOutLabel.AutoSize = true;
            this.logOutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutLabel.Location = new System.Drawing.Point(2334, 9);
            this.logOutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Size = new System.Drawing.Size(105, 32);
            this.logOutLabel.TabIndex = 66;
            this.logOutLabel.Text = "Log Out";
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2452, 920);
            this.ControlBox = false;
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.CatDGV);
            this.Controls.Add(this.delete3Button);
            this.Controls.Add(this.edit3Button);
            this.Controls.Add(this.add3Button);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.name3Label);
            this.Controls.Add(this.id3label);
            this.Controls.Add(this.CatDescTb);
            this.Controls.Add(this.CatNameTb);
            this.Controls.Add(this.CatIdTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Categories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label totalLabel;
        private Button searchButton;
        private TextBox searchTextBox;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private Button refreshButton;
        private DataGridView CatDGV;
        private Button delete3Button;
        private Button edit3Button;
        private Button add3Button;
        private Label descriptionLabel;
        private Label name3Label;
        private Label id3label;
        private TextBox CatDescTb;
        private TextBox CatNameTb;
        private TextBox CatIdTb;
        private Label logOutLabel;
    }
}