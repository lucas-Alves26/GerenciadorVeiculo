namespace GerenciadorVeiculo1.Relatorio
{
    partial class PrimeiroRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dB_GER_VEICULODataSet = new GerenciadorVeiculo1.DB_GER_VEICULODataSet();
            this.dBGERVEICULODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dB_GER_VEICULODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBGERVEICULODataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dBGERVEICULODataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GerenciadorVeiculo1.Rpt1 - Cópia .rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // dB_GER_VEICULODataSet
            // 
            this.dB_GER_VEICULODataSet.DataSetName = "DB_GER_VEICULODataSet";
            this.dB_GER_VEICULODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBGERVEICULODataSetBindingSource
            // 
            this.dBGERVEICULODataSetBindingSource.DataSource = this.dB_GER_VEICULODataSet;
            this.dBGERVEICULODataSetBindingSource.Position = 0;
            // 
            // PrimeiroRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrimeiroRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrimeiroRelatorio";
            this.Load += new System.EventHandler(this.PrimeiroRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_GER_VEICULODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBGERVEICULODataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dBGERVEICULODataSetBindingSource;
        private DB_GER_VEICULODataSet dB_GER_VEICULODataSet;
    }
}