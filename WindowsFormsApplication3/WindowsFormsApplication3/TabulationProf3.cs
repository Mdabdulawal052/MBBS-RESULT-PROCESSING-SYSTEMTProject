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
    public partial class TabulationProf3 : Form
    {
        ReportDocument cry = new ReportDocument();
        public TabulationProf3()
        {
            InitializeComponent();
        }
        

        private void buttonTabulationProf3_Click(object sender, EventArgs e)
        {
            string Subject = comboBoxTabulationProf3.GetItemText(comboBoxTabulationProf3.SelectedItem);
            if (Subject == "Pathology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf3.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf3four", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf3.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf3.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf3");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf3.ReportSource = cry;
            }
            else if (Subject == "Microbiology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf3.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf3five", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf3.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf3.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf3");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf3.ReportSource = cry;
            }
            else if (Subject == "Pharmacology And Therapeutics")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf3.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf3six", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf3.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf3.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf3");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf3.ReportSource = cry;
            }


            else if (Subject == "Pathology,Microbiology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf3.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf3one", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf3.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf3.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf3");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf3.ReportSource = cry;
            }
            else if (Subject == "Pathology,Pharmacology And Therapeutics")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf3.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf3two", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf3.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf3.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf3");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf3.ReportSource = cry;
            }
            else if (Subject == "Microbiology,Pharmacology And Therapeutics")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf3.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf3Threee", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf3.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf3.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf3");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf3.ReportSource = cry;
            }
            else
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf3.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf3", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf3.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf3.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf3");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf3.ReportSource = cry;
            }
        }
    }
}
