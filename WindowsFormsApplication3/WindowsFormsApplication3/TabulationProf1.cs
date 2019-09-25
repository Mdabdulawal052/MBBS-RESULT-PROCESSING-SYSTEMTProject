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
    public partial class TabulationProf1 : Form
    {
        ReportDocument cry = new ReportDocument();
        public TabulationProf1()
        {
            InitializeComponent();
        }

        private void buttonSearchTabulation_Click(object sender, EventArgs e)
        {
            string Subject = comboBox1TABULATIONpROF1.GetItemText(comboBox1TABULATIONpROF1.SelectedItem);
            if (Subject == "Anatomy")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf1one", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1Tabulationprof1.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf2.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TbulationProf1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            else if (Subject == "Physiology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProftwo", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1Tabulationprof1.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf2.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TbulationProf1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            else if (Subject == "Biochemistry")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf1three", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1Tabulationprof1.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf2.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TbulationProf1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            else if (Subject == "Anatomy,Physiology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf1four", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1Tabulationprof1.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf2.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TbulationProf1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            else if (Subject == "Anatomy,Biochemistry")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf1five", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1Tabulationprof1.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf2.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TbulationProf1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            else if (Subject == "Physiology,Biochemistry")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf1Six", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1Tabulationprof1.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf2.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TbulationProf1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            else
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportTabulationProf1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("TabulationProf1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBox1Tabulationprof1.Text;
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBox2TabulationProf2.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "TbulationProf1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
        }
    }
}
