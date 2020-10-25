using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp2.Classes
{
    class Recruiterclass
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string ExperienceLevel { get; set; }
        public string PreviousCompany { get; set; }
        public string Qualification { get; set; }
        public string Address { get; set; }
        public string AdditionalInfo { get; set; }

        static string Myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(Myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM recruiter_table1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);


            }
            catch (Exception ex)
            {


            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        public bool Insert(Recruiterclass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(Myconnstrng);

            try
            {
                string sql = "INSERT INTO recruiter_table1 (FirstName, LastName, Age, Email, PhoneNumber, Gender, ExperienceLevel, PreviousCompany, Qualification, Address, AdditionalInfo) VALUES (@FirstName, @LastName, @Age, @Email, @PhoneNumber, @Gender, @ExperienceLevel, @PreviousCompany, @Qualification, @Address, @AdditionalInfo)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Age", c.Age);
                cmd.Parameters.AddWithValue("@Email", c.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", c.PhoneNumber);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ExperienceLevel", c.ExperienceLevel);
                cmd.Parameters.AddWithValue("@PreviousCompany", c.PreviousCompany);
                cmd.Parameters.AddWithValue("@Qualification", c.Qualification);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@AdditionalInfo", c.AdditionalInfo);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {

            }

            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        
        

        




    }
}
