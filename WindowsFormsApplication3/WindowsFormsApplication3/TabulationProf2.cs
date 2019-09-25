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
    public partial class TabulationProf2 : Form
    {
        ReportDocument cry = new ReportDocument();
        public TabulationProf2()
        {
            InitializeComponent();
        }

        private void buttonTabulationProf2_Click(object sender, EventArgs e)
        {
            string Subject = comboBoxTabulationProf2.GetItemText(comboBoxTabulationProf2.SelectedItem);
            if (Subject == "Community Medicine")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf2.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf2one", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf2.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf2.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf2");
                cry.SetDataSource(st);
                crystalReportViewer1TabulationProf2.ReportSource = cry;
            }
            else if (Subject == "Forensic Medicine And Toxicology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf2.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf2two", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf2.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf2.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf2");
                cry.SetDataSource(st);
                crystalReportViewer1TabulationProf2.ReportSource = cry;
            }
            else
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf2.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf2", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf2.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf2.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf2");
                cry.SetDataSource(st);
                crystalReportViewer1TabulationProf2.ReportSource = cry;
            }
        }
    }
}
