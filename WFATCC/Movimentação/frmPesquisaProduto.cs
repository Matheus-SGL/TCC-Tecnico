using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFATCC.Movimentação
{
    public partial class frmPesquisaProduto : Form
    {
        public frmPesquisaProduto()
        {
            InitializeComponent();
        }
        private int _CodigoRetorno;

        public int CodigoRetorno
        {
            get { return _CodigoRetorno; }
            set { _CodigoRetorno = value; }
        }
        
        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtProduto.Text == "")
                dEWMProdutoBindingSource.Filter = "";
            else
                dEWMProdutoBindingSource.Filter = "Nome like '" + txtProduto.Text + "%'"; 
        }

        private void lstProduto_DoubleClick(object sender, EventArgs e)
        {
            if (lstProduto.Text != "")
            {
                _CodigoRetorno = Convert.ToInt32(lstProduto.SelectedValue);
                Close();
            }
        }

        private void frmPesquisaProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_DEWM_MatheusDB.DEWM_Produto' table. You can move, or remove it, as needed.
            this.dEWM_ProdutoTableAdapter.Fill(this.dataSet_DEWM_MatheusDB.DEWM_Produto);
            // TODO: This line of code loads data into the 'dataSet_DEWM_MatheusDB.DEWM_Produto' table. You can move, or remove it, as needed.
            this.dEWM_ProdutoTableAdapter.Fill(this.dataSet_DEWM_MatheusDB.DEWM_Produto);

        }
    }
}
