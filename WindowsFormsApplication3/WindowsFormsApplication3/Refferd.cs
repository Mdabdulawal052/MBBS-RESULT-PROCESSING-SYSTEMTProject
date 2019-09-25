using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    class Refferd
    {
        public SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
          SqlCommand com = new SqlCommand();
          SqlDataAdapter SDA; 
        
          public string Anatomy;
          public string Physiology;
          public string Biochemistry;
          public string Community;
          public string Forensic;
          public string Pathology;
          public string Microbiology;
          public string Pharmacology;
          public string Surgery;
          public string Medicine;
          public string Gynacology;
          
        public string checkedProf1(string text)
          {
              
              com = new SqlCommand("select Anatomy,Physiology,Biochemistry from PROF_1 where Reg_NO='" + text + "';", con);
              con.Open();
              SqlDataReader read = com.ExecuteReader();
              while (read.Read())
              {
                   Anatomy = (read["Anatomy"].ToString());
                   Physiology = (read["Physiology"].ToString());
                   Biochemistry = (read["Biochemistry"].ToString());
              }
              con.Close();

              if (Anatomy == "Pass" && Physiology == "Pass" && Biochemistry == "Pass")
              {
                  return "Passed";
              }
              else if (Anatomy == "Pass" && Physiology == "Pass" && Biochemistry == "Fail")
              {
                  return "Ref in BioChemistry";
              }
              else if (Anatomy == "Pass" && Physiology == "Fail" && Biochemistry == "Pass")
              {
                  return "Ref in Physiology";
              }
              else if (Anatomy == "Fail" && Physiology == "Pass" && Biochemistry == "Pass")
              {
                  return "Ref in Anatomy";
              }
              else if (Anatomy == "Pass" && Physiology == "Fail" && Biochemistry == "Fail")
              {
                  return "Ref in Physio & Bio";
              }
              else if (Anatomy == "Fail" && Physiology == "Fail" && Biochemistry == "Pass")
              {
                  return "Ref in Ana & Phy";
              }
              else if (Anatomy == "Fail" && Physiology == "Pass" && Biochemistry == "Fail")
              {
                  return "Ref in Ana & Bio";
              }
              else
              {
                  return "Fail";
              }
          }
        public string checkedProf2(string text)
        {

            com = new SqlCommand("select Commu,Forn from PROF_2 where Reg_NO='" + text + "';", con);
            con.Open();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                Community = (read["Commu"].ToString());
                Forensic = (read["Forn"].ToString());
            }
            con.Close();

            if (Community == "Pass" && Forensic == "Pass")
            {
                return "Passed";
            }
            else if (Community == "Pass" && Forensic == "Fail")
            {
                return "Ref in Forensic";
            }
            else if (Community == "Fail" && Forensic == "Pass")
            {
                return "Ref in Community";
            }
            else
            {
                return "Fail";
            }
        }
        public string checkedProf3(string text)
        {

            com = new SqlCommand("select Phatho,Micro,Pharma from PROF_3 where Reg_NO='" + text + "';", con);
            con.Open();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                Pathology = (read["Phatho"].ToString());
                Microbiology = (read["Micro"].ToString());
                Pharmacology = (read["Pharma"].ToString());
            }
            con.Close();

            if (Pathology == "Pass" && Microbiology == "Pass" && Pharmacology == "Pass")
            {
                return "Passed";
            }
            else if (Pathology == "Pass" && Microbiology == "Pass" && Pharmacology == "Fail")
            {
                return "Ref in Pharmacology";
            }
            else if (Pathology == "Pass" && Microbiology == "Fail" && Pharmacology == "Pass")
            {
                return "Ref in Microbiology";
            }
            else if (Pathology == "Fail" && Microbiology == "Pass" && Pharmacology == "Pass")
            {
                return "Ref in Pathology";
            }
            else if (Pathology == "Pass" && Microbiology == "Fail" && Pharmacology == "Fail")
            {
                return "Ref in Micro & Pharma";
            }
            else if (Pathology == "Fail" && Microbiology == "Fail" && Pharmacology == "Pass")
            {
                return "Ref in Patho & Micro";
            }
            else if (Pathology == "Fail" && Microbiology == "Pass" && Pharmacology == "Fail")
            {
                return "Ref in Patho & Pharma";
            }
            else
            {
                return "Fail";
            }
        }
        public string checkedProf4(string text)
        {

            com = new SqlCommand("select Surgery,Medicine,Ghyna from PROF_4 where Reg_NO='" + text + "';", con);
            con.Open();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                Surgery = (read["Surgery"].ToString());
                Medicine = (read["Medicine"].ToString());
                Gynacology = (read["Ghyna"].ToString());
            }
            con.Close();

            if (Surgery == "Pass" && Medicine == "Pass" && Gynacology == "Pass")
            {
                return "Passed";
            }
            else if (Surgery == "Pass" && Medicine == "Pass" && Gynacology == "Fail")
            {
                return "Ref in Gynacology";
            }
            else if (Surgery == "Pass" && Medicine == "Fail" && Gynacology == "Pass")
            {
                return "Ref in Medicine";
            }
            else if (Surgery == "Fail" && Medicine == "Pass" && Gynacology == "Pass")
            {
                return "Ref in Surgery";
            }
            else if (Surgery == "Pass" && Medicine == "Fail" && Gynacology == "Fail")
            {
                return "Ref in Medi & Gyna";
            }
            else if (Surgery == "Fail" && Medicine == "Fail" && Gynacology == "Pass")
            {
                return "Ref in Sur & Medi";
            }
            else if (Surgery == "Fail" && Medicine == "Pass" && Gynacology == "Fail")
            {
                return "Ref in Sur & Gyna";
            }
            else
            {
                return "Fail";
            }
        }
         
    }
}
