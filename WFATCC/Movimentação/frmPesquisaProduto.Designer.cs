namespace WFATCC.Movimentação
{
    partial class frmPesquisaProduto
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
            this.lstProduto = new System.Windows.Forms.ListBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_DEWM_MatheusDB = new WFATCC.Dados.DataSet_DEWM_MatheusDB();
            this.dEWM_ProdutoTableAdapter = new WFATCC.Dados.DataSet_DEWM_MatheusDBTableAdapters.DEWM_ProdutoTableAdapter();
            this.dEWMProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DEWM_MatheusDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEWMProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProduto
            // 
            this.lstProduto.DataSource = this.dEWMProdutoBindingSource;
            this.lstProduto.DisplayMember = "Nome";
            this.lstProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProduto.FormattingEnabled = true;
            this.lstProduto.ItemHeight = 16;
            this.lstProduto.Location = new System.Drawing.Point(12, 74);
            this.lstProduto.Name = "lstProduto";
            this.lstProduto.Size = new System.Drawing.Size(260, 276);
            this.lstProduto.TabIndex = 2;
            this.lstProduto.ValueMember = "Cod_Pro";
            this.lstProduto.DoubleClick += new System.EventHandler(this.lstProduto_DoubleClick);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(12, 34);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(260, 20);
            this.txtProduto.TabIndex = 1;
            this.txtProduto.TextChanged += new System.EventHandler(this.txtProduto_TextChanged);
            // 
            // bindingSource
            // 
            this.bindingSource.AllowNew = true;
            this.bindingSource.DataMember = "DEWM_Produto";
            this.bindingSource.DataSource = this.dataSet_DEWM_MatheusDB;
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
            // dEWMProdutoBindingSource
            // 
            this.dEWMProdutoBindingSource.DataMember = "DEWM_Produto";
            this.dEWMProdutoBindingSource.DataSource = this.dataSet_DEWM_MatheusDB;
            // 
            // frmPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 403);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lstProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmPesquisaProduto";
            this.Text = "Pesquisa de Produto";
            this.Load += new System.EventHandler(this.frmPesquisaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_DEWM_MatheusDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEWMProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private Dados.DataSet_DEWM_MatheusDB dataSet_DEWM_MatheusDB;
        public Dados.DataSet_DEWM_MatheusDBTableAdapters.DEWM_ProdutoTableAdapter dEWM_ProdutoTableAdapter;
        public System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingSource dEWMProdutoBindingSource;
    }
}