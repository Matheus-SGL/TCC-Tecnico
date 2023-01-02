using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFATCC.Relatorios
{
    public partial class frmRelatorioSaldo : Form
    {
        public frmRelatorioSaldo()
        {
            InitializeComponent();
        }

        private void frmRelatorioSaldo_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
