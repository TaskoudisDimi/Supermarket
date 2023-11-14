namespace SupermarketTuto.Forms.SellingForms
{
    partial class MainSelling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSelling));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.categoriesProductsButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.createBillButton = new System.Windows.Forms.Button();
            this.seller_Name_Label = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sidePanel.Controls.Add(this.categoriesProductsButton);
            this.sidePanel.Controls.Add(this.billButton);
            this.sidePanel.Controls.Add(this.createBillButton);
            this.sidePanel.Controls.Add(this.seller_Name_Label);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(163, 690);
            this.sidePanel.TabIndex = 69;
            // 
            // categoriesProductsButton
            // 
            this.categoriesProductsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categoriesProductsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.categoriesProductsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.categoriesProductsButton.Location = new System.Drawing.Point(19, 114);
            this.categoriesProductsButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.categoriesProductsButton.Name = "categoriesProductsButton";
            this.categoriesProductsButton.Size = new System.Drawing.Size(125, 47);
            this.categoriesProductsButton.TabIndex = 5;
            this.categoriesProductsButton.Text = "Categories/Products";
            this.categoriesProductsButton.UseVisualStyleBackColor = false;
            this.categoriesProductsButton.Click += new System.EventHandler(this.categoriesProductsButton_Click);
            // 
            // billButton
            // 
            this.billButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.billButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.billButton.Location = new System.Drawing.Point(19, 257);
            this.billButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(125, 43);
            this.billButton.TabIndex = 4;
            this.billButton.Text = "Bills";
            this.billButton.UseVisualStyleBackColor = false;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // createBillButton
            // 
            this.createBillButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createBillButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createBillButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createBillButton.Location = new System.Drawing.Point(19, 188);
            this.createBillButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.createBillButton.Name = "createBillButton";
            this.createBillButton.Size = new System.Drawing.Size(125, 43);
            this.createBillButton.TabIndex = 3;
            this.createBillButton.Text = "Create Bill";
            this.createBillButton.UseVisualStyleBackColor = false;
            this.createBillButton.Click += new System.EventHandler(this.createBillButton_Click);
            // 
            // seller_Name_Label
            // 
            this.seller_Name_Label.AutoSize = true;
            this.seller_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.seller_Name_Label.Location = new System.Drawing.Point(23, 64);
            this.seller_Name_Label.Name = "seller_Name_Label";
            this.seller_Name_Label.Size = new System.Drawing.Size(114, 24);
            this.seller_Name_Label.TabIndex = 0;
            this.seller_Name_Label.Text = "Seller Name";
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(163, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Size = new System.Drawing.Size(1061, 690);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 70;
            // 
            // MainSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1224, 690);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.sidePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainSelling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sidePanel;
        private Button billButton;
        private Button createBillButton;
        private Label seller_Name_Label;
        private Button categoriesProductsButton;
        private SplitContainer splitContainer1;
    }
}