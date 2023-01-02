namespace WFATCC.Relatorios
{
    partial class frmRelatorioSaida
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DEWM_MovimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSaida = new WFATCC.DataSetSaida();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetSaidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DEWM_MovimentacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DEWM_MovimentacaoBindingSource
            // 
            this.DEWM_MovimentacaoBindingSource.DataMember = "DEWM_Movimentacao";
            this.DEWM_MovimentacaoBindingSource.DataSource = this.dataSetSaida;
            // 
            // dataSetSaida
            // 
            this.dataSetSaida.DataSetName = "DataSetSaida";
            this.dataSetSaida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataSetSaidaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WFATCC.Relatorios.rptSaida.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(700, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetSaidaBindingSource
            // 
            this.dataSetSaidaBindingSource.DataSource = this.dataSetSaida;
            this.dataSetSaidaBindingSource.Position = 0;
            // 
            // frmRelatorioSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 370);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRelatorioSaida";
            this.Text = "Relatorio de Saida";
            this.Load += new System.EventHandler(this.frmRelatorioSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DEWM_MovimentacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSaidaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DEWM_MovimentacaoBindingSource;
        private DataSetSaida dataSetSaida;
        private System.Windows.Forms.BindingSource dataSetSaidaBindingSource;
    }
}