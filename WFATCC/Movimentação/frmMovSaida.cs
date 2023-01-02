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
using WFATCC.Cadastros;
using WFATCC.Formularios;

namespace WFATCC.Movimentação
{
    public partial class frmMovSaida : Form
    {
        public frmMovSaida()
        {
            InitializeComponent();
        }
        string origem;
        string destino;

        private void btnCancel_EstoRot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
         * 
         * Confere Campo
         * 
         */
        private void confereCampo_EstoRot()
        {
            if (mtbData_EstoRot.Text.Length < 8 || txtFunc_EstoRot.Text.Length == 0 || txtCod_EstoRot.Text.Length == 0 ||
                mtbQtdade_EstoRot.Text.Length == 0 || txtLocal_EstoRot.Text.Length == 0)
            {
                btnSalvar_EstoRot.Enabled = false;
            }
            else
            {
                btnSalvar_EstoRot.Enabled = true;
            }
        }
        private void confereCampo_EstoCli()
        {
            if (mtbData_EstoCli.Text.Length < 8 || txtFunc_EstoCli.Text.Length == 0 || txtCod_EstoCli.Text.Length == 0 ||
                mtbQtdade_EstoCli.Text.Length == 0 || txtLocal_EstoCli.Text.Length == 0 || mtbCodCli_EstoCli.Text.Length == 0 ||
                mtbPedido_EstoCli.Text.Length == 0)
            {
                btnSalvar_EstoCli.Enabled = false;
            }
            else
            {
                btnSalvar_EstoCli.Enabled = true;
            }
        }
        private void confereCampo_EstoProc()
        {
            if (mtbData_EstoProc.Text.Length < 8 || txtFunc_EstoProc.Text.Length == 0 || txtCod_EstoProc.Text.Length == 0 ||
                mtbQtdade_EstoProc.Text.Length == 0 || txtLocal_EstoProc.Text.Length == 0 || mtbRi_EstoProc.Text.Length == 0)
            {
                btnSalvar_EstoProc.Enabled = false;
            }
            else
            {
                btnSalvar_EstoProc.Enabled = true;
            }
        }
        private void confereCampo_ProdCli()
        {
            if (mtbData_ProdCli.Text.Length < 8 || txtFunc_ProdCli.Text.Length == 0 || txtCod_ProdCli.Text.Length == 0 ||
                mtbQtdade_ProdCli.Text.Length == 0 || mtbCodCli_ProdCli.Text.Length == 0 || mtbPedido_ProdCli.Text.Length == 0)
            {
                btnSalvar_ProdCli.Enabled = false;
            }
            else
            {
                btnSalvar_ProdCli.Enabled = true;
            }
        }
        /*
         * 
         * Botões Limpar
         * 
         */
        private void btnLimpar_EstoRot_Click(object sender, EventArgs e)
        {
            mtbData_EstoRot.Text = "";
            mtbOp_EstoRot.Text = "";
            mtbPalette_EstoRot.Text = "";
            mtbQtdade_EstoRot.Text = "";
            mtbValidade_EstoRot.Text = "";
            txtCod_EstoRot.Text = "";
            txtFunc_EstoRot.Text = "";
            txtLocal_EstoRot.Text = "";
            txtLote_EstoRot.Text = "";
            txtObs_EstoRot.Text = "";
            txtCodNome_EstoRot.Text = "";
        }

        private void btnLimpar_EstoCli_Click(object sender, EventArgs e)
        {
            mtbData_EstoCli.Text = "";
            mtbOp_EstoCli.Text = "";
            mtbPalette_EstoCli.Text = "";
            mtbQtdade_EstoCli.Text = "";
            mtbValidade_EstoCli.Text = "";
            mtbCodCli_EstoCli.Text = "";
            mtbPedido_EstoCli.Text = "";
            txtCod_EstoCli.Text = "";
            txtFunc_EstoCli.Text = "";
            txtLocal_EstoCli.Text = "";
            txtLote_EstoCli.Text = "";
            txtNomeCli_EstoCli.Text = "";
            txtObs_EstoCli.Text = "";
            txtCodNome_EstoCli.Text = "";
            
        }

