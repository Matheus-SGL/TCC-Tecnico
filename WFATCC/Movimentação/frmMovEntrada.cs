using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFATCC.Dados;
using WFATCC.Dados.DataSet_DEWM_MatheusDBTableAdapters;
using WFATCC.Cadastros;
using WFATCC.Formularios;
using System.Data.SqlClient;

namespace WFATCC.Movimentação
{
    public partial class frmMovEntrada : Form
    {
        public frmMovEntrada()
        {
            InitializeComponent();
            confereCampo_ProdEsto();
            confereCampo_ProdRot();
            confereCampo_ProcEsto();
            confereCampo_DevRot();
            confereCampo_DevRej();
            btnSalvarInsert_ProdEsto.Visible = false;
            btnSalvarUpdate_ProdEsto.Visible = true;
            btnSalvarInsert_ProcEsto.Visible = false;
            btnSalvarUpdate_ProcEsto.Visible = true;
        }

        string origem;
        string destino;
        /* 
         * 
         * ConfereCampo de todos
         * 
        */
        private void confereCampo_ProdEsto()
        {
            if (mtbData_ProdEstoq.Text.Length < 8 || mtbOp_ProdEsto.Text.Length == 0 || mtbPalette_ProdEsto.Text.Length == 0 ||
                mtbQtdade_ProdEsto.Text.Length == 0 || mtbValidade_ProdEsto.Text.Length < 8 || txtCod_ProdEsto.Text.Length == 0 ||
                txtFunc_ProdEsto.Text.Length == 0 || txtLocal_ProdEsto.Text.Length == 0 || txtLote_ProdEsto.Text.Length == 0)
            {
                btnSalvarInsert_ProdEsto.Enabled = false;
                btnSalvarUpdate_ProdEsto.Enabled = false;
            }
            else
            {
                btnSalvarInsert_ProdEsto.Enabled = true;
                btnSalvarUpdate_ProdEsto.Enabled = true;
            }
        }
        private void confereCampo_ProdRot()
        {
            if (mtbData_ProdRot.Text.Length < 8 || mtbOp_ProdRot.Text.Length == 0 || mtbPalette_ProdRot.Text.Length == 0 ||
                mtbQtdade_ProdRot.Text.Length == 0 || mtbValidade_ProdRot.Text.Length < 8 || txtCod_ProdRot.Text.Length == 0 ||
                txtFunc_ProdRot.Text.Length == 0 || txtLote_ProdRot.Text.Length == 0)
            {
                btnSalvar_ProdRot.Enabled = false;
            }
            else
            {
                btnSalvar_ProdRot.Enabled = true;
            }
        }
        private void confereCampo_ProcEsto()
        {
            if (mtbData_ProcEsto.Text.Length < 8 || mtbPalette_ProcEsto.Text.Length == 0 || mtbQtdade_ProcEsto.Text.Length == 0 ||
                mtbValidade_ProcEsto.Text.Length < 8 || txtCod_ProcEsto.Text.Length == 0 ||  txtLocal_ProcEsto.Text.Length == 0)
            {
                btnSalvarInsert_ProcEsto.Enabled = false;
                btnSalvarUpdate_ProcEsto.Enabled = false;
            }
            else
            {
                btnSalvarInsert_ProcEsto.Enabled = true;
                btnSalvarUpdate_ProcEsto.Enabled = true;
            }
        }
        private void confereCampo_DevRot()
        {
            if (mtbData_DevRot.Text.Length < 8 || mtbQtdade_DevRot.Text.Length == 0 || mtbValidade_DevRot.Text.Length < 8 ||
                mtbCodCli_DevRot.Text.Length == 0 || mtbPedido_DevRot.Text.Length == 0 || txtCod_DevRot.Text.Length == 0 ||
                txtFunc_DevRot.Text.Length == 0 || txtLote_DevRot.Text.Length == 0)
            {
                btnSalvar_DevRot.Enabled = false;
            }
            else
            {
                btnSalvar_DevRot.Enabled = true;
            }
        }
        private void confereCampo_DevRej()
        {
            if (mtbData_DevRej.Text.Length < 8 || mtbQtdade_DevRej.Text.Length == 0 || mtbValidade_DevRej.Text.Length < 8 ||
                mtbCodCli_DevRej.Text.Length == 0 || mtbPedido_DevRej.Text.Length == 0 || txtCod_DevRej.Text.Length == 0 ||
                txtFunc_DevRej.Text.Length == 0 || txtLote_DevRej.Text.Length == 0)
            {
                btnSalvar_DevRej.Enabled = false;
            }
            else
            {
                btnSalvar_DevRej.Enabled = true;
            }
        }

