using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto.Forms
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }

        public void SetProgress(int value, string Message = null)
        {
            if (value <= BGWprogressBar.Maximum)
                BGWprogressBar.Value = value;
            bgwLabel.Text = string.IsNullOrWhiteSpace(Message) ? string.Empty : Message;
        }


    }
}
