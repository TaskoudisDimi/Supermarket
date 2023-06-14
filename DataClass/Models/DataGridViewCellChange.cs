using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1.Models
{
    public class DataGridViewCellChange
    {

        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }    
        public string NewValue { get; set; }
        public DataGridViewRow dataRow;

    }
}
