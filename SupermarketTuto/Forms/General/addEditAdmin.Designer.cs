namespace SupermarketTuto.Forms.General
{
    partial class addEditAdmin
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
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.name3Label = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.AdminPassTb = new System.Windows.Forms.TextBox();
            this.AdminNameTb = new System.Windows.Forms.TextBox();
            this.AdminIdTb = new System.Windows.Forms.TextBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.superAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editButton.Location = new System.Drawing.Point(230, 316);
            this.editButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(73, 40);
            this.editButton.TabIndex = 109;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addButton.Location = new System.Drawing.Point(60, 316);
            this.addButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 40);
            this.addButton.TabIndex = 108;
            this.addButton.Text = "Create New";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.descriptionLabel.Location = new System.Drawing.Point(26, 143);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(82, 21);
            this.descriptionLabel.TabIndex = 105;
            this.descriptionLabel.Text = "Password";
            // 
            // name3Label
            // 
            this.name3Label.AutoSize = true;
            this.name3Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.name3Label.Location = new System.Drawing.Point(48, 83);
            this.name3Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.name3Label.Name = "name3Label";
            this.name3Label.Size = new System.Drawing.Size(87, 21);
            this.name3Label.TabIndex = 104;
            this.name3Label.Text = "Username";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.idlabel.Location = new System.Drawing.Point(57, 29);
            this.idlabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(27, 21);
            this.idlabel.TabIndex = 103;
            this.idlabel.Text = "ID";
            // 
            // AdminPassTb
            // 
            this.AdminPassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AdminPassTb.Location = new System.Drawing.Point(160, 138);
            this.AdminPassTb.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.AdminPassTb.Name = "AdminPassTb";
            this.AdminPassTb.Size = new System.Drawing.Size(183, 26);
            this.AdminPassTb.TabIndex = 102;
            // 
            // AdminNameTb
            // 
            this.AdminNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AdminNameTb.Location = new System.Drawing.Point(160, 83);
            this.AdminNameTb.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.AdminNameTb.Name = "AdminNameTb";
            this.AdminNameTb.Size = new System.Drawing.Size(183, 26);
            this.AdminNameTb.TabIndex = 101;
            // 
            // AdminIdTb
            // 
            this.AdminIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AdminIdTb.Location = new System.Drawing.Point(160, 29);
            this.AdminIdTb.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.AdminIdTb.Name = "AdminIdTb";
            this.AdminIdTb.Size = new System.Drawing.Size(183, 26);
            this.AdminIdTb.TabIndex = 100;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(166, 203);
            this.activeCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.activeCheckBox.TabIndex = 142;
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(35, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 141;
            this.label1.Text = "Active";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(35, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 143;
            this.label2.Text = "Super Admin";
            // 
            // superAdminCheckBox
            // 
            this.superAdminCheckBox.AutoSize = true;
            this.superAdminCheckBox.Location = new System.Drawing.Point(166, 250);
            this.superAdminCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.superAdminCheckBox.Name = "superAdminCheckBox";
            this.superAdminCheckBox.Size = new System.Drawing.Size(15, 14);
            this.superAdminCheckBox.TabIndex = 144;
            this.superAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // addEditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 388);
            this.Controls.Add(this.superAdminCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.name3Label);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.AdminPassTb);
            this.Controls.Add(this.AdminNameTb);
            this.Controls.Add(this.AdminIdTb);
            this.Name = "addEditAdmin";
            this.Text = "addEditAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button editButton;
        public Button addButton;
        private Label descriptionLabel;
        private Label name3Label;
        public Label idlabel;
        public TextBox AdminPassTb;
        public TextBox AdminNameTb;
        public TextBox AdminIdTb;
        public CheckBox activeCheckBox;
        private Label label1;
        private Label label2;
        public CheckBox superAdminCheckBox;
    }
}