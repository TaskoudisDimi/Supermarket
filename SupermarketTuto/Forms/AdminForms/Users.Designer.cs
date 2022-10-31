namespace SupermarketTuto.Forms
{
    partial class Users
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
            this.usersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(15, 89);
            this.usersDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersWidth = 62;
            this.usersDataGridView.RowTemplate.Height = 25;
            this.usersDataGridView.Size = new System.Drawing.Size(998, 495);
            this.usersDataGridView.TabIndex = 0;
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usersLabel.Location = new System.Drawing.Point(15, 12);
            this.usersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(162, 32);
            this.usersLabel.TabIndex = 1;
            this.usersLabel.Text = "Table of Users";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 695);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.usersDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView usersDataGridView;
        private Label usersLabel;
    }
}