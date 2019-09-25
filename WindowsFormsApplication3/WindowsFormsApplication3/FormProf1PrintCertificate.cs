using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class FormProf1PrintCertificate : Form
    {
        ReportDocument cry = new ReportDocument();
        public FormProf1PrintCertificate()
        {
            InitializeComponent();
        }

        private void buttonProf1Certificate_Click(object sender, EventArgs e)
        {
            cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf1Certificate.rpt");
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Prof1Certificate", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;

            sda.SelectCommand.Parameters.Add("@Roll4 ", System.Data.SqlDbType.Int).Value = textBoxProf1Certificate.Text;
            DataSet st = new System.Data.DataSet();
            sda.Fill(st, "DataSetProf1Certificate");
            cry.SetDataSource(st);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}
