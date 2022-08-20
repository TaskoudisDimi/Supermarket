namespace SupermarketTuto.Forms
{
    partial class Sellers
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uploadButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.SellDGV = new System.Windows.Forms.DataGridView();
            this.SellPass = new System.Windows.Forms.TextBox();
            this.delete2Button = new System.Windows.Forms.Button();
            this.edit2Button = new System.Windows.Forms.Button();
            this.add2Button = new System.Windows.Forms.Button();
            this.SellPhone = new System.Windows.Forms.TextBox();
            this.SellAge = new System.Windows.Forms.TextBox();
            this.SellName = new System.Windows.Forms.TextBox();
            this.SellId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(19, 670);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 91;
            this.totalLabel.Text = "Total:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(497, 102);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 30);
            this.searchButton.TabIndex = 90;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(28, 104);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(192, 26);
            this.searchTextBox.TabIndex = 89;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDateTimePicker.Location = new System.Drawing.Point(358, 104);
            this.toDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(124, 26);
            this.toDateTimePicker.TabIndex = 87;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateTimePicker.Location = new System.Drawing.Point(256, 104);
            this.fromDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(122, 26);
            this.fromDateTimePicker.TabIndex = 86;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(1658, 365);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 26);
            this.dateTimePicker.TabIndex = 85;
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(1922, 340);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(73, 38);
            this.uploadButton.TabIndex = 84;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(1874, 203);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(159, 118);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 83;
            this.pictureBox.TabStop = false;
            // 
            // SellDGV
            // 
            this.SellDGV.AllowUserToAddRows = false;
            this.SellDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.SellDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SellDGV.Location = new System.Drawing.Point(23, 136);
            this.SellDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SellDGV.Name = "SellDGV";
            this.SellDGV.RowHeadersWidth = 62;
            this.SellDGV.RowTemplate.Height = 30;
            this.SellDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellDGV.Size = new System.Drawing.Size(1338, 516);
            this.SellDGV.TabIndex = 82;
            // 
            // SellPass
            // 
            this.SellPass.Location = new System.Drawing.Point(1658, 328);
            this.SellPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SellPass.Name = "SellPass";
            this.SellPass.Size = new System.Drawing.Size(127, 26);
            this.SellPass.TabIndex = 80;
            // 
            // delete2Button
            // 
            this.delete2Button.Location = new System.Drawing.Point(1688, 447);
            this.delete2Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete2Button.Name = "delete2Button";
            this.delete2Button.Size = new System.Drawing.Size(76, 32);
            this.delete2Button.TabIndex = 79;
            this.delete2Button.Text = "Delete";
            this.delete2Button.UseVisualStyleBackColor = true;
            // 
            // edit2Button
            // 
            this.edit2Button.Location = new System.Drawing.Point(1606, 447);
            this.edit2Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit2Button.Name = "edit2Button";
            this.edit2Button.Size = new System.Drawing.Size(76, 32);
            this.edit2Button.TabIndex = 78;
            this.edit2Button.Text = "Edit";
            this.edit2Button.UseVisualStyleBackColor = true;
            // 
            // add2Button
            // 
            this.add2Button.Location = new System.Drawing.Point(1517, 447);
            this.add2Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add2Button.Name = "add2Button";
            this.add2Button.Size = new System.Drawing.Size(76, 32);
            this.add2Button.TabIndex = 77;
            this.add2Button.Text = "Add";
            this.add2Button.UseVisualStyleBackColor = true;
            // 
            // SellPhone
            // 
            this.SellPhone.Location = new System.Drawing.Point(1658, 300);
            this.SellPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SellPhone.Name = "SellPhone";
            this.SellPhone.Size = new System.Drawing.Size(127, 26);
            this.SellPhone.TabIndex = 72;
            // 
            // SellAge
            // 
            this.SellAge.Location = new System.Drawing.Point(1658, 268);
            this.SellAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SellAge.Name = "SellAge";
            this.SellAge.Size = new System.Drawing.Size(127, 26);
            this.SellAge.TabIndex = 71;
            // 
            // SellName
            // 
            this.SellName.Location = new System.Drawing.Point(1658, 237);
            this.SellName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SellName.Name = "SellName";
            this.SellName.Size = new System.Drawing.Size(127, 26);
            this.SellName.TabIndex = 70;
            // 
            // SellId
            // 
            this.SellId.Location = new System.Drawing.Point(1658, 203);
            this.SellId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SellId.Name = "SellId";
            this.SellId.Size = new System.Drawing.Size(127, 26);
            this.SellId.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1513, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 98;
            this.label1.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1512, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1512, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1522, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 95;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1512, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1522, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 93;
            this.label6.Text = "ID";
            // 
            // Sellers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2095, 1054);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.SellDGV);
            this.Controls.Add(this.SellPass);
            this.Controls.Add(this.delete2Button);
            this.Controls.Add(this.edit2Button);
            this.Controls.Add(this.add2Button);
            this.Controls.Add(this.SellPhone);
            this.Controls.Add(this.SellAge);
            this.Controls.Add(this.SellName);
            this.Controls.Add(this.SellId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sellers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sellers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label totalLabel;
        private Button searchButton;
        private TextBox searchTextBox;
        private DateTimePicker toDateTimePicker;
        private DateTimePicker fromDateTimePicker;
        private DateTimePicker dateTimePicker;
        private Button uploadButton;
        private PictureBox pictureBox;
        private DataGridView SellDGV;
        private TextBox SellPass;
        private Button delete2Button;
        private Button edit2Button;
        private Button add2Button;
        private TextBox SellPhone;
        private TextBox SellAge;
        private TextBox SellName;
        private TextBox SellId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}