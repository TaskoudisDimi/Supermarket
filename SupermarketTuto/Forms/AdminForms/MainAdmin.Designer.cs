namespace SupermarketTuto.Forms.AdminForms
{
    partial class MainAdmin
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
            this.udpRadioButton = new System.Windows.Forms.RadioButton();
            this.productsButton = new System.Windows.Forms.Button();
            this.tcpRadioButton = new System.Windows.Forms.RadioButton();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.sellersButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sidePanel.Controls.Add(this.udpRadioButton);
            this.sidePanel.Controls.Add(this.productsButton);
            this.sidePanel.Controls.Add(this.tcpRadioButton);
            this.sidePanel.Controls.Add(this.categoriesButton);
            this.sidePanel.Controls.Add(this.sellersButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(180, 690);
            this.sidePanel.TabIndex = 2;
            // 
            // udpRadioButton
            // 
            this.udpRadioButton.AutoSize = true;
            this.udpRadioButton.Location = new System.Drawing.Point(29, 329);
            this.udpRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.udpRadioButton.Name = "udpRadioButton";
            this.udpRadioButton.Size = new System.Drawing.Size(48, 17);
            this.udpRadioButton.TabIndex = 1;
            this.udpRadioButton.TabStop = true;
            this.udpRadioButton.Text = "UDP";
            this.udpRadioButton.UseVisualStyleBackColor = true;
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.productsButton.Location = new System.Drawing.Point(18, 209);
            this.productsButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(125, 43);
            this.productsButton.TabIndex = 3;
            this.productsButton.Text = "Products";
            this.productsButton.UseVisualStyleBackColor = false;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // tcpRadioButton
            // 
            this.tcpRadioButton.AutoSize = true;
            this.tcpRadioButton.Location = new System.Drawing.Point(29, 298);
            this.tcpRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcpRadioButton.Name = "tcpRadioButton";
            this.tcpRadioButton.Size = new System.Drawing.Size(46, 17);
            this.tcpRadioButton.TabIndex = 0;
            this.tcpRadioButton.TabStop = true;
            this.tcpRadioButton.Text = "TCP";
            this.tcpRadioButton.UseVisualStyleBackColor = true;
            // 
            // categoriesButton
            // 
            this.categoriesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoriesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.categoriesButton.Location = new System.Drawing.Point(18, 152);
            this.categoriesButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.categoriesButton.Name = "categoriesButton";
            this.categoriesButton.Size = new System.Drawing.Size(125, 43);
            this.categoriesButton.TabIndex = 2;
            this.categoriesButton.Text = "Categories";
            this.categoriesButton.UseVisualStyleBackColor = false;
            this.categoriesButton.Click += new System.EventHandler(this.categoriesButton_Click);
            // 
            // sellersButton
            // 
            this.sellersButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sellersButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sellersButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sellersButton.Location = new System.Drawing.Point(18, 92);
            this.sellersButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.sellersButton.Name = "sellersButton";
            this.sellersButton.Size = new System.Drawing.Size(125, 43);
            this.sellersButton.TabIndex = 1;
            this.sellersButton.Text = "Sellers";
            this.sellersButton.UseVisualStyleBackColor = false;
            this.sellersButton.Click += new System.EventHandler(this.sellersButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(180, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(1143, 690);
            this.splitContainer1.SplitterDistance = 546;
            this.splitContainer1.TabIndex = 3;
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1323, 690);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.sidePanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainAdmin";
            this.Text = "MainAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainAdmin_FormClosing);
            this.Load += new System.EventHandler(this.MainAdmin_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sidePanel;
        private Button productsButton;
        private Button categoriesButton;
        private Button sellersButton;
        public SplitContainer splitContainer1;
        private RadioButton udpRadioButton;
        private RadioButton tcpRadioButton;
    }
}