using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransFlash.BO;

namespace TransFlash.Reporting
{
    public partial class Frm_ReportEmploye : Form
    {

        private IEnumerable<Employe> employes = null;

        public Frm_ReportEmploye(IEnumerable<Employe> employes)
        {

            this.employes = employes;
            InitializeComponent();
        }

        private void Frm_ReportEmploye_Load(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.LocalReport.ReportPath = "ReportEmploye.rdlc";
                this.reportViewer1.LocalReport.DataSources.Add(
                    new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", this.employes));
                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
                this.reportViewer1.ZoomPercent = 100;
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
