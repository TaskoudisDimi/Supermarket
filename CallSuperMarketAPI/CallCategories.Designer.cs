namespace CallSuperMarketAPI
{
    partial class CallCategories
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
            this.putButton = new System.Windows.Forms.Button();
            this.DeleteApiButton = new System.Windows.Forms.Button();
            this.PostButton = new System.Windows.Forms.Button();
            this.GetButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.name3Label = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.CatDescTb = new System.Windows.Forms.TextBox();
            this.CatNameTb = new System.Windows.Forms.TextBox();
            this.CatIdTb = new System.Windows.Forms.TextBox();
            this.CatDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // putButton
            // 
            this.putButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.putButton.Location = new System.Drawing.Point(1120, 744);
            this.putButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.putButton.Name = "putButton";
            this.putButton.Size = new System.Drawing.Size(102, 45);
            this.putButton.TabIndex = 134;
            this.putButton.Text = "Put";
            this.putButton.UseVisualStyleBackColor = true;
            this.putButton.Click += new System.EventHandler(this.putButton_Click);
            // 
            // DeleteApiButton
            // 
            this.DeleteApiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DeleteApiButton.Location = new System.Drawing.Point(880, 741);
            this.DeleteApiButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteApiButton.Name = "DeleteApiButton";
            this.DeleteApiButton.Size = new System.Drawing.Size(102, 45);
            this.DeleteApiButton.TabIndex = 133;
            this.DeleteApiButton.Text = "Delete";
            this.DeleteApiButton.UseVisualStyleBackColor = true;
            this.DeleteApiButton.Click += new System.EventHandler(this.DeleteApiButton_Click);
            // 
            // PostButton
            // 
            this.PostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PostButton.Location = new System.Drawing.Point(644, 742);
            this.PostButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(100, 46);
            this.PostButton.TabIndex = 132;
            this.PostButton.Text = "Post";
            this.PostButton.UseVisualStyleBackColor = true;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.GetButton.Location = new System.Drawing.Point(438, 741);
            this.GetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(96, 48);
            this.GetButton.TabIndex = 131;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateLabel.Location = new System.Drawing.Point(1288, 457);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(67, 32);
            this.dateLabel.TabIndex = 142;
            this.dateLabel.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(1442, 457);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(273, 35);
            this.dateTimePicker.TabIndex = 141;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.descriptionLabel.Location = new System.Drawing.Point(1240, 356);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(146, 32);
            this.descriptionLabel.TabIndex = 140;
            this.descriptionLabel.Text = "Description";
            // 
            // name3Label
            // 
            this.name3Label.AutoSize = true;
            this.name3Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.name3Label.Location = new System.Drawing.Point(1274, 263);
            this.name3Label.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.name3Label.Name = "name3Label";
            this.name3Label.Size = new System.Drawing.Size(81, 32);
            this.name3Label.TabIndex = 139;
            this.name3Label.Text = "Name";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.idlabel.Location = new System.Drawing.Point(1287, 180);
            this.idlabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(40, 32);
            this.idlabel.TabIndex = 138;
            this.idlabel.Text = "ID";
            // 
            // CatDescTb
            // 
            this.CatDescTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CatDescTb.Location = new System.Drawing.Point(1442, 348);
            this.CatDescTb.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.CatDescTb.Name = "CatDescTb";
            this.CatDescTb.Size = new System.Drawing.Size(273, 35);
            this.CatDescTb.TabIndex = 137;
            // 
            // CatNameTb
            // 
            this.CatNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CatNameTb.Location = new System.Drawing.Point(1442, 263);
            this.CatNameTb.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.CatNameTb.Name = "CatNameTb";
            this.CatNameTb.Size = new System.Drawing.Size(273, 35);
            this.CatNameTb.TabIndex = 136;
            // 
            // CatIdTb
            // 
            this.CatIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CatIdTb.Location = new System.Drawing.Point(1442, 180);
            this.CatIdTb.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.CatIdTb.Name = "CatIdTb";
            this.CatIdTb.Size = new System.Drawing.Size(273, 35);
            this.CatIdTb.TabIndex = 135;
            // 
            // CatDGV
            // 
            this.CatDGV.AllowUserToAddRows = false;
            this.CatDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CatDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDGV.Location = new System.Drawing.Point(79, 94);
            this.CatDGV.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersWidth = 62;
            this.CatDGV.RowTemplate.Height = 30;
            this.CatDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CatDGV.Size = new System.Drawing.Size(1053, 544);
            this.CatDGV.TabIndex = 143;
            // 
            // CallCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 886);
            this.Controls.Add(this.CatDGV);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.name3Label);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.CatDescTb);
            this.Controls.Add(this.CatNameTb);
            this.Controls.Add(this.CatIdTb);
            this.Controls.Add(this.putButton);
            this.Controls.Add(this.DeleteApiButton);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.GetButton);
            this.Name = "CallCategories";
            this.Text = "CallCategories";
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button putButton;
        private System.Windows.Forms.Button DeleteApiButton;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label name3Label;
        public System.Windows.Forms.Label idlabel;
        public System.Windows.Forms.TextBox CatDescTb;
        public System.Windows.Forms.TextBox CatNameTb;
        public System.Windows.Forms.TextBox CatIdTb;
        private System.Windows.Forms.DataGridView CatDGV;
    }
}