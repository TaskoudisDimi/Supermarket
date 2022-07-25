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
            this.totalLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(583, 491);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(35, 15);
            this.totalLabel.TabIndex = 68;
            this.totalLabel.Text = "Total:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(739, 72);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 67;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(583, 72);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(150, 23);
            this.searchTextBox.TabIndex = 66;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(96, 310);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(73, 15);
            this.dateLabel.TabIndex = 65;
            this.dateLabel.Text = "Date of Birth";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(950, 72);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(97, 23);
            this.toDateTimePicker.TabIndex = 64;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(836, 73);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(96, 23);
            this.fromDateTimePicker.TabIndex = 63;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(192, 304);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(95, 23);
            this.dateTimePicker.TabIndex = 62;
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(448, 215);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(57, 29);
            this.uploadButton.TabIndex = 61;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(420, 109);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(124, 88);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 60;
            this.pictureBox.TabStop = false;
            // 
            // SellDGV
            // 
            this.SellDGV.AllowUserToAddRows = false;
            this.SellDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.SellDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellDGV.Location = new System.Drawing.Point(583, 101);
            this.SellDGV.Name = "SellDGV";
            this.SellDGV.RowHeadersWidth = 62;
            this.SellDGV.RowTemplate.Height = 30;
            this.SellDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellDGV.Size = new System.Drawing.Size(464, 387);
            this.SellDGV.TabIndex = 59;
            // 
            // password2Label
            // 
            this.password2Label.AutoSize = true;
            this.password2Label.Location = new System.Drawing.Point(95, 261);
            this.password2Label.Name = "password2Label";
            this.password2Label.Size = new System.Drawing.Size(57, 15);
            this.password2Label.TabIndex = 58;
            this.password2Label.Text = "Password";
            // 
            // SellPass
            // 
            this.SellPass.Location = new System.Drawing.Point(192, 258);
            this.SellPass.Name = "SellPass";
            this.SellPass.Size = new System.Drawing.Size(100, 23);
            this.SellPass.TabIndex = 57;
            // 
            // delete2Button
            // 
            this.delete2Button.Location = new System.Drawing.Point(266, 401);
            this.delete2Button.Name = "delete2Button";
            this.delete2Button.Size = new System.Drawing.Size(75, 23);
            this.delete2Button.TabIndex = 56;
            this.delete2Button.Text = "Delete";
            this.delete2Button.UseVisualStyleBackColor = true;
            // 
            // edit2Button
            // 
            this.edit2Button.Location = new System.Drawing.Point(174, 401);
            this.edit2Button.Name = "edit2Button";
            this.edit2Button.Size = new System.Drawing.Size(75, 23);
            this.edit2Button.TabIndex = 55;
            this.edit2Button.Text = "Edit";
            this.edit2Button.UseVisualStyleBackColor = true;
            // 
            // add2Button
            // 
            this.add2Button.Location = new System.Drawing.Point(78, 401);
            this.add2Button.Name = "add2Button";
            this.add2Button.Size = new System.Drawing.Size(75, 23);
            this.add2Button.TabIndex = 54;
            this.add2Button.Text = "Add";
            this.add2Button.UseVisualStyleBackColor = true;
            // 
            // phone2Label
            // 
            this.phone2Label.AutoSize = true;
            this.phone2Label.Location = new System.Drawing.Point(95, 225);
            this.phone2Label.Name = "phone2Label";
            this.phone2Label.Size = new System.Drawing.Size(41, 15);
            this.phone2Label.TabIndex = 53;
            this.phone2Label.Text = "Phone";
            // 
            // age2Label
            // 
            this.age2Label.AutoSize = true;
            this.age2Label.Location = new System.Drawing.Point(106, 183);
            this.age2Label.Name = "age2Label";
            this.age2Label.Size = new System.Drawing.Size(28, 15);
            this.age2Label.TabIndex = 52;
            this.age2Label.Text = "Age";
            // 
            // name2Label
            // 
            this.name2Label.AutoSize = true;
            this.name2Label.Location = new System.Drawing.Point(95, 147);
            this.name2Label.Name = "name2Label";
            this.name2Label.Size = new System.Drawing.Size(39, 15);
            this.name2Label.TabIndex = 51;
            this.name2Label.Text = "Name";
            // 
            // id2label
            // 
            this.id2label.AutoSize = true;
            this.id2label.Location = new System.Drawing.Point(106, 101);
            this.id2label.Name = "id2label";
            this.id2label.Size = new System.Drawing.Size(18, 15);
            this.id2label.TabIndex = 50;
            this.id2label.Text = "ID";
            // 
            // SellPhone
            // 
            this.SellPhone.Location = new System.Drawing.Point(192, 222);
            this.SellPhone.Name = "SellPhone";
            this.SellPhone.Size = new System.Drawing.Size(100, 23);
            this.SellPhone.TabIndex = 49;
            // 
            // SellAge
            // 
            this.SellAge.Location = new System.Drawing.Point(192, 183);
            this.SellAge.Name = "SellAge";
            this.SellAge.Size = new System.Drawing.Size(100, 23);
            this.SellAge.TabIndex = 48;
            // 
            // SellName
            // 
            this.SellName.Location = new System.Drawing.Point(192, 144);
            this.SellName.Name = "SellName";
            this.SellName.Size = new System.Drawing.Size(100, 23);
            this.SellName.TabIndex = 47;
            // 
            // SellId
            // 
            this.SellId.Location = new System.Drawing.Point(192, 101);
            this.SellId.Name = "SellId";
            this.SellId.Size = new System.Drawing.Size(100, 23);
            this.SellId.TabIndex = 46;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 579);
            this.ControlBox = false;
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.SellDGV);
            this.Controls.Add(this.password2Label);
            this.Controls.Add(this.SellPass);
            this.Controls.Add(this.delete2Button);
            this.Controls.Add(this.edit2Button);
            this.Controls.Add(this.add2Button);
            this.Controls.Add(this.phone2Label);
            this.Controls.Add(this.age2Label);
            this.Controls.Add(this.name2Label);
            this.Controls.Add(this.id2label);
            this.Controls.Add(this.SellPhone);
            this.Controls.Add(this.SellAge);
            this.Controls.Add(this.SellName);
            this.Controls.Add(this.SellId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sellers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SellerForm_FormClosing);
            this.Load += new System.EventHandler(this.SellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label totalLabel;
        private Button searchButton;
        private TextBox searchTextBox;
        private Label dateLabel;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private DateTimePicker dateTimePicker;
        private Button uploadButton;
        private PictureBox pictureBox;
        private DataGridView SellDGV;
        private Label password2Label;
        private TextBox SellPass;
        private Button delete2Button;
        private Button edit2Button;
        private Button add2Button;
        private Label phone2Label;
        private Label age2Label;
        private Label name2Label;
        private Label id2label;
        private TextBox SellPhone;
        private TextBox SellAge;
        private TextBox SellName;
        private TextBox SellId;
    }
}