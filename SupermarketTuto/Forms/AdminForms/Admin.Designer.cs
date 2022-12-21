namespace SupermarketTuto.Forms
{
    partial class Admin
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
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.adminsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(14, 69);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersWidth = 62;
            this.usersDataGridView.RowTemplate.Height = 25;
            this.usersDataGridView.Size = new System.Drawing.Size(861, 454);
            this.usersDataGridView.TabIndex = 0;
            this.usersDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.usersDataGridView_CellFormatting);
            // 
            // adminsLabel
            // 
            this.adminsLabel.AutoSize = true;
            this.adminsLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.adminsLabel.Location = new System.Drawing.Point(10, 8);
            this.adminsLabel.Name = "adminsLabel";
            this.adminsLabel.Size = new System.Drawing.Size(142, 21);
            this.adminsLabel.TabIndex = 1;
            this.adminsLabel.Text = "Table of All Admins";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 538);
            this.Controls.Add(this.adminsLabel);
            this.Controls.Add(this.usersDataGridView);
            this.Name = "Admin";
            this.Text = "Admins";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView usersDataGridView;
        private Label adminsLabel;
    }
}