using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketTuto.Forms.General
{
    public partial class WaitBar : Form
    {
        public WaitBar()
        {
            InitializeComponent();
            
        }

        public void UpdateProgressBar(int progress)
        {
            // Ensure that the progress value is within the valid range (0-100)
            if (progress >= 0 && progress <= 100)
            {
                waitProgressBar.Value = progress;
            }
        }


    }
}
