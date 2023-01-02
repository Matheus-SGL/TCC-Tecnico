using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFATCC.Sistema;

namespace WFATCC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        int  Erros = 0;

        private bool CaixasOK()
        {
            if (txtUsuario.Text == "")
            {
                errError.SetError(txtUsuario, "Informar o usuário!");
                return false;
            }
            else
                errError.SetError(txtUsuario, "");

            if (txtSenha.Text == "")
            {
                errError.SetError(txtSenha, "Informar a senha!");
                return false;
            }
            else
                errError.SetError(txtSenha, "");
            return true;
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CaixasOK())
            {
                if (txtUsuario.Text != "admin" && txtSenha.Text != "nn4045")
                {
                    MessageBox.Show(this, "Usuário ou Senha inválidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Erros++;
                    if (Erros == 3)
                    {
                        MessageBox.Show(this, "Número de tentativas esgotado...", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Exit();
                    }
                }
                else
                {
                    Properties.Settings.Default.NivelUsuarioLogado = 1;
                    Properties.Settings.Default.NomeUsuarioLogado = txtUsuario.Text;
                    frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
                    menuPrincipal.Show();
                    this.Close();
                }

                /*if (CaixasOK())
                {
                    DataSet_DEWM_MatheusDB.UsuarisoDataTable dtUsuario;
                    UsuariosTableAdapter taUsuario = new UsuariosTableAdapter();
                    dtUsuario = taUsuario.VerificaNivel(txtUsuario.Text, txtSenha.Text);
                    if (dtUsuario.Rows.Count == 0)
                    {
                        MessageBox.Show(this, "Usuário ou senha inválidos!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Erros++;
                        if (Erros == 3)
                        {
                            MessageBox.Show(this, "Número de tentativas esgotado...", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            taUsuario.Dispose();
                            Application.Exit();
                        }
                    }
                    else
                    {
                        Properties.Settings.Default.NivelUsuarioLogado = (int)dtUsuario.Rows[0]["Nivel"];
                        Properties.Settings.Default.NomeUsuarioLogado = txtUsuario.Text;
                        frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
                        menuPrincipal.Show();
                        this.Close();
                    }
                }*/
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