        private void mtbData_ProdRot_Leave(object sender, EventArgs e)
        {
            confereCampo_ProdRot();
        }

        private void mtbData_ProcEsto_Leave(object sender, EventArgs e)
        {
            confereCampo_ProcEsto();
        }

        private void mtbData_DevRot_Leave(object sender, EventArgs e)
        {
            confereCampo_DevRot();
        }

        private void mtbData_DevRej_Leave(object sender, EventArgs e)
        {
            confereCampo_DevRej();
        }

        private void mtbData_ProdEstoq_Click(object sender, EventArgs e)
        {
            mtbData_DevRej.SelectAll();
            mtbData_DevRot.SelectAll();
            mtbData_ProcEsto.SelectAll();
            mtbData_ProdEstoq.SelectAll();
            mtbData_ProdRot.SelectAll();
        }

        private void mtbValidade_DevRej_Enter(object sender, EventArgs e)
        {
            mtbValidade_DevRej.SelectAll();
            mtbValidade_DevRot.SelectAll();
            mtbValidade_ProcEsto.SelectAll();
            mtbValidade_ProdEsto.SelectAll();
            mtbValidade_ProdRot.SelectAll();
        }
        /*
         * 
         * BotãoCancelar de todos ~> Fecha a janela
         * 
         */
        private void btnCancel_ProdEsto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
         * 
         * BotãoLimpar de todos ~> Limpa os campos
         * 
        */
        private void btnLimpar_ProdEsto_Click(object sender, EventArgs e)
        {
            mtbData_ProdEstoq.Text = "";
            mtbOp_ProdEsto.Text = "";
            mtbPalette_ProdEsto.Text = "";
            mtbQtdade_ProdEsto.Text = "";
            mtbValidade_ProdEsto.Text = "";
            txtCod_ProdEsto.Text = "";
            txtFunc_ProdEsto.Text = "";
            txtLocal_ProdEsto.Text = "";
            txtLote_ProdEsto.Text = "";
            txtObs_ProdEsto.Text = "";
            txtCodNome_ProdEsto.Text = "";
            btnSalvarInsert_ProdEsto.Enabled = false;
            btnSalvarUpdate_ProdEsto.Enabled = false;
            btnSalvarInsert_ProdEsto.Visible = false;
            btnSalvarUpdate_ProdEsto.Visible = true;
        }

        private void btnLimpar_ProdRot_Click(object sender, EventArgs e)
        {
            mtbData_ProdRot.Text = "";
            mtbOp_ProdRot.Text = "";
            mtbPalette_ProdRot.Text = "";
            mtbQtdade_ProdRot.Text = "";
            mtbValidade_ProdRot.Text = "";
            txtCod_ProdRot.Text = "";
            txtFunc_ProdRot.Text = "";
            txtLote_ProdRot.Text = "";
            txtObs_ProdRot.Text = "";
            txtCodNome_ProdRot.Text = "";
            btnSalvar_ProdRot.Enabled = false;
        }

        private void btnLimpar_ProcEsto_Click(object sender, EventArgs e)
        {
            mtbData_ProcEsto.Text = "";
            mtbPalette_ProcEsto.Text = "";
            mtbQtdade_ProcEsto.Text = "";
            mtbValidade_ProcEsto.Text = "";
            txtCod_ProcEsto.Text = "";
            txtFunc_ProcEsto.Text = "";
            txtObs_ProcEsto.Text = "";
            txtLocal_ProcEsto.Text = "";
            txtCodNome_ProcEsto.Text = "";
            btnSalvarInsert_ProcEsto.Enabled = false;
            btnSalvarUpdate_ProcEsto.Enabled = false;
            btnSalvarInsert_ProcEsto.Visible = false;
            btnSalvarUpdate_ProcEsto.Visible = true;
        }

