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
using System.Data.Sql;
using System.Data.SqlTypes;



namespace steptest
{
    public partial class Stafflogin : Form
    {
        public Stafflogin()
        {
            InitializeComponent();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private SqlDataReader reader;
        private void Submit_Click(object sender, EventArgs e)
        {

                    
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            connection.ConnectionString = @"Data Source=BRTHDYBYROJY\SQLEXPRESS;" + "Initial Catalog=steptest; Integrated Security=YES";
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Staff WHERE Staff_id=@StaffID";
            command.Parameters.Clear(); 
            command.Parameters.AddWithValue("@StaffID", Staffid.Text); 
            try 
            { 
                connection.Open(); 

                reader = command.ExecuteReader(CommandBehavior.SingleRow); 
                if (reader.Read())
                {
                    textBox1.Text = reader["Staff_name"].ToString();

                    Class1.sname = textBox1.Text;                   
                    Customerlogin sec = new Customerlogin();
                    sec.Show();
                   
                }
                else MessageBox.Show("StaffID does not exist.");
            } 
            catch (SqlException ex) 
            { 
                MessageBox.Show(ex.Message); 
            } 
            
            finally { connection.Close(); }

        }
 
    


            


        //private void Register_Click(object sender, EventArgs e)
        //{
        //    StaffRegister registering = new StaffRegister();
        //    registering.Show();
        //}

        private void Staffid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click_1(object sender, EventArgs e)
        {
            Staff registering = new Staff();
            registering.Show();
        }
    }
}
