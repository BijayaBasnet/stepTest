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


namespace steptest
{
    public partial class FinalResult : Form
    {
        public FinalResult()
        {
            InitializeComponent();
        }
        private int GetresultID()
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            connection.ConnectionString = @"Data Source=BRTHDYBYROJY\SQLEXPRESS;" + "Initial Catalog=steptest; Integrated Security=YES";
            command.Connection = connection;

            command.CommandText = "SELECT IDENT_CURRENT('Test_result') + IDENT_INCR('Test_result')";
            try
            {
                connection.Open();
                int nextID = Convert.ToInt32(command.ExecuteScalar());
                Resultid.Text = Convert.ToString(nextID - 1);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally { connection.Close(); }
            return 0;
        }

        private void FinalResult_Load(object sender, EventArgs e)
        {
            GetresultID();
            testid.Text = Class1.testingid;
            Aerocapacity.Text = Class1.aerobic;
            Testdate.Text = Class1.dates;
            Testcusname.Text = Class1.name  +" "+  Class1.lastname;
            TestCusage.Text = Class1.age;
            Age.Text = Class1.age;
            Sex.Text = Class1.sex;
            int age = Convert.ToInt32(Age.Text);
            if (Sex.Text == "M")
            {
                if (age == 15 | age == 16 | age == 17 | age == 18 | age == 19)
                {
                    if (Convert.ToInt32(Aerocapacity.Text) > 59)
                    {
                        FitnessRating.Text = "Excellent";
                    }

                    if (Convert.ToInt32(Aerocapacity.Text) > 47 & Convert.ToInt32(Aerocapacity.Text) < 60)
                    {
                        FitnessRating.Text = "Good";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 38 & Convert.ToInt32(Aerocapacity.Text) < 48)
                    {
                        FitnessRating.Text = "Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 29 & Convert.ToInt32(Aerocapacity.Text) < 39)
                    {
                        FitnessRating.Text = "Below Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) < 30)
                    {
                        FitnessRating.Text = "poor";
                    }

                }
                if (age == 20 | age == 21 | age == 22 | age == 23 | age == 24 | age == 25 | age == 26 | age == 27 | age == 28 | age == 29)
                {
                    if (Convert.ToInt32(Aerocapacity.Text) > 54)
                    {
                        FitnessRating.Text = "Excellent";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 43 & Convert.ToInt32(Aerocapacity.Text) < 55)
                    {
                        FitnessRating.Text = "Good";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 34 & Convert.ToInt32(Aerocapacity.Text) < 44)
                    {
                        FitnessRating.Text = "Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 27 & Convert.ToInt32(Aerocapacity.Text) < 37)
                    {
                        FitnessRating.Text = "Below Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) < 28)
                    {
                        FitnessRating.Text = "poor";
                    }




                }
                if (age == 30 | age == 31 | age == 32 | age == 33 | age == 34 | age == 35 | age == 36 | age == 37 | age == 38 | age == 39)
                {
                    if (Convert.ToInt32(Aerocapacity.Text) > 49)
                    {
                        FitnessRating.Text = "Excellent";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 39 & Convert.ToInt32(Aerocapacity.Text) < 50)
                    {
                        FitnessRating.Text = "Good";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 33 & Convert.ToInt32(Aerocapacity.Text) < 40)
                    {
                        FitnessRating.Text = "Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 25 & Convert.ToInt32(Aerocapacity.Text) < 34)
                    {
                        FitnessRating.Text = "Below Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) < 26)
                    {
                        FitnessRating.Text = "poor";
                    }

                }
                if (age == 40 | age == 41 | age == 42 | age == 43 | age == 44 | age == 45 | age == 46 | age == 47 | age == 48 | age == 49)
                {
                    if (Convert.ToInt32(Aerocapacity.Text) > 45)
                    {
                        FitnessRating.Text = "Excellent";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 36 & Convert.ToInt32(Aerocapacity.Text) < 46)
                    {
                        FitnessRating.Text = "Good";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 31 & Convert.ToInt32(Aerocapacity.Text) < 37)
                    {
                        FitnessRating.Text = "Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 24 & Convert.ToInt32(Aerocapacity.Text) < 32)
                    {
                        FitnessRating.Text = "Below Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) < 25)
                    {
                        FitnessRating.Text = "poor";
                    }

                }
                if (age == 50 | age == 51 | age == 52 | age == 53 | age == 54 | age == 55 | age == 56 | age == 57 | age == 58 | age == 59)
                {
                    if (Convert.ToInt32(Aerocapacity.Text) > 43)
                    {
                        FitnessRating.Text = "Excellent";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 34 & Convert.ToInt32(Aerocapacity.Text) < 44)
                    {
                        FitnessRating.Text = "Good";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 28 & Convert.ToInt32(Aerocapacity.Text) < 35)
                    {
                        FitnessRating.Text = "Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 22 & Convert.ToInt32(Aerocapacity.Text) < 29)
                    {
                        FitnessRating.Text = "Below Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) < 23)
                    {
                        FitnessRating.Text = "poor";
                    }

                }
                if (age == 60 | age == 61 | age == 62 | age == 63 | age == 64 | age == 65)
                {
                    if (Convert.ToInt32(Aerocapacity.Text) > 39)
                    {
                        FitnessRating.Text = "Excellent";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 32 & Convert.ToInt32(Aerocapacity.Text) < 40)
                    {
                        FitnessRating.Text = "Good";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 24 & Convert.ToInt32(Aerocapacity.Text) < 33)
                    {
                        FitnessRating.Text = "Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 19 & Convert.ToInt32(Aerocapacity.Text) < 25)
                    {
                        FitnessRating.Text = "Below Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) < 20)
                    {
                        FitnessRating.Text = "poor";
                    }

                }

            }

            if (Sex.Text == "F")
            {
                if (age == 15 | age == 16 | age == 17 | age == 18 | age == 19)
                {
                    if (Convert.ToInt32(Aerocapacity.Text) > 54)
                    {
                        FitnessRating.Text = "Excellent";
                    }

                    if (Convert.ToInt32(Aerocapacity.Text) > 43 & Convert.ToInt32(Aerocapacity.Text) < 55)
                    {
                        FitnessRating.Text = "Good";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 35 & Convert.ToInt32(Aerocapacity.Text) < 44)
                    {
                        FitnessRating.Text = "Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 28 & Convert.ToInt32(Aerocapacity.Text) < 35)
                    {
                        FitnessRating.Text = "Below Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) < 29)
                    {
                        FitnessRating.Text = "poor";
                    }

                }
                if (age == 20 | age == 21 | age == 22 | age == 23 | age == 24 | age == 25 | age == 26 | age == 27 | age == 28 | age == 29)
                {
                    if (Convert.ToInt32(Aerocapacity.Text) > 49)
                    {
                        FitnessRating.Text = "Excellent";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 39 & Convert.ToInt32(Aerocapacity.Text) < 50)
                    {
                        FitnessRating.Text = "Good";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 31 & Convert.ToInt32(Aerocapacity.Text) < 40)
                    {
                        FitnessRating.Text = "Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 26 & Convert.ToInt32(Aerocapacity.Text) < 31)
                    {
                        FitnessRating.Text = "Below Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) < 27)
                    {
                        FitnessRating.Text = "poor";
                    }

                }
                if (age == 30 | age == 31 | age == 32 | age == 33 | age == 34 | age == 35 | age == 36 | age == 37 | age == 38 | age == 39)
                {
                    if (Convert.ToInt32(Aerocapacity.Text) > 45)
                    {
                        FitnessRating.Text = "Excellent";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 35 & Convert.ToInt32(Aerocapacity.Text) < 46)
                    {
                        FitnessRating.Text = "Good";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 29 & Convert.ToInt32(Aerocapacity.Text) < 36)
                    {
                        FitnessRating.Text = "Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 24 & Convert.ToInt32(Aerocapacity.Text) < 30)
                    {
                        FitnessRating.Text = "Below Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) < 25)
                    {
                        FitnessRating.Text = "poor";
                    }


                }

                if (age == 40 | age == 41 | age == 42 | age == 43 | age == 44 | age == 45 | age == 46 | age == 47 | age == 48 | age == 49)
                {
                    if (Convert.ToInt32(Aerocapacity.Text) > 42)
                    {
                        FitnessRating.Text = "Excellent";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 33 & Convert.ToInt32(Aerocapacity.Text) < 43)
                    {
                        FitnessRating.Text = "Good";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 29 & Convert.ToInt32(Aerocapacity.Text) < 34)
                    {
                        FitnessRating.Text = "Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 21 & Convert.ToInt32(Aerocapacity.Text) < 27)
                    {
                        FitnessRating.Text = "Below Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) < 22)
                    {
                        FitnessRating.Text = "poor";
                    }

                }
                if (age == 50 | age == 51 | age == 52 | age == 53 | age == 54 | age == 55 | age == 56 | age == 57 | age == 58 | age == 59)
                {
                    if (Convert.ToInt32(Aerocapacity.Text) > 40)
                    {
                        FitnessRating.Text = "Excellent";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 32 & Convert.ToInt32(Aerocapacity.Text) < 41)
                    {
                        FitnessRating.Text = "Good";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 25 & Convert.ToInt32(Aerocapacity.Text) < 33)
                    {
                        FitnessRating.Text = "Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 20 & Convert.ToInt32(Aerocapacity.Text) < 26)
                    {
                        FitnessRating.Text = "Below Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) < 21)
                    {
                        FitnessRating.Text = "poor";
                    }

                }
                if (age == 60 | age == 61 | age == 62 | age == 63 | age == 64 | age == 65)
                {
                    if (Convert.ToInt32(Aerocapacity.Text) > 38)
                    {
                        FitnessRating.Text = "Excellent";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 30 & Convert.ToInt32(Aerocapacity.Text) < 39)
                    {
                        FitnessRating.Text = "Good";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 23 & Convert.ToInt32(Aerocapacity.Text) < 31)
                    {
                        FitnessRating.Text = "Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) > 18 & Convert.ToInt32(Aerocapacity.Text) < 23)
                    {
                        FitnessRating.Text = "Below Average";
                    }
                    if (Convert.ToInt32(Aerocapacity.Text) < 19)
                    {
                        FitnessRating.Text = "poor";
                    }

                }

            }
            if (FitnessRating.Text=="Excellent")
            {
                Remarks.Text = "Excellent state. keep going.!";
            }
            else if (FitnessRating.Text == "Good")
            {
                Remarks.Text = "You are at good state but still can improve.!";
            }
            if (FitnessRating.Text == "Average")
            {
                Remarks.Text = "Average rating, work hard to get to good and excellent level";
            }
            if (FitnessRating.Text == "Below Average")
            {
                Remarks.Text = "You really need to start woking on our fitness, you are below average";
            }
            if (FitnessRating.Text == "poor")
            {
                Remarks.Text = "you need to be worried about your fitness level, Very poor.";
            }
        }
       
        private void Savefinalresults_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            connection.ConnectionString = @"Data Source=BRTHDYBYROJY\SQLEXPRESS;" + "Initial Catalog=steptest; Integrated Security=YES";
            command.Connection = connection;

            command.CommandText = "INSERT INTO Test_result" + "(Result_id, Result_date,Aerobic_capacity,Fitness_Rating,Remarks,Test_id)VALUES" + "(@resultid,@resultdate,@aerobiccapacity,@fitnessrating,@remarks,@testid)";
            command.Parameters.AddWithValue("@resultid", Resultid.Text);
            command.Parameters.AddWithValue("@resultdate", Testdate.Text);
            command.Parameters.AddWithValue("@aerobiccapacity", Aerocapacity.Text);
            command.Parameters.AddWithValue("@fitnessrating",FitnessRating.Text );
            command.Parameters.AddWithValue("@remarks", Remarks.Text);
            command.Parameters.AddWithValue("@testid ", testid.Text);




            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();
                if
                (result > 0)
                {
                    MessageBox.Show("Test Result Saved!");


                }
                else
                    MessageBox.Show("OOPS! Something Went Wrong. Try Again");
            }
            catch
                (SqlException )
            {
                MessageBox.Show("An error has occured!");
            }
            finally
            {
               
                connection.Close();
            }
            this.Close();
        }
       
    }
}

