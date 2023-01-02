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

namespace WFATCC.Usuários
{
    public partial class frmAlterarUsuario : Form
    {
        public frmAlterarUsuario()
        {
            InitializeComponent();
            travaCampo();
            atualizaGrid();
        }

        private void confereCampo()
        {
            if (txtUsuario.Text.Length == 0 || txtSenha.Text.Length == 0 || txtConfSenha.Text.Length == 0)
            {
                btnSalvarUpdate.Enabled = false;
                travaCampo();
            }
            else
            {
                btnSalvarUpdate.Enabled = true;
                liberaCampo();
            }
        }

        private void limpaCampo()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtConfSenha.Text = "";
        }

        private void travaCampo()
        {
            txtUsuario.ReadOnly = true;
            txtSenha.ReadOnly = true;
            txtConfSenha.ReadOnly = true;
            groupBox1.Enabled = false;
        }

        private void liberaCampo()
        {
            txtUsuario.ReadOnly = false;
            txtSenha.ReadOnly = false;
            txtConfSenha.ReadOnly = false;
            groupBox1.Enabled = true;
        }

        private void atualizaTabela()
        {
            txtUsuario.Text = dgvUsuario[1, dgvUsuario.CurrentRow.Index].Value.ToString();
            txtSenha.Text = dgvUsuario[2, dgvUsuario.CurrentRow.Index].Value.ToString();
            txtConfSenha.Text = txtSenha.Text;
            if ((dgvUsuario[3, dgvUsuario.CurrentRow.Index].Value.Equals(1)))
            {
                rdbAvancado.Checked = true;
            }
            else
            {
                rdbComum.Checked = true;
            }
        }

        private void atualizaGrid()
        {
            DEWM_UsuariosTableAdapter ta = new DEWM_UsuariosTableAdapter();
            DataSet_DEWM_MatheusDB ds = new DataSet_DEWM_MatheusDB();
            ta.Fill(ds.DEWM_Usuarios);
            bindingSource.DataSource = ds.DEWM_Usuarios;
            dgvUsuario.DataSource = bindingSource;
            bindingNavigator.BindingSource = bindingSource;

            dgvUsuario.Columns[0].HeaderText = "ID";
            dgvUsuario.Columns[0].Width = 50;
            dgvUsuario.Columns[1].HeaderText = "Usuário";
            dgvUsuario.Columns[1].Width = 200;
            dgvUsuario.Columns[2].Visible = false;
            dgvUsuario.Columns[3].HeaderText = "Privilégio*";
            dgvUsuario.Columns[3].Width = 50;
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizaTabela();
            confereCampo();
        }

        private void dgvUsuario_DoubleClick(object sender, EventArgs e)
        {
            atualizaTabela();
            confereCampo();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaCampo();
            travaCampo();
            rdbAvancado.Checked = false;
            rdbComum.Checked = false;
        }

        private void btnSalvarUpdate_Click(object sender, EventArgs e)
        {
            int privilegio;
            if (rdbComum.Checked)
            {
                privilegio = 0;
            }
            else
            {
                privilegio = 1;
            }
            try
            {
                DEWM_UsuariosTableAdapter ta = new DEWM_UsuariosTableAdapter();
                ta.Update(txtUsuario.Text, txtSenha.Text, privilegio, (int)dgvUsuario.CurrentRow.Cells[0].Value);

                MessageBox.Show(this, "Usuário alterado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizaGrid();
                limpaCampo();
                travaCampo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length == 0)
            {
                MessageBox.Show(this, "Um usuário deve ser selecionado antes!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
                try
                {
                    DEWM_UsuariosTableAdapter ta = new DEWM_UsuariosTableAdapter();
                    ta.Delete((int)dgvUsuario.CurrentRow.Cells[0].Value);

                    MessageBox.Show(this, "Cliente deletado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizaGrid();
                    limpaCampo();
                    travaCampo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
