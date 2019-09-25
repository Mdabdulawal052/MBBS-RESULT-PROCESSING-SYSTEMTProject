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
    public partial class proof4 : Form
    {
        ReportDocument cry = new ReportDocument();
        public proof4()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4One.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Surgery1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll23 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll24 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "SurgeryTable1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4Two.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Surgery2", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll25 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll26 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "SurgeryTable2");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4Three.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Surgery3", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll27 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll28 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "SurgeryTable3");
                cry.SetDataSource(st);
                crystalReportViewer3.ReportSource = cry;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4Four.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Surgery4", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll29 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll30 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "SurgeryTable4");
                cry.SetDataSource(st);
                crystalReportViewer4.ReportSource = cry;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage5"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4Five.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Surgery5", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll31 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll32 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "SurgeryTable5");
                cry.SetDataSource(st);
                crystalReportViewer5.ReportSource = cry;
            }
        }
        
        private void buttonSearch12_Click(object sender, EventArgs e)
        {
            string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (Subject == "Medicine" || Subject == "Obsterics  And Gynaecology" || Subject == "Medicine,Obsterics  And Gynaecology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4Onenew1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Surgerynew1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll23 ", System.Data.SqlDbType.Int).Value = textBoxSearch23.Text;
                sda.SelectCommand.Parameters.Add("@Roll24", System.Data.SqlDbType.Int).Value = textBoxSearch24.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "SurgeryTablenew1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            else
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4One.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Surgery1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll23 ", System.Data.SqlDbType.Int).Value = textBoxSearch23.Text;
                sda.SelectCommand.Parameters.Add("@Roll24 ", System.Data.SqlDbType.Int).Value = textBoxSearch24.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "SurgeryTable1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            
        }

        private void buttonSearch13_Click(object sender, EventArgs e)
        {
            string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (Subject == "Medicine" || Subject == "Obsterics  And Gynaecology" || Subject == "Medicine,Obsterics  And Gynaecology")
            {
                
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4Twonew.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Surgerynew", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll29 ", System.Data.SqlDbType.Int).Value = textBoxSearch23.Text;
                sda.SelectCommand.Parameters.Add("@Roll30 ", System.Data.SqlDbType.Int).Value = textBoxSearch24.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "SurgeryTablenew");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
            else
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4Two.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Surgery2", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll25 ", System.Data.SqlDbType.Int).Value = textBoxSearch23.Text;
                sda.SelectCommand.Parameters.Add("@Roll26 ", System.Data.SqlDbType.Int).Value = textBoxSearch24.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "SurgeryTable2");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
            
        }

        private void buttonSearch14_Click(object sender, EventArgs e)
        {
            string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (Subject == "Surgery" || Subject == "Obsterics  And Gynaecology" || Subject == "Surgery,Obsterics  And Gynaecology")
            {
                MessageBox.Show("hello");
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4Twonew.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Surgerynew", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll29 ", System.Data.SqlDbType.Int).Value = textBoxSearch23.Text;
                sda.SelectCommand.Parameters.Add("@Roll30 ", System.Data.SqlDbType.Int).Value = textBoxSearch24.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "SurgeryTablenew");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
            else
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4Three.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Surgery3", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll27 ", System.Data.SqlDbType.Int).Value = textBoxSearch23.Text;
                sda.SelectCommand.Parameters.Add("@Roll28 ", System.Data.SqlDbType.Int).Value = textBoxSearch24.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "SurgeryTable3");
                cry.SetDataSource(st);
                crystalReportViewer3.ReportSource = cry;
            }
            
        }

        private void buttonSearch15_Click(object sender, EventArgs e)
        {
             string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
             if (Subject == "Surgery" || Subject == "Medicine" || Subject == "Surgery,Medicine")
             {
                 cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4Twonew.rpt");
                 SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                 SqlDataAdapter sda = new SqlDataAdapter("Surgerynew", con);
                 sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                 sda.SelectCommand.Parameters.Add("@Roll29 ", System.Data.SqlDbType.Int).Value = textBoxSearch23.Text;
                 sda.SelectCommand.Parameters.Add("@Roll30 ", System.Data.SqlDbType.Int).Value = textBoxSearch24.Text;
                 DataSet st = new System.Data.DataSet();
                 sda.Fill(st, "SurgeryTablenew");
                 cry.SetDataSource(st);
                 crystalReportViewer2.ReportSource = cry;
             }
             else
             {
                 cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4Four.rpt");
                 SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                 SqlDataAdapter sda = new SqlDataAdapter("Surgery4", con);
                 sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                 sda.SelectCommand.Parameters.Add("@Roll29 ", System.Data.SqlDbType.Int).Value = textBoxSearch23.Text;
                 sda.SelectCommand.Parameters.Add("@Roll30 ", System.Data.SqlDbType.Int).Value = textBoxSearch24.Text;
                 DataSet st = new System.Data.DataSet();
                 sda.Fill(st, "SurgeryTable4");
                 cry.SetDataSource(st);
                 crystalReportViewer4.ReportSource = cry;
             }
            
        }

        private void buttonSearch16_Click(object sender, EventArgs e)
        {
             string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
             if (Subject == "Surgery" || Subject == "Medicine" || Subject == "Surgery,Medicine"|| Subject == "Obsterics  And Gynaecology" || Subject == "Surgery,Obsterics  And Gynaecology"|| Subject == "Medicine,Obsterics  And Gynaecology")
             {
                 cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4Twonew.rpt");
                 SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                 SqlDataAdapter sda = new SqlDataAdapter("Surgerynew", con);
                 sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                 sda.SelectCommand.Parameters.Add("@Roll29 ", System.Data.SqlDbType.Int).Value = textBoxSearch23.Text;
                 sda.SelectCommand.Parameters.Add("@Roll30 ", System.Data.SqlDbType.Int).Value = textBoxSearch24.Text;
                 DataSet st = new System.Data.DataSet();
                 sda.Fill(st, "SurgeryTablenew");
                 cry.SetDataSource(st);
                 crystalReportViewer2.ReportSource = cry;
             }
            else
             {
                 cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf4Five.rpt");
                 SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Surgery5", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll31 ", System.Data.SqlDbType.Int).Value = textBoxSearch23.Text;
                sda.SelectCommand.Parameters.Add("@Roll32 ", System.Data.SqlDbType.Int).Value = textBoxSearch24.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "SurgeryTable5");
                cry.SetDataSource(st);
                crystalReportViewer5.ReportSource = cry;
             }
            
        }
    }
}
