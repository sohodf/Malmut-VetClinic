using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vet_Clinic
{
    public partial class healthPackageF : Form
    {
        public healthPackageF()
        {
            InitializeComponent();
        }
        
        public void setReport(CrystalDecisions.CrystalReports.Engine.ReportDocument aReport)
        {
            crystalReportViewer1.ReportSource = aReport;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void healthPackageF_Load(object sender, EventArgs e)
        {

        }
    }
}
