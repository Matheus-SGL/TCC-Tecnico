using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFATCC.Dados.DataSet_DEWM_MatheusDBTableAdapters;
using WFATCC.Dados;

namespace WFATCC.Cadastros
{
    public partial class frmCadProduto : Form
    {
        public frmCadProduto()
        {
            InitializeComponent();
            travaCampo();
            atualizaGrid();
        }

        private void confereCampo()
        {
            if (txtCodigo.Text.Length == 0 || txtNome.Text.Length == 0 || txtDescricao.Text.Length == 0 || txtLinha.Text.Length == 0 || txtEspecie.Text.Length == 0)
            {
                btnSalvarInsert.Enabled = false;
                btnSalvarUpdate.Enabled = false;
            }
            else
            {
                btnSalvarInsert.Enabled = true;
                btnSalvarUpdate.Enabled = true;
            }
        }

        private void limpaCampo()
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtEspecie.Text = "";
            txtLinha.Text = "";
            txtNome.Text = "";
        }
        private void travaCampo()
        {
            txtCodigo.ReadOnly = true;
            txtDescricao.ReadOnly = true;
            txtEspecie.ReadOnly = true;
            txtLinha.ReadOnly = true;
            txtNome.ReadOnly = true;
        }

        private void liberaCampo()
        {
            txtCodigo.ReadOnly = false;
            txtDescricao.ReadOnly = false;
            txtEspecie.ReadOnly = false;
            txtLinha.ReadOnly = false;
            txtNome.ReadOnly = false;
        }

        private void atualizaTabela()
        {
            txtCodigo.Text = dgvProduto[1, dgvProduto.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvProduto[2, dgvProduto.CurrentRow.Index].Value.ToString();
            txtDescricao.Text = dgvProduto[3, dgvProduto.CurrentRow.Index].Value.ToString();
            txtLinha.Text = dgvProduto[4, dgvProduto.CurrentRow.Index].Value.ToString();
            txtEspecie.Text = dgvProduto[5, dgvProduto.CurrentRow.Index].Value.ToString();
        }

        private void atualizaGrid()
        {
            DEWM_ProdutoTableAdapter ta = new DEWM_ProdutoTableAdapter();
            DataSet_DEWM_MatheusDB ds = new DataSet_DEWM_MatheusDB();
            ta.Fill(ds.DEWM_Produto);
            dataSetDEWMBindingSource.DataSource = ds.DEWM_Produto;
            dgvProduto.DataSource = dataSetDEWMBindingSource;
            bindingNavigator.BindingSource = dataSetDEWMBindingSource;
        }

        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_DEWM_MatheusDB.DEWM_Produto' table. You can move, or remove it, as needed.
            this.dEWM_ProdutoTableAdapter.Fill(this.dataSet_DEWM_MatheusDB.DEWM_Produto);
            btnNovo.Focus();
            pnlBtnNF.Visible = true;

        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizaTabela();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            pnlBtnNF.Visible = false;
            pnlBtnSALC.Visible = true;
            btnSalvarUpdate.Visible = false;
            btnSalvarInsert.Visible = true;
            btnSalvarInsert.Enabled = false;
            btnFechar.Enabled = false;
            lblStatus.Text = "Cadastrando";
            dgvProduto.Enabled = false;
            txtCodigo.Focus();
            liberaCampo();
            limpaCampo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlBtnSALC.Visible = true;
            pnlBtnNF.Visible = true;
            dgvProduto.Enabled = true;
            btnFechar.Enabled = true;
            btnNovo.Enabled = true;
            lblStatus.Text = "";
            btnNovo.Focus();
            travaCampo();
            limpaCampo();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCampo();
            btnSalvarInsert.Enabled = false;
            btnSalvarUpdate.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show(this, "Um produto deve ser selecionado antes!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                try
                {
                    pnlBtnNF.Visible = false;
                    pnlBtnSALC.Visible = true;
                    btnSalvarUpdate.Enabled = false;
                    btnSalvarUpdate.Visible = true;
                    btnSalvarInsert.Visible = false;
                    btnNovo.Enabled = false;
                    lblStatus.Text = "Alterando";
                    dgvProduto.Enabled = false;
                    txtCodigo.Focus();
                    liberaCampo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void mtbPalete_Leave(object sender, EventArgs e)
        {
            confereCampo();
        }

        private void btnSalvarUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DEWM_ProdutoTableAdapter ta = new DEWM_ProdutoTableAdapter();
                ta.Update(txtCodigo.Text, txtNome.Text, txtDescricao.Text, txtLinha.Text, txtEspecie.Text, 0);

                MessageBox.Show(this, "Produto atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizaGrid();
                limpaCampo();
                dgvProduto.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DEWM_ProdutoTableAdapter ta = new DEWM_ProdutoTableAdapter();
                ta.Insert(txtCodigo.Text, txtNome.Text, txtDescricao.Text, txtLinha.Text, txtEspecie.Text, 0);

                MessageBox.Show(this, "Produto salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizaGrid();
                limpaCampo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show(this, "Um produto deve ser selecionado antes!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                try
                {
                    DEWM_ProdutoTableAdapter ta = new DEWM_ProdutoTableAdapter();
                    ta.deleteProduto((int)dgvProduto.CurrentRow.Cells[0].Value);

                    MessageBox.Show(this, "Produto deletado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizaGrid();
                    limpaCampo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProduto.CurrentRow.Cells[0].Value.ToString() == "")
            {
                btnNovo_Click(sender, e);
            }
            else
            {
                btnAlterar_Click(sender, e);
            }
        }
    }
}
