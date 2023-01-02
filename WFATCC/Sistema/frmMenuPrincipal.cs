using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WFATCC.Cadastros;
using WFATCC.Movimentação;
using WFATCC.Usuários;
using WFATCC.Sistema;
using WFATCC.Formularios;
using WFATCC.Relatorios;

namespace WFATCC.Sistema
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            /*if (Properties.Settings.Default.NivelUsuarioLogado != 1)
            {
                usuárioToolStripMenuItem.Visible = false;
                mstCadUsuario.Visible = false;
            }*/
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirma!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            staUsuario.Text = "Usuário atual: " + Properties.Settings.Default.NomeUsuarioLogado;
        }

        private void mstCadProduto_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadProduto>().Count() > 0)
            {
                MessageBox.Show(this, "Janela já aberta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmCadProduto cadProduto = new frmCadProduto();
                cadProduto.MdiParent = this;
                cadProduto.Show();
            }
        }

        private void mstCadCliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadCliente>().Count() > 0)
            {
                MessageBox.Show(this, "Janela já aberta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmCadCliente cadCliente = new frmCadCliente();
                cadCliente.MdiParent = this;
                cadCliente.Show();
            }
        }

        private void mstCadUsuario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadUsuario>().Count() > 0)
            {
                MessageBox.Show(this, "Janela já aberta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmCadUsuario cadUsuario = new frmCadUsuario();
                cadUsuario.MdiParent = this;
                cadUsuario.Show();
            }
        }

        private void mstMovEntrada_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmMovEntrada>().Count() > 0)
            {
                MessageBox.Show(this, "Janela já aberta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmMovEntrada movEntrada = new frmMovEntrada();
                movEntrada.MdiParent = this;
                movEntrada.Show();
            }
        }

        private void mstMovSaida_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmMovSaida>().Count() > 0)
            {
                MessageBox.Show(this, "Janela já aberta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmMovSaida movSaida = new frmMovSaida();
                movSaida.MdiParent = this;
                movSaida.Show();
            }
        }

        private void mstRelatEntrada_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelatorioEntrada>().Count() > 0)
            {
                MessageBox.Show(this, "Janela já aberta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmRelatorioEntrada relatorioEntrada = new frmRelatorioEntrada();
                relatorioEntrada.MdiParent = this;
                relatorioEntrada.Show();
            }
        }

        private void mstRelatSaida_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelatorioSaida>().Count() > 0)
            {
                MessageBox.Show(this, "Janela já aberta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmRelatorioSaida relatorioSaida = new frmRelatorioSaida();
                relatorioSaida.MdiParent = this;
                relatorioSaida.Show();
            }
        }

        private void mstRelatSaldo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelatorioSaldo>().Count() > 0)
            {
                MessageBox.Show(this, "Janela já aberta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmRelatorioSaldo relatorioSaldo = new frmRelatorioSaldo();
                relatorioSaldo.MdiParent = this;
                relatorioSaldo.Show();
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelatorioSaldo>().Count() > 0)
            {
                MessageBox.Show(this, "Janela já aberta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmConsultaProduto consultaProduto = new frmConsultaProduto();
                consultaProduto.MdiParent = this;
                consultaProduto.Show();
            }
        }

        private void mstAlterUsuario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmAlterarUsuario>().Count() > 0)
            {
                MessageBox.Show(this, "Janela já aberta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmAlterarUsuario alterarUsuario = new frmAlterarUsuario();
                alterarUsuario.MdiParent = this;
                alterarUsuario.Show();
            }
        }

        /*private void mstManual_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCadProduto>().Count() > 0)
            {
                MessageBox.Show(this, "Janela já aberta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
            //TODO manual do usuario
            }
        }*/

        private void mstSobre_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSobre>().Count() > 0)
            {
                MessageBox.Show(this, "Janela já aberta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmSobre sobre = new frmSobre();
                sobre.MdiParent = this;
                sobre.Show();
            }
        }


        private void gerarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSobre>().Count() > 0)
            {
                MessageBox.Show(this, "Janela já aberta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frmBackup backup = new frmBackup();
                backup.MdiParent = this;
                backup.Show();
            }
        }

        private void mstSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirma!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                //HUEHUEHUEHUHE
            }
            else
            {
                Application.ExitThread();
            }
        }
    }
}