        private void btnLimpar_EstoProc_Click(object sender, EventArgs e)
        {
            mtbData_EstoProc.Text = "";
            mtbQtdade_EstoProc.Text = "";
            mtbRi_EstoProc.Text = "";
            mtbValidade_EstoProc.Text = "";
            txtCod_EstoProc.Text = "";
            txtFunc_EstoProc.Text = "";
            txtLocal_EstoProc.Text = "";
            txtLote_EstoProc.Text = "";
            txtObs_EstoProc.Text = "";
            txtCodNome_EstoProc.Text = "";
        }

        private void btnLimpar_ProdCli_Click(object sender, EventArgs e)
        {
            mtbCodCli_ProdCli.Text = "";
            mtbData_ProdCli.Text = "";
            mtbOp_ProdCli.Text = "";
            mtbPalette_ProdCli.Text = "";
            mtbPedido_ProdCli.Text = "";
            mtbQtdade_ProdCli.Text = "";
            mtbValidade_ProdCli.Text = "";
            txtCod_ProdCli.Text = "";
            txtFunc_ProdCli.Text = "";
            txtNomeCli_ProdCli.Text = "";
            txtLote_ProdCli.Text = "";
            txtObs_ProdCli.Text = "";
        }
        /*
         * 
         * Confere Campo
         * 
         */
        private void mtbData_EstoRot_Leave(object sender, EventArgs e)
        {
            confereCampo_EstoRot();
        }

        private void mtbData_EstoCli_Leave(object sender, EventArgs e)
        {
            confereCampo_EstoCli();
        }

        private void mtbData_EstoProc_Leave(object sender, EventArgs e)
        {
            confereCampo_EstoProc();
        }

        private void mtbData_ProdCli_Leave(object sender, EventArgs e)
        {
            confereCampo_ProdCli();
        }

        private void mtbData_EstoRot_Click(object sender, EventArgs e)
        {
            mtbData_EstoRot.SelectAll();
            mtbData_EstoCli.SelectAll();
            mtbData_EstoProc.SelectAll();
            mtbData_ProdCli.SelectAll();
        }
        /*
         * 
         * Verifica se existe Produto
         * 
         */
        private void txtCod_EstoRot_Leave(object sender, EventArgs e)
        {
            if (txtCod_EstoRot.Text != "")
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                dtProduto = taProduto.getProduto(txtCod_EstoRot.Text);

                if (dtProduto.Rows.Count == 0)
                {
                    if (MessageBox.Show(this, "Código de produto não encontrado! Deseja cadastrar novo produto?", "Produto não encontrado!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadProduto frmProduto = new frmCadProduto();
                        frmProduto.ShowDialog();
                    }
                    else
                    {
                        txtCod_EstoRot.SelectAll();
                    }
                }
                else
                {
                    txtCodNome_EstoRot.Text = dtProduto.Rows[0]["Nome"].ToString();
                    txtLote_EstoRot.Text = dtProduto.Rows[0]["Lote"].ToString();
                    mtbValidade_EstoRot.Text = dtProduto.Rows[0]["Validade"].ToString();
                    mtbOp_EstoRot.Text = dtProduto.Rows[0]["N_OP"].ToString();
                    mtbPalette_EstoRot.Text = dtProduto.Rows[0]["N_Pallet"].ToString();
                    txtLocal_EstoRot.Text = dtProduto.Rows[0]["Local_Pro"].ToString();
                }
            }
            confereCampo_EstoRot();
        }

