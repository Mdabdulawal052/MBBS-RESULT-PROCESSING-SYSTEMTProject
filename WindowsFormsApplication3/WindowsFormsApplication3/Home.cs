using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
   
    class Home
    {
        public SqlConnection con = new SqlConnection("Data Source=FOYSAL-PC;Initial Catalog=Poysal;Integrated Security=True");
          SqlCommand com = new SqlCommand();
          SqlDataAdapter SDA; 
          SqlCommandBuilder scb;
          DataTable DataTable;
           string match;
            public string Roll ;
            public string Reg ;
            public string Session ;
            public string Name ;
            public string Date ;
            public string MobileNum ;
            public int SReg(string text)
            {

                com = new SqlCommand("select Reg_NO from Student where Reg_NO='" + text + "';", con);
                con.Open();

                SqlDataReader read = com.ExecuteReader();
                //string tot;
                while (read.Read())
                {
                    match = (read["Reg_NO"].ToString());
                }

                con.Close();
                int result = Convert.ToInt32(match);
                return result;
            }
            public void insert()
            {
                con.Open();
                SDA = new SqlDataAdapter("INSERT INTO Student (Reg_NO,Session,EXam_Roll,Name_of_Student,Date_Of_Birth,Mobile) VALUES ('" + Reg + "','" + Session + "','" + Roll + "','" + Name + "','" + Date + "','" + MobileNum + "')", con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();

            }

            public void Delet(string R)
            {
                string Reg = R;
                con.Open();
                SDA = new SqlDataAdapter("Delete From Student WHERE Reg_NO='" + Reg + "'", con);
                SDA.SelectCommand.ExecuteNonQuery();

                con.Close();
            }
            //*********Prof1********//
            public int Check(string text)
            {

                com = new SqlCommand("select Reg_NO from ANATOMY where Reg_NO='" + text + "';", con);
                con.Open();

                SqlDataReader read = com.ExecuteReader();
                //string tot;
                while (read.Read())
                {
                    match = (read["Reg_NO"].ToString());
                }

                con.Close();
                int result = Convert.ToInt32(match);
                return result;
            }
            //*********Prof2********//
            public int Check1(string text)
            {

                com = new SqlCommand("select Reg_NO from COMMUNITY_MEDICINE where Reg_NO='" + text + "';", con);
                con.Open();

                SqlDataReader read = com.ExecuteReader();
                //string tot;
                while (read.Read())
                {
                    match = (read["Reg_NO"].ToString());
                }

                con.Close();
                int result = Convert.ToInt32(match);
                return result;
            }
            //*********Prof3********//
            public int Check2(string text)
            {

                com = new SqlCommand("select Reg_NO from PATHOLOGY where Reg_NO='" + text + "';", con);
                con.Open();

                SqlDataReader read = com.ExecuteReader();
                //string tot;
                while (read.Read())
                {
                    match = (read["Reg_NO"].ToString());
                }

                con.Close();
                int result = Convert.ToInt32(match);
                return result;
            }
            //********* Final Proof ********//
            public int Check3(string text)
            {

                com = new SqlCommand("select Reg_NO from SURGERY where Reg_NO='" + text + "';", con);
                con.Open();

                SqlDataReader read = com.ExecuteReader();
                //string tot;
                while (read.Read())
                {
                    match = (read["Reg_NO"].ToString());
                }

                con.Close();
                int result = Convert.ToInt32(match);
                return result;
            }
            // *******Result*******//
            public int CheckResultRegularSerialnum(string text)
            {

                com = new SqlCommand("select SerialNum from Student where SerialNum='" + text + "';", con);
                con.Open();

                SqlDataReader read = com.ExecuteReader();
                //string tot;
                while (read.Read())
                {
                    match = (read["SerialNum"].ToString());
                }

                con.Close();
                int result = Convert.ToInt32(match);
                return result;
            }
        
        
        

    }
}
