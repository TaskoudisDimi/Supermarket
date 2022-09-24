namespace SupermarketTuto.Forms
{
    partial class Seller
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
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.phone2Label = new System.Windows.Forms.Label();
            this.age2Label = new System.Windows.Forms.Label();
            this.name2Label = new System.Windows.Forms.Label();
            this.id2label = new System.Windows.Forms.Label();
            this.SellPhone = new System.Windows.Forms.TextBox();
            this.SellAge = new System.Windows.Forms.TextBox();
            this.SellName = new System.Windows.Forms.TextBox();
            this.SellId = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.totalLabel.Location = new System.Drawing.Point(9, 660);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 114;
            this.totalLabel.Text = "Total:";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchButton.Location = new System.Drawing.Point(199, 203);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(87, 23);
            this.searchButton.TabIndex = 113;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchTextBox.Location = new System.Drawing.Point(7, 205);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(179, 26);
            this.searchTextBox.TabIndex = 112;
            this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTextBox_KeyPress);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateLabel.Location = new System.Drawing.Point(930, 553);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(112, 20);
            this.dateLabel.TabIndex = 111;
            this.dateLabel.Text = "Date of Birth";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(529, 203);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(117, 26);
            this.toDateTimePicker.TabIndex = 110;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(399, 203);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(119, 26);
            this.fromDateTimePicker.TabIndex = 109;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged_1);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(1062, 553);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(119, 26);
            this.dateTimePicker.TabIndex = 108;
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.uploadButton.Location = new System.Drawing.Point(1313, 450);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(83, 31);
            this.uploadButton.TabIndex = 107;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click_1);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(1313, 253);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(165, 122);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 106;
            this.pictureBox.TabStop = false;
            // 
            // SellDGV
            // 
            this.SellDGV.AllowUserToAddRows = false;
            this.SellDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.SellDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellDGV.Location = new System.Drawing.Point(9, 253);
            this.SellDGV.Name = "SellDGV";
            this.SellDGV.RowHeadersWidth = 62;
            this.SellDGV.RowTemplate.Height = 30;
            this.SellDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellDGV.Size = new System.Drawing.Size(873, 389);
            this.SellDGV.TabIndex = 105;
            this.SellDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellDGV_CellClick);
            this.SellDGV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SellDGV_MouseDown);
            // 
            // password2Label
            // 
            this.password2Label.AutoSize = true;
            this.password2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.password2Label.Location = new System.Drawing.Point(929, 493);
            this.password2Label.Name = "password2Label";
            this.password2Label.Size = new System.Drawing.Size(86, 20);
            this.password2Label.TabIndex = 104;
            this.password2Label.Text = "Password";
            // 
            // SellPass
            // 
            this.SellPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SellPass.Location = new System.Drawing.Point(1062, 491);
            this.SellPass.Name = "SellPass";
            this.SellPass.Size = new System.Drawing.Size(119, 26);
            this.SellPass.TabIndex = 103;
            // 
            // delete2Button
            // 
            this.delete2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.delete2Button.Location = new System.Drawing.Point(1115, 669);
            this.delete2Button.Name = "delete2Button";
            this.delete2Button.Size = new System.Drawing.Size(64, 31);
            this.delete2Button.TabIndex = 102;
            this.delete2Button.Text = "Delete";
            this.delete2Button.UseVisualStyleBackColor = true;
            this.delete2Button.Click += new System.EventHandler(this.delete2Button_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editButton.Location = new System.Drawing.Point(1037, 669);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(64, 31);
            this.editButton.TabIndex = 101;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click_1);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(954, 669);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 31);
            this.addButton.TabIndex = 100;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.add2Button_Click);
            // 
            // phone2Label
            // 
            this.phone2Label.AutoSize = true;
            this.phone2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phone2Label.Location = new System.Drawing.Point(929, 440);
            this.phone2Label.Name = "phone2Label";
            this.phone2Label.Size = new System.Drawing.Size(60, 20);
            this.phone2Label.TabIndex = 99;
            this.phone2Label.Text = "Phone";
            // 
            // age2Label
            // 
            this.age2Label.AutoSize = true;
            this.age2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.age2Label.Location = new System.Drawing.Point(939, 379);
            this.age2Label.Name = "age2Label";
            this.age2Label.Size = new System.Drawing.Size(41, 20);
            this.age2Label.TabIndex = 98;
            this.age2Label.Text = "Age";
            // 
            // name2Label
            // 
            this.name2Label.AutoSize = true;
            this.name2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.name2Label.Location = new System.Drawing.Point(929, 320);
            this.name2Label.Name = "name2Label";
            this.name2Label.Size = new System.Drawing.Size(55, 20);
            this.name2Label.TabIndex = 97;
            this.name2Label.Text = "Name";
            // 
            // id2label
            // 
            this.id2label.AutoSize = true;
            this.id2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.id2label.Location = new System.Drawing.Point(939, 259);
            this.id2label.Name = "id2label";
            this.id2label.Size = new System.Drawing.Size(28, 20);
            this.id2label.TabIndex = 96;
            this.id2label.Text = "ID";
            // 
            // SellPhone
            // 
            this.SellPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SellPhone.Location = new System.Drawing.Point(1062, 437);
            this.SellPhone.Name = "SellPhone";
            this.SellPhone.Size = new System.Drawing.Size(119, 26);
            this.SellPhone.TabIndex = 95;
            // 
            // SellAge
            // 
            this.SellAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SellAge.Location = new System.Drawing.Point(1062, 379);
            this.SellAge.Name = "SellAge";
            this.SellAge.Size = new System.Drawing.Size(119, 26);
            this.SellAge.TabIndex = 94;
            // 
            // SellName
            // 
            this.SellName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SellName.Location = new System.Drawing.Point(1062, 318);
            this.SellName.Name = "SellName";
            this.SellName.Size = new System.Drawing.Size(119, 26);
            this.SellName.TabIndex = 93;
            // 
            // SellId
            // 
            this.SellId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SellId.Location = new System.Drawing.Point(1062, 259);
            this.SellId.Name = "SellId";
            this.SellId.Size = new System.Drawing.Size(119, 26);
            this.SellId.TabIndex = 92;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.refreshButton.Location = new System.Drawing.Point(784, 213);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(87, 23);
            this.refreshButton.TabIndex = 115;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // imageTextBox
            // 
            this.imageTextBox.Location = new System.Drawing.Point(1313, 413);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(227, 20);
            this.imageTextBox.TabIndex = 116;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(1313, 493);
            this.showButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(60, 33);
            this.showButton.TabIndex = 117;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1646, 705);
            this.ControlBox = false;
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.refreshButton);
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
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.phone2Label);
            this.Controls.Add(this.age2Label);
            this.Controls.Add(this.name2Label);
            this.Controls.Add(this.id2label);
            this.Controls.Add(this.SellPhone);
            this.Controls.Add(this.SellAge);
            this.Controls.Add(this.SellName);
            this.Controls.Add(this.SellId);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Seller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Seller_Load);
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
        private Button editButton;
        private Button addButton;
        private Label phone2Label;
        private Label age2Label;
        private Label name2Label;
        private Label id2label;
        private TextBox SellPhone;
        private TextBox SellAge;
        private TextBox SellName;
        private TextBox SellId;
        private Button refreshButton;
        private TextBox imageTextBox;
        private Button showButton;
    }
}