using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalSystem
{
    public partial class GridViewReport : Form
    {
        public GridViewReport()
        {
            InitializeComponent();
        }

        public GridViewReport(DataTable tbl)
        {
            InitializeComponent();
            dataGridView1.DataSource = tbl;
        }
    }
}