        private void txtCod_EstoCli_Leave(object sender, EventArgs e)
        {
            if (txtCod_EstoCli.Text != "")
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                dtProduto = taProduto.getProduto(txtCod_EstoCli.Text);

                if (dtProduto.Rows.Count == 0)
                {
                    if (MessageBox.Show(this, "Código de produto não encontrado! Deseja cadastrar novo produto?", "Produto não encontrado!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadProduto frmProduto = new frmCadProduto();
                        frmProduto.ShowDialog();
                    }
                    else
                    {
                        txtCod_EstoCli.SelectAll();
                    }
                }
                else
                {
                    txtCodNome_EstoCli.Text = dtProduto.Rows[0]["Nome"].ToString();
                    txtLote_EstoCli.Text = dtProduto.Rows[0]["Lote"].ToString();
                    mtbValidade_EstoCli.Text = dtProduto.Rows[0]["Validade"].ToString();
                    mtbOp_EstoCli.Text = dtProduto.Rows[0]["N_OP"].ToString();
                    mtbPalette_EstoCli.Text = dtProduto.Rows[0]["N_Pallet"].ToString();
                    txtLocal_EstoCli.Text = dtProduto.Rows[0]["Local_Pro"].ToString();
                }
            }
            confereCampo_EstoCli();
        }

        private void txtCod_EstoProc_Leave(object sender, EventArgs e)
        {
            if (txtCod_EstoProc.Text != "")
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                dtProduto = taProduto.getProduto(txtCod_EstoProc.Text);

                if (dtProduto.Rows.Count == 0)
                {
                    if (MessageBox.Show(this, "Código de produto não encontrado! Deseja cadastrar novo produto?", "Produto não encontrado!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadProduto frmProduto = new frmCadProduto();
                        frmProduto.ShowDialog();
                    }
                    else
                    {
                        txtCod_EstoProc.SelectAll();
                    }
                }
                else
                {
                    txtCodNome_EstoProc.Text = dtProduto.Rows[0]["Nome"].ToString();
                    txtLote_EstoProc.Text = dtProduto.Rows[0]["Lote"].ToString();
                    mtbValidade_EstoProc.Text = dtProduto.Rows[0]["Validade"].ToString();
                    txtLocal_EstoProc.Text = dtProduto.Rows[0]["Local_Pro"].ToString();
                }
            }
            confereCampo_EstoProc();
        }

