using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Classes;

namespace WindowsFormsApp2
{
    public partial class Holse : Form
    {
       
        public Holse()
        {
            InitializeComponent();
            
        }

        Recruiterclass c = new Recruiterclass();

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fullname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Register_Click(object sender, EventArgs e)
        {

            c.FirstName = txtboxfirstname.Text;
            c.LastName = txtboxlastname.Text;
            c.Age = txtboxage.Text;
            c.Email = txtboxemail.Text;
            c.PhoneNumber = txtboxphonenumber.Text;
            
            c.Gender = comboBoxgender.Text;
            c.ExperienceLevel = txtboxexperience.Text;
            c.PreviousCompany = txtboxprecompany.Text;
            c.Qualification = txtboxhighqualification.Text;
            c.Address = txtboxaddress.Text;
            c.AdditionalInfo = txtboxadditionalinfo.Text;

            bool success = c.Insert(c);
            if(success == true)
            {
                MessageBox.Show("Successfully Register");
                Clear();
            }
            else
            {
                MessageBox.Show("Registration Failed");
            }


            DataTable dt = c.Select();
            dgvlist.DataSource = dt;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dataviewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataTable dt = c.Select();
            dgvlist.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        


        private void txtboxexperience_TextChanged(object sender, EventArgs e)
        {
           
            
            
            
            

            


           
           
        }

        private void settings_Click(object sender, EventArgs e)
        {
            
        }
        public void Clear()
        {
            txtboxfirstname.Text = "";
            txtboxlastname.Text = "";
            txtboxage.Text = "";
            txtboxemail.Text = "";
            comboBoxgender.Text = "";
            txtboxexperience.Text = "";
            txtboxhighqualification.Text = "";
            txtboxprecompany.Text = "";
            txtboxphonenumber.Text = "";
            txtboxaddress.Text = "";
            txtboxadditionalinfo.Text = "";

           


           

        }

        

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void explevellabel_Click(object sender, EventArgs e)
        {

        }

        private void txtboxage_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void explimit_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void explimit_TextChanged_1(object sender, EventArgs e)
        {

            

            
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }

