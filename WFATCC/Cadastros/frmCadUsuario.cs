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

namespace WFATCC.Formularios
{
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();
            btnSalvar.Enabled = false;
        }

        private void confereCampo()
        {
            if (txtUsuario.Text.Length == 0 || txtSenha.Text.Length == 0 || txtConfSenha.Text.Length == 0)
            {
                btnSalvar.Enabled = false;
            }
            else
                btnSalvar.Enabled = true;
        }

        private void txtConfSenha_Leave(object sender, EventArgs e)
        {
            if (txtConfSenha.Text != txtSenha.Text)
            {
                btnSalvar.Enabled = false;
                sError.SetError(txtConfSenha, "Senha inválida!");
                MessageBox.Show("Confirmação de senha incorreta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfSenha.SelectAll();
                txtConfSenha.Focus();
            }
            else
            {
                sError.SetError(txtConfSenha, "");
                confereCampo();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            confereCampo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int privilegio;
            try
            {
                if (rdbComum.Checked)
                {
                    privilegio = 0;
                }
                else
                {
                    privilegio = 1;
                }
                DEWM_UsuariosTableAdapter ta = new DEWM_UsuariosTableAdapter();
                DataSet_DEWM_MatheusDB ds = new DataSet_DEWM_MatheusDB();
                ta.Insert(txtUsuario.Text, txtSenha.Text, privilegio);
                MessageBox.Show(this, "Usuário salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                if(se.Message.StartsWith("Violation of UNIQUE KEY constraint"))
                {
                    MessageBox.Show(this, "Usuário ja cadastrado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(se.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
