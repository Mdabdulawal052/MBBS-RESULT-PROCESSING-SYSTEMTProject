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
    public partial class proof2 : Form
    {
        ReportDocument cry = new ReportDocument();
        public proof2()
        {
            InitializeComponent();
        }

        private void proof2_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf2One.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("COMMU1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

               sda.SelectCommand.Parameters.Add("@Roll9 ", System.Data.SqlDbType.Int).Value = "1";
               sda.SelectCommand.Parameters.Add("@Roll10 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "CommuTable1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf2Two.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("COMMU2", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

               sda.SelectCommand.Parameters.Add("@Roll11 ", System.Data.SqlDbType.Int).Value = "1";
               sda.SelectCommand.Parameters.Add("@Roll12 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "CommuTable2");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf2Three.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("COMMU3", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll13 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll14 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "CommuTable3");
                cry.SetDataSource(st);
                crystalReportViewer3.ReportSource = cry;
            }
        }

        private void buttonSearch5_Click(object sender, EventArgs e)
        {
            string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
            if(Subject=="Forensic Medicine And Toxicology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf2Onenew1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("COMMU1new1", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;

            sda.SelectCommand.Parameters.Add("@Roll9 ", System.Data.SqlDbType.Int).Value = textBoxSearch9.Text;
            sda.SelectCommand.Parameters.Add("@Roll10 ", System.Data.SqlDbType.Int).Value = textBoxSearch10.Text;
            DataSet st = new System.Data.DataSet();
            sda.Fill(st, "CommuTable1new1");
            cry.SetDataSource(st);
            crystalReportViewer1.ReportSource = cry;
            }
            
            else
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf2One.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("COMMU1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll9 ", System.Data.SqlDbType.Int).Value = textBoxSearch9.Text;
                sda.SelectCommand.Parameters.Add("@Roll10 ", System.Data.SqlDbType.Int).Value = textBoxSearch10.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "CommuTable1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            
        }

        private void buttonSearch6_Click(object sender, EventArgs e)
        {
            string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (Subject == "Community Medicine")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf2Twonew1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("COMMU2new1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll11 ", System.Data.SqlDbType.Int).Value = textBoxSearch9.Text;
                sda.SelectCommand.Parameters.Add("@Roll12 ", System.Data.SqlDbType.Int).Value = textBoxSearch10.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "CommuTable2new1");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
            else if (Subject == "Forensic Medicine And Toxicology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf2Twonew2.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("COMMU2new2", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll11 ", System.Data.SqlDbType.Int).Value = textBoxSearch9.Text;
                sda.SelectCommand.Parameters.Add("@Roll12 ", System.Data.SqlDbType.Int).Value = textBoxSearch10.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "CommuTable2new2");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
            else
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf2Two.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("COMMU2", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll11 ", System.Data.SqlDbType.Int).Value = textBoxSearch9.Text;
                sda.SelectCommand.Parameters.Add("@Roll12 ", System.Data.SqlDbType.Int).Value = textBoxSearch10.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "CommuTable2");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
            
        }

        private void buttonSearch7_Click(object sender, EventArgs e)
        {
            string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (Subject == "Community Medicine")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf2Threennew1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("COMMU3new1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll13 ", System.Data.SqlDbType.Int).Value = textBoxSearch9.Text;
                sda.SelectCommand.Parameters.Add("@Roll14 ", System.Data.SqlDbType.Int).Value = textBoxSearch10.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "CommuTable3new1");
                cry.SetDataSource(st);
                crystalReportViewer3.ReportSource = cry;
            }
            else if (Subject == "Forensic Medicine And Toxicology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf2Threennew2.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("COMMU3new2", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll13 ", System.Data.SqlDbType.Int).Value = textBoxSearch9.Text;
                sda.SelectCommand.Parameters.Add("@Roll14 ", System.Data.SqlDbType.Int).Value = textBoxSearch10.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "CommuTable3new2");
                cry.SetDataSource(st);
                crystalReportViewer3.ReportSource = cry;
            }
            else 
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf2Three.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("COMMU3", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll13 ", System.Data.SqlDbType.Int).Value = textBoxSearch9.Text;
                sda.SelectCommand.Parameters.Add("@Roll14 ", System.Data.SqlDbType.Int).Value = textBoxSearch10.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "CommuTable3");
                cry.SetDataSource(st);
                crystalReportViewer3.ReportSource = cry;
            }
            
        }

    }
}
