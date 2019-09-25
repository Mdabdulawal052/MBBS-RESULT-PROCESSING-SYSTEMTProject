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
    public partial class proof1 : Form
    {
        ReportDocument cry = new ReportDocument();
        public proof1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void proof1_Load(object sender, EventArgs e)
        {
           
        }

       

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf1One.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("AnaOne", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "Profone1");
                cry.SetDataSource(st);
                crystalReportViewer1.ReportSource = cry;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("AnaOne1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll3 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll4 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "ANAOne1");
                cry.SetDataSource(st);
                crystalReportViewer2.ReportSource = cry;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne2.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("AnaTow2", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll5 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll6 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "AnaTow2");
                cry.SetDataSource(st);
                crystalReportViewer3.ReportSource = cry;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne3.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("AnaThree3", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll7 ", System.Data.SqlDbType.Int).Value = "1";
                sda.SelectCommand.Parameters.Add("@Roll8 ", System.Data.SqlDbType.Int).Value = "3";
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "AnaTHREE3");
                cry.SetDataSource(st);
                crystalReportViewer4.ReportSource = cry;
            }
        }
       private void button1_Click_1(object sender, EventArgs e)
        {
            
            string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
            //MessageBox.Show(Subject);
            if (Subject == "Physiology" || Subject == "Biochemistry" || Subject == "Physiology,Biochemistry")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf1One.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("AnaOnenew", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;

            sda.SelectCommand.Parameters.Add("@Roll37 ", System.Data.SqlDbType.Int).Value = textBoxsearch1.Text;
            sda.SelectCommand.Parameters.Add("@Roll38 ", System.Data.SqlDbType.Int).Value = textBoxSearch2.Text;
            DataSet st = new System.Data.DataSet();
            sda.Fill(st, "Profone1");
            cry.SetDataSource(st);
            crystalReportViewer1.ReportSource = cry;
            }
           
            else
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProf1One.rpt");
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("AnaOne", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;

            sda.SelectCommand.Parameters.Add("@Roll1 ", System.Data.SqlDbType.Int).Value = textBoxsearch1.Text;
            sda.SelectCommand.Parameters.Add("@Roll2 ", System.Data.SqlDbType.Int).Value = textBoxSearch2.Text;
            DataSet st = new System.Data.DataSet();
            sda.Fill(st, "Profone1");
            cry.SetDataSource(st);
            crystalReportViewer1.ReportSource = cry;
            }
            
        }

        private void buttonSearch2_Click_1(object sender, EventArgs e)
        {
            string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
            //MessageBox.Show(Subject);
             if (Subject == "Biochemistry")
             {
                 cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne1new3.rpt");
                 SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                 SqlDataAdapter sda = new SqlDataAdapter("AnaOne1new3", con);
                 sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                 sda.SelectCommand.Parameters.Add("@Roll45 ", System.Data.SqlDbType.Int).Value = textBoxsearch1.Text;
                 sda.SelectCommand.Parameters.Add("@Roll46 ", System.Data.SqlDbType.Int).Value = textBoxSearch2.Text;
                 DataSet st = new System.Data.DataSet();
                 sda.Fill(st, "ANAOne1new3");
                 cry.SetDataSource(st);
                 crystalReportViewer2.ReportSource = cry;
             }
             else if (Subject == "Anatomy" || Subject == "Anatomy,Biochemistry")
             {
               cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne1new1.rpt");
               SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
               SqlDataAdapter sda = new SqlDataAdapter("AnaOne1new1", con);
               sda.SelectCommand.CommandType = CommandType.StoredProcedure;

               sda.SelectCommand.Parameters.Add("@Roll33 ", System.Data.SqlDbType.Int).Value = textBoxsearch1.Text;
               sda.SelectCommand.Parameters.Add("@Roll34 ", System.Data.SqlDbType.Int).Value = textBoxSearch2.Text;
               DataSet st = new System.Data.DataSet();
               sda.Fill(st, "ANAOnenew1");
               cry.SetDataSource(st);
               crystalReportViewer2.ReportSource = cry;
            }
            else if (Subject == "Physiology" || Subject == "Physiology,Biochemistry")
            {
               cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne1new2.rpt");
               SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
               SqlDataAdapter sda = new SqlDataAdapter("AnaOne1new2", con);
               sda.SelectCommand.CommandType = CommandType.StoredProcedure;

               sda.SelectCommand.Parameters.Add("@Roll35 ", System.Data.SqlDbType.Int).Value = textBoxsearch1.Text;
               sda.SelectCommand.Parameters.Add("@Roll36 ", System.Data.SqlDbType.Int).Value = textBoxSearch2.Text;
               DataSet st = new System.Data.DataSet();
               sda.Fill(st, "ANAOne1new2");
               cry.SetDataSource(st);
               crystalReportViewer2.ReportSource = cry;
           }
           else
           {
               cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne1.rpt");
               SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
               SqlDataAdapter sda = new SqlDataAdapter("AnaOne1", con);
               sda.SelectCommand.CommandType = CommandType.StoredProcedure;

               sda.SelectCommand.Parameters.Add("@Roll3 ", System.Data.SqlDbType.Int).Value = textBoxsearch1.Text;
               sda.SelectCommand.Parameters.Add("@Roll4 ", System.Data.SqlDbType.Int).Value = textBoxSearch2.Text;
               DataSet st = new System.Data.DataSet();
               sda.Fill(st, "ANAOne1");
               cry.SetDataSource(st);
               crystalReportViewer2.ReportSource = cry;
             }
           
        }

        private void buttonSearch3_Click(object sender, EventArgs e)
        {
            string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (Subject == "Anatomy")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne2new3.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("AnaTow2new3", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll45 ", System.Data.SqlDbType.Int).Value = textBoxsearch1.Text;
                sda.SelectCommand.Parameters.Add("@Roll46 ", System.Data.SqlDbType.Int).Value = textBoxSearch2.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "AnaTow2new3");
                cry.SetDataSource(st);
                crystalReportViewer3.ReportSource = cry;
            }
            else if (Subject == "Physiology" || Subject == "Anatomy,Physiology")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne2new1.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("AnaTow2new1", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll39 ", System.Data.SqlDbType.Int).Value = textBoxsearch1.Text;
                sda.SelectCommand.Parameters.Add("@Roll40 ", System.Data.SqlDbType.Int).Value = textBoxSearch2.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "AnaTow2new1");
                cry.SetDataSource(st);
                crystalReportViewer3.ReportSource = cry;
            }
            else if (Subject == "Biochemistry" || Subject == "Anatomy,Biochemistry")
            {
                cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne2new2.rpt");
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("AnaTow2new2", con);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.SelectCommand.Parameters.Add("@Roll41 ", System.Data.SqlDbType.Int).Value = textBoxsearch1.Text;
                sda.SelectCommand.Parameters.Add("@Roll42 ", System.Data.SqlDbType.Int).Value = textBoxSearch2.Text;
                DataSet st = new System.Data.DataSet();
                sda.Fill(st, "AnaTow2new2");
                cry.SetDataSource(st);
                crystalReportViewer3.ReportSource = cry;
            }
            else
            {
            cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne2.rpt");
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("AnaTow2", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;

            sda.SelectCommand.Parameters.Add("@Roll5 ", System.Data.SqlDbType.Int).Value = textBoxsearch1.Text;
            sda.SelectCommand.Parameters.Add("@Roll6 ", System.Data.SqlDbType.Int).Value = textBoxSearch2.Text;
            DataSet st = new System.Data.DataSet();
            sda.Fill(st, "AnaTow2");
            cry.SetDataSource(st);
            crystalReportViewer3.ReportSource = cry;
            }
        }

        private void buttonSearch4_Click(object sender, EventArgs e)
        {
            string Subject = comboBox1.GetItemText(comboBox1.SelectedItem);
            if (Subject == "Anatomy"||Subject == "Physiology" || Subject == "Anatomy,Physiology")
            {
            cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne3new2.rpt");
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
             SqlDataAdapter sda = new SqlDataAdapter("AnaThree3new2", con);
             sda.SelectCommand.CommandType = CommandType.StoredProcedure;

             sda.SelectCommand.Parameters.Add("@Roll7 ", System.Data.SqlDbType.Int).Value = textBoxsearch1.Text;
             sda.SelectCommand.Parameters.Add("@Roll8 ", System.Data.SqlDbType.Int).Value = textBoxSearch2.Text;
             DataSet st = new System.Data.DataSet();
             sda.Fill(st, "AnaThree3new2");
             cry.SetDataSource(st);
             crystalReportViewer4.ReportSource = cry;
         }
         else if (Subject == "Biochemistry" || Subject == "Anatomy,Biochemistry" || Subject == "Physiology,Biochemistry")
         {
             cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne3new1.rpt");
             SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
             SqlDataAdapter sda = new SqlDataAdapter("AnaThree3new1", con);
             sda.SelectCommand.CommandType = CommandType.StoredProcedure;

             sda.SelectCommand.Parameters.Add("@Roll43 ", System.Data.SqlDbType.Int).Value = textBoxsearch1.Text;
             sda.SelectCommand.Parameters.Add("@Roll44 ", System.Data.SqlDbType.Int).Value = textBoxSearch2.Text;
             DataSet st = new System.Data.DataSet();
             sda.Fill(st, "AnaThree3new1");
             cry.SetDataSource(st);
             crystalReportViewer4.ReportSource = cry;
         }
         else
         {
             cry.Load(@"D:\WindowsFormsApplication3\WindowsFormsApplication3\CrystalReportProfOne3.rpt");
             SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
             SqlDataAdapter sda = new SqlDataAdapter("AnaThree3", con);
             sda.SelectCommand.CommandType = CommandType.StoredProcedure;

             sda.SelectCommand.Parameters.Add("@Roll7 ", System.Data.SqlDbType.Int).Value = textBoxsearch1.Text;
             sda.SelectCommand.Parameters.Add("@Roll8 ", System.Data.SqlDbType.Int).Value = textBoxSearch2.Text;
             DataSet st = new System.Data.DataSet();
             sda.Fill(st, "AnaTHREE3");
             cry.SetDataSource(st);
             crystalReportViewer4.ReportSource = cry;
         }
        }

    }
}
