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
    public partial class TabulationProf4 : Form
    {
        ReportDocument cry = new ReportDocument();
        public TabulationProf4()
        {
            InitializeComponent();
        }

        private void buttonTabulationProf4_Click(object sender, EventArgs e)
        {

            string Subject = comboBoxTabulationProf4.GetItemText(comboBoxTabulationProf4.SelectedItem);
            if (Subject == "Surgery")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf4.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf4one", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf4.Text;
                sda.SelectCommand.Parameters.Add("@Roll2", System.Data.SqlDbType.Int).Value = textBox2TabulationProf4.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf4");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf4.ReportSource = cry;
            }
            else if (Subject == "Medicine")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf4.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf4two", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf4.Text;
                sda.SelectCommand.Parameters.Add("@Roll2", System.Data.SqlDbType.Int).Value = textBox2TabulationProf4.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf4");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf4.ReportSource = cry;
            }
            else if (Subject == "Obsterics  And Gynaecology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf4.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf4three", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf4.Text;
                sda.SelectCommand.Parameters.Add("@Roll2", System.Data.SqlDbType.Int).Value = textBox2TabulationProf4.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf4");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf4.ReportSource = cry;
            }
            else if (Subject == "Surgery,Medicine")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf4.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf4four", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf4.Text;
                sda.SelectCommand.Parameters.Add("@Roll2", System.Data.SqlDbType.Int).Value = textBox2TabulationProf4.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf4");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf4.ReportSource = cry;
            }
            else if (Subject == "Surgery,Obsterics  And Gynaecology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf4.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf4five", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf4.Text;
                sda.SelectCommand.Parameters.Add("@Roll2", System.Data.SqlDbType.Int).Value = textBox2TabulationProf4.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf4");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf4.ReportSource = cry;
            }
            else if (Subject == "Medicine,Obsterics  And Gynaecology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf4.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf4six", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf4.Text;
                sda.SelectCommand.Parameters.Add("@Roll2", System.Data.SqlDbType.Int).Value = textBox2TabulationProf4.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf4");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf4.ReportSource = cry;
            }
            else
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf4.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf4", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1TabulationProf4.Text;
                sda.SelectCommand.Parameters.Add("@Roll2", System.Data.SqlDbType.Int).Value = textBox2TabulationProf4.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TabulationProf4");
                cry.SetDataSource(st);
                crystalReportViewerTabulationProf4.ReportSource = cry;
            }
        }
    }
}