        private void btnLimpar_DevRot_Click(object sender, EventArgs e)
        {
            mtbData_DevRot.Text = "";
            mtbQtdade_DevRot.Text = "";
            mtbValidade_DevRot.Text = "";
            mtbCodCli_DevRot.Text = "";
            mtbPedido_DevRot.Text = "";
            txtCod_DevRot.Text = "";
            txtFunc_DevRot.Text = "";
            txtObs_DevRot.Text = "";
            txtLote_DevRot.Text = "";
            txtNomeCli_DevRot.Text = "";
            txtCodNome_DevRot.Text = "";
            btnSalvar_DevRot.Enabled = false;
        }

        private void btnLimpar_DevRej_Click(object sender, EventArgs e)
        {
            mtbData_DevRej.Text = "";
            mtbQtdade_DevRej.Text = "";
            mtbValidade_DevRej.Text = "";
            mtbCodCli_DevRej.Text = "";
            mtbPedido_DevRej.Text = "";
            txtCod_DevRej.Text = "";
            txtFunc_DevRej.Text = "";
            txtObs_DevRej.Text = "";
            txtLote_DevRej.Text = "";
            txtNomeCli_DevRej.Text = "";
            txtCodNome_DevRej.Text = "";
            btnSalvar_DevRej.Enabled = false;
        }

        private void txtCod_ProdEsto_Enter(object sender, EventArgs e)
        {
            btnSalvarInsert_ProdEsto.Visible = false;
            btnSalvarUpdate_ProdEsto.Visible = true;
        }
        /*
         * 
         * Evento ConfereCampo ~> todos os campos passam por aqui
         * 
        */
        private void txtObs_ProdEsto_Leave(object sender, EventArgs e)
        {
            confereCampo_ProdEsto();
        }
        /*
         * 
         * Leaves de todos
         * 
        */
        private void txtLocal_ProdEsto_Leave(object sender, EventArgs e)
        {
            if (txtLocal_ProdEsto.Text != "" || txtCod_ProdEsto.Text != "")
            {
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                dtProduto = taProduto.getProduto(txtCod_ProdEsto.Text);

                if (dtProduto.Rows.Count > 0)
                {
                    string vLocal = dtProduto.Rows[0]["Local_Pro"].ToString();

                    if (!(vLocal == txtLocal_ProdEsto.Text) && vLocal != "")
                    {
                        if (MessageBox.Show(this, "Este produto não pertence a este local, ele pertence ao local " + vLocal +
                            "! Deseja salvar neste novo local?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            == System.Windows.Forms.DialogResult.Yes)
                        {
                            btnSalvarInsert_ProdEsto.Visible = true;
                            btnSalvarUpdate_ProdEsto.Visible = false;
                            mtbQtdade_ProdEsto.Focus();
                        }
                        else
                        {
                            btnSalvarInsert_ProdEsto.Visible = false;
                            btnSalvarUpdate_ProdEsto.Visible = true;
                            txtLocal_ProdEsto.SelectAll();
                        }
                    }
                }
            }
            confereCampo_ProdEsto();
        }

        private void txtLocal_ProcEsto_Leave(object sender, EventArgs e)
        {
            if (txtLocal_ProcEsto.Text != "" || txtCod_ProcEsto.Text != "")
            {
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                dtProduto = taProduto.getProduto(txtCod_ProcEsto.Text);

                if (dtProduto.Rows.Count > 0)
                {
                    string vLocal = dtProduto.Rows[0]["Local_Pro"].ToString();

                    if (!(vLocal == txtLocal_ProcEsto.Text) && vLocal != "")
                    {
                        if (MessageBox.Show(this, "Este produto não pertence a este local, ele pertence ao local " + vLocal +
                                "! Deseja salvar neste novo local?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                                == System.Windows.Forms.DialogResult.Yes)
                        {
                            btnSalvarInsert_ProcEsto.Visible = true;
                            btnSalvarUpdate_ProcEsto.Visible = false;
                            mtbQtdade_ProcEsto.Focus();
                        }
                        else
                        {
                            btnSalvarInsert_ProcEsto.Visible = false;
                            btnSalvarUpdate_ProcEsto.Visible = true;
                            mtbQtdade_ProcEsto.Focus();
                        }
                    }
                }
            }
            confereCampo_ProcEsto();
        }
        /*
         * 
         * Verifica se Existe o Produto
         * 
        */

        //Produção - Estoque
        private void txtCod_ProdEsto_Leave(object sender, EventArgs e)
        {
            btnPesq_ProdEsto.TabIndex = 4;
            if (txtCod_ProdEsto.Text != "")
            {
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                dtProduto = taProduto.getProduto(txtCod_ProdEsto.Text);

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
                        
                        btnPesq_ProdEsto.Focus();
                    }
                }
                else
                txtCodNome_ProdEsto.Text = dtProduto.Rows[0]["Nome"].ToString();
            }
            confereCampo_ProdEsto();
        }

        //Produção - Rotativo
        private void txtCod_ProdRot_Leave(object sender, EventArgs e)
        {
            btnPesq_ProdRot.TabIndex = 4;
            if (txtCod_ProdRot.Text != "")
            {
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                dtProduto = taProduto.getProduto(txtCod_ProdRot.Text);

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
                        btnPesq_ProdRot.Focus();
                    }
                }else
                txtCodNome_ProdRot.Text = dtProduto.Rows[0]["Nome"].ToString();
            }
            confereCampo_ProdRot();
        }

