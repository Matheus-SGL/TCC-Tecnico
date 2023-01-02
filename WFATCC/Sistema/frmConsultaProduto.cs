using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFATCC.Sistema
{
    public partial class frmConsultaProduto : Form
    {
        public frmConsultaProduto()
        {
            InitializeComponent();
        }

        private void frmConsultaProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_DEWM_MatheusDB.DEWM_Produto' table. You can move, or remove it, as needed.
            this.dEWM_ProdutoTableAdapter.Fill(this.dataSet_DEWM_MatheusDB.DEWM_Produto);

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
                dEWMProdutoBindingSource.Filter = "";
            else if (txtDescricao.Text != "")
                txtDescricao.Text = "";
            else
                dEWMProdutoBindingSource.Filter = "Cod_Pro like '" + txtCodigo.Text + "%'";
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
                dEWMProdutoBindingSource.Filter = "";
            else if (txtCodigo.Text != "")
                txtCodigo.Text = "";
            else
                dEWMProdutoBindingSource.Filter = "Descricao like '" + txtDescricao.Text + "%'";
        }
    }
}
