using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace steptest
{
    public partial class Customercontrolform : Form
    {
        public Customercontrolform()
        {
            InitializeComponent();
        }
        //------------------Updating customer details----------------------------------------------------------------------------------------
        private void UpdateCus_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            connection.ConnectionString = @"Data Source=BRTHDYBYROJY\SQLEXPRESS;" + "Initial Catalog=steptest; Integrated Security=YES";
            command.Connection = connection;
            command.Connection = connection; command.CommandText = "UPDATE Customer SET Cus_name=@Cusname, " + "Cus_lastname=@LastName, Cus_age=@Cusage, Cus_gender=@Cusgender " + "WHERE Cus_id=@CusID";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Cusname", Cusname.Text);
            command.Parameters.AddWithValue("@LastName", Cuslast.Text);
            command.Parameters.AddWithValue("@Cusage", CusAge.Text);
            command.Parameters.AddWithValue("@Cusgender", Cussex.Text);
            command.Parameters.AddWithValue("@CusID", Cusid.Text);
            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0) MessageBox.Show("Customer detail has been updated..!!");
                else MessageBox.Show("Update Failed! Customer Id entered incorrect..!");
            }
            catch (SqlException)
            {
                MessageBox.Show("An error occured.");
            }
            finally
            {
                connection.Close();
            }
        }
        //--------------deleting customer-------------------------------------------------------------------------------------
        private void DeleteCus_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            connection.ConnectionString = @"Data Source=BRTHDYBYROJY\SQLEXPRESS;" + "Initial Catalog=steptest; Integrated Security=YES";
            command.Connection = connection; command.CommandText = "DELETE FROM Customer WHERE Cus_id=@CusID";
            command.Parameters.AddWithValue("@CusID", Cusid.Text);
            try
            {
                connection.Open(); int result = command.ExecuteNonQuery();
                if (result > 0)
                { MessageBox.Show("Congratulations! Customer has been deleted.");
                Customerlogin backagain = new Customerlogin();
                backagain.Show();
                                  
                }
                else MessageBox.Show("Unable to delete the customer,Can't find Customer.please check the staff id.");
            }
            catch
                (SqlException)
            {
                MessageBox.Show("An error has occured.");
            }
            finally
            {
                connection.Close();

            }
        }
        //--------------------------------go to test--------------------------------------------------------
        private void PerformTest_Click(object sender, EventArgs e)
        {
            if (Cusid.Text == "" || Cusname.Text == "" || Cuslast.Text == "" || CusAge.Text == "" || Cussex.Text == "")
            {
                MessageBox.Show("Some of the information aren't completed..! ");
            }
            else
            {
                Class1.id = Cusid.Text;
                Class1.name = Cusname.Text;
                Class1.lastname = Cuslast.Text;
                Class1.age = CusAge.Text;
                Class1.sex = Cussex.Text;
                TestForm testing = new TestForm();
                testing.Show();
            }
        }
        //-----------------get customer details from earlier form----------------------------
        private void Customercontrolform_Load(object sender, EventArgs e)
        {
            Cusid.Text = Class1.custid;
        }

        private SqlDataReader reader;
        private void Cusid_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            connection.ConnectionString = @"Data Source=BRTHDYBYROJY\SQLEXPRESS;" + "Initial Catalog=steptest; Integrated Security=YES";
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Customer WHERE Cus_id=@CustID";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@CustID", Cusid.Text);
            try
            {
                connection.Open();

                reader = command.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    Cusname.Text = reader["Cus_name"].ToString();
                    Cuslast.Text=reader["Cus_lastname"].ToString();
                        CusAge.Text=reader["cus_age"].ToString();
                        Cussex.Text = reader["Cus_gender"].ToString();

                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally { connection.Close(); }
        }
    }
}