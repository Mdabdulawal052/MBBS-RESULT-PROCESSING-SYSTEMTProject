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
    public partial class proof3 : Form
    {
        ReportDocument cry = new ReportDocument();
        public proof3()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3One.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("PATHO1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll15 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll16 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "PathoTable1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Two.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("PATHO2", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll17 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll18 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "PathoTable2");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Three.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("PATHO3", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll19 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll20 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "PathoTable3");
                cry.SetDataSource(st);
                crystalReportViewer3.ReportSource = cry;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Four.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("PATHO4", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll21 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll22 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "PathoTable4");
                cry.SetDataSource(st);
                crystalReportViewer4.ReportSource = cry;
            }
        }
        private void buttonSearch8_Click(object sender, EventArgs e)
        {
            string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
            if(Subject=="Microbiology"||Subject=="Pharmacology And Therapeutics"||Subject=="Microbiology,Pharmacology And Therapeutics")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Onenew1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("COMMU1new1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.Add("@Roll9 ", System.Data.SqlDbType.Int).Value = textBoxSearch15.Text;
                sda.SelectCommand.Parameters.Add("@Roll10 ", System.Data.SqlDbType.Int).Value = textBoxSearch16.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "CommuTable1new1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            else
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3One.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("PATHO1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll15 ", System.Data.SqlDbType.Int).Value = textBoxSearch15.Text;
                sda.SelectCommand.Parameters.Add("@Roll16 ", System.Data.SqlDbType.Int).Value = textBoxSearch16.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "PathoTable1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            
        }

        private void buttonSearch9_Click(object sender, EventArgs e)
        { 
            string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
            if(Subject=="Pharmacology And Therapeutics")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Twonew3.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("PATHO2new3", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll17 ", System.Data.SqlDbType.Int).Value = textBoxSearch15.Text;
                sda.SelectCommand.Parameters.Add("@Roll18 ", System.Data.SqlDbType.Int).Value = textBoxSearch16.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "PathoTable2new3");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
            else if (Subject == "Pathology" || Subject == "Pathology,Pharmacology And Therapeutics")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Twonew1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("PATHO2new1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll17 ", System.Data.SqlDbType.Int).Value = textBoxSearch15.Text;
                sda.SelectCommand.Parameters.Add("@Roll18 ", System.Data.SqlDbType.Int).Value = textBoxSearch16.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "PathoTable2new1");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
            else if (Subject == "Microbiology" || Subject == "Microbiology,Pharmacology And Therapeutics")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Twonew2.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("PATHO2new2", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll17 ", System.Data.SqlDbType.Int).Value = textBoxSearch15.Text;
                sda.SelectCommand.Parameters.Add("@Roll18 ", System.Data.SqlDbType.Int).Value = textBoxSearch16.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "PathoTable2new2");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
            else 
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Two.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("PATHO2", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll17 ", System.Data.SqlDbType.Int).Value = textBoxSearch15.Text;
                sda.SelectCommand.Parameters.Add("@Roll18 ", System.Data.SqlDbType.Int).Value = textBoxSearch16.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "PathoTable2");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
           
        }

        private void buttonSearch10_Click(object sender, EventArgs e)
        {
             string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
             if (Subject == "Pathology")
             {
                 cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Threenew3.rpt");
                 SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                 SqlDataAdapter sda = new SqlDataAdapter("PATHO3new3", con);
                 sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                 sda.SelectCommand.Parameters.Add("@Roll19 ", System.Data.SqlDbType.Int).Value = textBoxSearch15.Text;
                 sda.SelectCommand.Parameters.Add("@Roll20 ", System.Data.SqlDbType.Int).Value = textBoxSearch16.Text;
                 DataSet st = new System.Data.DataSet();
                 sda.Fill(st, "PathoTable3new3");
                 cry.SetDataSource(st);
                 crystalReportViewer3.ReportSource = cry;
             }
             else if (Subject == "Microbiology" || Subject == "Pathology,Microbiology")
             {
                 cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Threenew1.rpt");
                 SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                 SqlDataAdapter sda = new SqlDataAdapter("PATHO3new1", con);
                 sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                 sda.SelectCommand.Parameters.Add("@Roll19 ", System.Data.SqlDbType.Int).Value = textBoxSearch15.Text;
                 sda.SelectCommand.Parameters.Add("@Roll20 ", System.Data.SqlDbType.Int).Value = textBoxSearch16.Text;
                 DataSet st = new System.Data.DataSet();
                 sda.Fill(st, "PathoTable3new1");
                 cry.SetDataSource(st);
                 crystalReportViewer3.ReportSource = cry;
             }
             else if (Subject == "Pharmacology And Therapeutics" || Subject == "Pathology,Pharmacology And Therapeutics")
             {
                 cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Threenew2.rpt");
                 SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                 SqlDataAdapter sda = new SqlDataAdapter("PATHO3new2", con);
                 sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                 sda.SelectCommand.Parameters.Add("@Roll19 ", System.Data.SqlDbType.Int).Value = textBoxSearch15.Text;
                 sda.SelectCommand.Parameters.Add("@Roll20 ", System.Data.SqlDbType.Int).Value = textBoxSearch16.Text;
                 DataSet st = new System.Data.DataSet();
                 sda.Fill(st, "PathoTable3new2");
                 cry.SetDataSource(st);
                 crystalReportViewer3.ReportSource = cry;
             }
             else
             {
                 cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Three.rpt");
                 SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                 SqlDataAdapter sda = new SqlDataAdapter("PATHO3", con);
                 sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                 sda.SelectCommand.Parameters.Add("@Roll19 ", System.Data.SqlDbType.Int).Value = textBoxSearch15.Text;
                 sda.SelectCommand.Parameters.Add("@Roll20 ", System.Data.SqlDbType.Int).Value = textBoxSearch16.Text;
                 DataSet st = new System.Data.DataSet();
                 sda.Fill(st, "PathoTable3");
                 cry.SetDataSource(st);
                 crystalReportViewer3.ReportSource = cry;
             }
            
        }

        private void buttonSearch11_Click(object sender, EventArgs e)
        {
            string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (Subject == "Pathology" || Subject == "Microbiology" || Subject == "Pathology,Microbiology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Threenew3.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("PATHO3new3", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll19 ", System.Data.SqlDbType.Int).Value = textBoxSearch15.Text;
                sda.SelectCommand.Parameters.Add("@Roll20  ", System.Data.SqlDbType.Int).Value = textBoxSearch16.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "PathoTable3new3");
                cry.SetDataSource(st);
                crystalReportViewer4.ReportSource = cry;
            }
            else if (Subject == "Pharmacology And Therapeutics" || Subject == "Pathology,Pharmacology And Therapeutics" || Subject == "Microbiology,Pharmacology And Therapeutics")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Fournew1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("PATHO4new1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll21 ", System.Data.SqlDbType.Int).Value = textBoxSearch15.Text;
                sda.SelectCommand.Parameters.Add("@Roll22 ", System.Data.SqlDbType.Int).Value = textBoxSearch16.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "PathoTable4new1");
                cry.SetDataSource(st);
                crystalReportViewer4.ReportSource = cry;
            }
            else
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf3Four.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("PATHO4", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll21 ", System.Data.SqlDbType.Int).Value = textBoxSearch15.Text;
                sda.SelectCommand.Parameters.Add("@Roll22 ", System.Data.SqlDbType.Int).Value = textBoxSearch16.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "PathoTable4");
                cry.SetDataSource(st);
                crystalReportViewer4.ReportSource = cry;
            }
            
        }
    }
}