        //Processo - Estoque
        private void txtCod_ProcEsto_Leave(object sender, EventArgs e)
        {
            btnPesq_ProcEsto.TabIndex = 4;
            if (txtCod_ProcEsto.Text != "")
            {
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                dtProduto = taProduto.getProduto(txtCod_ProcEsto.Text);

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
                        btnPesq_ProcEsto.Focus();
                    }
                }else
                txtCodNome_ProcEsto.Text = dtProduto.Rows[0]["Nome"].ToString();
            }
            confereCampo_ProcEsto();
        }

        //Devolução - Rotativo
        private void txtCod_DevRot_Leave(object sender, EventArgs e)
        {
            btnPesq_DevRot.TabIndex = 4;
            if (txtCod_DevRot.Text != "")
            {
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                dtProduto = taProduto.getProduto(txtCod_DevRot.Text);

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
                        btnPesq_DevRot.Focus();
                    }
                }else
                txtCodNome_DevRot.Text = dtProduto.Rows[0]["Nome"].ToString();
            }
            confereCampo_DevRot();
        }

        //Devolução - Rejeitado
        private void txtCod_DevRej_Leave(object sender, EventArgs e)
        {
            btnPesq_DevRej.TabIndex = 4;
            if (txtCod_DevRej.Text != "")
            {
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                dtProduto = taProduto.getProduto(txtCod_DevRej.Text);

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
                        btnPesq_DevRej.Focus();
                    }
                }else
                txtCodNome_DevRej.Text = dtProduto.Rows[0]["Nome"].ToString();
            }
            confereCampo_DevRej();
        }
        /*
         * 
         * Nome do Cliente && Codigo do Cliente
         * 
        */
        //Devolução - Rotativo
        private void mtbCodCli_DevRot_Leave(object sender, EventArgs e)
        {
            if (mtbCodCli_DevRot.Text != "")
            {
                DEWM_ClienteTableAdapter taCliente = new DEWM_ClienteTableAdapter();
                DataSet_DEWM_MatheusDB.DEWM_ClienteDataTable dtCliente = new DataSet_DEWM_MatheusDB.DEWM_ClienteDataTable();
                dtCliente = taCliente.getCliente(int.Parse(mtbCodCli_DevRot.Text));

                if (dtCliente.Rows.Count == 0)
                {
                    if (MessageBox.Show(this, "Código de cliente não encontrado! Deseja cadastrar novo cliente?", "Cliente não encontrado!",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadCliente frmCliente = new frmCadCliente();
                        frmCliente.ShowDialog();
                    }
                    else
                    {
                        mtbCodCli_DevRot.Focus();
                        mtbCodCli_DevRot.SelectAll();
                    }
                }
                else
                {
                    txtNomeCli_DevRot.Text = dtCliente.Rows[0]["Nome"].ToString();
                }
            }
            confereCampo_DevRot();
        }

        //Devolução - Rejeitado
        private void mtbCodCli_DevRej_Leave(object sender, EventArgs e)
        {
            if (mtbCodCli_DevRej.Text != "")
            {
                DEWM_ClienteTableAdapter taCliente = new DEWM_ClienteTableAdapter();
                DataSet_DEWM_MatheusDB.DEWM_ClienteDataTable dtCliente = new DataSet_DEWM_MatheusDB.DEWM_ClienteDataTable();
                dtCliente = taCliente.getCliente(int.Parse(mtbCodCli_DevRej.Text));

                if (dtCliente.Rows.Count == 0)
                {
                    if (MessageBox.Show(this, "Código de cliente não encontrado! Deseja cadastrar novo cliente?", "Cliente não encontrado!",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        frmCadCliente frmCliente = new frmCadCliente();
                        frmCliente.ShowDialog();
                    }
                    else
                    {
                        mtbCodCli_DevRej.Focus();
                        mtbCodCli_DevRej.SelectAll();
                    }
                }
                else
                {
                    txtNomeCli_DevRej.Text = dtCliente.Rows[0]["Nome"].ToString();
                }
            }
            confereCampo_DevRej();
        }
        /*
         * 
         * BotãoSalvar de todos
         * 
        */

        //Produção - Estoque (update)
        int vQtde_Ent, vQtde;
        private void btnSalvarUpdate_ProdEsto_Click(object sender, EventArgs e)
        {
            origem = "Producao";
            destino = "Estoque";
            try
            {
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();

                DEWM_MovimentacaoTableAdapter taMov = new DEWM_MovimentacaoTableAdapter();
                vQtde_Ent = int.Parse(mtbQtdade_ProdEsto.Text);
                vQtde = (int)taProduto.getSaldo(txtCod_ProdEsto.Text);
                vQtde_Ent = vQtde_Ent + vQtde;

                taMov.insMovEnt(txtCod_ProdEsto.Text, "Entrada", destino, int.Parse(mtbQtdade_ProdEsto.Text), 
                    DateTime.Parse(mtbData_ProdEstoq.Text), vQtde_Ent, txtObs_ProdEsto.Text);

                taProduto.upProduto_ProdEsto(origem, txtLocal_ProdEsto.Text, DateTime.Parse(mtbValidade_ProdEsto.Text),
                    Convert.ToString(mtbOp_ProdEsto.Text), Convert.ToString(mtbPalette_ProdEsto.Text), txtLote_ProdEsto.Text, vQtde_Ent,
                    txtCod_ProdEsto.Text);

                MessageBox.Show(this, "Entrada de produto com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_ProdEsto_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Produção - Estoque (insert)
        private void btnSalvarInsert_ProdEsto_Click(object sender, EventArgs e)
        {
            //O insert acontece quando eu vou ter dois produtos no mesmo local
            origem = "Producao";
            destino = "Estoque";
            try
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable dtProduto = new DataSet_DEWM_MatheusDB.DEWM_ProdutoDataTable();

                DEWM_MovimentacaoTableAdapter taMov = new DEWM_MovimentacaoTableAdapter();
                vQtde_Ent = int.Parse(mtbQtdade_ProdEsto.Text);
                vQtde = (int)taProduto.getSaldo(txtCod_ProdEsto.Text);

                vQtde_Ent = vQtde_Ent + vQtde;
                taMov.insMovEnt(txtCod_ProdEsto.Text, "Entrada", destino, int.Parse(mtbQtdade_ProdEsto.Text), 
                    DateTime.Parse(mtbData_ProdEstoq.Text), vQtde_Ent, txtObs_ProdEsto.Text);

                taProduto.insProduto_ProdEsto(txtCod_ProdEsto.Text, origem, txtLocal_ProdEsto.Text, DateTime.Parse(mtbValidade_ProdEsto.Text),
                    Convert.ToString(mtbOp_ProdEsto.Text), Convert.ToString(mtbPalette_ProdEsto.Text), txtLote_ProdEsto.Text, vQtde_Ent);

                MessageBox.Show(this, "Entrada de produto com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_ProdEsto_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Produção - Rotativo
        private void btnSalvar_ProdRot_Click(object sender, EventArgs e)
        {
            origem = "Produção";
            destino = "Rotativo";
            try
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();

                DEWM_MovimentacaoTableAdapter taMov = new DEWM_MovimentacaoTableAdapter();
                vQtde_Ent = int.Parse(mtbQtdade_ProdRot.Text);
                vQtde = (int)taProduto.getSaldo(txtCod_ProdRot.Text);

                vQtde_Ent = vQtde_Ent + vQtde;
                taMov.insMovEnt(txtCod_ProdRot.Text, "Entrada", destino, int.Parse(mtbQtdade_ProdRot.Text), 
                    DateTime.Parse(mtbData_ProdRot.Text), vQtde_Ent, txtObs_ProdRot.Text);

                taProduto.upProduto_ProdRot(origem, DateTime.Parse(mtbValidade_ProdRot.Text), Convert.ToString(mtbOp_ProdRot.Text),
                    Convert.ToString(mtbPalette_ProdRot.Text), txtLote_ProdRot.Text,vQtde_Ent, txtCod_ProdRot.Text);

                MessageBox.Show(this, "Entrada de produto com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_ProdRot_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Processo - Estoque (update)
        private void btnSalvarUpdate_ProcEsto_Click(object sender, EventArgs e)
        {
            origem = "Processo";
            destino = "Estoque";
            try
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();

                DEWM_MovimentacaoTableAdapter taMov = new DEWM_MovimentacaoTableAdapter();
                vQtde_Ent = int.Parse(mtbQtdade_ProcEsto.Text);
                vQtde = (int)taProduto.getSaldo(txtCod_ProcEsto.Text);

                vQtde_Ent = vQtde_Ent + vQtde;
                taMov.insMovEnt(txtCod_ProcEsto.Text, "Entrada", destino, int.Parse(mtbQtdade_ProcEsto.Text), 
                    DateTime.Parse(mtbData_ProcEsto.Text), vQtde_Ent, txtObs_ProcEsto.Text);

                taProduto.upProduto_ProcEsto(origem, DateTime.Parse(mtbValidade_ProcEsto.Text), Convert.ToString(mtbPalette_ProcEsto.Text),
                   vQtde_Ent, txtCod_ProcEsto.Text);

                MessageBox.Show(this, "Entrada de produto com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_ProcEsto_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Processo - Estoque (insert)
        private void btnSalvarInsert_ProcEsto_Click(object sender, EventArgs e)
        {
            //O insert acontece quando eu vou ter dois produtos no mesmo local
            origem = "Processo";
            destino = "Estoque";
            try
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();

                DEWM_MovimentacaoTableAdapter taMov = new DEWM_MovimentacaoTableAdapter();
                vQtde_Ent = int.Parse(mtbQtdade_ProcEsto.Text);
                vQtde = (int)taProduto.getSaldo(txtCod_ProcEsto.Text);

                vQtde_Ent = vQtde_Ent + vQtde;
                taMov.insMovEnt(txtCod_ProcEsto.Text, "Entrada", destino, int.Parse(mtbQtdade_ProcEsto.Text),
                    DateTime.Parse(mtbData_ProcEsto.Text), vQtde_Ent, txtObs_ProcEsto.Text);

                taProduto.insProduto_ProcEsto(txtCod_ProcEsto.Text, origem, DateTime.Parse(mtbValidade_ProcEsto.Text),
                    Convert.ToString(mtbPalette_ProcEsto.Text), vQtde_Ent);

                MessageBox.Show(this, "Entrada de produto com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_ProcEsto_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Devolução - Rotativo
        private void btnSalvar_DevRot_Click(object sender, EventArgs e)
        {
            origem = "Devolução";
            destino = "Rotativo";
            try
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();

                DEWM_MovimentacaoTableAdapter taMov = new DEWM_MovimentacaoTableAdapter();
                vQtde_Ent = int.Parse(mtbQtdade_DevRot.Text);
                vQtde = (int)taMov.getQtde(txtCod_DevRot.Text);

                vQtde_Ent = vQtde_Ent + vQtde;
                taMov.insMovEnt_Dev(int.Parse(mtbCodCli_DevRot.Text),int.Parse(txtCod_DevRot.Text), "Entrada", destino, int.Parse(mtbQtdade_DevRot.Text),
                    DateTime.Parse(mtbData_DevRot.Text), vQtde_Ent, txtObs_DevRot.Text);

                taProduto.upProduto_Dev(origem, DateTime.Parse(mtbValidade_DevRot.Text), txtLote_DevRot.Text, vQtde_Ent, txtCod_DevRot.Text);

                MessageBox.Show(this, "Entrada de produto com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_DevRot_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Devolução - Rejeitado
        private void btnSalvar_DevRej_Click(object sender, EventArgs e)
        {
            origem = "Devolução";
            destino = "Rejeitado";
            try
            {
                DEWM_ProdutoTableAdapter taProduto = new DEWM_ProdutoTableAdapter();
                DEWM_MovimentacaoTableAdapter taMov = new DEWM_MovimentacaoTableAdapter();

                vQtde_Ent = int.Parse(mtbQtdade_DevRej.Text);
                vQtde = (int)taMov.getQtde(txtCod_DevRej.Text);
                vQtde_Ent = vQtde_Ent + vQtde;

                taMov.insMovEnt_Dev(int.Parse(mtbCodCli_DevRej.Text), int.Parse(txtCod_DevRej.Text), "Entrada", destino, int.Parse(mtbQtdade_DevRej.Text), 
                    DateTime.Parse(mtbData_DevRej.Text), vQtde_Ent, txtObs_DevRej.Text);
                taProduto.upProduto_Dev(origem, DateTime.Parse(mtbValidade_DevRej.Text), txtLote_DevRej.Text,vQtde_Ent, txtCod_DevRej.Text);

                MessageBox.Show(this, "Entrada de produto com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar_DevRej_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
         * 
         * Botões Pesquisa de Produto
         * 
         */
        private void btnPesq_ProdEsto_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisaPro = new frmPesquisaProduto();
            frmPesquisaPro.ShowDialog();
            txtCod_ProdEsto.Text = frmPesquisaPro.CodigoRetorno.ToString();
            txtCod_ProdEsto.Focus();
            txtLocal_ProdEsto.Focus();
        }

        private void btnPesq_ProdRot_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisaPro = new frmPesquisaProduto();
            frmPesquisaPro.ShowDialog();
            txtCod_ProdRot.Text = frmPesquisaPro.CodigoRetorno.ToString();
            txtCod_ProdRot.Focus();
            mtbQtdade_ProdRot.Focus();
        }

        private void btnPesq_ProcEsto_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisaPro = new frmPesquisaProduto();
            frmPesquisaPro.ShowDialog();
            txtCod_ProcEsto.Text = frmPesquisaPro.CodigoRetorno.ToString();
            txtCod_ProcEsto.Focus();
            txtLocal_ProcEsto.Focus();
        }

        private void btnPesq_DevRot_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisaPro = new frmPesquisaProduto();
            frmPesquisaPro.ShowDialog();
            txtCod_DevRot.Text = frmPesquisaPro.CodigoRetorno.ToString();
            txtCod_DevRot.Focus();
            mtbQtdade_DevRot.Focus();
        }

        private void btnPesq_DevRej_Click(object sender, EventArgs e)
        {
            frmPesquisaProduto frmPesquisaPro = new frmPesquisaProduto();
            frmPesquisaPro.ShowDialog();
            txtCod_DevRej.Text = frmPesquisaPro.CodigoRetorno.ToString();
            txtCod_DevRej.Focus();
            mtbQtdade_DevRej.Focus();
        }

        

        
    }
}
