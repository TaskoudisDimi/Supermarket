namespace SupermarketTuto.Forms
{
    partial class Main
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.productsButton = new System.Windows.Forms.Button();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.sellersButton = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sidePanel.Controls.Add(this.productsButton);
            this.sidePanel.Controls.Add(this.categoriesButton);
            this.sidePanel.Controls.Add(this.sellersButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(270, 1269);
            this.sidePanel.TabIndex = 1;
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productsButton.Location = new System.Drawing.Point(27, 322);
            this.productsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(188, 66);
            this.productsButton.TabIndex = 3;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // categoriesButton
            // 
            this.categoriesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoriesButton.Location = new System.Drawing.Point(27, 234);
            this.categoriesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(188, 66);
            this.categoriesButton.TabIndex = 2;
            this.categoriesButton.Text = "Categories";
            this.categoriesButton.UseVisualStyleBackColor = false;
            this.categoriesButton.Click += new System.EventHandler(this.categoriesButton_Click);
            // 
            // sellersButton
            // 
            this.sellersButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sellersButton.Location = new System.Drawing.Point(27, 142);
            this.sellersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sellersButton.Name = "sellersButton";
            this.sellersButton.Size = new System.Drawing.Size(188, 66);
            this.sellersButton.TabIndex = 1;
            this.sellersButton.Text = "Sellers";
            this.sellersButton.UseVisualStyleBackColor = false;
            this.sellersButton.Click += new System.EventHandler(this.sellersButton_Click);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(1747, 19);
            this.languageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(81, 20);
            this.languageLabel.TabIndex = 8;
            this.languageLabel.Text = "Language";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(1868, 13);
            this.languageComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(107, 28);
            this.languageComboBox.TabIndex = 7;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(270, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(2104, 1269);
            this.mainPanel.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2374, 1269);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.sidePanel);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel sidePanel;
        private Button productsButton;
        private Button categoriesButton;
        private Button sellersButton;
        private Label languageLabel;
        private ComboBox languageComboBox;
        private Panel mainPanel;
    }
}