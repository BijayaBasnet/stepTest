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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

       private int Getcustomerid()
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            connection.ConnectionString = @"Data Source=BRTHDYBYROJY\SQLEXPRESS;" + "Initial Catalog=steptest; Integrated Security=YES";
            command.Connection = connection;

            command.CommandText = "SELECT IDENT_CURRENT('Customer') + IDENT_INCR('Customer')";
            try
            {
                connection.Open();
                int nextID = Convert.ToInt32(command.ExecuteScalar());
                MessageBox.Show("Your Customer Id is " + (nextID - 1));

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally { connection.Close(); }
            return 0;
       }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (FirstName.Text != "" & Lastname.Text != "" & Age.Text != "" & Sex.Text != "")
            {

                //SqlConnection connection = new SqlConnection();
                //SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection();
                SqlCommand command = new SqlCommand();
                connection.ConnectionString = @"Data Source=BRTHDYBYROJY\SQLEXPRESS;" + "Initial Catalog=steptest; Integrated Security=YES";
                command.Connection = connection;

                command.CommandText = "INSERT INTO Customer " + "(Cus_name,Cus_lastname,Cus_age,Cus_gender)VALUES" + "(@Staffname,@stafflastname,@cusage,@cussex)";
                command.Parameters.AddWithValue("@Staffname", FirstName.Text);
                command.Parameters.AddWithValue("@stafflastname", Lastname.Text);
                command.Parameters.AddWithValue("@Cusage", Age.Text);
                command.Parameters.AddWithValue("@Cussex", Sex.Text);



                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    if
                    (result > 0)
                    {
                        MessageBox.Show("Registration Successful ! Congratulations");
                        Getcustomerid();
                    }

                    else
                        MessageBox.Show("OOPS! Something Went Wrong. Try Again");
                }
                catch
                    (SqlException )
                {
                    MessageBox.Show("OOps! An error occured");
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter all the details.");
            }
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {

        }
        }
        }
    
