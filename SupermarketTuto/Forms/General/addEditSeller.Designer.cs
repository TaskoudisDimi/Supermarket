namespace SupermarketTuto.Forms.General
{
    partial class addEditSeller
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.adressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.password2Label = new System.Windows.Forms.Label();
            this.SellPass = new System.Windows.Forms.TextBox();
            this.phone2Label = new System.Windows.Forms.Label();
            this.age2Label = new System.Windows.Forms.Label();
            this.name2Label = new System.Windows.Forms.Label();
            this.id2label = new System.Windows.Forms.Label();
            this.SellPhone = new System.Windows.Forms.TextBox();
            this.SellAge = new System.Windows.Forms.TextBox();
            this.SellName = new System.Windows.Forms.TextBox();
            this.SellId = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(558, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 589);
            this.panel1.TabIndex = 136;
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.adressLabel.Location = new System.Drawing.Point(34, 585);
            this.adressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(109, 29);
            this.adressLabel.TabIndex = 135;
            this.adressLabel.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(244, 585);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(176, 26);
            this.addressTextBox.TabIndex = 134;
            this.addressTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressTextBox_KeyDown);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateLabel.Location = new System.Drawing.Point(46, 505);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(157, 29);
            this.dateLabel.TabIndex = 133;
            this.dateLabel.Text = "Date of Birth";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(244, 505);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(176, 35);
            this.dateTimePicker.TabIndex = 132;
            // 
            // password2Label
            // 
            this.password2Label.AutoSize = true;
            this.password2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.password2Label.Location = new System.Drawing.Point(45, 412);
            this.password2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password2Label.Name = "password2Label";
            this.password2Label.Size = new System.Drawing.Size(128, 29);
            this.password2Label.TabIndex = 131;
            this.password2Label.Text = "Password";
            // 
            // SellPass
            // 
            this.SellPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SellPass.Location = new System.Drawing.Point(244, 409);
            this.SellPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellPass.Name = "SellPass";
            this.SellPass.Size = new System.Drawing.Size(176, 35);
            this.SellPass.TabIndex = 130;
            // 
            // phone2Label
            // 
            this.phone2Label.AutoSize = true;
            this.phone2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phone2Label.Location = new System.Drawing.Point(45, 331);
            this.phone2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone2Label.Name = "phone2Label";
            this.phone2Label.Size = new System.Drawing.Size(88, 29);
            this.phone2Label.TabIndex = 129;
            this.phone2Label.Text = "Phone";
            // 
            // age2Label
            // 
            this.age2Label.AutoSize = true;
            this.age2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.age2Label.Location = new System.Drawing.Point(60, 237);
            this.age2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.age2Label.Name = "age2Label";
            this.age2Label.Size = new System.Drawing.Size(59, 29);
            this.age2Label.TabIndex = 128;
            this.age2Label.Text = "Age";
            // 
            // name2Label
            // 
            this.name2Label.AutoSize = true;
            this.name2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.name2Label.Location = new System.Drawing.Point(45, 146);
            this.name2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name2Label.Name = "name2Label";
            this.name2Label.Size = new System.Drawing.Size(82, 29);
            this.name2Label.TabIndex = 127;
            this.name2Label.Text = "Name";
            // 
            // id2label
            // 
            this.id2label.AutoSize = true;
            this.id2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.id2label.Location = new System.Drawing.Point(60, 52);
            this.id2label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id2label.Name = "id2label";
            this.id2label.Size = new System.Drawing.Size(38, 29);
            this.id2label.TabIndex = 126;
            this.id2label.Text = "ID";
            // 
            // SellPhone
            // 
            this.SellPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SellPhone.Location = new System.Drawing.Point(244, 326);
            this.SellPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellPhone.Name = "SellPhone";
            this.SellPhone.Size = new System.Drawing.Size(176, 35);
            this.SellPhone.TabIndex = 125;
            // 
            // SellAge
            // 
            this.SellAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SellAge.Location = new System.Drawing.Point(244, 237);
            this.SellAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellAge.Name = "SellAge";
            this.SellAge.Size = new System.Drawing.Size(176, 35);
            this.SellAge.TabIndex = 124;
            // 
            // SellName
            // 
            this.SellName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SellName.Location = new System.Drawing.Point(244, 143);
            this.SellName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellName.Name = "SellName";
            this.SellName.Size = new System.Drawing.Size(176, 35);
            this.SellName.TabIndex = 123;
            // 
            // SellId
            // 
            this.SellId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SellId.Location = new System.Drawing.Point(244, 52);
            this.SellId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SellId.Name = "SellId";
            this.SellId.Size = new System.Drawing.Size(176, 35);
            this.SellId.TabIndex = 122;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editButton.Location = new System.Drawing.Point(243, 720);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(96, 48);
            this.editButton.TabIndex = 138;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(118, 720);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 48);
            this.addButton.TabIndex = 137;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addEditSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 815);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.password2Label);
            this.Controls.Add(this.SellPass);
            this.Controls.Add(this.phone2Label);
            this.Controls.Add(this.age2Label);
            this.Controls.Add(this.name2Label);
            this.Controls.Add(this.id2label);
            this.Controls.Add(this.SellPhone);
            this.Controls.Add(this.SellAge);
            this.Controls.Add(this.SellName);
            this.Controls.Add(this.SellId);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "addEditSeller";
            this.Text = "addSeller";
            this.Load += new System.EventHandler(this.addEditSeller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label adressLabel;
        private Label dateLabel;
        private Label password2Label;
        private Label phone2Label;
        private Label age2Label;
        private Label name2Label;
        private Label id2label;
        private Button editButton;
        private Button addButton;
        public TextBox addressTextBox;
        public DateTimePicker dateTimePicker;
        public TextBox SellPass;
        public TextBox SellPhone;
        public TextBox SellAge;
        public TextBox SellName;
        public TextBox SellId;
    }
}