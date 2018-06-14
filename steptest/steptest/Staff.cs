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

namespace steptest
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        private int GetstaffID()
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            connection.ConnectionString = @"Data Source=BRTHDYBYROJY\SQLEXPRESS;" + "Initial Catalog=steptest; Integrated Security=YES";
            command.Connection = connection;

            command.CommandText = "SELECT IDENT_CURRENT('Staff') + IDENT_INCR('Staff')";
            try
            {
                connection.Open();
                int nextID = Convert.ToInt32(command.ExecuteScalar());
                MessageBox.Show("Your Staff Id is " + (nextID - 1));
               
            }
            catch (SqlException ex)

            {
                MessageBox.Show(ex.Message); 
            }

            finally { connection.Close(); }
            return 0;
        }

       
        private void CusRegisterBut_Click(object sender, EventArgs e)
        {
            if (StaffFirstName.Text != "" & StaffLastName.Text!="")
            {
                SqlConnection connection = new SqlConnection();
                SqlCommand command = new SqlCommand();
                connection.ConnectionString = @"Data Source=BRTHDYBYROJY\SQLEXPRESS;" + "Initial Catalog=steptest; Integrated Security=YES";
                command.Connection = connection;

                command.CommandText = "INSERT INTO Staff " + "(Staff_name,staff_lastname)VALUES" + "(@Staffname,@stafflastname)";
                command.Parameters.AddWithValue("@Staffname", StaffFirstName.Text);
                command.Parameters.AddWithValue("@stafflastname", StaffLastName.Text);

               

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if
                    (result > 0)
                    {
                        MessageBox.Show("Registration Successful ! Congratulations");
                       
                        
                    }
                    else
                        MessageBox.Show("OOPS! Something Went Wrong. Try Again");
                }
                catch
                    (SqlException)
                {
                    MessageBox.Show("An error has occured!");
                }
                finally
                {
                    GetstaffID();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter all the boxes !");
            }
            
        }
        
        private void StaffRegister_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            Stafflogin register = new Stafflogin();
            register.Show();
          
        }

       
        }
    
    
        }

