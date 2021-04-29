using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Agrosis.Reportes
{
    partial class CompraRepo : Form
    {
        public List<CompraDet> Detalle = new List<CompraDet>();
        public List<CompraEnc> Titulo = new List<CompraEnc>();
        public CompraRepo()
        {
            InitializeComponent();
        }

        private void CompraRepo_Load(object sender, EventArgs e)
        {
            this.Rpv1.LocalReport.DataSources.Clear();
            this.Rpv1.LocalReport.DataSources.Add(new ReportDataSource("Enca",Titulo));
            this.Rpv1.LocalReport.DataSources.Add(new ReportDataSource("Detalle", Detalle));
            this.Rpv1.RefreshReport();
        }
    }
}
