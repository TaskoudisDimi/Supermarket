namespace Server
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.startButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.connectedClientsLabel = new System.Windows.Forms.Label();
            this.buferSizeLabel = new System.Windows.Forms.Label();
            this.bufferSizeTextBox = new System.Windows.Forms.TextBox();
            this.tcpLabel = new System.Windows.Forms.Label();
            this.udpLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 246);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1139, 498);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.logListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1131, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 25;
            this.logListBox.Location = new System.Drawing.Point(4, 5);
            this.logListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(1111, 429);
            this.logListBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1131, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(38, 163);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(107, 38);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(98, 103);
            this.countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(0, 25);
            this.countLabel.TabIndex = 11;
            // 
            // connectedClientsLabel
            // 
            this.connectedClientsLabel.AutoSize = true;
            this.connectedClientsLabel.Location = new System.Drawing.Point(38, 34);
            this.connectedClientsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectedClientsLabel.Name = "connectedClientsLabel";
            this.connectedClientsLabel.Size = new System.Drawing.Size(154, 25);
            this.connectedClientsLabel.TabIndex = 10;
            this.connectedClientsLabel.Text = "Connected Clients";
            // 
            // buferSizeLabel
            // 
            this.buferSizeLabel.AutoSize = true;
            this.buferSizeLabel.Location = new System.Drawing.Point(299, 34);
            this.buferSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buferSizeLabel.Name = "buferSizeLabel";
            this.buferSizeLabel.Size = new System.Drawing.Size(95, 25);
            this.buferSizeLabel.TabIndex = 15;
            this.buferSizeLabel.Text = "Buffer Size";
            // 
            // bufferSizeTextBox
            // 
            this.bufferSizeTextBox.Location = new System.Drawing.Point(299, 64);
            this.bufferSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bufferSizeTextBox.Name = "bufferSizeTextBox";
            this.bufferSizeTextBox.Size = new System.Drawing.Size(141, 31);
            this.bufferSizeTextBox.TabIndex = 14;
            // 
            // tcpLabel
            // 
            this.tcpLabel.AutoSize = true;
            this.tcpLabel.Location = new System.Drawing.Point(604, 34);
            this.tcpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tcpLabel.Name = "tcpLabel";
            this.tcpLabel.Size = new System.Drawing.Size(41, 25);
            this.tcpLabel.TabIndex = 16;
            this.tcpLabel.Text = "TCP";
            // 
            // udpLabel
            // 
            this.udpLabel.AutoSize = true;
            this.udpLabel.Location = new System.Drawing.Point(680, 34);
            this.udpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.udpLabel.Name = "udpLabel";
            this.udpLabel.Size = new System.Drawing.Size(47, 25);
            this.udpLabel.TabIndex = 17;
            this.udpLabel.Text = "UDP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 793);
            this.Controls.Add(this.udpLabel);
            this.Controls.Add(this.tcpLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.connectedClientsLabel);
            this.Controls.Add(this.buferSizeLabel);
            this.Controls.Add(this.bufferSizeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox logListBox;
        private TabPage tabPage2;
        private Button startButton;
        private Label countLabel;
        private Label connectedClientsLabel;
        private Label buferSizeLabel;
        private TextBox bufferSizeTextBox;
        private Label tcpLabel;
        private Label udpLabel;
    }
}