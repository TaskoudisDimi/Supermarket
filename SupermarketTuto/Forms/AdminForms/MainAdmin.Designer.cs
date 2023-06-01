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
            this.productsButton = new System.Windows.Forms.Button();
            this.categoriesButton = new System.Windows.Forms.Button();
            this.sellersButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tcpRadioButton = new System.Windows.Forms.RadioButton();
            this.udpRadioButton = new System.Windows.Forms.RadioButton();
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
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(270, 1062);
            this.sidePanel.TabIndex = 2;
            // 
            // productsButton
            // 
            this.productsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.categoriesButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.sellersButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sellersButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sellersButton.Location = new System.Drawing.Point(27, 142);
            this.sellersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sellersButton.Name = "sellersButton";
            this.sellersButton.Size = new System.Drawing.Size(188, 66);
            this.sellersButton.TabIndex = 1;
            this.sellersButton.Text = "Sellers";
            this.sellersButton.UseVisualStyleBackColor = false;
            this.sellersButton.Click += new System.EventHandler(this.sellersButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(270, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(1714, 1062);
            this.splitContainer1.SplitterDistance = 546;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 3;
            // 
            // tcpRadioButton
            // 
            this.tcpRadioButton.AutoSize = true;
            this.tcpRadioButton.Location = new System.Drawing.Point(43, 459);
            this.tcpRadioButton.Name = "tcpRadioButton";
            this.tcpRadioButton.Size = new System.Drawing.Size(64, 24);
            this.tcpRadioButton.TabIndex = 0;
            this.tcpRadioButton.TabStop = true;
            this.tcpRadioButton.Text = "TCP";
            this.tcpRadioButton.UseVisualStyleBackColor = true;
            // 
            // udpRadioButton
            // 
            this.udpRadioButton.AutoSize = true;
            this.udpRadioButton.Location = new System.Drawing.Point(43, 506);
            this.udpRadioButton.Name = "udpRadioButton";
            this.udpRadioButton.Size = new System.Drawing.Size(68, 24);
            this.udpRadioButton.TabIndex = 1;
            this.udpRadioButton.TabStop = true;
            this.udpRadioButton.Text = "UDP";
            this.udpRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1984, 1062);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.sidePanel);
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