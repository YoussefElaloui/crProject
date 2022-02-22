using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace crProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oUVRAGEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oUVRAGEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librairieDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librairieDataSet.OUVRAGE' table. You can move, or remove it, as needed.
            this.oUVRAGETableAdapter.Fill(this.librairieDataSet.OUVRAGE);



            lstOuvrages cr = new lstOuvrages();
            cr.SetDataSource(librairieDataSet);
            crystalReportViewer1.ReportSource = cr;



        }
    }
}
