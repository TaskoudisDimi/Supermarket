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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.productsButton = new System.Windows.Forms.Button();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.sellersButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.welcome = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            resources.ApplyResources(this.sidePanel, "sidePanel");
            this.sidePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sidePanel.Controls.Add(this.productsButton);
            this.sidePanel.Controls.Add(this.categoriesButton);
            this.sidePanel.Controls.Add(this.sellersButton);
            this.sidePanel.Name = "sidePanel";
            // 
            // productsButton
            // 
            resources.ApplyResources(this.productsButton, "productsButton");
            this.productsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productsButton.Name = "productsButton";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // categoriesButton
            // 
            resources.ApplyResources(this.categoriesButton, "categoriesButton");
            this.categoriesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.UseVisualStyleBackColor = false;
            this.categoriesButton.Click += new System.EventHandler(this.categoriesButton_Click);
            // 
            // sellersButton
            // 
            resources.ApplyResources(this.sellersButton, "sellersButton");
            this.sellersButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sellersButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sellersButton.Name = "sellersButton";
            this.sellersButton.UseVisualStyleBackColor = false;
            this.sellersButton.Click += new System.EventHandler(this.sellersButton_Click);
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Controls.Add(this.languageComboBox);
            this.mainPanel.Controls.Add(this.welcome);
            this.mainPanel.Name = "mainPanel";
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // welcome
            // 
            resources.ApplyResources(this.welcome, "welcome");
            this.welcome.Name = "welcome";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Name = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidePanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sidePanel;
        private Button productsButton;
        private Button categoriesButton;
        private Button sellersButton;
        private Panel mainPanel;
        private Label welcome;
        private ComboBox languageComboBox;
    }
}