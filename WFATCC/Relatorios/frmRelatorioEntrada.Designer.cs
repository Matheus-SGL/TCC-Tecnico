namespace WFATCC.Relatorios
{
    partial class frmRelatorioEntrada
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetRelatorioEntrada = new WFATCC.DataSetRelatorioEntrada();
            this.dataSetRelatorioEntradaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DEWM_MovimentacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRelatorioEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRelatorioEntradaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEWM_MovimentacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DEWM_MovimentacaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WFATCC.Relatorios.rptEntrada.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(739, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetRelatorioEntrada
            // 
            this.dataSetRelatorioEntrada.DataSetName = "DataSetRelatorioEntrada";
            this.dataSetRelatorioEntrada.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetRelatorioEntradaBindingSource
            // 
            this.dataSetRelatorioEntradaBindingSource.DataSource = this.dataSetRelatorioEntrada;
            this.dataSetRelatorioEntradaBindingSource.Position = 0;
            // 
            // DEWM_MovimentacaoBindingSource
            // 
            this.DEWM_MovimentacaoBindingSource.DataMember = "DEWM_Movimentacao";
            this.DEWM_MovimentacaoBindingSource.DataSource = this.dataSetRelatorioEntrada;
            // 
            // frmRelatorioEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 396);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmRelatorioEntrada";
            this.Text = "Relatório de Entrada";
            this.Load += new System.EventHandler(this.frmRelatorioEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRelatorioEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRelatorioEntradaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEWM_MovimentacaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DEWM_MovimentacaoBindingSource;
        private DataSetRelatorioEntrada dataSetRelatorioEntrada;
        private System.Windows.Forms.BindingSource dataSetRelatorioEntradaBindingSource;
    }
}