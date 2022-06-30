using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB_SW
{
    public partial class ActorsDisplay : Form
    {
        ActorsReport actorsReport;
        public ActorsDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = actorsReport;
        }

        private void ActorsDisplay_Load(object sender, EventArgs e)
        {
            actorsReport = new ActorsReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
