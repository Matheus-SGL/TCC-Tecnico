namespace WFATCC.Sistema
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.staUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.cadastroDeProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.entradaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.alterarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.manualDoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 404);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(930, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // staUsuario
            // 
            this.staUsuario.Name = "staUsuario";
            this.staUsuario.Size = new System.Drawing.Size(93, 17);
            this.staUsuario.Text = "Usuário Logado:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripButton1,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton5,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(930, 60);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeProdutoToolStripMenuItem,
            this.cadastroDeClienteToolStripMenuItem,
            this.cadastroDeUsuárioToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(117, 57);
            this.toolStripDropDownButton1.Text = "&Cadastro";
            // 
            // cadastroDeProdutoToolStripMenuItem
            // 
            this.cadastroDeProdutoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroDeProdutoToolStripMenuItem.Image")));
            this.cadastroDeProdutoToolStripMenuItem.Name = "cadastroDeProdutoToolStripMenuItem";
            this.cadastroDeProdutoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.P)));
            this.cadastroDeProdutoToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.cadastroDeProdutoToolStripMenuItem.Text = "Cadastro de Produto";
            this.cadastroDeProdutoToolStripMenuItem.Click += new System.EventHandler(this.mstCadProduto_Click);
            // 
            // cadastroDeClienteToolStripMenuItem
            // 
            this.cadastroDeClienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroDeClienteToolStripMenuItem.Image")));
            this.cadastroDeClienteToolStripMenuItem.Name = "cadastroDeClienteToolStripMenuItem";
            this.cadastroDeClienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.C)));
            this.cadastroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.cadastroDeClienteToolStripMenuItem.Text = "Cadastro de Cliente";
            this.cadastroDeClienteToolStripMenuItem.Click += new System.EventHandler(this.mstCadCliente_Click);
            // 
            // cadastroDeUsuárioToolStripMenuItem
            // 
            this.cadastroDeUsuárioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroDeUsuárioToolStripMenuItem.Image")));
            this.cadastroDeUsuárioToolStripMenuItem.Name = "cadastroDeUsuárioToolStripMenuItem";
            this.cadastroDeUsuárioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.U)));
            this.cadastroDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.cadastroDeUsuárioToolStripMenuItem.Text = "Cadastro de Usuário";
            this.cadastroDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.mstCadUsuario_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.saídaToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(150, 57);
            this.toolStripDropDownButton2.Text = "&Movimentação";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("entradaToolStripMenuItem.Image")));
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.entradaToolStripMenuItem.Text = "&Entrada";
            this.entradaToolStripMenuItem.Click += new System.EventHandler(this.mstMovEntrada_Click);
            // 
            // saídaToolStripMenuItem
            // 
            this.saídaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saídaToolStripMenuItem.Image")));
            this.saídaToolStripMenuItem.Name = "saídaToolStripMenuItem";
            this.saídaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saídaToolStripMenuItem.Text = "&Saída";
            this.saídaToolStripMenuItem.Click += new System.EventHandler(this.mstMovSaida_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem1,
            this.saídaToolStripMenuItem1,
            this.saldoToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(122, 57);
            this.toolStripDropDownButton3.Text = "&Relatórios";
            // 
            // entradaToolStripMenuItem1
            // 
            this.entradaToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("entradaToolStripMenuItem1.Image")));
            this.entradaToolStripMenuItem1.Name = "entradaToolStripMenuItem1";
            this.entradaToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.entradaToolStripMenuItem1.Text = "Entrada";
            this.entradaToolStripMenuItem1.Click += new System.EventHandler(this.mstRelatEntrada_Click);
            // 
            // saídaToolStripMenuItem1
            // 
            this.saídaToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saídaToolStripMenuItem1.Image")));
            this.saídaToolStripMenuItem1.Name = "saídaToolStripMenuItem1";
            this.saídaToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.saídaToolStripMenuItem1.Text = "Saída";
            this.saídaToolStripMenuItem1.Click += new System.EventHandler(this.mstRelatSaida_Click);
            // 
            // saldoToolStripMenuItem
            // 
            this.saldoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saldoToolStripMenuItem.Image")));
            this.saldoToolStripMenuItem.Name = "saldoToolStripMenuItem";
            this.saldoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saldoToolStripMenuItem.Text = "Saldo";
            this.saldoToolStripMenuItem.Click += new System.EventHandler(this.mstRelatSaldo_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(163, 57);
            this.toolStripButton1.Text = "Consultar &Produtos";
            this.toolStripButton1.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarUsuárioToolStripMenuItem,
            this.gerarBackupToolStripMenuItem});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(125, 57);
            this.toolStripDropDownButton4.Text = "&Segurança";
            // 
            // alterarUsuárioToolStripMenuItem
            // 
            this.alterarUsuárioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alterarUsuárioToolStripMenuItem.Image")));
            this.alterarUsuárioToolStripMenuItem.Name = "alterarUsuárioToolStripMenuItem";
            this.alterarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alterarUsuárioToolStripMenuItem.Text = "&Alterar Usuário";
            this.alterarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.mstAlterUsuario_Click);
            // 
            // gerarBackupToolStripMenuItem
            // 
            this.gerarBackupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gerarBackupToolStripMenuItem.Image")));
            this.gerarBackupToolStripMenuItem.Name = "gerarBackupToolStripMenuItem";
            this.gerarBackupToolStripMenuItem.Size = new System.Drawing.Size(186, 56);
            this.gerarBackupToolStripMenuItem.Text = "Gerar &Backup";
            this.gerarBackupToolStripMenuItem.Click += new System.EventHandler(this.gerarBackupToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDoUsuárioToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(101, 57);
            this.toolStripDropDownButton5.Text = "&Ajuda";
            // 
            // manualDoUsuárioToolStripMenuItem
            // 
            this.manualDoUsuárioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manualDoUsuárioToolStripMenuItem.Image")));
            this.manualDoUsuárioToolStripMenuItem.Name = "manualDoUsuárioToolStripMenuItem";
            this.manualDoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.manualDoUsuárioToolStripMenuItem.Text = "&Manual do Usuário";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem.Image")));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.mstSobre_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(80, 57);
            this.toolStripButton2.Text = "&Sair";
            this.toolStripButton2.Click += new System.EventHandler(this.mstSair_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 426);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel staUsuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saídaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem alterarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
        private System.Windows.Forms.ToolStripMenuItem manualDoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}