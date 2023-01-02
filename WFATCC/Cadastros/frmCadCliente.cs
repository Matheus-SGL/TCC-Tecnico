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

namespace WFATCC.Formularios
{
    public partial class frmCadCliente : Form
    {
        
        public frmCadCliente()
        {
            InitializeComponent();
            atualizaGrid();
            travaCampo();
        }

        private void confereCampo()
        {
            if (txtCodigo.Text.Length == 0|| txtNome.Text.Length == 0 || txtEndereco.Text.Length == 0 || mtbCnpj.Text.Length < 18)
            {
                btnSalvarInsert.Enabled = false;
                btnSalvarUpdate.Enabled = true;
            }
            else
            {
                btnSalvarInsert.Enabled = true;
                btnSalvarUpdate.Enabled = true;
            }
        }

        private void limpaCampo()
        {
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtCodigo.Text = "";
            txtEndereco.Text = "";
            txtNome.Text = "";
            mtbCep.Text = "";
            mtbCnpj.Text = "";
            txtNumero.Text = "";
            mtbTelefone.Text = "";
        }
        private void travaCampo()
        {
            txtCodigo.ReadOnly = true;
            txtBairro.ReadOnly = true;
            txtCidade.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNome.ReadOnly = true;
            mtbCep.ReadOnly = true;
            mtbCnpj.ReadOnly = true;
            txtNumero.ReadOnly = true;
            mtbTelefone.ReadOnly = true;
        }

        private void liberaCampo()
        {
            txtCodigo.ReadOnly = false;
            txtBairro.ReadOnly = false;
            txtCidade.ReadOnly = false;
            txtEndereco.ReadOnly = false;
            txtNome.ReadOnly = false;
            mtbCep.ReadOnly = false;
            mtbCnpj.ReadOnly = false;
            txtNumero.ReadOnly = false;
            mtbTelefone.ReadOnly = false;
        }

        public void atualizaTabela()
        {
            txtCodigo.Text = dgvCliente[1, dgvCliente.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvCliente[2, dgvCliente.CurrentRow.Index].Value.ToString();
            txtEndereco.Text = dgvCliente[3, dgvCliente.CurrentRow.Index].Value.ToString();
            txtNumero.Text = dgvCliente[4, dgvCliente.CurrentRow.Index].Value.ToString();
            txtBairro.Text = dgvCliente[5, dgvCliente.CurrentRow.Index].Value.ToString();
            txtCidade.Text = dgvCliente[6, dgvCliente.CurrentRow.Index].Value.ToString();
            mtbCep.Text = dgvCliente[7, dgvCliente.CurrentRow.Index].Value.ToString();
            mtbTelefone.Text = dgvCliente[8, dgvCliente.CurrentRow.Index].Value.ToString();
            mtbCnpj.Text = dgvCliente[9, dgvCliente.CurrentRow.Index].Value.ToString();
        }
        public void atualizaGrid()
        {   
            DEWM_ClienteTableAdapter ta = new DEWM_ClienteTableAdapter();
            DataSet_DEWM_MatheusDB ds = new DataSet_DEWM_MatheusDB();
            ta.Fill(ds.DEWM_Cliente);
            dataSetDEWMBindingSource.DataSource = ds.DEWM_Cliente;
            dgvCliente.DataSource = dataSetDEWMBindingSource;
            bindingNavigator1.BindingSource = dataSetDEWMBindingSource;

            //dgvCliente.Columns[12].Visible = false;
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_DEWM_MatheusDB.DEWM_Cliente' table. You can move, or remove it, as needed.
            this.dEWM_ClienteTableAdapter.Fill(this.dataSet_DEWM_MatheusDB.DEWM_Cliente);
            btnNovo.Focus();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
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
            dgvCliente.Enabled = false;
            txtCodigo.Focus();
            liberaCampo();
            limpaCampo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlBtnSALC.Visible = false;
            pnlBtnNF.Visible = true;
            dgvCliente.Enabled = true;
            btnFechar.Enabled = true;
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
                MessageBox.Show(this, "Um cliente deve ser selecionado antes!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                try
                {
                    pnlBtnNF.Visible = false;
                    pnlBtnSALC.Visible = true;
                    btnSalvarUpdate.Enabled = false;
                    btnSalvarUpdate.Visible = true;
                    btnSalvarInsert.Visible = false;
                    btnFechar.Enabled = false;
                    lblStatus.Text = "Alterando";
                    dgvCliente.Enabled = false;
                    txtCodigo.Focus();
                    liberaCampo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            confereCampo();
        }

        private void btnSalvarInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DEWM_ClienteTableAdapter ta = new DEWM_ClienteTableAdapter();
                ta.Insert(txtNome.Text, txtEndereco.Text,
                    mtbCnpj.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text,
                    mtbCep.Text, mtbTelefone.Text, int.Parse(txtCodigo.Text));

                MessageBox.Show(this, "Cliente salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizaGrid();
                limpaCampo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DEWM_ClienteTableAdapter ta = new DEWM_ClienteTableAdapter();
                ta.Update(int.Parse(txtCodigo.Text), txtNome.Text, txtEndereco.Text,
                    mtbCnpj.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text,
                    mtbCep.Text, mtbTelefone.Text);

                MessageBox.Show(this, "Cliente atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizaGrid();
                limpaCampo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show(this, "Um cliente deve ser selecionado antes!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                try
                {
                    DEWM_ClienteTableAdapter ta = new DEWM_ClienteTableAdapter();
                    ta.Delete((int)dgvCliente.CurrentRow.Cells[0].Value);

                    MessageBox.Show(this, "Cliente deletado com sucesso!", "Sucesso!", MessageBoxButtons.OK);
                    atualizaGrid();
                    limpaCampo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCliente.CurrentRow.Cells[0].Value.ToString() == "")
            {
                btnNovo_Click(sender, e);
            }
            else
            {
                btnAlterar_Click(sender, e);
            }
        }

        private void mtbCep_Enter(object sender, EventArgs e)
        {
            mtbCep.SelectAll();
        }

        private void mtbTelefone_Enter(object sender, EventArgs e)
        {
            mtbTelefone.SelectAll();
        }

        private void mtbCnpj_Enter(object sender, EventArgs e)
        {
            mtbCnpj.SelectAll();
        }
    }
}
