using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class first : Form
    {
        public first()
        {
            InitializeComponent();
        }
        SqlDataAdapter SDA;
        SqlCommandBuilder scb;
        DataTable DataTable;
        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.Blue;
        }
        private void buttonSave_MouseLeave(object sender, EventArgs e)
        {
            buttonSave.BackColor = Color.Green;
        }
        private void buttonShow_MouseEnter(object sender, EventArgs e)
        {
            buttonShow.BackColor = Color.DarkTurquoise;
        }
        private void buttonShow_MouseLeave(object sender, EventArgs e)
        {
            buttonShow.BackColor = Color.Green;
        }
        private void buttonSearch_MouseEnter(object sender, EventArgs e)
        {
            buttonSearch.BackColor = Color.Blue;
        }
        private void buttonSearch_MouseLeave(object sender, EventArgs e)
        {
            buttonSearch.BackColor = Color.Green;
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Poysal;Integrated Security=True");
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Home h = new Home();
             h.Roll = textBoxRollNo.Text;
             h.Reg = textBoxRegNo.Text;
             h.Session = textBoxSession.Text;
             h.Name = textBoxName.Text;
             h.Date = textBoxDateOfBirth.Text;
             h.MobileNum = textBoxMobileNumber.Text;

             int findresult = h.SReg(textBoxRegNo.Text);
             string reg = Convert.ToString(findresult);

             if (reg == textBoxRegNo.Text)
             {
                 MessageBox.Show("You already Insert This Registration Num, Please Change It....");
             }
             else if (textBoxRegNo.Text == String.Empty )
             {
                 MessageBox.Show("Please Enter Reg No....");
             }
             else if (textBoxRollNo.Text == String.Empty)
             {
                 MessageBox.Show("Please Enter Roll No....");
             }
             else if (textBoxSession.Text == String.Empty)
             {
                 MessageBox.Show("Please Enter Session....");
             }
             else if (textBoxName.Text == String.Empty )
             {
                 MessageBox.Show("Please Enter Name....");
             }
             else if (textBoxDateOfBirth.Text == String.Empty)
             {
                 MessageBox.Show("Please Enter Birth date....");
             }
             else
             {
                 h.insert();
                 MessageBox.Show("Save Successfully....");
             }
            
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SDA = new SqlDataAdapter("Select  Student.Reg_NO,Session,EXam_Roll,Name_of_Student,Date_Of_Birth,Mobile from Student;", con);
            DataTable = new DataTable();
            SDA.Fill(DataTable);
            con.Close();
            dataGridView1.DataSource = DataTable;
            
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            con.Open();
            SDA = new SqlDataAdapter("UPDATE Student SET Session='" + textBoxSession.Text + "',EXam_Roll='" + textBoxRollNo.Text + "',Name_of_Student='" + textBoxName.Text + "',Date_Of_Birth='" + textBoxDateOfBirth.Text + "',Mobile='" + textBoxMobileNumber.Text + "'WHERE Reg_NO='" + textBoxRegNo.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfully......");

        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            textBoxRegNo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxSession.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxRollNo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxDateOfBirth.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBoxMobileNumber.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            string RegNum = textBoxRegNo.Text;
            Home h = new Home();
            h.Delet(RegNum);
            MessageBox.Show("Delete Successfully...");
         }
        //*************************    Search  ****************************//

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                con.Open();
                SDA = new SqlDataAdapter(@"select Student.Reg_NO,Session,EXam_Roll,Name_of_Student,ANA_A1,ANA_B1,ANA_MCQ1,ANA_Formative1,ANA_A2,ANA_B2,ANA_MCQ2,ANA_Formative2,
                                    ANA_Theory_Total,ANA_Oral,ANA_Practical, ANA_TOTAL,PHY_A1,PHY_B1,PHY_MCQ1,PHY_For1,PHY_A2,PHY_B2,PHY_MCQ2,PHY_For2,PHY_Theory_Total,
                                    PHY_Oral,PHY_Parctical,PHY_TOTAL,BIO_A1,BIO_B1,BIO_MCQ1,BIO_For1,BIO_A2,BIO_B2,BIO_MCQ2,BIO_For2,BIO_Theory_Total,BIO_Oral,BIO_Practical,BIO_TOTAL,GRAND_TOTAL,Anatomy,Physiology,Biochemistry,Remarks from Student
                                    left join ANATOMY
                                    on Student.Reg_NO=ANATOMY.Reg_NO
                                    left join PHYSIOLOGY
                                    on Student.Reg_NO=PHYSIOLOGY.Reg_NO
                                    left join BIOCHEMISTRY
                                    on Student.Reg_NO=BIOCHEMISTRY.Reg_NO
                                    left join PROF_1
                                    on Student.Reg_NO=PROF_1.Reg_NO 
                                    WHERE Student.Reg_NO='" + textBoxSearchSId.Text + "'", con);

                DataTable = new DataTable();
                SDA.Fill(DataTable);
                con.Close();
                dataGridView3.DataSource = DataTable;
            }
            if (checkBox2.Checked)
            {
                con.Open();
                SDA = new SqlDataAdapter(@"select Student.Reg_NO,EXam_Roll,Name_of_Student,COM_SAQ_Total,COM_MCQ,COM_For,COM_Theory_Total,COM_Oral,COM_PARTICAL_Total,COM_TOTAL,
                                        FOR_SAQ_Total,FOR_MCQ,FOR_For,FOR_Theory_Total,FOR_Oral,FOR_Partical_Total,FOR_TOTAL,GRAND_TOTAL,Remarks from Student
                                        left join COMMUNITY_MEDICINE
                                        on Student.Reg_NO=COMMUNITY_MEDICINE.Reg_NO
									    left join FORENSIC_MEDICINE_And_TOXICOLOGY
                                        on Student.Reg_NO=FORENSIC_MEDICINE_And_TOXICOLOGY.Reg_NO
									    left join PROF_2
                                        on Student.Reg_NO=PROF_2.Reg_NO  
                                        WHERE Student.Reg_NO='" + textBoxSearchSId.Text + "'", con);
                DataTable = new DataTable();
                SDA.Fill(DataTable);
                con.Close();
                dataGridView3.DataSource = DataTable;
            }
            if (checkBox3.Checked)
            {
                con.Open();
                SDA = new SqlDataAdapter(@"select Student.Reg_NO,EXam_Roll,Name_of_Student,Patho_GYNA_SAQ_Total,Patho_MCQ,Patho_For,Patho_Theory_Total,Patho_Oral,Patho_Parctical_Total,Patho_TOTAL,Micro_SAQ_Total,Micro_MCQ,Micro_For,Micro_Theory_Total,Micro_Oral,Micro_Partical_Total,
                                    Micro_TOTAL,Pharma_SAQ_Total,Pharma_MCQ,Pharma_For,Pharma_Theory_Total,Pharma_Oral,Pharma_Partical_Total,Pharma_TOTAL,GRAND_TOTAL,Remarks from Student
									left join PATHOLOGY
                                    on Student.Reg_NO=PATHOLOGY.Reg_NO
									left join MICROBIOLOGY
                                    on Student.Reg_NO=MICROBIOLOGY.Reg_NO
									left join PHARMACOLOGY_And_THERAPEUTICS
                                    on Student.Reg_NO=PHARMACOLOGY_And_THERAPEUTICS.Reg_NO
									left join PROF_3
                                    on Student.Reg_NO=PROF_3.Reg_NO  
                                    WHERE Student.Reg_NO='" + textBoxSearchSId.Text + "'", con);
                DataTable = new DataTable();
                SDA.Fill(DataTable);
                con.Close();
                dataGridView3.DataSource = DataTable;
            }
            if (checkBox4.Checked)
            {
                con.Open();
                SDA = new SqlDataAdapter(@"select Student.Reg_NO,EXam_Roll,Name_of_Student,SUR_SAQPaper1_Total,SUR_MCQ1,SUR_Formative1,SUR_Total_Paper1,
			                            SUR_SAQPaper2_Total,SUR_MCQ2,SUR_Formative2,SUR_Total_Paper2,SUR_Theory_Total,SUR_Oral,SUR_Partical,SUR_Clinical,SUR_TOTAL,
			                            MEDI_SAQPaper1_Total,MEDI_MCQ1,MEDI_Formative1,MEDI_Total_Paper1,MEDI_SAQPaper2_Total,MEDI_MCQ2,MEDI_Formative2,
			                            MEDI_Total_Paper2,MEDI_Theory_Total,MEDI_Oral,MEDI_Partical,MEDI_Clinical,MEDI_TOTAL,OBS_GYNA_SAQPaper1_Total,OBS_GYNA_MCQ1,OBS_GYNA_Formative1,OBS_GYNA_Total_Paper1,
			                            OBS_GYNA_SAQPaper2_Total,OBS_GYNA_MCQ2,OBS_GYNA_Formative2,OBS_GYNA_Total_Paper2,OBS_GYNA_Theory_Total,OBS_GYNA_Oral,OBS_GYNA_Practical,OBS_GYNA_Clinical,OBS_GYNA_TOTAL,GRAND_TOTAL,Remarks from Student
									    left join SURGERY
									    on Student.Reg_NO=SURGERY.Reg_NO
									    left join MEDICINE
                                        on Student.Reg_NO=MEDICINE.Reg_NO
									    left join OBSTETRICS_And_GYNAECOLOGY
                                        on Student.Reg_NO=OBSTETRICS_And_GYNAECOLOGY.Reg_NO
									    left join PROF_4
                                        on Student.Reg_NO=PROF_4.Reg_NO  
                                        WHERE Student.Reg_NO='" + textBoxSearchSId.Text + "'", con);
                DataTable = new DataTable();
                SDA.Fill(DataTable);
                con.Close();
                dataGridView3.DataSource = DataTable;
            }
        }
        private void buttonPrintCertificate_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "proof 1")
            {
                FormProf1PrintCertificate ss = new FormProf1PrintCertificate();
                ss.Show();
            }
            else if (comboBox2.Text == "proof 2")
            {
                FormProf2PrintCertificate ss = new FormProf2PrintCertificate();
                ss.Show();
            }
            else if (comboBox2.Text == "proof 3")
            {
                FormProf3PrintCertificate ss = new FormProf3PrintCertificate();
                ss.Show();
            }
            else if (comboBox2.Text == "Final Proof")
            {
                FormProf4PrintCertificate ss = new FormProf4PrintCertificate();
                ss.Show();
            }
            
        }

        //*************************    Prof1   ****************************//
            public int ANASAQTotalPaper1()
            {

                int Total = Convert.ToInt32(textBoxAnaA1.Text) + Convert.ToInt32(textBoxAnaB1.Text);
                return Total;
            }
            public int ANASAQTotalPaper2()
            {

                int Total = Convert.ToInt32(textBoxAnaA2.Text) + Convert.ToInt32(textBoxAnaB2.Text);
                return Total;
            }
            public int ANAMCQTotal()
            {

                int Total =  Convert.ToInt32(textBoxAnaMcq1.Text) + Convert.ToInt32(textBoxAnaMcq2.Text);
                return Total;
            }
            public int ANAForTotal()
            {

                int Total =  Convert.ToInt32(textBoxAnaFormative1.Text) + Convert.ToInt32(textBoxAnaFormative2.Text);
                return Total;
            }
            public int ANATotalPaper1()
            {

                int Total = ANASAQTotalPaper1() + Convert.ToInt32(textBoxAnaMcq1.Text) + Convert.ToInt32(textBoxAnaFormative1.Text);
                return Total;
            }
            public int ANATotalPaper2()
            {

                int Total = ANASAQTotalPaper2() + Convert.ToInt32(textBoxAnaMcq2.Text) + Convert.ToInt32(textBoxAnaFormative2.Text);
                return Total;
            }
            public int ANATHEORYTOTAL()
            {

                int Total = ANASAQTotalPaper1() + ANASAQTotalPaper2() + ANAMCQTotal() + ANAForTotal();
                return Total;
            }
            public int ANATOTAL() 
            {
                
                int TOTAL = ANATHEORYTOTAL() + Convert.ToInt32(textBoxAnaOral.Text) + Convert.ToInt32(textBoxAnaPartical.Text);
            return TOTAL;
            }
            public int PHYSAQTotalPaper1()
            {

                int Total = Convert.ToInt32(textBoxPhyA1.Text) + Convert.ToInt32(textBoxPhyB1.Text);
                return Total;
            }
            public int PHYSAQTotalPaper2()
            {

                int Total = Convert.ToInt32(textBoxPhyA2.Text) + Convert.ToInt32(textBoxPhyB2.Text);
                return Total;
            }
            public int PHYMCQTotal()
            {

                int Total = Convert.ToInt32(textBoxPhyMcq1.Text) + Convert.ToInt32(textBoxPhyMcq2.Text);
                return Total;
            }
            public int PHYForTotal()
            {

                int Total = Convert.ToInt32(textBoxPhyFormative1.Text) + Convert.ToInt32(textBoxPhyFormative2.Text);
                return Total;
            }
            public int PHYTotalPaper1()
            {

                int Total = PHYSAQTotalPaper1() + Convert.ToInt32(textBoxPhyMcq1.Text) + Convert.ToInt32(textBoxPhyFormative1.Text);
                return Total;
            }
            public int PHYTotalPaper2()
            {

                int Total = PHYSAQTotalPaper2() + Convert.ToInt32(textBoxPhyMcq2.Text) + Convert.ToInt32(textBoxPhyFormative2.Text);
                return Total;
            }
            public int PHYTHEORYTOTAL()
            {

                int Total = PHYSAQTotalPaper1() + PHYSAQTotalPaper2() + PHYMCQTotal() + PHYForTotal();
                return Total;
            }
            public int PHYTOTAL()
            {
               
                int Total = PHYTHEORYTOTAL() + Convert.ToInt32(textBoxPhyOral.Text) + Convert.ToInt32(textBoxPhyPartical.Text);
                return Total;
            }
            public int BIOSAQTotalPaper1()
            {

                int Total = Convert.ToInt32(textBoxBioA1.Text) + Convert.ToInt32(textBoxBioB1.Text);
                return Total;
            }
            public int BIOSAQTotalPaper2()
            {

                int Total = Convert.ToInt32(textBoxBioA2.Text) + Convert.ToInt32(textBoxBioB2.Text);
                return Total;
            }
            public int BIOMCQTotal()
            {

                int Total = Convert.ToInt32(textBoxBioMcq1.Text) + Convert.ToInt32(textBoxBioMcq2.Text);
                return Total;
            }
            public int BIOForTotal()
            {

                int Total = Convert.ToInt32(textBoxBioFormative1.Text) + Convert.ToInt32(textBoxBioFormative2.Text);
                return Total;
            }
            public int BIOTotalPaper1()
            {

                int Total = BIOSAQTotalPaper1() + Convert.ToInt32(textBoxBioMcq1.Text) + Convert.ToInt32(textBoxBioFormative1.Text);
                return Total;
            }
            public int BIOTotalPaper2()
            {

                int Total = BIOSAQTotalPaper2() + Convert.ToInt32(textBoxBioMcq2.Text) + Convert.ToInt32(textBoxBioFormative2.Text);
                return Total;
            }
            public int BIOTHEORYTOTAL()
            {

                int Total = BIOSAQTotalPaper1() + BIOSAQTotalPaper2() + BIOMCQTotal() + BIOForTotal();
                return Total; 
            }
            public int BIOTOTAL()
            {
               
                int TOTAL = BIOTHEORYTOTAL() + Convert.ToInt32(textBoxBioOral.Text) + Convert.ToInt32(textBoxBioPartical.Text);
                return TOTAL;
            }
            public int Prof1GrandTotal()
            {
                int GTotal = ANATOTAL() + PHYTOTAL() + BIOTOTAL();
                return GTotal;
            }
           //****************************** Prof1 Reffered Checked**********************************//
           public string  prof1Reffered()
            {
                Refferd h = new Refferd();
                string findresult = h.checkedProf1(textBoxProf1RegNumber.Text);
                return findresult;
            }
           public string prof2Reffered()
           {
               Refferd h = new Refferd();
               string findresult = h.checkedProf2(textBoxProf2RegNum.Text);
               return findresult;
           }
           public string prof3Reffered()
           {
               Refferd h = new Refferd();
               string findresult = h.checkedProf3(textBoxProf3RegNum.Text);
               return findresult;
           }
           public string prof4Reffered()
           {
               Refferd h = new Refferd();
               string findresult = h.checkedProf4(textBoxFinalProf.Text);
               return findresult;
           }
        
            //****************************** Prof1 Reffered Checked End**********************************//
                
       private void buttonProf1Save_Click(object sender, EventArgs e)
        {
        
            //ANATOMY
            Home h= new Home();
            int findresult = h.Check(textBoxProf1RegNumber.Text);
            string reg= Convert.ToString(findresult);

            if (reg == textBoxProf1RegNumber.Text)
            {
                MessageBox.Show("You already Insert This Registration Num,Please Change It....");
            }
            else if (textBoxProf1RegNumber.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Reg No....");
            }
            else
            { 
                con.Open();
                SDA = new SqlDataAdapter("INSERT INTO ANATOMY(Reg_NO,ANA_A1,ANA_B1,ANA_MCQ1,ANA_Formative1,ANA_A2,ANA_B2,ANA_MCQ2,ANA_Formative2,ANA_Theory_Total,ANA_Oral,ANA_Practical,ANA_TOTAL,ANA_SAQ_Total1,ANA_SAQ_Total2,ANA_Total1,ANA_Total2) VALUES ('" + textBoxProf1RegNumber.Text + "','" + textBoxAnaA1.Text + "','" + textBoxAnaB1.Text + "','" + textBoxAnaMcq1.Text + "','" + textBoxAnaFormative1.Text + "','" + textBoxAnaA2.Text + "','" + textBoxAnaB2.Text + "','" + textBoxAnaMcq2.Text + "','" + textBoxAnaFormative2.Text + "','" + Convert.ToString(ANATHEORYTOTAL()) + "','" + textBoxAnaOral.Text + "','" + textBoxAnaPartical.Text + "','" + Convert.ToString(ANATOTAL()) + "','" + Convert.ToString(ANASAQTotalPaper1()) + "','" + Convert.ToString(ANASAQTotalPaper2()) + "','" + Convert.ToString(ANATotalPaper1()) + "','" + Convert.ToString(ANATotalPaper2()) + "')", con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();

                //PHYSIOLOGY

                con.Open();
                SDA = new SqlDataAdapter("INSERT INTO PHYSIOLOGY (Reg_NO,PHY_A1,PHY_B1,PHY_MCQ1,PHY_For1,PHY_A2,PHY_B2,PHY_MCQ2,PHY_For2,PHY_Theory_Total,PHY_Oral,PHY_Parctical,PHY_TOTAL,PHY_SAQ_Total1,PHY_SAQ_Total2,PHY_Total1,PHY_Total2) VALUES ('" + textBoxProf1RegNumber.Text + "','" + textBoxPhyA1.Text + "','" + textBoxPhyB1.Text + "','" + textBoxPhyMcq1.Text + "','" + textBoxPhyFormative1.Text + "','" + textBoxPhyA2.Text + "','" + textBoxPhyB2.Text + "','" + textBoxPhyMcq2.Text + "','" + textBoxPhyFormative2.Text + "','" + Convert.ToString(PHYTHEORYTOTAL()) + "','" + textBoxPhyOral.Text + "','" + textBoxPhyPartical.Text + "','" + Convert.ToString(PHYTOTAL()) + "','" + Convert.ToString(PHYSAQTotalPaper1()) + "','" + Convert.ToString(PHYSAQTotalPaper2()) + "','" + Convert.ToString(PHYTotalPaper1()) + "','" + Convert.ToString(PHYTotalPaper2()) + "')", con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();

                //BIOCHEMISTRY

                con.Open();
                SDA = new SqlDataAdapter("INSERT INTO BIOCHEMISTRY (Reg_NO,BIO_A1,BIO_B1,BIO_MCQ1,BIO_For1,BIO_A2,BIO_B2,BIO_MCQ2,BIO_For2,BIO_Theory_Total,BIO_Oral,BIO_Practical,BIO_TOTAL,BIO_SAQ_Total1,BIO_SAQ_Total2,BIO_Total1,BIO_Total2) VALUES ('" + textBoxProf1RegNumber.Text + "','" + textBoxBioA1.Text + "','" + textBoxBioB1.Text + "','" + textBoxBioMcq1.Text + "','" + textBoxBioFormative1.Text + "','" + textBoxBioA2.Text + "','" + textBoxBioB2.Text + "','" + textBoxBioMcq2.Text + "','" + textBoxBioFormative2.Text + "','" + Convert.ToString(BIOTHEORYTOTAL()) + "','" + textBoxBioOral.Text + "','" + textBoxBioPartical.Text + "','" + Convert.ToString(BIOTOTAL()) + "','" + Convert.ToString(BIOSAQTotalPaper1()) + "','" + Convert.ToString(BIOSAQTotalPaper2()) + "','" + Convert.ToString(BIOTotalPaper1()) + "','" + Convert.ToString(BIOTotalPaper2()) + "')", con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();

                Result A = new Result();
                string Anatomy = A.checkedAnatomy(ANATHEORYTOTAL(), Convert.ToInt32(textBoxAnaOral.Text), Convert.ToInt32(textBoxAnaPartical.Text));
                string Phyology = A.checkedPhysiology(PHYTHEORYTOTAL(), Convert.ToInt32(textBoxPhyOral.Text), Convert.ToInt32(textBoxPhyPartical.Text));
                string Biology=A.checkedBiochemistry(BIOTHEORYTOTAL(), Convert.ToInt32(textBoxBioOral.Text), Convert.ToInt32(textBoxBioPartical.Text));
                con.Open();
                SDA = new SqlDataAdapter("INSERT INTO PROF_1 (Reg_NO,GRAND_TOTAL,Anatomy,Physiology,Biochemistry) VALUES ('" + textBoxProf1RegNumber.Text + "','" + Convert.ToString(Prof1GrandTotal()) + "','" + Anatomy + "','" + Phyology + "','" + Biology + "')", con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();

                con.Open();
                SDA = new SqlDataAdapter("UPDATE PROF_1  SET Remarks='" + prof1Reffered() + "'WHERE Reg_NO='" + textBoxProf1RegNumber.Text + "'", con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Save Successfully....");
            }
        }

       private void buttonProf1View_Click(object sender, EventArgs e)
       {
           con.Open();
           SDA = new SqlDataAdapter(@"select Student.Reg_NO,Session,EXam_Roll,Name_of_Student,ANA_A1,ANA_B1,ANA_MCQ1,ANA_Formative1,ANA_A2,ANA_B2,ANA_MCQ2,ANA_Formative2,
                                    ANA_Theory_Total,ANA_Oral,ANA_Practical, ANA_TOTAL,PHY_A1,PHY_B1,PHY_MCQ1,PHY_For1,PHY_A2,PHY_B2,PHY_MCQ2,PHY_For2,PHY_Theory_Total,
                                    PHY_Oral,PHY_Parctical,PHY_TOTAL,BIO_A1,BIO_B1,BIO_MCQ1,BIO_For1,BIO_A2,BIO_B2,BIO_MCQ2,BIO_For2,BIO_Theory_Total,BIO_Oral,BIO_Practical,BIO_TOTAL,GRAND_TOTAL,Anatomy,Physiology,Biochemistry,Remarks from Student
                                    left join ANATOMY
                                    on Student.Reg_NO=ANATOMY.Reg_NO
                                    left join PHYSIOLOGY
                                    on Student.Reg_NO=PHYSIOLOGY.Reg_NO
                                    left join BIOCHEMISTRY
                                    on Student.Reg_NO=BIOCHEMISTRY.Reg_NO 
                                    left join PROF_1
                                    on Student.Reg_NO=PROF_1.Reg_NO;", con);
                                   
           DataTable = new DataTable();
           SDA.Fill(DataTable);
           con.Close();
           dataGridView4.DataSource = DataTable;

       }

       private void buttonProf1Update_Click(object sender, EventArgs e)
       {
          
           
           con.Open();
           SDA = new SqlDataAdapter("UPDATE ANATOMY SET ANA_A1='" + textBoxAnaA1.Text + "',ANA_B1='" + textBoxAnaB1.Text + "',ANA_MCQ1='" + textBoxAnaMcq1.Text + "',ANA_Formative1='" + textBoxAnaFormative1.Text + "',ANA_A2='" + textBoxAnaA2.Text + "',ANA_B2='" + textBoxAnaB2.Text + "',ANA_MCQ2='" + textBoxAnaMcq2.Text + "',ANA_Formative2='" + textBoxAnaFormative2.Text + "',ANA_Theory_Total='" + Convert.ToString(ANATHEORYTOTAL()) + "',ANA_Oral='" + textBoxAnaOral.Text + "',ANA_Practical='" + textBoxAnaPartical.Text + "',ANA_TOTAL='" + Convert.ToString(ANATOTAL()) + "',ANA_SAQ_Total1='" + Convert.ToString(ANASAQTotalPaper1()) + "',ANA_SAQ_Total2='" + Convert.ToString(ANASAQTotalPaper2()) + "',ANA_Total1='" + Convert.ToString(ANATotalPaper1()) + "',ANA_Total2='" + Convert.ToString(ANATotalPaper2()) + "'WHERE Reg_NO='" + textBoxProf1RegNumber.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           con.Open();
           SDA = new SqlDataAdapter("UPDATE PHYSIOLOGY SET PHY_A1='" + textBoxPhyA1.Text + "',PHY_B1='" + textBoxPhyB1.Text + "',PHY_MCQ1='" + textBoxPhyMcq1.Text + "',PHY_For1='" + textBoxPhyFormative1.Text + "',PHY_A2='" + textBoxPhyA2.Text + "',PHY_B2='" + textBoxPhyB2.Text + "',PHY_MCQ2='" + textBoxPhyMcq2.Text + "',PHY_For2='" + textBoxPhyFormative2.Text + "',PHY_Theory_Total='" + Convert.ToString(PHYTHEORYTOTAL()) + "',PHY_Oral='" + textBoxPhyOral.Text + "',PHY_Parctical='" + textBoxPhyPartical.Text + "',PHY_TOTAL='" + Convert.ToString(PHYTOTAL()) + "',PHY_SAQ_Total1='" + Convert.ToString(PHYSAQTotalPaper1()) + "',PHY_SAQ_Total2='" + Convert.ToString(PHYSAQTotalPaper2()) + "',PHY_Total1='" + Convert.ToString(PHYTotalPaper1()) + "',PHY_Total2='" + Convert.ToString(PHYTotalPaper2()) + "'WHERE Reg_NO='" + textBoxProf1RegNumber.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           con.Open();
           SDA = new SqlDataAdapter("UPDATE BIOCHEMISTRY SET BIO_A1='" + textBoxBioA1.Text + "',BIO_B1='" + textBoxBioB1.Text + "',BIO_MCQ1='" + textBoxBioMcq1.Text + "',BIO_For1='" + textBoxBioFormative1.Text + "',BIO_A2='" + textBoxBioA2.Text + "',BIO_B2='" + textBoxBioB2.Text + "',BIO_MCQ2='" + textBoxBioMcq2.Text + "',BIO_For2='" + textBoxBioFormative2.Text + "',BIO_Theory_Total='" + Convert.ToString(BIOTHEORYTOTAL()) + "',BIO_Oral='" + textBoxBioOral.Text + "',BIO_Practical='" + textBoxBioPartical.Text + "',BIO_TOTAL='" + Convert.ToString(BIOTOTAL()) + "',BIO_SAQ_Total1='" + Convert.ToString(BIOSAQTotalPaper1()) + "',BIO_SAQ_Total2='" + Convert.ToString(BIOSAQTotalPaper2()) + "',BIO_Total1='" + Convert.ToString(BIOTotalPaper1()) + "',BIO_Total2='" + Convert.ToString(BIOTotalPaper2()) + "'WHERE Reg_NO='" + textBoxProf1RegNumber.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
            Result A = new Result();
            
           con.Open();
           SDA = new SqlDataAdapter("UPDATE PROF_1 SET GRAND_TOTAL='" + Convert.ToString(Prof1GrandTotal()) + "',Anatomy='" + A.checkedAnatomy(ANATHEORYTOTAL(), Convert.ToInt32(textBoxAnaOral.Text), Convert.ToInt32(textBoxAnaPartical.Text)) + "',Physiology='" + A.checkedPhysiology(PHYTHEORYTOTAL(), Convert.ToInt32(textBoxPhyOral.Text), Convert.ToInt32(textBoxPhyPartical.Text)) + "',Biochemistry='" + A.checkedBiochemistry(BIOTHEORYTOTAL(), Convert.ToInt32(textBoxBioOral.Text), Convert.ToInt32(textBoxBioPartical.Text)) + "'WHERE Reg_NO='" + textBoxProf1RegNumber.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           
           con.Open();
           SDA = new SqlDataAdapter("UPDATE PROF_1  SET Remarks='" + prof1Reffered() + "'WHERE Reg_NO='" + textBoxProf1RegNumber.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           MessageBox.Show("Update Successfully...");
           

       }

       private void buttonProf1Delete_Click(object sender, EventArgs e)
       {
            
           con.Open();
           SDA = new SqlDataAdapter("DELETE FROM ANATOMY WHERE Reg_NO ='" + textBoxProf1RegNumber.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           con.Open();
           SDA = new SqlDataAdapter("DELETE FROM PHYSIOLOGY WHERE Reg_NO ='" + textBoxProf1RegNumber.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           con.Open();
           SDA = new SqlDataAdapter("DELETE FROM BIOCHEMISTRY WHERE Reg_NO ='" + textBoxProf1RegNumber.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           con.Open();
           SDA = new SqlDataAdapter("DELETE FROM PROF_1 WHERE Reg_NO ='" + textBoxProf1RegNumber.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();

           MessageBox.Show("Delete Successfully...");
           
       }

       private void dataGridView4_MouseDoubleClick(object sender, MouseEventArgs e)
       {
           textBoxProf1RegNumber.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
           textBoxAnaA1.Text=dataGridView4.SelectedRows[0].Cells[4].Value.ToString();
           textBoxAnaB1.Text = dataGridView4.SelectedRows[0].Cells[5].Value.ToString();
           textBoxAnaMcq1.Text = dataGridView4.SelectedRows[0].Cells[6].Value.ToString();
           textBoxAnaFormative1.Text = dataGridView4.SelectedRows[0].Cells[7].Value.ToString();
           textBoxAnaA2.Text = dataGridView4.SelectedRows[0].Cells[8].Value.ToString();
           textBoxAnaB2.Text = dataGridView4.SelectedRows[0].Cells[9].Value.ToString();
           textBoxAnaMcq2.Text = dataGridView4.SelectedRows[0].Cells[10].Value.ToString();
           textBoxAnaFormative2.Text = dataGridView4.SelectedRows[0].Cells[11].Value.ToString();
           textBoxAnaOral.Text = dataGridView4.SelectedRows[0].Cells[13].Value.ToString();
           textBoxAnaPartical.Text = dataGridView4.SelectedRows[0].Cells[14].Value.ToString();

           textBoxPhyA1.Text = dataGridView4.SelectedRows[0].Cells[16].Value.ToString();
           textBoxPhyB1.Text = dataGridView4.SelectedRows[0].Cells[17].Value.ToString();
           textBoxPhyMcq1.Text = dataGridView4.SelectedRows[0].Cells[18].Value.ToString();
           textBoxPhyFormative1.Text = dataGridView4.SelectedRows[0].Cells[19].Value.ToString();
           textBoxPhyA2.Text = dataGridView4.SelectedRows[0].Cells[20].Value.ToString();
           textBoxPhyB2.Text = dataGridView4.SelectedRows[0].Cells[21].Value.ToString();
           textBoxPhyMcq2.Text = dataGridView4.SelectedRows[0].Cells[22].Value.ToString();
           textBoxPhyFormative2.Text = dataGridView4.SelectedRows[0].Cells[23].Value.ToString();
           textBoxPhyOral.Text = dataGridView4.SelectedRows[0].Cells[25].Value.ToString();
           textBoxPhyPartical.Text = dataGridView4.SelectedRows[0].Cells[26].Value.ToString();

           textBoxBioA1.Text = dataGridView4.SelectedRows[0].Cells[28].Value.ToString();
           textBoxBioB1.Text = dataGridView4.SelectedRows[0].Cells[29].Value.ToString();
           textBoxBioMcq1.Text = dataGridView4.SelectedRows[0].Cells[30].Value.ToString();
           textBoxBioFormative1.Text = dataGridView4.SelectedRows[0].Cells[31].Value.ToString();
           textBoxBioA2.Text = dataGridView4.SelectedRows[0].Cells[32].Value.ToString();
           textBoxBioB2.Text = dataGridView4.SelectedRows[0].Cells[33].Value.ToString();
           textBoxBioMcq2.Text = dataGridView4.SelectedRows[0].Cells[34].Value.ToString();
           textBoxBioFormative2.Text = dataGridView4.SelectedRows[0].Cells[35].Value.ToString();
           textBoxBioOral.Text = dataGridView4.SelectedRows[0].Cells[37].Value.ToString();
           textBoxBioPartical.Text = dataGridView4.SelectedRows[0].Cells[38].Value.ToString();

       }

        //*********** Prof2***********//
       public int COMMSAQTotal()
       {

           int Total = Convert.ToInt32(textBoxCommA.Text) + Convert.ToInt32(textBoxCommB.Text) + Convert.ToInt32(textBoxCommC.Text) + Convert.ToInt32(textBoxCommD.Text);
           return Total;
       }
        public int COMMTHEORYTOTAL()
       {

           int Total = COMMSAQTotal() + Convert.ToInt32(textBoxCommMCQ.Text) + Convert.ToInt32(textBoxCommFormative.Text);
           return Total;
       }
       public int COMMParticalTOTAL()
       {

           int TOTAL =  Convert.ToInt32(textBoxCommOspe.Text) + Convert.ToInt32(textBoxCommPartical.Text);
           return TOTAL;
       }
       public int COMMTOTAL()
       {

           int TOTAL = COMMTHEORYTOTAL() + COMMParticalTOTAL() + Convert.ToInt32(textBoxCommOral.Text);
           return TOTAL;
       }
       public int FORENSAQTotal()
       {

           int Total = Convert.ToInt32(textBoxForenA.Text) + Convert.ToInt32(textBoxForenB.Text) + Convert.ToInt32(textBoxForenC.Text) + Convert.ToInt32(textBoxForenD.Text);
           return Total;
       }
       public int FORENTHEORYTOTAL()
       {

           int Total = FORENSAQTotal() + Convert.ToInt32(textBoxForenMCQ.Text) + Convert.ToInt32(textBoxForenFormative.Text);
           return Total;
       }
       public int FORENParticalTOTAL()
       {

           int TOTAL =  Convert.ToInt32(textBoxForenOspe.Text) + Convert.ToInt32(textBoxForenPartical.Text);
           return TOTAL;
       }
       public int FORENTOTAL()
       {

           int TOTAL = FORENTHEORYTOTAL() + FORENParticalTOTAL() + Convert.ToInt32(textBoxForenOral.Text);
           return TOTAL;
       }
       public int Prof2GrandTotal()
        {
           int GTotal= COMMTOTAL() + FORENTOTAL();
           return GTotal;
        }

       private void buttonProf2Save_Click(object sender, EventArgs e)
        {
           
          Home h= new Home();
          int findresult = h.Check1(textBoxProf2RegNum.Text);
            string reg= Convert.ToString(findresult);
           
          if (reg == textBoxProf2RegNum.Text)
           {
               MessageBox.Show("You already Insert This Registration Num,Please Change It....");
           }
          else if (textBoxProf2RegNum.Text == String.Empty)
          {
              MessageBox.Show("Please Enter Reg No....");
          }
          else
           {
               //Insert in COMMUNITY_MEDICINE
               con.Open();
               SDA = new SqlDataAdapter("INSERT INTO COMMUNITY_MEDICINE(Reg_NO,COM_A,COM_B,COM_C,COM_D,COM_MCQ,COM_For,COM_Theory_Total,COM_Oral,COM_OSPE,COM_Partical,COM_PARTICAL_Total,COM_TOTAL,COM_SAQ_Total) VALUES ('" + textBoxProf2RegNum.Text + "','" + textBoxCommA.Text + "','" + textBoxCommB.Text + "','" + textBoxCommC.Text + "','" + textBoxCommD.Text + "','" + textBoxCommMCQ.Text + "','" + textBoxCommFormative.Text + "','" + Convert.ToString(COMMTHEORYTOTAL()) + "','" + textBoxCommOral.Text + "','" + textBoxCommOspe.Text + "','" + textBoxCommPartical.Text + "','" + Convert.ToString(COMMParticalTOTAL()) + "','" + Convert.ToString(COMMTOTAL()) + "','" + Convert.ToString(COMMSAQTotal()) + "')", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();

               //InsertvFORENSIC_MEDICINE_And_TOXICOLOGY
               con.Open();
               SDA = new SqlDataAdapter("INSERT INTO FORENSIC_MEDICINE_And_TOXICOLOGY (Reg_NO,FOR_A,FOR_B,FOR_C,FOR_D,FOR_MCQ,FOR_For,FOR_Theory_Total,FOR_Oral,FOR_OSPE,FOR_Parctical,FOR_Partical_Total,FOR_TOTAL,FOR_SAQ_Total) VALUES ('" + textBoxProf2RegNum.Text + "','" + textBoxForenA.Text + "','" + textBoxForenB.Text + "','" + textBoxForenC.Text + "','" + textBoxForenD.Text + "','" + textBoxForenMCQ.Text + "','" + textBoxForenFormative.Text + "','" + Convert.ToString(FORENTHEORYTOTAL()) + "','" + textBoxForenOral.Text + "','" + textBoxForenOspe.Text + "','" + textBoxForenPartical.Text + "','" + Convert.ToString(FORENParticalTOTAL()) + "','" + Convert.ToString(FORENTOTAL()) + "','" + Convert.ToString(FORENSAQTotal()) + "')", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();
               Result A = new Result();
               con.Open();
               SDA = new SqlDataAdapter("INSERT INTO PROF_2 (Reg_NO,GRAND_TOTAL,Commu,Forn) VALUES ('" + textBoxProf2RegNum.Text + "','" + Convert.ToString(Prof2GrandTotal()) + "','" + A.checkedCommunity(COMMTHEORYTOTAL(), Convert.ToInt32(textBoxCommOral.Text), COMMParticalTOTAL()) + "','" + A.checkedForensic(FORENTHEORYTOTAL(), Convert.ToInt32(textBoxForenOral.Text), FORENParticalTOTAL()) + "')", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();
               con.Open();
               SDA = new SqlDataAdapter("UPDATE PROF_2  SET Remarks='" + prof2Reffered() + "'WHERE Reg_NO='" + textBoxProf2RegNum.Text + "'", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();
               MessageBox.Show("Save Successfully...");
           }
       }

       private void buttonProf2View_Click(object sender, EventArgs e)
       {
           con.Open();
           SDA = new SqlDataAdapter(@"select Student.Reg_NO,Session,EXam_Roll,Name_of_Student,COM_A,COM_B,COM_C,COM_D,COM_MCQ,COM_For,COM_Theory_Total,COM_Oral,COM_OSPE,COM_Partical,COM_PARTICAL_Total,COM_TOTAL,FOR_A,FOR_B,FOR_C,FOR_D,FOR_MCQ,FOR_For,FOR_Theory_Total,FOR_Oral,FOR_OSPE,FOR_Parctical,FOR_Partical_Total,FOR_TOTAL,GRAND_TOTAL,Commu,Forn,Remarks from Student
                                    left join COMMUNITY_MEDICINE
                                    on Student.Reg_NO=COMMUNITY_MEDICINE.Reg_NO
                                    left join FORENSIC_MEDICINE_And_TOXICOLOGY
                                    on Student.Reg_NO=FORENSIC_MEDICINE_And_TOXICOLOGY.Reg_NO
                                    left join PROF_2
                                    on Student.Reg_NO=PROF_2.Reg_NO;", con);
           DataTable = new DataTable();
           SDA.Fill(DataTable);
           con.Close();
           dataGridView5.DataSource = DataTable;


       }

       private void dataGridView5_MouseDoubleClick(object sender, MouseEventArgs e)
       {
           textBoxProf2RegNum.Text = dataGridView5.SelectedRows[0].Cells[0].Value.ToString();
           textBoxCommA.Text = dataGridView5.SelectedRows[0].Cells[4].Value.ToString();
           textBoxCommB.Text = dataGridView5.SelectedRows[0].Cells[5].Value.ToString();
           textBoxCommC.Text = dataGridView5.SelectedRows[0].Cells[6].Value.ToString();
           textBoxCommD.Text = dataGridView5.SelectedRows[0].Cells[7].Value.ToString();
           textBoxCommMCQ.Text = dataGridView5.SelectedRows[0].Cells[8].Value.ToString();
           textBoxCommFormative.Text = dataGridView5.SelectedRows[0].Cells[9].Value.ToString();
           textBoxCommOral.Text = dataGridView5.SelectedRows[0].Cells[11].Value.ToString();
           textBoxCommOspe.Text = dataGridView5.SelectedRows[0].Cells[12].Value.ToString();
           textBoxCommPartical.Text = dataGridView5.SelectedRows[0].Cells[13].Value.ToString();

           textBoxForenA.Text = dataGridView5.SelectedRows[0].Cells[16].Value.ToString();
           textBoxForenB.Text = dataGridView5.SelectedRows[0].Cells[17].Value.ToString();
           textBoxForenC.Text = dataGridView5.SelectedRows[0].Cells[18].Value.ToString();
           textBoxForenD.Text = dataGridView5.SelectedRows[0].Cells[19].Value.ToString();
           textBoxForenMCQ.Text = dataGridView5.SelectedRows[0].Cells[20].Value.ToString();
           textBoxForenFormative.Text = dataGridView5.SelectedRows[0].Cells[21].Value.ToString();
           textBoxForenOral.Text = dataGridView5.SelectedRows[0].Cells[23].Value.ToString();
           textBoxForenOspe.Text= dataGridView5.SelectedRows[0].Cells[24].Value.ToString();
           textBoxForenPartical.Text = dataGridView5.SelectedRows[0].Cells[25].Value.ToString();
       }

       private void buttonProf2Update_Click(object sender, EventArgs e)
       {
           con.Open();
           SDA = new SqlDataAdapter("UPDATE COMMUNITY_MEDICINE SET COM_A='" + textBoxCommA.Text + "',COM_B='" + textBoxCommB.Text + "',COM_C='" + textBoxCommC.Text + "',COM_D='" + textBoxCommD.Text + "',COM_MCQ='" + textBoxCommMCQ.Text + "',COM_For='" + textBoxCommFormative.Text + "',COM_Theory_Total='" + Convert.ToString(COMMTHEORYTOTAL()) + "',COM_Oral='" + textBoxCommOral.Text + "',COM_OSPE='" + textBoxCommOspe.Text + "',COM_Partical='" + textBoxCommPartical.Text + "',COM_PARTICAL_Total='" + Convert.ToString(COMMParticalTOTAL()) + "',COM_TOTAL='" + Convert.ToString(COMMTOTAL()) + "',COM_SAQ_Total='" + Convert.ToString(COMMSAQTotal()) + "'WHERE Reg_NO='" + textBoxProf2RegNum.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
   
           con.Open();
           SDA = new SqlDataAdapter("UPDATE FORENSIC_MEDICINE_And_TOXICOLOGY SET FOR_A='" + textBoxForenA.Text + "',FOR_B='" + textBoxForenB.Text + "',FOR_C='" + textBoxForenC.Text + "',FOR_D='" + textBoxForenD.Text + "',FOR_MCQ='" + textBoxForenMCQ.Text + "',FOR_For='" + textBoxForenFormative.Text + "',FOR_Theory_Total='" + Convert.ToString(FORENTHEORYTOTAL()) + "',FOR_Oral='" + textBoxForenOral.Text + "',FOR_OSPE='" + textBoxForenOspe.Text + "',FOR_Parctical='" + textBoxForenPartical.Text + "',FOR_Partical_Total='" + Convert.ToString(FORENParticalTOTAL()) + "',FOR_TOTAL='" + Convert.ToString(FORENTOTAL()) + "',FOR_SAQ_Total='" + Convert.ToString(FORENSAQTotal()) + "'WHERE Reg_NO='" + textBoxProf2RegNum.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           Result A = new Result();
           con.Open();
           SDA = new SqlDataAdapter("UPDATE PROF_2 SET GRAND_TOTAL='" + Convert.ToString(Prof2GrandTotal()) + "',Commu='" + A.checkedCommunity(COMMTHEORYTOTAL(), Convert.ToInt32(textBoxCommOral.Text), COMMParticalTOTAL()) + "',Forn='" + A.checkedForensic(FORENTHEORYTOTAL(), Convert.ToInt32(textBoxForenOral.Text), FORENParticalTOTAL()) + "'WHERE Reg_NO='" + textBoxProf2RegNum.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           con.Open();
           SDA = new SqlDataAdapter("UPDATE PROF_2  SET Remarks='" + prof2Reffered() + "'WHERE Reg_NO='" + textBoxProf2RegNum.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           MessageBox.Show("Update Successfully...");     
       }

       private void buttonProf2Delete_Click(object sender, EventArgs e)
       {
           con.Open();
           SDA = new SqlDataAdapter("DELETE FROM COMMUNITY_MEDICINE WHERE Reg_NO ='" + textBoxProf2RegNum.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           con.Open();
           SDA = new SqlDataAdapter("DELETE FROM FORENSIC_MEDICINE_And_TOXICOLOGY WHERE Reg_NO ='" + textBoxProf2RegNum.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           con.Open();
           SDA = new SqlDataAdapter("DELETE FROM PROF_2 WHERE Reg_NO ='" + textBoxProf2RegNum.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           MessageBox.Show("Delete Successfully...");
       }

       //****************************** Prof3**********************************//
       public int PathoSAQTotal()
       {
           int Total = Convert.ToInt32(textBoxPathoA.Text) + Convert.ToInt32(textBoxPathoB.Text) + Convert.ToInt32(textBoxPathoC.Text) + Convert.ToInt32(textBoxPathoD.Text) ;
           return Total;
       }
        public int PATHOTHEORYTOTAL()
       {

           int Total = PathoSAQTotal() + Convert.ToInt32(textBoxPathoMCQ.Text) + Convert.ToInt32(textBoxPathoFor.Text);
           return Total;
       }
       public int PATHOPracticalTOTAL()
       {

           int TOTAL = Convert.ToInt32(textBoxPathoOspe.Text) + Convert.ToInt32(textBoxPathoPractical.Text);
           return TOTAL;
       }
       public int PATHOTOTAL()
       {

           int TOTAL = PATHOTHEORYTOTAL() + PATHOPracticalTOTAL() + Convert.ToInt32(textBoxPathoOral.Text);
           return TOTAL;
       }
       public int MicroSAQTotal()
       {
           int Total = Convert.ToInt32(textBoxMicroA.Text) + Convert.ToInt32(textBoxMicroB.Text) + Convert.ToInt32(textBoxMicroC.Text) + Convert.ToInt32(textBoxMicroD.Text);
           return Total;
       }

       public int MICROTHEORYTOTAL()
       {

           int Total = MicroSAQTotal() + Convert.ToInt32(textBoxMicroMCQ.Text) + Convert.ToInt32(textBoxMicroFor.Text);
           return Total;
       }
       public int MICROParticalTOTAL()
       {

           int TOTAL = Convert.ToInt32(textBoxMicroOspe.Text) + Convert.ToInt32(textBoxMicroPartical.Text);
           return TOTAL;
       }
       public int MICROTOTAL()
       {

           int TOTAL = MICROTHEORYTOTAL() + MICROParticalTOTAL() + Convert.ToInt32(textBoxMicroOral.Text);
           return TOTAL;
       }
       public int PHARMASAQTotal()
       {

           int Total = Convert.ToInt32(textBoxPharmaA.Text) + Convert.ToInt32(textBoxPharmaB.Text) + Convert.ToInt32(textBoxPharmaC.Text) + Convert.ToInt32(textBoxPharmaD.Text);
           return Total;
       }
       public int PHARMATHEORYTOTAL()
       {

           int Total = PHARMASAQTotal() + Convert.ToInt32(textBoxPharmaMCQ.Text) + Convert.ToInt32(textBoxPharmaFor.Text);
           return Total;
       }
       public int PHARMAParticalTOTAL()
       {

           int TOTAL = Convert.ToInt32(textBoxPharmaOspe.Text) + Convert.ToInt32(textBoxPharmaPartical.Text);
           return TOTAL;
       }
       public int PHARMATOTAL()
       {

           int TOTAL = PHARMATHEORYTOTAL() + PHARMAParticalTOTAL() + Convert.ToInt32(textBoxPharmaOral.Text);
           return TOTAL;
       }
       public int Prof3GrandTotal()
       {
           int GTotal = PATHOTOTAL() + MICROTOTAL() + PHARMATOTAL();
           return GTotal;
       }

       private void buttonProf3Save_Click(object sender, EventArgs e)
       {
           Home h = new Home();
           int findresult = h.Check2(textBoxProf3RegNum.Text);
           string reg = Convert.ToString(findresult);

           if (reg == textBoxProf3RegNum.Text)
           {
               MessageBox.Show("You already Insert This Registration Num,Please Change It....");
           }
           else if (textBoxProf3RegNum.Text == String.Empty)
           {
               MessageBox.Show("Please Enter Reg No....");
           }
           else
           {
               //PATHOLOGY
               con.Open();
               SDA = new SqlDataAdapter("INSERT INTO PATHOLOGY(Reg_NO,Patho_A,Patho_B,Patho_C,Patho_D,Patho_MCQ,Patho_For,Patho_Theory_Total,Patho_Oral,Patho_OSPE,Patho_Parctical,Patho_Parctical_Total,Patho_TOTAL,Patho_GYNA_SAQ_Total) VALUES ('" + textBoxProf3RegNum.Text + "','" + textBoxPathoA.Text + "','" + textBoxPathoB.Text + "','" + textBoxPathoC.Text + "','" + textBoxPathoD.Text + "','" + textBoxPathoMCQ.Text + "','" + textBoxPathoFor.Text + "','" + Convert.ToString(PATHOTHEORYTOTAL()) + "','" + textBoxPathoOral.Text + "','" + textBoxPathoOspe.Text + "','" + textBoxPathoPractical.Text + "','" + Convert.ToString(PATHOPracticalTOTAL()) + "','" + Convert.ToString(PathoSAQTotal()) + "')", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();

               //MICROBIOLOGY

               con.Open();
               SDA = new SqlDataAdapter("INSERT INTO MICROBIOLOGY (Reg_NO,Micro_A,Micro_B,Micro_C,Micro_D,Micro_MCQ,Micro_For,Micro_Theory_Total,Micro_Oral,Micro_OSPE,Micro_Partical,Micro_Partical_Total,Micro_TOTAL,Micro_SAQ_Total) VALUES ('" + textBoxProf3RegNum.Text + "','" + textBoxMicroA.Text + "','" + textBoxMicroB.Text + "','" + textBoxMicroC.Text + "','" + textBoxMicroD.Text + "','" + textBoxMicroMCQ.Text + "','" + textBoxMicroFor.Text + "','" + Convert.ToString(MICROTHEORYTOTAL()) + "','" + textBoxMicroOral.Text + "','" + textBoxMicroOspe.Text + "','" + textBoxMicroPartical.Text + "','" + Convert.ToString(MICROParticalTOTAL()) + "','" + Convert.ToString(MICROTOTAL()) + "','" + Convert.ToString(MICROTHEORYTOTAL()) + "','" + Convert.ToString(MicroSAQTotal()) + "')", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();

               //PHARMACOLOGY & THERAPEUTICS

               con.Open();
               SDA = new SqlDataAdapter("INSERT INTO PHARMACOLOGY_And_THERAPEUTICS (Reg_NO,Pharma_A,Pharma_B,Pharma_C,Pharma_D,Pharma_MCQ,Pharma_For,Pharma_Theory_Total,Pharma_Oral,Pharma_OSPE,Pharma_Partical,Pharma_Partical_Total,Pharma_TOTAL,Pharma_SAQ_Total) VALUES ('" + textBoxProf3RegNum.Text + "','" + textBoxPharmaA.Text + "','" + textBoxPharmaB.Text + "','" + textBoxPharmaC.Text + "','" + textBoxPharmaD.Text + "','" + textBoxPharmaMCQ.Text + "','" + textBoxPharmaFor.Text + "','" + Convert.ToString(PHARMATHEORYTOTAL()) + "','" + textBoxPharmaOral.Text + "','" + textBoxPharmaOspe.Text + "','" + textBoxPharmaPartical.Text + "','" + Convert.ToString(PHARMAParticalTOTAL()) + "','" + Convert.ToString(PHARMATOTAL()) + "','" + Convert.ToString(PHARMASAQTotal()) + "')", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();

               Result A = new Result();
               con.Open();
               SDA = new SqlDataAdapter("INSERT INTO PROF_3 (Reg_NO,GRAND_TOTAL,Phatho,Micro,Pharma) VALUES ('" + textBoxProf3RegNum.Text + "','" + Convert.ToString(Prof3GrandTotal()) + "','" + A.checkedPathology(PATHOTHEORYTOTAL(), Convert.ToInt32(textBoxPathoOral.Text), PATHOPracticalTOTAL()) + "','" + A.checkedMicroBio(MICROTHEORYTOTAL(), Convert.ToInt32(textBoxMicroOral.Text), MICROParticalTOTAL()) + "','" + A.checkedPharmaco(PHARMATHEORYTOTAL(), Convert.ToInt32(textBoxPharmaOral.Text), PHARMAParticalTOTAL()) + "')", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();
               con.Open();
               SDA = new SqlDataAdapter("UPDATE PROF_3  SET Remarks='" + prof3Reffered() + "'WHERE Reg_NO='" + textBoxProf3RegNum.Text + "'", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();

               MessageBox.Show("Save Successfully....");
           }

       }
        private void buttonProf3View_Click(object sender, EventArgs e)
        {
           con.Open();
           SDA = new SqlDataAdapter(@"select Student.Reg_NO,Session,EXam_Roll,Name_of_Student,Patho_A,Patho_B,Patho_C,Patho_D,Patho_MCQ,Patho_For,Patho_Theory_Total,Patho_Oral,Patho_OSPE,Patho_Parctical,Patho_Parctical_Total,Patho_TOTAL,Micro_A,Micro_B,Micro_C,Micro_D,Micro_MCQ,Micro_For,Micro_Theory_Total,Micro_Oral,Micro_OSPE,Micro_Partical,Micro_Partical_Total,Micro_TOTAL,
                                    Pharma_A,Pharma_B,Pharma_C,Pharma_D,Pharma_MCQ,Pharma_For,Pharma_Theory_Total,Pharma_Oral,Pharma_OSPE,Pharma_Partical,Pharma_Partical_Total,Pharma_TOTAL,GRAND_TOTAL,Phatho,Micro,Pharma,Remarks from Student
                                    left join PATHOLOGY
                                    on Student.Reg_NO=PATHOLOGY.Reg_NO
                                    left join MICROBIOLOGY
                                    on Student.Reg_NO=MICROBIOLOGY.Reg_NO
									left join PHARMACOLOGY_And_THERAPEUTICS
                                    on Student.Reg_NO=PHARMACOLOGY_And_THERAPEUTICS.Reg_NO
                                    left join PROF_3
                                    on Student.Reg_NO=PROF_3.Reg_NO;", con);
           DataTable = new DataTable();
           SDA.Fill(DataTable);
           con.Close();
           dataGridView6.DataSource = DataTable;
  
       }

        private void dataGridView6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxProf3RegNum.Text = dataGridView6.SelectedRows[0].Cells[0].Value.ToString();
            textBoxPathoA.Text = dataGridView6.SelectedRows[0].Cells[4].Value.ToString();
            textBoxPathoB.Text = dataGridView6.SelectedRows[0].Cells[5].Value.ToString();
            textBoxPathoC.Text = dataGridView6.SelectedRows[0].Cells[6].Value.ToString();
            textBoxPathoD.Text = dataGridView6.SelectedRows[0].Cells[7].Value.ToString();
            textBoxPathoMCQ.Text = dataGridView6.SelectedRows[0].Cells[8].Value.ToString();
            textBoxPathoFor.Text = dataGridView6.SelectedRows[0].Cells[9].Value.ToString();
            textBoxPathoOral.Text = dataGridView6.SelectedRows[0].Cells[11].Value.ToString();
            textBoxPathoOspe.Text = dataGridView6.SelectedRows[0].Cells[12].Value.ToString();
            textBoxPathoPractical.Text = dataGridView6.SelectedRows[0].Cells[13].Value.ToString();

            textBoxMicroA.Text = dataGridView6.SelectedRows[0].Cells[16].Value.ToString();
            textBoxMicroB.Text = dataGridView6.SelectedRows[0].Cells[17].Value.ToString();
            textBoxMicroC.Text = dataGridView6.SelectedRows[0].Cells[18].Value.ToString();
            textBoxMicroD.Text = dataGridView6.SelectedRows[0].Cells[19].Value.ToString();
            textBoxMicroMCQ.Text = dataGridView6.SelectedRows[0].Cells[20].Value.ToString();
            textBoxMicroFor.Text = dataGridView6.SelectedRows[0].Cells[21].Value.ToString();
            textBoxMicroOral.Text = dataGridView6.SelectedRows[0].Cells[23].Value.ToString();
            textBoxMicroOspe.Text = dataGridView6.SelectedRows[0].Cells[24].Value.ToString();
            textBoxMicroPartical.Text = dataGridView6.SelectedRows[0].Cells[25].Value.ToString();

            textBoxPharmaA.Text = dataGridView6.SelectedRows[0].Cells[28].Value.ToString();
            textBoxPharmaB.Text = dataGridView6.SelectedRows[0].Cells[29].Value.ToString();
            textBoxPharmaC.Text = dataGridView6.SelectedRows[0].Cells[30].Value.ToString();
            textBoxPharmaD.Text = dataGridView6.SelectedRows[0].Cells[31].Value.ToString();
            textBoxPharmaMCQ.Text = dataGridView6.SelectedRows[0].Cells[32].Value.ToString();
            textBoxPharmaFor.Text = dataGridView6.SelectedRows[0].Cells[33].Value.ToString();
            textBoxPharmaOral.Text = dataGridView6.SelectedRows[0].Cells[35].Value.ToString();
            textBoxPharmaOspe.Text = dataGridView6.SelectedRows[0].Cells[36].Value.ToString();
            textBoxPharmaPartical.Text = dataGridView6.SelectedRows[0].Cells[37].Value.ToString();
        }


        private void buttonProf3Update_Click(object sender, EventArgs e)
        {
           con.Open();
           SDA = new SqlDataAdapter("UPDATE PATHOLOGY SET Patho_A='" + textBoxPathoA.Text + "',Patho_B='" + textBoxPathoB.Text + "',Patho_C='" + textBoxPathoC.Text + "',Patho_D='" + textBoxPathoD.Text + "',Patho_MCQ='" + textBoxPathoMCQ.Text + "',Patho_For='" + textBoxPathoFor.Text + "',Patho_Theory_Total='" + Convert.ToString(PATHOTHEORYTOTAL()) + "',Patho_Oral='" + textBoxPathoOral.Text + "',Patho_OSPE='" + textBoxPathoOspe.Text + "',Patho_Parctical='" + textBoxPathoPractical.Text + "',Patho_Parctical_Total='" + Convert.ToString(PATHOPracticalTOTAL()) + "',Patho_TOTAL='" + Convert.ToString(PATHOTOTAL()) + "',Patho_GYNA_SAQ_Total='" + Convert.ToString(PathoSAQTotal()) + "'WHERE Reg_NO='" + textBoxProf3RegNum.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
   
           con.Open();
           SDA = new SqlDataAdapter("UPDATE MICROBIOLOGY SET Micro_A='" + textBoxMicroA.Text + "',Micro_B='" + textBoxMicroB.Text + "',Micro_C='" + textBoxMicroC.Text + "',Micro_D='" + textBoxMicroD.Text + "',Micro_MCQ='" + textBoxMicroMCQ.Text + "',Micro_For='" + textBoxMicroFor.Text + "',Micro_Theory_Total='" + Convert.ToString(MICROTHEORYTOTAL()) + "',Micro_Oral='" + textBoxMicroOral.Text + "',Micro_OSPE='" + textBoxMicroOspe.Text + "',Micro_Partical='" + textBoxMicroPartical.Text + "',Micro_Partical_Total='" + Convert.ToString(MICROParticalTOTAL()) + "',Micro_TOTAL='" + Convert.ToString(MICROTOTAL()) + "',Micro_SAQ_Total='" + Convert.ToString(MicroSAQTotal()) + "'WHERE Reg_NO='" + textBoxProf3RegNum.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           con.Open();
           SDA = new SqlDataAdapter("UPDATE PHARMACOLOGY_And_THERAPEUTICS SET Pharma_A='" + textBoxPharmaA.Text + "',Pharma_B='" + textBoxPharmaB.Text + "',Pharma_C='" + textBoxPharmaC.Text + "',Pharma_D='" + textBoxPharmaD.Text + "',Pharma_MCQ='" + textBoxPharmaMCQ.Text + "',Pharma_For='" + textBoxPharmaFor.Text + "',Pharma_Theory_Total='" + Convert.ToString(PHARMATHEORYTOTAL()) + "',Pharma_Oral='" + textBoxPharmaOral.Text + "',Pharma_OSPE='" + textBoxPharmaOspe.Text + "',Pharma_Partical='" + textBoxPharmaPartical.Text + "',Pharma_Partical_Total='" + Convert.ToString(PHARMAParticalTOTAL()) + "',Pharma_TOTAL='" + Convert.ToString(PHARMATOTAL()) + "',Pharma_SAQ_Total='" + Convert.ToString(PHARMASAQTotal()) + "'WHERE Reg_NO='" + textBoxProf3RegNum.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();

           Result A = new Result();
           con.Open();
           SDA = new SqlDataAdapter("UPDATE PROF_3 SET GRAND_TOTAL='" + Convert.ToString(Prof3GrandTotal()) + "',Phatho='" + A.checkedPathology(PATHOTHEORYTOTAL(), Convert.ToInt32(textBoxPathoOral.Text), PATHOPracticalTOTAL()) + "',Micro='" + A.checkedMicroBio(MICROTHEORYTOTAL(), Convert.ToInt32(textBoxMicroOral.Text), MICROParticalTOTAL()) + "',Pharma='" + A.checkedPharmaco(PHARMATHEORYTOTAL(), Convert.ToInt32(textBoxPharmaOral.Text), PHARMAParticalTOTAL()) + "'WHERE Reg_NO='" + textBoxProf3RegNum.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           con.Open();
           SDA = new SqlDataAdapter("UPDATE PROF_3  SET Remarks='" + prof3Reffered() + "'WHERE Reg_NO='" + textBoxProf3RegNum.Text + "'", con);
           SDA.SelectCommand.ExecuteNonQuery();
           con.Close();
           MessageBox.Show("Update Successfully...");
        }
        private void buttonProf3Delete_Click(object sender, EventArgs e)
        {
            


            con.Open();
            SDA = new SqlDataAdapter("DELETE FROM PATHOLOGY WHERE Reg_NO ='" + textBoxProf3RegNum.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            con.Open();
            SDA = new SqlDataAdapter("DELETE FROM MICROBIOLOGY WHERE Reg_NO ='" + textBoxProf3RegNum.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            con.Open();
            SDA = new SqlDataAdapter("DELETE FROM PHARMACOLOGY_And_THERAPEUTICS WHERE Reg_NO ='" + textBoxProf3RegNum.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            con.Open();
            SDA = new SqlDataAdapter("DELETE FROM PROF_3 WHERE Reg_NO ='" + textBoxProf3RegNum.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Delete Successfully...");
        }

        //****************************** Final Prof**********************************//

        public int SURSAQTotalPaper1()
        {

            int Total = Convert.ToInt32(textBoxSurA1.Text) + Convert.ToInt32(textBoxSurB1.Text) + Convert.ToInt32(textBoxSurC1.Text) + Convert.ToInt32(textBoxSurD1.Text);
            return Total;
        }
        public int SURSAQTotalPaper2()
        {

            int Total =  Convert.ToInt32(textBoxSurA2.Text) + Convert.ToInt32(textBoxSurB2.Text) + Convert.ToInt32(textBoxSurC2.Text) + Convert.ToInt32(textBoxSurD2.Text);
            return Total;
        }
        public int SURSAQTotalPaper11()
        {

            int Total = SURSAQTotalPaper1() + Convert.ToInt32(textBoxSurMcq1.Text) + Convert.ToInt32(textBoxSurFor1.Text);
            return Total;
        }
        public int SURSAQTotalPaper21()
        {

            int Total = SURSAQTotalPaper2() + Convert.ToInt32(textBoxSurMcq2.Text) + +Convert.ToInt32(textBoxSurFor2.Text);
            return Total;
        }
        public int SURSAQTotal()
        {

            int Total = SURSAQTotalPaper1() + SURSAQTotalPaper2();
            return Total;
        }
        public int SURMCQTotal()
        {

            int Total = Convert.ToInt32(textBoxSurMcq1.Text) + Convert.ToInt32(textBoxSurMcq2.Text);
            return Total;
        }
        public int SURForTotal()
        {

            int Total = Convert.ToInt32(textBoxSurFor1.Text) + Convert.ToInt32(textBoxSurFor2.Text);
            return Total;
        }
        public int SURTHEORYTOTAL()
        {

            int Total = SURSAQTotal() + SURMCQTotal() + SURForTotal();
            return Total;
        }
       
        public int SURTOTAL()
        {

            int TOTAL = SURTHEORYTOTAL() + Convert.ToInt32(textBoxSurOral.Text) + Convert.ToInt32(textBoxSurPractical.Text) + Convert.ToInt32(textBoxSurClinical.Text);
            return TOTAL;
        }
        public int MEDISAQTotalPaper1()
        {

            int Total = Convert.ToInt32(textBoxMediA1.Text) + Convert.ToInt32(textBoxMediB1.Text);
            return Total;
        }
        public int MEDISAQTotalPaper2()
        {

            int Total = Convert.ToInt32(textBoxMediA2.Text) + Convert.ToInt32(textBoxMediB2.Text);
            return Total;
        }
        public int MEDISAQTotalPaper11()
        {

            int Total = MEDISAQTotalPaper1() + Convert.ToInt32(textBoxMediMcq1.Text) + Convert.ToInt32(textBoxMediFor1.Text);
            return Total;
        }
        public int MEDISAQTotalPaper21()
        {

            int Total = MEDISAQTotalPaper2() + Convert.ToInt32(textBoxMediMcq2.Text) + Convert.ToInt32(textBoxMediFor2.Text);
            return Total;
        }
        public int MEDISAQTotal()
        {

            int Total = MEDISAQTotalPaper1() + MEDISAQTotalPaper2();
            return Total;
        }
        public int MEDIMCQTotal()
        {

            int Total = Convert.ToInt32(textBoxMediMcq1.Text) + Convert.ToInt32(textBoxMediMcq2.Text);
            return Total;
        }
        public int MEDIForTotal()
        {

            int Total = Convert.ToInt32(textBoxMediFor1.Text) + Convert.ToInt32(textBoxMediFor2.Text);
            return Total;
        }
        public int MEDITHEORYTOTAL()
        {

            int Total = MEDISAQTotal() + MEDIMCQTotal() + MEDIForTotal();
            return Total;
        }
       
        public int MEDITOTAL()
        {

            int TOTAL = MEDITHEORYTOTAL() + Convert.ToInt32(textBoxMediOral.Text) + Convert.ToInt32(textBoxMediPractical.Text) + Convert.ToInt32(textBoxMediClinical.Text);
            return TOTAL;
        }
        public int GYNASAQTotalPaper1()
        {

            int Total = Convert.ToInt32(textBoxGynaA1.Text) + Convert.ToInt32(textBoxGynaB1.Text);
            return Total;
        }
        public int GYNASAQTotalPaper2()
        {

            int Total = Convert.ToInt32(textBoxGynaA2.Text) + Convert.ToInt32(textBoxGynaB2.Text);
            return Total;
        }
        public int GYNASAQTotalPaper11()
        {

            int Total = GYNASAQTotalPaper1() + Convert.ToInt32(textBoxGynaMcq1.Text) + Convert.ToInt32(textBoxGynaFor1.Text);
            return Total;
        }
        public int GYNASAQTotalPaper21()
        {

            int Total = GYNASAQTotalPaper2() + Convert.ToInt32(textBoxGynaMcq2.Text) + Convert.ToInt32(textBoxGynaFor2.Text);
            return Total;
        }
        public int GYNASAQTotal()
        {

            int Total = GYNASAQTotalPaper1() + GYNASAQTotalPaper2();
            return Total;
        }
        public int GYNAMCQTotal()
        {

            int Total = Convert.ToInt32(textBoxGynaMcq1.Text) + Convert.ToInt32(textBoxGynaMcq2.Text);
            return Total;
        }
        public int GYNAForTotal()
        {

            int Total = Convert.ToInt32(textBoxGynaFor1.Text) + Convert.ToInt32(textBoxGynaFor2.Text);
            return Total;
        }
        public int GYNATHEORYTOTAL()
        {

            int Total = GYNASAQTotal() + GYNAMCQTotal() + GYNAForTotal();
            return Total;
        }
        
        public int GYNATOTAL()
        {

            int TOTAL = GYNATHEORYTOTAL() + Convert.ToInt32(textBoxGynaOral.Text) + Convert.ToInt32(textBoxGynaPartical.Text) + Convert.ToInt32(textBoxGynaClinical.Text);
            return TOTAL;
        }
        public int FinalProfTotal()
        {
            int GTotal = SURTOTAL() + MEDITOTAL() + GYNATOTAL();
            return GTotal;
        }

         
        private void buttonFinalProfSave_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            int findresult = h.Check3(textBoxFinalProf.Text);
           string reg = Convert.ToString(findresult);

           if (reg == textBoxFinalProf.Text)
           {
               MessageBox.Show("You already Insert This Registration Num,Please Change It....");
           }
           else if (textBoxFinalProf.Text == String.Empty)
           {
               MessageBox.Show("Please Enter Reg No....");
           }
           else
           {
               //SURGERY

               con.Open();
               SDA = new SqlDataAdapter("INSERT INTO SURGERY(Reg_NO,SUR_A1,SUR_B1,SUR_C1,SUR_D1,SUR_MCQ1,SUR_Formative1,SUR_A2,SUR_B2,SUR_C2,SUR_D2,SUR_MCQ2,SUR_Formative2,SUR_Theory_Total,SUR_Oral,SUR_Partical,SUR_Clinical,SUR_TOTAL,SUR_SAQPaper1_Total,SUR_SAQPaper2_Total,SUR_Total_Paper1,SUR_Total_Paper2) VALUES ('" + textBoxFinalProf.Text + "','" + textBoxSurA1.Text + "','" + textBoxSurB1.Text + "','" + textBoxSurC1.Text + "','" + textBoxSurD1.Text + "','" + textBoxSurMcq1.Text + "','" + textBoxSurFor1.Text + "','" + textBoxSurA2.Text + "','" + textBoxSurB2.Text + "','" + textBoxSurC2.Text + "','" + textBoxSurD2.Text + "','" + textBoxSurMcq2.Text + "','" + textBoxSurFor2.Text + "','" + Convert.ToString(SURTHEORYTOTAL()) + "','" + textBoxSurOral.Text + "','" + textBoxSurPractical.Text + "','" + textBoxSurClinical.Text + "','" + Convert.ToString(SURTOTAL()) + "','" + Convert.ToString(SURSAQTotalPaper1()) + "','" + Convert.ToString(SURSAQTotalPaper2()) + "','" + Convert.ToString(SURSAQTotalPaper11()) + "','" + Convert.ToString(SURSAQTotalPaper21()) + "')", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();

               //MEDICINE 

               con.Open();
               SDA = new SqlDataAdapter("INSERT INTO MEDICINE (Reg_NO,MEDI_A1,MEDI_B1,MEDI_MCQ1,MEDI_Formative1,MEDI_A2,MEDI_B2,MEDI_MCQ2,MEDI_Formative2,MEDI_Theory_Total,MEDI_Oral,MEDI_Partical,MEDI_Clinical,MEDI_TOTAL,MEDI_SAQPaper1_Total,MEDI_SAQPaper2_Total,MEDI_Total_Paper1,MEDI_Total_Paper2) VALUES ('" + textBoxFinalProf.Text + "','" + textBoxMediA1.Text + "','" + textBoxMediB1.Text + "','" + textBoxMediMcq1.Text + "','" + textBoxMediFor1.Text + "','" + textBoxMediA2.Text + "','" + textBoxMediB2.Text + "','" + textBoxMediMcq2.Text + "','" + textBoxMediFor2.Text + "','" + Convert.ToString(MEDITHEORYTOTAL()) + "','" + textBoxMediOral.Text + "','" + textBoxMediPractical.Text + "','" + textBoxMediClinical.Text + "','" + Convert.ToString(MEDITOTAL()) + "','" + Convert.ToString(MEDISAQTotalPaper1()) + "','" + Convert.ToString(MEDISAQTotalPaper2()) + "','" + Convert.ToString(MEDISAQTotalPaper11()) + "','" + Convert.ToString(MEDISAQTotalPaper21()) + "')", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();

               //OBSTETRICS_And_GYNAECOLOGY

               con.Open();
               SDA = new SqlDataAdapter("INSERT INTO OBSTETRICS_And_GYNAECOLOGY (Reg_NO,OBS_GYNA_A1,OBS_GYNA_B1,OBS_GYNA_MCQ1,OBS_GYNA_Formative1,OBS_GYNA_A2,OBS_GYNA_B2,OBS_GYNA_MCQ2,OBS_GYNA_Formative2,OBS_GYNA_Theory_Total,OBS_GYNA_Oral,OBS_GYNA_Practical,OBS_GYNA_Clinical,OBS_GYNA_TOTAL,OBS_GYNA_SAQPaper1_Total,OBS_GYNA_SAQPaper2_Total,OBS_GYNA_Total_Paper1,OBS_GYNA_Total_Paper2) VALUES ('" + textBoxFinalProf.Text + "','" + textBoxGynaA1.Text + "','" + textBoxGynaB1.Text + "','" + textBoxGynaMcq1.Text + "','" + textBoxGynaFor1.Text + "','" + textBoxGynaA2.Text + "','" + textBoxGynaB2.Text + "','" + textBoxGynaMcq2.Text + "','" + textBoxGynaFor2.Text + "','" + Convert.ToString(GYNATHEORYTOTAL()) + "','" + textBoxGynaOral.Text + "','" + textBoxGynaPartical.Text + "','" + textBoxGynaClinical.Text + "','" + Convert.ToString(GYNATOTAL()) + "','" + Convert.ToString(GYNASAQTotalPaper1()) + "','" + Convert.ToString(GYNASAQTotalPaper2()) + "','" + Convert.ToString(GYNASAQTotalPaper11()) + "','" + Convert.ToString(GYNASAQTotalPaper21()) + "')", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();

               Result A = new Result();
               con.Open();
               SDA = new SqlDataAdapter("INSERT INTO PROF_4 (Reg_NO,GRAND_TOTAL,Surgery,Medicine,Ghyna) VALUES ('" + textBoxFinalProf.Text + "','" + Convert.ToString(FinalProfTotal()) + "','" + A.checkedSurgary(SURTHEORYTOTAL(), Convert.ToInt32(textBoxSurOral.Text), Convert.ToInt32(textBoxSurPractical.Text), Convert.ToInt32(textBoxSurClinical.Text)) + "','" + A.checkedMedicine(MEDITHEORYTOTAL(), Convert.ToInt32(textBoxMediOral.Text), Convert.ToInt32(textBoxMediPractical.Text), Convert.ToInt32(textBoxMediClinical.Text)) + "','" + A.checkedGynacology(GYNATHEORYTOTAL(), Convert.ToInt32(textBoxGynaOral.Text), Convert.ToInt32(textBoxGynaPartical.Text), Convert.ToInt32(textBoxGynaClinical.Text)) + "')", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();
               con.Open();
               SDA = new SqlDataAdapter("UPDATE PROF_4  SET Remarks='" + prof4Reffered() + "'WHERE Reg_NO='" + textBoxFinalProf.Text + "'", con);
               SDA.SelectCommand.ExecuteNonQuery();
               con.Close();

               MessageBox.Show("Save Successfully....");
           }
        }

        private void buttonFinalProfView_Click(object sender, EventArgs e)
        {
            con.Open();
            SDA = new SqlDataAdapter(@"select Student.Reg_NO,Session,EXam_Roll,Name_of_Student,SUR_A1,SUR_B1,SUR_C1,SUR_D1,SUR_MCQ1,SUR_Formative1,SUR_A2,SUR_B2,SUR_C2,SUR_D2,SUR_MCQ2,SUR_Formative2,SUR_Theory_Total,SUR_Oral,SUR_Partical,SUR_Clinical,SUR_TOTAL,MEDI_A1,MEDI_B1,MEDI_MCQ1,MEDI_Formative1,MEDI_A2,MEDI_B2,MEDI_MCQ2,MEDI_Formative2,MEDI_Theory_Total,MEDI_Oral,MEDI_Partical,MEDI_Clinical,MEDI_TOTAL,
                                    OBS_GYNA_A1,OBS_GYNA_B1,OBS_GYNA_MCQ1,OBS_GYNA_Formative1,OBS_GYNA_A2,OBS_GYNA_B2,OBS_GYNA_MCQ2,OBS_GYNA_Formative2,OBS_GYNA_Theory_Total,OBS_GYNA_Oral,OBS_GYNA_Practical,OBS_GYNA_Clinical,OBS_GYNA_TOTAL,GRAND_TOTAL,Surgery,Medicine,Ghyna,Remarks from Student
                                    left join SURGERY
                                    on Student.Reg_NO=SURGERY.Reg_NO
                                    left join MEDICINE
                                    on Student.Reg_NO=MEDICINE.Reg_NO
									left join OBSTETRICS_And_GYNAECOLOGY
                                    on Student.Reg_NO=OBSTETRICS_And_GYNAECOLOGY.Reg_NO
                                    left join PROF_4
                                    on Student.Reg_NO=PROF_4.Reg_NO;", con);
            DataTable = new DataTable();
            SDA.Fill(DataTable);
            con.Close();
            dataGridView7.DataSource = DataTable;
        }

        private void dataGridView7_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxFinalProf.Text = dataGridView7.SelectedRows[0].Cells[0].Value.ToString();
            textBoxSurA1.Text = dataGridView7.SelectedRows[0].Cells[4].Value.ToString();
            textBoxSurB1.Text = dataGridView7.SelectedRows[0].Cells[5].Value.ToString();
            textBoxSurC1.Text = dataGridView7.SelectedRows[0].Cells[6].Value.ToString();
            textBoxSurD1.Text = dataGridView7.SelectedRows[0].Cells[7].Value.ToString();
            textBoxSurMcq1.Text = dataGridView7.SelectedRows[0].Cells[8].Value.ToString();
            textBoxSurFor1.Text = dataGridView7.SelectedRows[0].Cells[9].Value.ToString();
            textBoxSurA2.Text = dataGridView7.SelectedRows[0].Cells[10].Value.ToString();
            textBoxSurB2.Text = dataGridView7.SelectedRows[0].Cells[11].Value.ToString();
            textBoxSurC2.Text = dataGridView7.SelectedRows[0].Cells[12].Value.ToString();
            textBoxSurD2.Text = dataGridView7.SelectedRows[0].Cells[13].Value.ToString();
            textBoxSurMcq2.Text = dataGridView7.SelectedRows[0].Cells[14].Value.ToString();
            textBoxSurFor2.Text = dataGridView7.SelectedRows[0].Cells[15].Value.ToString();
            textBoxSurOral.Text = dataGridView7.SelectedRows[0].Cells[17].Value.ToString();
            textBoxSurPractical.Text = dataGridView7.SelectedRows[0].Cells[18].Value.ToString();
            textBoxSurClinical.Text = dataGridView7.SelectedRows[0].Cells[19].Value.ToString();

            textBoxMediA1.Text = dataGridView7.SelectedRows[0].Cells[21].Value.ToString();
            textBoxMediB1.Text = dataGridView7.SelectedRows[0].Cells[22].Value.ToString();
            textBoxMediMcq1.Text = dataGridView7.SelectedRows[0].Cells[23].Value.ToString();
            textBoxMediFor1.Text = dataGridView7.SelectedRows[0].Cells[24].Value.ToString();
            textBoxMediA2.Text = dataGridView7.SelectedRows[0].Cells[25].Value.ToString();
            textBoxMediB2.Text = dataGridView7.SelectedRows[0].Cells[26].Value.ToString();
            textBoxMediMcq2.Text = dataGridView7.SelectedRows[0].Cells[27].Value.ToString();
            textBoxMediFor2.Text = dataGridView7.SelectedRows[0].Cells[28].Value.ToString();
            textBoxMediOral.Text = dataGridView7.SelectedRows[0].Cells[30].Value.ToString();
            textBoxMediPractical.Text = dataGridView7.SelectedRows[0].Cells[31].Value.ToString();
            textBoxMediClinical.Text = dataGridView7.SelectedRows[0].Cells[32].Value.ToString();

            textBoxGynaA1.Text= dataGridView7.SelectedRows[0].Cells[34].Value.ToString();
            textBoxGynaB1.Text = dataGridView7.SelectedRows[0].Cells[35].Value.ToString();
            textBoxGynaMcq1.Text = dataGridView7.SelectedRows[0].Cells[36].Value.ToString();
            textBoxGynaFor1.Text = dataGridView7.SelectedRows[0].Cells[37].Value.ToString();
            textBoxGynaA2.Text = dataGridView7.SelectedRows[0].Cells[38].Value.ToString();
            textBoxGynaB2.Text = dataGridView7.SelectedRows[0].Cells[39].Value.ToString();
            textBoxGynaMcq2.Text = dataGridView7.SelectedRows[0].Cells[40].Value.ToString();
            textBoxGynaFor2.Text = dataGridView7.SelectedRows[0].Cells[41].Value.ToString();
            textBoxGynaOral.Text = dataGridView7.SelectedRows[0].Cells[43].Value.ToString();
            textBoxGynaPartical.Text = dataGridView7.SelectedRows[0].Cells[44].Value.ToString();
            textBoxGynaClinical.Text = dataGridView7.SelectedRows[0].Cells[45].Value.ToString();
        }

        private void buttonFinalProfUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SDA = new SqlDataAdapter("UPDATE SURGERY SET SUR_A1='" + textBoxSurA1.Text + "',SUR_B1='" + textBoxSurB1.Text + "',SUR_C1='" + textBoxSurC1.Text + "',SUR_D1='" + textBoxSurD1.Text + "',SUR_MCQ1='" + textBoxSurMcq1.Text + "',SUR_Formative1='" + textBoxSurFor1.Text + "',SUR_A2='" + textBoxSurA2.Text + "',SUR_B2='" + textBoxSurB2.Text + "',SUR_C2='" + textBoxSurC2.Text + "',SUR_D2='" + textBoxSurD2.Text + "',SUR_MCQ2='" + textBoxSurMcq2.Text + "',SUR_Formative2='" + textBoxSurFor2.Text + "',SUR_Theory_Total='" + Convert.ToString(SURTHEORYTOTAL()) + "',SUR_Oral='" + textBoxSurOral.Text + "',SUR_Partical='" + textBoxSurPractical.Text + "',SUR_Clinical='" + textBoxSurClinical.Text + "',SUR_TOTAL='" + Convert.ToString(SURTOTAL()) + "',SUR_SAQPaper1_Total='" + Convert.ToString(SURSAQTotalPaper1()) + "',SUR_SAQPaper2_Total='" + Convert.ToString(SURSAQTotalPaper2()) + "',SUR_Total_Paper1='" + Convert.ToString(SURSAQTotalPaper11()) + "',SUR_Total_Paper2='" + Convert.ToString(SURSAQTotalPaper21()) + "'WHERE Reg_NO='" + textBoxFinalProf.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            con.Open();
            SDA = new SqlDataAdapter("UPDATE MEDICINE SET MEDI_A1='" + textBoxMediA1.Text + "',MEDI_B1='" + textBoxMediB1.Text + "',MEDI_MCQ1='" + textBoxMediMcq1.Text + "',MEDI_Formative1='" + textBoxMediFor1.Text + "',MEDI_A2='" + textBoxMediA2.Text + "',MEDI_B2='" + textBoxMediB2.Text + "',MEDI_MCQ2='" + textBoxMediMcq2.Text + "',MEDI_Formative2='" + textBoxMediFor2.Text + "',MEDI_Theory_Total='" + Convert.ToString(MEDITHEORYTOTAL()) + "',MEDI_Oral='" + textBoxMediOral.Text + "',MEDI_Partical='" + textBoxMediPractical.Text + "',MEDI_Clinical='" + textBoxMediClinical.Text + "',MEDI_TOTAL='" + Convert.ToString(MEDITOTAL()) + "',MEDI_SAQPaper1_Total='" + Convert.ToString(MEDISAQTotalPaper1()) + "',MEDI_SAQPaper2_Total='" + Convert.ToString(MEDISAQTotalPaper2()) + "',MEDI_Total_Paper1='" + Convert.ToString(MEDISAQTotalPaper11()) + "',MEDI_Total_Paper2='" + Convert.ToString(MEDISAQTotalPaper21()) + "'WHERE Reg_NO='" + textBoxFinalProf.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
           con.Open();
           SDA = new SqlDataAdapter("UPDATE OBSTETRICS_And_GYNAECOLOGY SET  OBS_GYNA_A1='" + textBoxGynaA1.Text + "',OBS_GYNA_B1='" + textBoxGynaB1.Text + "',OBS_GYNA_MCQ1='" + textBoxGynaMcq1.Text + "',OBS_GYNA_Formative1='" + textBoxGynaFor1.Text + "',OBS_GYNA_A2='" + textBoxGynaA2.Text + "',OBS_GYNA_B2='" + textBoxGynaB2.Text + "',OBS_GYNA_MCQ2='" + textBoxGynaMcq2.Text + "',OBS_GYNA_Formative2='" + textBoxGynaFor2.Text + "',OBS_GYNA_Theory_Total='" + Convert.ToString(GYNATHEORYTOTAL()) + "',OBS_GYNA_Oral='" + textBoxGynaOral.Text + "',OBS_GYNA_Practical='" + textBoxGynaPartical.Text + "',OBS_GYNA_Clinical='" + textBoxGynaClinical.Text + "',OBS_GYNA_TOTAL='" + Convert.ToString(GYNATOTAL()) + "',OBS_GYNA_SAQPaper1_Total='" + Convert.ToString(GYNASAQTotalPaper1()) + "',OBS_GYNA_SAQPaper2_Total='" + Convert.ToString(GYNASAQTotalPaper2()) + "',OBS_GYNA_Total_Paper1='" + Convert.ToString(GYNASAQTotalPaper11()) + "',OBS_GYNA_Total_Paper2='" + Convert.ToString(GYNASAQTotalPaper21()) + "'WHERE Reg_NO='" + textBoxFinalProf.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            Result A = new Result();
            con.Open();
            SDA = new SqlDataAdapter("UPDATE PROF_4 SET GRAND_TOTAL='" + Convert.ToString(FinalProfTotal()) + "',Surgery='" + A.checkedSurgary(SURTHEORYTOTAL(), Convert.ToInt32(textBoxSurOral.Text), Convert.ToInt32(textBoxSurPractical.Text), Convert.ToInt32(textBoxSurClinical.Text)) + "',Medicine='" + A.checkedMedicine(MEDITHEORYTOTAL(), Convert.ToInt32(textBoxMediOral.Text), Convert.ToInt32(textBoxMediPractical.Text), Convert.ToInt32(textBoxMediClinical.Text)) + "',Ghyna='" + A.checkedGynacology(GYNATHEORYTOTAL(), Convert.ToInt32(textBoxGynaOral.Text), Convert.ToInt32(textBoxGynaPartical.Text), Convert.ToInt32(textBoxGynaClinical.Text)) + "'WHERE Reg_NO='" + textBoxFinalProf.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            con.Open();
            SDA = new SqlDataAdapter("UPDATE PROF_4  SET Remarks='" + prof4Reffered() + "'WHERE Reg_NO='" + textBoxFinalProf.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfully...");
        }
        private void buttonFinalProfDelete_Click(object sender, EventArgs e)
        {

            con.Open();
            SDA = new SqlDataAdapter("DELETE FROM SURGERY WHERE Reg_NO ='" + textBoxFinalProf.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            con.Open();
            SDA = new SqlDataAdapter("DELETE FROM MEDICINE WHERE Reg_NO ='" + textBoxFinalProf.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            con.Open();
            SDA = new SqlDataAdapter("DELETE FROM OBSTETRICS_And_GYNAECOLOGY WHERE Reg_NO ='" + textBoxFinalProf.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            con.Open();
            SDA = new SqlDataAdapter("DELETE FROM PROF_4 WHERE Reg_NO ='" + textBoxFinalProf.Text + "'", con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Delete Successfully...");
        }

        //****************************** Result **********************************//
        private void show_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                con.Open();
                SDA = new SqlDataAdapter(@"select Student.Reg_NO,Session,EXam_Roll,Name_of_Student,ANA_A1,ANA_B1,ANA_MCQ1,ANA_Formative1,ANA_A2,ANA_B2,ANA_MCQ2,ANA_Formative2,
                                    ANA_Theory_Total,ANA_Oral,ANA_Practical, ANA_TOTAL,PHY_A1,PHY_B1,PHY_MCQ1,PHY_For1,PHY_A2,PHY_B2,PHY_MCQ2,PHY_For2,PHY_Theory_Total,
                                    PHY_Oral,PHY_Parctical,PHY_TOTAL,BIO_A1,BIO_B1,BIO_MCQ1,BIO_For1,BIO_A2,BIO_B2,BIO_MCQ2,BIO_For2,BIO_Theory_Total,BIO_Oral,BIO_Practical,BIO_TOTAL,GRAND_TOTAL,Anatomy,Physiology,Biochemistry,Remarks from Student
                                    left join ANATOMY
                                    on Student.Reg_NO=ANATOMY.Reg_NO
                                    left join PHYSIOLOGY
                                    on Student.Reg_NO=PHYSIOLOGY.Reg_NO
                                    left join BIOCHEMISTRY
                                    on Student.Reg_NO=BIOCHEMISTRY.Reg_NO
                                    left join PROF_1
                                    on Student.Reg_NO=PROF_1.Reg_NO ;", con);

                DataTable = new DataTable();
                SDA.Fill(DataTable);
                con.Close();
                dataGridView2.DataSource = DataTable;
            }
            else if (radioButton2.Checked)
            {
                con.Open();
                SDA = new SqlDataAdapter(@"select Student.Reg_NO,Session,EXam_Roll,Name_of_Student,COM_A,COM_B,COM_C,COM_D,COM_MCQ,COM_For,COM_Theory_Total,COM_Oral,COM_OSPE,COM_Partical,COM_PARTICAL_Total,COM_TOTAL,FOR_A,FOR_B,FOR_C,FOR_D,FOR_MCQ,FOR_For,FOR_Theory_Total,FOR_Oral,FOR_OSPE,FOR_Parctical,FOR_Partical_Total,FOR_TOTAL,GRAND_TOTAL,Commu,Forn,Remarks from Student
                                    left join COMMUNITY_MEDICINE
                                    on Student.Reg_NO=COMMUNITY_MEDICINE.Reg_NO
                                    left join FORENSIC_MEDICINE_And_TOXICOLOGY
                                    on Student.Reg_NO=FORENSIC_MEDICINE_And_TOXICOLOGY.Reg_NO
                                    left join PROF_2
                                    on Student.Reg_NO=PROF_2.Reg_NO ;", con);
                DataTable = new DataTable();
                SDA.Fill(DataTable);
                con.Close();
                dataGridView2.DataSource = DataTable;
            }
            else if (radioButton3.Checked)
            {
                con.Open();
                SDA = new SqlDataAdapter(@"select Student.Reg_NO,Session,EXam_Roll,Name_of_Student,Patho_A,Patho_B,Patho_C,Patho_D,Patho_MCQ,Patho_For,Patho_Theory_Total,Patho_Oral,Patho_OSPE,Patho_Parctical,Patho_Parctical_Total,Patho_TOTAL,Micro_A,Micro_B,Micro_C,Micro_D,Micro_MCQ,Micro_For,Micro_Theory_Total,Micro_Oral,Micro_OSPE,Micro_Partical,Micro_Partical_Total,Micro_TOTAL,
                                    Pharma_A,Pharma_B,Pharma_C,Pharma_D,Pharma_MCQ,Pharma_For,Pharma_Theory_Total,Pharma_Oral,Pharma_OSPE,Pharma_Partical,Pharma_Partical_Total,Pharma_TOTAL,GRAND_TOTAL,Phatho,Micro,Pharma,Remarks from Student
                                    left join PATHOLOGY
                                    on Student.Reg_NO=PATHOLOGY.Reg_NO
                                    left join MICROBIOLOGY
                                    on Student.Reg_NO=MICROBIOLOGY.Reg_NO
									left join PHARMACOLOGY_And_THERAPEUTICS
                                    on Student.Reg_NO=PHARMACOLOGY_And_THERAPEUTICS.Reg_NO
                                    left join PROF_3
                                    on Student.Reg_NO=PROF_3.Reg_NO ;", con);
                DataTable = new DataTable();
                SDA.Fill(DataTable);
                con.Close();
                dataGridView2.DataSource = DataTable;
            }
            else if (radioButton4.Checked)
            {
                con.Open();
                SDA = new SqlDataAdapter(@"select Student.Reg_NO,Session,EXam_Roll,Name_of_Student,SUR_A1,SUR_B1,SUR_C1,SUR_D1,SUR_MCQ1,SUR_Formative1,SUR_A2,SUR_B2,SUR_C2,SUR_D2,SUR_MCQ2,SUR_Formative2,SUR_Theory_Total,SUR_Oral,SUR_Partical,SUR_Clinical,SUR_TOTAL,MEDI_A1,MEDI_B1,MEDI_MCQ1,MEDI_Formative1,MEDI_A2,MEDI_B2,MEDI_MCQ2,MEDI_Formative2,MEDI_Theory_Total,MEDI_Oral,MEDI_Partical,MEDI_Clinical,MEDI_TOTAL,
                                    OBS_GYNA_A1,OBS_GYNA_B1,OBS_GYNA_MCQ1,OBS_GYNA_Formative1,OBS_GYNA_A2,OBS_GYNA_B2,OBS_GYNA_MCQ2,OBS_GYNA_Formative2,OBS_GYNA_Theory_Total,OBS_GYNA_Oral,OBS_GYNA_Practical,OBS_GYNA_Clinical,OBS_GYNA_TOTAL,GRAND_TOTAL,Surgery,Medicine,Ghyna,Remarks from Student
                                    left join SURGERY
                                    on Student.Reg_NO=SURGERY.Reg_NO
                                    left join MEDICINE
                                    on Student.Reg_NO=MEDICINE.Reg_NO
									left join OBSTETRICS_And_GYNAECOLOGY
                                    on Student.Reg_NO=OBSTETRICS_And_GYNAECOLOGY.Reg_NO
                                    left join PROF_4
                                    on Student.Reg_NO=PROF_4.Reg_NO ;", con);
                DataTable = new DataTable();
                SDA.Fill(DataTable);
                con.Close();
                dataGridView2.DataSource = DataTable;
            }
        }

       


        private void buttonSerialNoSave_Click(object sender, EventArgs e)
        {
            string Subject = comboBoxSubjectPrint.GetItemText(comboBoxSubjectPrint.SelectedItem);
            Home h = new Home();
            int findresult = h.CheckResultRegularSerialnum(textBoxResultRegNo.Text);
            string SerialNo = Convert.ToString(findresult);
            if (textBoxResultRegNo.Text == String.Empty)
            {
                MessageBox.Show("Please Enter Reg No....");
            }
            else if(comboBoxSubjectPrint.Text==string.Empty)
            {
                MessageBox.Show("Please Select Subject Name....");
            }
            else if (SerialNo == textBoxResultRegNo.Text)
            {
                MessageBox.Show("You already Insert This Serial No.,Please Change It....");
            }
            
            else
            {
                    con.Open();
                    SDA = new SqlDataAdapter("UPDATE Student SET Subject = '" + Subject + "',SerialNum= '" + textBoxResultRegular.Text + "'WHERE Reg_NO='" + textBoxResultRegNo.Text + "'", con);
                    SDA.SelectCommand.ExecuteNonQuery();
                    con.Close();
                MessageBox.Show("Save Successfully...");
            }
        }

        private void buttonResultShow_Click(object sender, EventArgs e)
        {
            con.Open();
            SDA = new SqlDataAdapter(@"select Reg_NO,Subject,SerialNum from Student;", con);
            DataTable = new DataTable();
            SDA.Fill(DataTable);
            con.Close();
            dataGridView8.DataSource = DataTable;
        }

        private void buttonResultDelete_Click(object sender, EventArgs e)
        {
             con.Open();
             SDA = new SqlDataAdapter("ALTER TABLE Student DROP COLUMN Subject;", con);
             SDA.SelectCommand.ExecuteNonQuery();
             con.Close();
             con.Open();
             SDA = new SqlDataAdapter("ALTER TABLE Student DROP COLUMN SerialNum;", con);
             SDA.SelectCommand.ExecuteNonQuery();
             con.Close();
             con.Open();
             SDA = new SqlDataAdapter("ALTER TABLE Student ADD Subject nvarchar(50);", con);
             SDA.SelectCommand.ExecuteNonQuery();
             con.Close();
             con.Open();
             SDA = new SqlDataAdapter("ALTER TABLE Student ADD SerialNum int;", con);
             SDA.SelectCommand.ExecuteNonQuery();
             con.Close();
             MessageBox.Show("Delete Successfully...");
            
        }
        

        private void buttonPrintTabulation_Click(object sender, EventArgs e)
        {
            if (comboBoxPrinttabulation.Text == "First Professional")
            {
                TabulationProf1 ss = new TabulationProf1();
                ss.Show();
            }
            else if (comboBoxPrinttabulation.Text == "Second Professional")
            {
                TabulationProf2 ss = new TabulationProf2();
                ss.Show();
            }
            else if (comboBoxPrinttabulation.Text == "Third Professional")
            {
                TabulationProf3 ss = new TabulationProf3();
                ss.Show();
            }
            else if (comboBoxPrinttabulation.Text == "Final Professional")
            {
                TabulationProf4 ss = new TabulationProf4();
                ss.Show();
            }
        }

        private void buttonPrintResults_Click(object sender, EventArgs e)
        {
            if (comboBoxPrintResults.Text == "prof 1")
            {
                proof1 ss = new proof1();
                ss.Show();
            }
            else if (comboBoxPrintResults.Text == "prof 2")
            {
                proof2 ss = new proof2();
                ss.Show();
            }
            else if (comboBoxPrintResults.Text == "prof 3")
            {
                proof3 ss = new proof3();
                ss.Show();
            }
            else if (comboBoxPrintResults.Text == "Final Prof")
            {
                proof4 ss = new proof4();
                ss.Show();
            }
        }

       

       

        
         
    }

}
