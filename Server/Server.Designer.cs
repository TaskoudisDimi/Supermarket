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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            logListBox = new ListBox();
            tabPage2 = new TabPage();
            startButton = new Button();
            countLabel = new Label();
            connectedClientsLabel = new Label();
            buferSizeLabel = new Label();
            bufferSizeTextBox = new TextBox();
            tcpLabel = new Label();
            udpLabel = new Label();
            stopButton = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(9, 148);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 299);
            tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(logListBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(789, 271);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // logListBox
            // 
            logListBox.FormattingEnabled = true;
            logListBox.ItemHeight = 15;
            logListBox.Location = new Point(3, 3);
            logListBox.Name = "logListBox";
            logListBox.Size = new Size(779, 259);
            logListBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(789, 271);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            startButton.Location = new Point(27, 98);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 12;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new Point(69, 62);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(0, 15);
            countLabel.TabIndex = 11;
            // 
            // connectedClientsLabel
            // 
            connectedClientsLabel.AutoSize = true;
            connectedClientsLabel.Location = new Point(27, 20);
            connectedClientsLabel.Name = "connectedClientsLabel";
            connectedClientsLabel.Size = new Size(104, 15);
            connectedClientsLabel.TabIndex = 10;
            connectedClientsLabel.Text = "Connected Clients";
            // 
            // buferSizeLabel
            // 
            buferSizeLabel.AutoSize = true;
            buferSizeLabel.Location = new Point(209, 20);
            buferSizeLabel.Name = "buferSizeLabel";
            buferSizeLabel.Size = new Size(62, 15);
            buferSizeLabel.TabIndex = 15;
            buferSizeLabel.Text = "Buffer Size";
            // 
            // bufferSizeTextBox
            // 
            bufferSizeTextBox.Location = new Point(209, 38);
            bufferSizeTextBox.Name = "bufferSizeTextBox";
            bufferSizeTextBox.Size = new Size(100, 23);
            bufferSizeTextBox.TabIndex = 14;
            // 
            // tcpLabel
            // 
            tcpLabel.AutoSize = true;
            tcpLabel.Location = new Point(423, 20);
            tcpLabel.Name = "tcpLabel";
            tcpLabel.Size = new Size(27, 15);
            tcpLabel.TabIndex = 16;
            tcpLabel.Text = "TCP";
            // 
            // udpLabel
            // 
            udpLabel.AutoSize = true;
            udpLabel.Location = new Point(476, 20);
            udpLabel.Name = "udpLabel";
            udpLabel.Size = new Size(30, 15);
            udpLabel.TabIndex = 17;
            udpLabel.Text = "UDP";
            // 
            // stopButton
            // 
            stopButton.Location = new Point(141, 98);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(75, 23);
            stopButton.TabIndex = 18;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 476);
            Controls.Add(stopButton);
            Controls.Add(udpLabel);
            Controls.Add(tcpLabel);
            Controls.Add(tabControl1);
            Controls.Add(startButton);
            Controls.Add(countLabel);
            Controls.Add(connectedClientsLabel);
            Controls.Add(buferSizeLabel);
            Controls.Add(bufferSizeTextBox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Server";
            Text = "Form1";
            FormClosing += Server_FormClosing;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Button stopButton;
    }
}