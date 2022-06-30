using CrystalDecisions.Shared;
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
    public partial class RateSearch : Form
    {
        RatingReport ratingReport;
        public RateSearch()
        {
            InitializeComponent();
        }

        private void RateSearch_Load(object sender, EventArgs e)
        {
            ratingReport = new RatingReport();
            foreach (ParameterDiscreteValue v in ratingReport.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.Text);
            ratingReport.SetParameterValue(0, comboBox1.Text.ToString());
            crystalReportViewer1.ReportSource = ratingReport;
        }
    }
}
