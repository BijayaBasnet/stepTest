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
    public partial class Customerlogin : Form
    {
        public Customerlogin()
        {
            InitializeComponent();
        }
 

       

        private void CusRegister_Click(object sender, EventArgs e)
        {
             Customer Cusregister = new Customer();
             Cusregister.Show();
        }

        

        private void SecondUI_Load(object sender, EventArgs e)
        {
            staffnaming.Text = Class1.sname;
        }

        private SqlDataReader reader;
        private void CusSubmit_Click_1(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            connection.ConnectionString = @"Data Source=BRTHDYBYROJY\SQLEXPRESS;" + "Initial Catalog=steptest; Integrated Security=YES";
            command.Connection = connection;
            command.CommandText = "SELECT * FROM Customer WHERE Cus_id=@CustID";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@CustID", Custid.Text);
            try
            {
                connection.Open();

                reader = command.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    textBox1.Text = reader["Cus_name"].ToString();
                    
                    Class1.custid = Custid.Text;
                    Customercontrolform cuscontrol = new Customercontrolform();
                    cuscontrol.Show();
                    

                }
                else MessageBox.Show("Please enter Valid Customer ID");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally { connection.Close(); }
        }

        

       

        
    }
}
