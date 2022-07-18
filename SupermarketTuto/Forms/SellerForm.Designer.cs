namespace SupermarketTuto
{
    partial class SellerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            this.manageSellersPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uploadButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.SellDGV = new System.Windows.Forms.DataGridView();
            this.password2Label = new System.Windows.Forms.Label();
            this.SellPass = new System.Windows.Forms.TextBox();
            this.delete2Button = new System.Windows.Forms.Button();
            this.edit2Button = new System.Windows.Forms.Button();
            this.add2Button = new System.Windows.Forms.Button();
            this.phone2Label = new System.Windows.Forms.Label();
            this.age2Label = new System.Windows.Forms.Label();
            this.name2Label = new System.Windows.Forms.Label();
            this.id2label = new System.Windows.Forms.Label();
            this.SellPhone = new System.Windows.Forms.TextBox();
            this.SellAge = new System.Windows.Forms.TextBox();
            this.SellName = new System.Windows.Forms.TextBox();
            this.SellId = new System.Windows.Forms.TextBox();
            this.manageSellersLabel = new System.Windows.Forms.Label();
            this.logOutLabel = new System.Windows.Forms.Label();
            this.products2Button = new System.Windows.Forms.Button();
            this.categories2Button = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.manageSellersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // manageSellersPanel
            // 
            this.manageSellersPanel.BackColor = System.Drawing.Color.Silver;
            this.manageSellersPanel.Controls.Add(this.totalLabel);
            this.manageSellersPanel.Controls.Add(this.searchButton);
            this.manageSellersPanel.Controls.Add(this.searchTextBox);
            this.manageSellersPanel.Controls.Add(this.dateLabel);
            this.manageSellersPanel.Controls.Add(this.toDateTimePicker);
            this.manageSellersPanel.Controls.Add(this.fromDateTimePicker);
            this.manageSellersPanel.Controls.Add(this.dateTimePicker);
            this.manageSellersPanel.Controls.Add(this.uploadButton);
            this.manageSellersPanel.Controls.Add(this.pictureBox);
            this.manageSellersPanel.Controls.Add(this.SellDGV);
            this.manageSellersPanel.Controls.Add(this.password2Label);
            this.manageSellersPanel.Controls.Add(this.SellPass);
            this.manageSellersPanel.Controls.Add(this.delete2Button);
            this.manageSellersPanel.Controls.Add(this.edit2Button);
            this.manageSellersPanel.Controls.Add(this.add2Button);
            this.manageSellersPanel.Controls.Add(this.phone2Label);
            this.manageSellersPanel.Controls.Add(this.age2Label);
            this.manageSellersPanel.Controls.Add(this.name2Label);
            this.manageSellersPanel.Controls.Add(this.id2label);
            this.manageSellersPanel.Controls.Add(this.SellPhone);
            this.manageSellersPanel.Controls.Add(this.SellAge);
            this.manageSellersPanel.Controls.Add(this.SellName);
            this.manageSellersPanel.Controls.Add(this.SellId);
            this.manageSellersPanel.Controls.Add(this.manageSellersLabel);
            this.manageSellersPanel.Location = new System.Drawing.Point(134, 47);
            this.manageSellersPanel.Name = "manageSellersPanel";
            this.manageSellersPanel.Size = new System.Drawing.Size(981, 520);
            this.manageSellersPanel.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(661, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 44;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(505, 81);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(150, 23);
            this.searchTextBox.TabIndex = 43;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(18, 319);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(73, 15);
            this.dateLabel.TabIndex = 25;
            this.dateLabel.Text = "Date of Birth";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(872, 81);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(97, 23);
            this.toDateTimePicker.TabIndex = 24;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.todateTimePicker_ValueChanged);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(758, 82);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(96, 23);
            this.fromDateTimePicker.TabIndex = 23;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.dataDateTimePicker_ValueChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(114, 313);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(95, 23);
            this.dateTimePicker.TabIndex = 19;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(370, 224);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(57, 29);
            this.uploadButton.TabIndex = 18;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(342, 118);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(124, 88);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // SellDGV
            // 
            this.SellDGV.AllowUserToAddRows = false;
            this.SellDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.SellDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellDGV.Location = new System.Drawing.Point(505, 110);
            this.SellDGV.Name = "SellDGV";
            this.SellDGV.RowHeadersWidth = 62;
            this.SellDGV.RowTemplate.Height = 30;
            this.SellDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellDGV.Size = new System.Drawing.Size(464, 387);
            this.SellDGV.TabIndex = 16;
            this.SellDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellDGV_CellClick);
            this.SellDGV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SellDGV_MouseDown);
            // 
            // password2Label
            // 
            this.password2Label.AutoSize = true;
            this.password2Label.Location = new System.Drawing.Point(17, 270);
            this.password2Label.Name = "password2Label";
            this.password2Label.Size = new System.Drawing.Size(57, 15);
            this.password2Label.TabIndex = 14;
            this.password2Label.Text = "Password";
            // 
            // SellPass
            // 
            this.SellPass.Location = new System.Drawing.Point(114, 267);
            this.SellPass.Name = "SellPass";
            this.SellPass.Size = new System.Drawing.Size(100, 23);
            this.SellPass.TabIndex = 13;
            // 
            // delete2Button
            // 
            this.delete2Button.Location = new System.Drawing.Point(188, 410);
            this.delete2Button.Name = "delete2Button";
            this.delete2Button.Size = new System.Drawing.Size(75, 23);
            this.delete2Button.TabIndex = 12;
            this.delete2Button.Text = "Delete";
            this.delete2Button.UseVisualStyleBackColor = true;
            this.delete2Button.Click += new System.EventHandler(this.delete2Button_Click);
            // 
            // edit2Button
            // 
            this.edit2Button.Location = new System.Drawing.Point(96, 410);
            this.edit2Button.Name = "edit2Button";
            this.edit2Button.Size = new System.Drawing.Size(75, 23);
            this.edit2Button.TabIndex = 11;
            this.edit2Button.Text = "Edit";
            this.edit2Button.UseVisualStyleBackColor = true;
            this.edit2Button.Click += new System.EventHandler(this.edit2Button_Click);
            // 
            // add2Button
            // 
            this.add2Button.Location = new System.Drawing.Point(0, 410);
            this.add2Button.Name = "add2Button";
            this.add2Button.Size = new System.Drawing.Size(75, 23);
            this.add2Button.TabIndex = 10;
            this.add2Button.Text = "Add";
            this.add2Button.UseVisualStyleBackColor = true;
            this.add2Button.Click += new System.EventHandler(this.add2Button_Click);
            // 
            // phone2Label
            // 
            this.phone2Label.AutoSize = true;
            this.phone2Label.Location = new System.Drawing.Point(17, 234);
            this.phone2Label.Name = "phone2Label";
            this.phone2Label.Size = new System.Drawing.Size(41, 15);
            this.phone2Label.TabIndex = 9;
            this.phone2Label.Text = "Phone";
            // 
            // age2Label
            // 
            this.age2Label.AutoSize = true;
            this.age2Label.Location = new System.Drawing.Point(28, 192);
            this.age2Label.Name = "age2Label";
            this.age2Label.Size = new System.Drawing.Size(28, 15);
            this.age2Label.TabIndex = 8;
            this.age2Label.Text = "Age";
            // 
            // name2Label
            // 
            this.name2Label.AutoSize = true;
            this.name2Label.Location = new System.Drawing.Point(17, 156);
            this.name2Label.Name = "name2Label";
            this.name2Label.Size = new System.Drawing.Size(39, 15);
            this.name2Label.TabIndex = 7;
            this.name2Label.Text = "Name";
            // 
            // id2label
            // 
            this.id2label.AutoSize = true;
            this.id2label.Location = new System.Drawing.Point(28, 110);
            this.id2label.Name = "id2label";
            this.id2label.Size = new System.Drawing.Size(18, 15);
            this.id2label.TabIndex = 6;
            this.id2label.Text = "ID";
            // 
            // SellPhone
            // 
            this.SellPhone.Location = new System.Drawing.Point(114, 231);
            this.SellPhone.Name = "SellPhone";
            this.SellPhone.Size = new System.Drawing.Size(100, 23);
            this.SellPhone.TabIndex = 5;
            // 
            // SellAge
            // 
            this.SellAge.Location = new System.Drawing.Point(114, 192);
            this.SellAge.Name = "SellAge";
            this.SellAge.Size = new System.Drawing.Size(100, 23);
            this.SellAge.TabIndex = 4;
            // 
            // SellName
            // 
            this.SellName.Location = new System.Drawing.Point(114, 153);
            this.SellName.Name = "SellName";
            this.SellName.Size = new System.Drawing.Size(100, 23);
            this.SellName.TabIndex = 3;
            // 
            // SellId
            // 
            this.SellId.Location = new System.Drawing.Point(114, 110);
            this.SellId.Name = "SellId";
            this.SellId.Size = new System.Drawing.Size(100, 23);
            this.SellId.TabIndex = 2;
            // 
            // manageSellersLabel
            // 
            this.manageSellersLabel.AutoSize = true;
            this.manageSellersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageSellersLabel.Location = new System.Drawing.Point(246, 0);
            this.manageSellersLabel.Name = "manageSellersLabel";
            this.manageSellersLabel.Size = new System.Drawing.Size(187, 32);
            this.manageSellersLabel.TabIndex = 1;
            this.manageSellersLabel.Text = "Manage Sellers";
            // 
            // logOutLabel
            // 
            this.logOutLabel.AutoSize = true;
            this.logOutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logOutLabel.Location = new System.Drawing.Point(681, 17);
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Size = new System.Drawing.Size(70, 21);
            this.logOutLabel.TabIndex = 40;
            this.logOutLabel.Text = "Log Out";
            this.logOutLabel.Click += new System.EventHandler(this.logOutLabel_Click);
            // 
            // products2Button
            // 
            this.products2Button.FlatAppearance.BorderSize = 0;
            this.products2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products2Button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.products2Button.Location = new System.Drawing.Point(3, 118);
            this.products2Button.Name = "products2Button";
            this.products2Button.Size = new System.Drawing.Size(105, 41);
            this.products2Button.TabIndex = 13;
            this.products2Button.Text = "Products";
            this.products2Button.UseVisualStyleBackColor = true;
            this.products2Button.Click += new System.EventHandler(this.products2Button_Click);
            // 
            // categories2Button
            // 
            this.categories2Button.FlatAppearance.BorderSize = 0;
            this.categories2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categories2Button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categories2Button.Location = new System.Drawing.Point(3, 180);
            this.categories2Button.Name = "categories2Button";
            this.categories2Button.Size = new System.Drawing.Size(125, 43);
            this.categories2Button.TabIndex = 14;
            this.categories2Button.Text = "Categories";
            this.categories2Button.UseVisualStyleBackColor = true;
            this.categories2Button.Click += new System.EventHandler(this.categories2Button_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(505, 500);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(35, 15);
            this.totalLabel.TabIndex = 45;
            this.totalLabel.Text = "Total:";
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 579);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.categories2Button);
            this.Controls.Add(this.products2Button);
            this.Controls.Add(this.manageSellersPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellerForm_FormClosing);
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.manageSellersPanel.ResumeLayout(false);
            this.manageSellersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel manageSellersPanel;
        private Label manageSellersLabel;
        private TextBox SellPhone;
        private TextBox SellAge;
        private TextBox SellName;
        private TextBox SellId;
        private Label phone2Label;
        private Label age2Label;
        private Label name2Label;
        private Label id2label;
        private Button delete2Button;
        private Button edit2Button;
        private Button add2Button;
        private Button products2Button;
        private Button categories2Button;
        private Label password2Label;
        private TextBox SellPass;
        private DataGridView SellDGV;
        private Label logOutLabel;
        private PictureBox pictureBox;
        private Button uploadButton;
        private DateTimePicker dateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private DateTimePicker toDateTimePicker;
        private Label dateLabel;
        private Button searchButton;
        private TextBox searchTextBox;
        private Label totalLabel;
    }
}