        private void txtCod_ProdCli_Leave(object sender, EventArgs e)
        {
            if (txtCod_ProdCli.Text != "")
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                dtProduto = taProduto.getProduto(txtCod_ProdCli.Text);

                if (dtProduto.Rows.Count == 0)
                {
                    if (MessageBox.Show(this, "Código de produto não encontrado! Deseja cadastrar novo produto?", "Produto não encontrado!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadProduto frmProduto = new frmCadProduto();
                        frmProduto.ShowDialog();
                    }
                    else
                    {
                        txtCod_ProdCli.SelectAll();
                    }
                }
                else
                {
                    txtCodNome_ProdCli.Text = dtProduto.Rows[0]["Nome"].ToString();
                    txtLote_ProdCli.Text = dtProduto.Rows[0]["Lote"].ToString();
                    mtbValidade_ProdCli.Text = dtProduto.Rows[0]["Validade"].ToString();
                    mtbOp_ProdCli.Text = dtProduto.Rows[0]["N_OP"].ToString();
                    mtbPalette_ProdCli.Text = dtProduto.Rows[0]["N_Pallet"].ToString();
                }
            }
            confereCampo_ProdCli();
        }
        /*
         * 
         * Nome do Cliente && Codigo do Cliente
         * 
         */
        private void mtbCodCli_EstoCli_Leave(object sender, EventArgs e)
        {
            if (mtbCodCli_EstoCli.Text != "")
            {
                DEWM_ClienteTableAdapter taCliente = new DEWM_ClienteTableAdapter();
                DataSet_DEWM_MatheusDB.DEWM_ClienteDataTable dtCliente = new DataSet_DEWM_MatheusDB.DEWM_ClienteDataTable();
                dtCliente = taCliente.GetData();

                if (dtCliente.Rows.Count == 0)
                {
                    if (MessageBox.Show(this, "Código de cliente não encontrado! Deseja cadastrar novo cliente?", "Cliente não encontrado!",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadCliente frmCliente = new frmCadCliente();
                        frmCliente.ShowDialog();
                    }
                }
                else
                {
                    txtNomeCli_EstoCli.Text = dtCliente.Rows[0]["Nome"].ToString();
                }
            }
            confereCampo_EstoCli();
        }
        private void mtbCodCli_ProdCli_Leave(object sender, EventArgs e)
        {
            if (mtbCodCli_ProdCli.Text != "")
            {
                DEWM_ClienteTableAdapter taCliente = new DEWM_ClienteTableAdapter();
                DataSet_DEWM_MatheusDB.DEWM_ClienteDataTable dtCliente = new DataSet_DEWM_MatheusDB.DEWM_ClienteDataTable();
                dtCliente = taCliente.GetData();

                if (dtCliente.Rows.Count == 0)
                {
                    if (MessageBox.Show(this, "Código de cliente não encontrado! Deseja cadastrar novo cliente?", "Cliente não encontrado!",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadCliente frmCliente = new frmCadCliente();
                        frmCliente.ShowDialog();
                    }
                }
                else
                {
                    txtNomeCli_ProdCli.Text = dtCliente.Rows[0]["Nome"].ToString();
                }
            }
            confereCampo_ProdCli();
        }
        /*
         * 
         * Quantidade Correta
         * 
         */
        int vQtde, vQtde_Sai;
        private void mtbQtdade_EstoRot_Leave(object sender, EventArgs e)
        {
            if (mtbQtdade_EstoRot.Text != "")
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                vQtde = int.Parse(mtbQtdade_EstoRot.Text);
                vQtde_Sai = (int)taProduto.getSaldo(txtCod_EstoRot.Text);

                if (vQtde > vQtde_Sai)
                {
                    MessageBox.Show(this, "Quantidade acima do estoque!", "Quantidade inválida!", MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);
                    mtbQtdade_EstoRot.SelectAll();
                    btnSalvar_EstoRot.Enabled = false;
                }
            }
            confereCampo_EstoRot();
        }

        private void mtbQtdade_EstoCli_Leave(object sender, EventArgs e)
        {
            if (mtbQtdade_EstoCli.Text != "")
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                vQtde = int.Parse(mtbQtdade_EstoCli.Text);
                vQtde_Sai = (int)taProduto.getSaldo(txtCod_EstoCli.Text);

                if (vQtde > vQtde_Sai)
                {
                    MessageBox.Show(this, "Quantidade acima do estoque!", "Quantidade inválida!", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    mtbQtdade_EstoCli.SelectAll();
                    btnSalvar_EstoCli.Enabled = false;
                }
            }
            confereCampo_EstoCli();
        }

        private void mtbQtdade_EstoProc_Leave(object sender, EventArgs e)
        {
            if (mtbQtdade_EstoProc.Text != "")
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                vQtde = int.Parse(mtbQtdade_EstoProc.Text);
                vQtde_Sai = (int)taProduto.getSaldo(txtCod_EstoProc.Text);

                if (vQtde > vQtde_Sai)
                {
                    MessageBox.Show(this, "Quantidade acima do estoque!", "Quantidade inválida!", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    mtbQtdade_EstoProc.SelectAll();
                    btnSalvar_EstoProc.Enabled = false;
                }
            }
            confereCampo_EstoProc();
        }

        private void mtbQtdade_ProdCli_Leave(object sender, EventArgs e)
        {
            if (mtbQtdade_ProdCli.Text != "")
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                vQtde = int.Parse(mtbQtdade_ProdCli.Text);
                vQtde_Sai = (int)taProduto.getSaldo(txtCod_ProdCli.Text);

                if (vQtde > vQtde_Sai)
                {
                    MessageBox.Show(this, "Quantidade acima do estoque!", "Quantidade inválida!", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    mtbQtdade_ProdCli.SelectAll();
                    btnSalvar_ProdCli.Enabled = false;
                }
            }
            confereCampo_ProdCli();
        }
        /*
         * 
         * Verifica Local Correto
         * 
         */
        private void txtLocal_EstoRot_Leave(object sender, EventArgs e)
        {
            if (txtCod_EstoRot.Text != "" || txtLocal_EstoRot.Text != "")
            {
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                dtProduto = taProduto.getProduto(txtCod_EstoRot.Text);

                if (dtProduto.Rows.Count > 0)
                {
                    string vLocal = dtProduto.Rows[0]["Local_Pro"].ToString();

                    if (!(vLocal == txtLocal_EstoRot.Text) && vLocal != "")
                    {
                        MessageBox.Show(this, "Este produto não pertence a este local, ele pertence ao local " + vLocal +
                            "!", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        txtLocal_EstoRot.SelectAll();
                    }
                }
            }
            confereCampo_EstoRot();
        }

        private void txtLocal_EstoCli_Leave(object sender, EventArgs e)
        {
            if (txtCod_EstoCli.Text != "" || txtLocal_EstoCli.Text != "")
            {
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                dtProduto = taProduto.getProduto(txtCod_EstoCli.Text);

                if (dtProduto.Rows.Count > 0)
                {
                    string vLocal = dtProduto.Rows[0]["Local_Pro"].ToString();

                    if (!(vLocal == txtLocal_EstoCli.Text) && vLocal != "")
                    {
                        MessageBox.Show(this, "Este produto não pertence a este local, ele pertence ao local " + vLocal +
                            "!", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        txtLocal_EstoCli.SelectAll();
                    }
                }
            }
            confereCampo_EstoCli();
        }

        private void txtLocal_EstoProc_Leave(object sender, EventArgs e)
        {
            if (txtCod_EstoProc.Text != "" || txtLocal_EstoProc.Text != "")
            {
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                dtProduto = taProduto.getProduto(txtCod_EstoProc.Text);

                if (dtProduto.Rows.Count > 0)
                {
                    string vLocal = dtProduto.Rows[0]["Local_Pro"].ToString();

                    if (!(vLocal == txtLocal_EstoProc.Text) && vLocal != "")
                    {
                        MessageBox.Show(this, "Este produto não pertence a este local, ele pertence ao local " + vLocal +
                            "!", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        txtLocal_EstoProc.SelectAll();
                    }
                }
            }
            confereCampo_EstoProc();
        }
        /*
         * 
         * Botões Pesquisa de Produto
         * 
         */
        private void btnPesq_EstoRot_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisaPro = new frmPesquisaProduto();
            frmPesquisaPro.ShowDialog();
            txtCod_EstoRot.Text = frmPesquisaPro.CodigoRetorno.ToString();
            txtCod_EstoRot.Focus();
            mtbQtdade_EstoRot.Focus();
        }

        private void btnPesq_EstoCli_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisaPro = new frmPesquisaProduto();
            frmPesquisaPro.ShowDialog();
            txtCod_EstoCli.Text = frmPesquisaPro.CodigoRetorno.ToString();
            txtCod_EstoCli.Focus();
            mtbQtdade_EstoCli.Focus();
        }

        private void btnPesq_EstoProc_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisaPro = new frmPesquisaProduto();
            frmPesquisaPro.ShowDialog();
            txtCod_EstoProc.Text = frmPesquisaPro.CodigoRetorno.ToString();
            txtCod_EstoProc.Focus();
            mtbQtdade_EstoProc.Focus();
        }

        private void btnPesq_ProdCli_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisaPro = new frmPesquisaProduto();
            frmPesquisaPro.ShowDialog();
            txtCod_ProdCli.Text = frmPesquisaPro.CodigoRetorno.ToString();
            txtCod_ProdCli.Focus();
            mtbQtdade_ProdCli.Focus();
        }
        /*
         * 
         * Botões Salvar
         * 
         */
        private void btnSalvar_EstoRot_Click(object sender, EventArgs e)
        {
            origem = "Estoque";
            destino = "Rotativo";
            try
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                DEWM_MovimentacaoTableAdapter taMov = new DEWM_MovimentacaoTableAdapter();

                vQtde = int.Parse(mtbQtdade_EstoRot.Text);
                vQtde_Sai = (int)taProduto.getSaldo(txtCod_EstoRot.Text);
                vQtde_Sai = vQtde_Sai - vQtde;

                taMov.insMovSai(txtCod_EstoRot.Text, "Saída", destino, vQtde, DateTime.Parse(mtbData_EstoRot.Text), vQtde_Sai,
                    txtObs_EstoRot.Text);
                taProduto.upProduto_EstoRot(origem, txtLocal_EstoRot.Text, vQtde_Sai, txtCod_EstoRot.Text);

                MessageBox.Show(this, "Saída de produto com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_EstoRot_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_EstoCli_Click(object sender, EventArgs e)
        {
            origem = "Estoque";
            destino = "Cliente";

            try
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                DEWM_MovimentacaoTableAdapter taMov = new DEWM_MovimentacaoTableAdapter();

                vQtde = int.Parse(mtbQtdade_EstoCli.Text);
                vQtde_Sai = (int)taProduto.getSaldo(txtCod_EstoCli.Text);
                vQtde_Sai = vQtde_Sai - vQtde;

                taMov.insMovSai_Cli(txtCod_EstoCli.Text, "Saída", destino, vQtde, DateTime.Parse(mtbData_EstoCli.Text), 
                    vQtde_Sai, int.Parse(mtbPedido_EstoCli.Text), int.Parse(mtbCodCli_EstoCli.Text), txtObs_EstoCli.Text);
                taProduto.upProduto_EstoRot(origem, txtLocal_EstoCli.Text, vQtde_Sai, txtCod_EstoCli.Text);

                MessageBox.Show(this, "Saída de produto com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_EstoCli_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnSalvar_EstoProc_Click(object sender, EventArgs e)
        {
            origem = "Estoque";
            destino = "Processo";

            try
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                DEWM_MovimentacaoTableAdapter taMov = new DEWM_MovimentacaoTableAdapter();

                vQtde = int.Parse(mtbQtdade_EstoProc.Text);
                vQtde_Sai = (int)taProduto.getSaldo(txtCod_EstoProc.Text);
                vQtde_Sai = vQtde_Sai - vQtde;

                taMov.insMovSai(txtCod_EstoProc.Text, "Saída", destino, vQtde, DateTime.Parse(mtbData_EstoProc.Text), vQtde_Sai, 
                    txtObs_EstoProc.Text);
                taProduto.upProduto_EstoRot(origem, txtLocal_EstoProc.Text, vQtde_Sai, txtCod_EstoProc.Text);

                MessageBox.Show(this, "Saída de produto com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_EstoProc_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnSalvar_ProdCli_Click(object sender, EventArgs e)
        {
            origem = "Produção";
            destino = "Cliente";

            try
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                DEWM_MovimentacaoTableAdapter taMov = new DEWM_MovimentacaoTableAdapter();

                vQtde = int.Parse(mtbQtdade_ProdCli.Text);
                vQtde_Sai = (int)taProduto.getSaldo(txtCod_ProdCli.Text);
                vQtde_Sai = vQtde_Sai - vQtde;

                taMov.insMovSai_Cli(txtCod_ProdCli.Text, "Saída", destino, vQtde, DateTime.Parse(mtbData_ProdCli.Text), vQtde_Sai,
                    int.Parse(mtbPedido_ProdCli.Text), int.Parse(mtbCodCli_ProdCli.Text), txtObs_ProdCli.Text);

                taProduto.upProduto_ProdCli(origem, vQtde_Sai, txtCod_ProdCli.Text);
                MessageBox.Show(this, "Saída de produto com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_ProdCli_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        

        

        

        

        

          
    }
}
