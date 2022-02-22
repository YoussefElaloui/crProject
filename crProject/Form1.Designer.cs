
namespace crProject
{
    partial class Form1
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
            this.librairieDataSet = new crProject.librairieDataSet();
            this.oUVRAGEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oUVRAGETableAdapter = new crProject.librairieDataSetTableAdapters.OUVRAGETableAdapter();
            this.tableAdapterManager = new crProject.librairieDataSetTableAdapters.TableAdapterManager();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.librairieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUVRAGEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // librairieDataSet
            // 
            this.librairieDataSet.DataSetName = "librairieDataSet";
            this.librairieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oUVRAGEBindingSource
            // 
            this.oUVRAGEBindingSource.DataMember = "OUVRAGE";
            this.oUVRAGEBindingSource.DataSource = this.librairieDataSet;
            // 
            // oUVRAGETableAdapter
            // 
            this.oUVRAGETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OUVRAGETableAdapter = this.oUVRAGETableAdapter;
            this.tableAdapterManager.UpdateOrder = crProject.librairieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librairieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oUVRAGEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private librairieDataSet librairieDataSet;
        private System.Windows.Forms.BindingSource oUVRAGEBindingSource;
        private librairieDataSetTableAdapters.OUVRAGETableAdapter oUVRAGETableAdapter;
        private librairieDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}

