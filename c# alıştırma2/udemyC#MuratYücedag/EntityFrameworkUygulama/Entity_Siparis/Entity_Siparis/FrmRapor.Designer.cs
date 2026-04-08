namespace Entity_Siparis
{
    partial class FrmRapor
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
            this.tBLURUNBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.entityUrunDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entity_UrunDataSet = new Entity_Siparis.Entity_UrunDataSet();
            this.tBLURUNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_URUNTableAdapter = new Entity_Siparis.Entity_UrunDataSetTableAdapters.TBL_URUNTableAdapter();
            this.TBL_URUNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityUrunDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity_UrunDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_URUNBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLURUNBindingSource1
            // 
            this.tBLURUNBindingSource1.DataMember = "TBL_URUN";
            this.tBLURUNBindingSource1.DataSource = this.entityUrunDataSetBindingSource;
            // 
            // entityUrunDataSetBindingSource
            // 
            this.entityUrunDataSetBindingSource.DataSource = this.entity_UrunDataSet;
            this.entityUrunDataSetBindingSource.Position = 0;
            // 
            // entity_UrunDataSet
            // 
            this.entity_UrunDataSet.DataSetName = "Entity_UrunDataSet";
            this.entity_UrunDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLURUNBindingSource
            // 
            this.tBLURUNBindingSource.DataMember = "TBL_URUN";
            this.tBLURUNBindingSource.DataSource = this.entityUrunDataSetBindingSource;
            // 
            // tBL_URUNTableAdapter
            // 
            this.tBL_URUNTableAdapter.ClearBeforeFill = true;
            // 
            // TBL_URUNBindingSource
            // 
            this.TBL_URUNBindingSource.DataMember = "TBL_URUN";
            this.TBL_URUNBindingSource.DataSource = this.entity_UrunDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TBL_URUNBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Entity_Siparis.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRapor";
            this.Text = "FrmRapor";
            this.Load += new System.EventHandler(this.FrmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityUrunDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entity_UrunDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_URUNBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource entityUrunDataSetBindingSource;
        private Entity_UrunDataSet entity_UrunDataSet;
        private System.Windows.Forms.BindingSource tBLURUNBindingSource;
        private Entity_UrunDataSetTableAdapters.TBL_URUNTableAdapter tBL_URUNTableAdapter;
        private System.Windows.Forms.BindingSource tBLURUNBindingSource1;
        private System.Windows.Forms.BindingSource TBL_URUNBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}