﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vet_Clinic
{
    public partial class kalevetRpt : Form
    {
        public kalevetRpt()
        {
            InitializeComponent();
        }

        public void setReport(CrystalDecisions.CrystalReports.Engine.ReportDocument aReport)
        {
            crystalReportViewer1.ReportSource = aReport;
        }
    }
}
