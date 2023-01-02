namespace WFATCC.Sistema
{
    partial class frmConsultaProduto
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
            this.components = new System.ComponentModel.Container();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNomeFrm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.Cod_Pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localProDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoEstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEWMProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDEWMMatheusDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_DEWM_MatheusDB = new WFATCC.Dados.DataSet_DEWM_MatheusDB();
            this.dEWM_ProdutoTableAdapter = new WFATCC.Dados.DataSet_DEWM_MatheusDBTableAdapters.DEWM_ProdutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEWMProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDEWMMatheusDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DEWM_MatheusDB)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(94, 59);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(186, 22);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código:";
            // 
            // lblNomeFrm
            // 
            this.lblNomeFrm.AutoSize = true;
            this.lblNomeFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFrm.ForeColor = System.Drawing.Color.Blue;
            this.lblNomeFrm.Location = new System.Drawing.Point(168, 18);
            this.lblNomeFrm.Name = "lblNomeFrm";
            this.lblNomeFrm.Size = new System.Drawing.Size(181, 24);
            this.lblNomeFrm.TabIndex = 5;
            this.lblNomeFrm.Text = "Consulta de Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(94, 107);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(354, 40);
            this.txtDescricao.TabIndex = 38;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AutoGenerateColumns = false;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Pro,
            this.localProDataGridViewTextBoxColumn,
            this.saldoEstDataGridViewTextBoxColumn,
            this.loteDataGridViewTextBoxColumn,
            this.validadeDataGridViewTextBoxColumn});
            this.dgvPesquisa.DataSource = this.dEWMProdutoBindingSource;
            this.dgvPesquisa.Location = new System.Drawing.Point(12, 169);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.Size = new System.Drawing.Size(504, 189);
            this.dgvPesquisa.TabIndex = 39;
            // 
            // Cod_Pro
            // 
            this.Cod_Pro.DataPropertyName = "Cod_Pro";
            this.Cod_Pro.HeaderText = "Código";
            this.Cod_Pro.Name = "Cod_Pro";
            this.Cod_Pro.ReadOnly = true;
            // 
            // localProDataGridViewTextBoxColumn
            // 
            this.localProDataGridViewTextBoxColumn.DataPropertyName = "Local_Pro";
            this.localProDataGridViewTextBoxColumn.HeaderText = "Local";
            this.localProDataGridViewTextBoxColumn.Name = "localProDataGridViewTextBoxColumn";
            this.localProDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoEstDataGridViewTextBoxColumn
            // 
            this.saldoEstDataGridViewTextBoxColumn.DataPropertyName = "Saldo_Est";
            this.saldoEstDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.saldoEstDataGridViewTextBoxColumn.Name = "saldoEstDataGridViewTextBoxColumn";
            this.saldoEstDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loteDataGridViewTextBoxColumn
            // 
            this.loteDataGridViewTextBoxColumn.DataPropertyName = "Lote";
            this.loteDataGridViewTextBoxColumn.HeaderText = "Lote";
            this.loteDataGridViewTextBoxColumn.Name = "loteDataGridViewTextBoxColumn";
            this.loteDataGridViewTextBoxColumn.ReadOnly = true;
            this.loteDataGridViewTextBoxColumn.Width = 80;
            // 
            // validadeDataGridViewTextBoxColumn
            // 
            this.validadeDataGridViewTextBoxColumn.DataPropertyName = "Validade";
            this.validadeDataGridViewTextBoxColumn.HeaderText = "Validade";
            this.validadeDataGridViewTextBoxColumn.Name = "validadeDataGridViewTextBoxColumn";
            this.validadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.validadeDataGridViewTextBoxColumn.Width = 80;
            // 
            // dEWMProdutoBindingSource
            // 
            this.dEWMProdutoBindingSource.DataMember = "DEWM_Produto";
            this.dEWMProdutoBindingSource.DataSource = this.dataSetDEWMMatheusDBBindingSource;
            // 
            // dataSetDEWMMatheusDBBindingSource
            // 
            this.dataSetDEWMMatheusDBBindingSource.DataSource = this.dataSet_DEWM_MatheusDB;
            this.dataSetDEWMMatheusDBBindingSource.Position = 0;
            // 
            // dataSet_DEWM_MatheusDB
            // 
            this.dataSet_DEWM_MatheusDB.DataSetName = "DataSet_DEWM_MatheusDB";
            this.dataSet_DEWM_MatheusDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEWM_ProdutoTableAdapter
            // 
            this.dEWM_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 422);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNomeFrm);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmConsultaProduto";
            this.Text = "Consulta de Produto";
            this.Load += new System.EventHandler(this.frmConsultaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEWMProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDEWMMatheusDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DEWM_MatheusDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNomeFrm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.BindingSource dataSetDEWMMatheusDBBindingSource;
        private Dados.DataSet_DEWM_MatheusDB dataSet_DEWM_MatheusDB;
        private System.Windows.Forms.BindingSource dEWMProdutoBindingSource;
        private Dados.DataSet_DEWM_MatheusDBTableAdapters.DEWM_ProdutoTableAdapter dEWM_ProdutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn localProDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoEstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validadeDataGridViewTextBoxColumn;
    }
}