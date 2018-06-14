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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
        //------------- getting test id for the current test----
        private int GettestID()
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            connection.ConnectionString = @"Data Source=BRTHDYBYROJY\SQLEXPRESS;" + "Initial Catalog=steptest; Integrated Security=YES";
            command.Connection = connection;

            command.CommandText = "SELECT IDENT_CURRENT('Test') + IDENT_INCR('Test')";
            try
            {
                connection.Open();
                int nextID = Convert.ToInt32(command.ExecuteScalar());
                TestId.Text = Convert.ToString(nextID - 1);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally { connection.Close(); }
            return 0;
        }

        private void Heightlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("Sorry You are not fit for this Test. Better try next time");
            }
            if (checkBox2.Checked == false)
            {
                MessageBox.Show("Sorry You are not fit for this Test. Better try next time");
            }
            if (checkBox3.Checked == false)
            {
                MessageBox.Show("Sorry You are not fit for this Test. Better try next time");
            }

            if (Testage.Text == "")
            {
                MessageBox.Show("Please Enter the Age!");
            }
            if (Testsex.Text == "")
            {
                MessageBox.Show("Please Select Your Sex!");
            }
            if (Heightlist.Text=="")
            {
                MessageBox.Show("please select the step height!");
            }

            if (Convert.ToInt32(Heightlist.Text) == 15)
            {
                Firstlevel.Text = Convert.ToString(11);
                Secondlevel.Text = Convert.ToString(14);
                Thirdlevel.Text = Convert.ToString(18);
                Fourthlevel.Text = Convert.ToString(21);
                Fifthlevel.Text = Convert.ToString(25);

            }


            if (Convert.ToInt32(Heightlist.Text) == 20)
            {
                Firstlevel.Text = Convert.ToString(12);
                Secondlevel.Text = Convert.ToString(17);
                Thirdlevel.Text = Convert.ToString(21);
                Fourthlevel.Text = Convert.ToString(25);
                Fifthlevel.Text = Convert.ToString(29);
            }


            if (Convert.ToInt32(Heightlist.Text) == 25)
            {
                Firstlevel.Text = Convert.ToString(14);
                Secondlevel.Text = Convert.ToString(19);
                Thirdlevel.Text = Convert.ToString(24);
                Fourthlevel.Text = Convert.ToString(28);
                Fifthlevel.Text = Convert.ToString(33);
            }

            if (Convert.ToInt32(Heightlist.Text) == 30)
            {
                Firstlevel.Text = Convert.ToString(16);
                Secondlevel.Text = Convert.ToString(21);
                Thirdlevel.Text = Convert.ToString(27);
                Fourthlevel.Text = Convert.ToString(32);
                Fifthlevel.Text = Convert.ToString(37);
            }

        }

        //private void Age_SelectedIndexChanged(object sender, EventArgs e)
        //{           
        //}
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (FirstRead.Text == "" || SecondRead.Text == "" || ThirdRead.Text == "" )
            {
                MessageBox.Show("At least three heart reading is required to conduct the test!");
                this.Close();
            }
            //---------------------------------saving the test--------------------------------------------------------------------------------------
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            connection.ConnectionString = @"Data Source=BRTHDYBYROJY\SQLEXPRESS;" + "Initial Catalog=steptest; Integrated Security=YES";
            command.Connection = connection;
            command.CommandText = "INSERT INTO Test " + "(Test_date,Step_height,Step_firstlevel,Heart_firstrate,Step_secondlevel,Heart_secondrate,Step_thirdlevel,Heart_thirdrate,Step_fourthlevel,Heart_fourthrate,Step_fifthlevel,Heart_fifthrate,Cus_id) VALUES "
                + "(@Testdate, @Stepheight, @Stepfirst, @heartfirst, @Stepsecond, @heartsecond,@Stepthird, @heartthird,@Stepfourth, @heartfourth,@Stepfifth, @heartfifth,@cusid)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Testdate", testdate.Text);
            command.Parameters.AddWithValue("@Stepheight", Heightlist.Text);

            command.Parameters.AddWithValue("@Stepfirst", Firstlevel.Text);
            command.Parameters.AddWithValue("@heartfirst", FirstRead.Text);

            command.Parameters.AddWithValue("@Stepsecond", Secondlevel.Text);
            command.Parameters.AddWithValue("@heartsecond", SecondRead.Text);

            command.Parameters.AddWithValue("@Stepthird", Thirdlevel.Text);
            command.Parameters.AddWithValue("@heartthird", ThirdRead.Text);

            command.Parameters.AddWithValue("@Stepfourth", Fourthlevel.Text);
            command.Parameters.AddWithValue("@heartfourth", FourthRead.Text);

            command.Parameters.AddWithValue("@Stepfifth", Fifthlevel.Text);
            command.Parameters.AddWithValue("@heartfifth", FifthRead.Text);

            command.Parameters.AddWithValue("@Cusid", TestCusId.Text);



            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result > 0) MessageBox.Show("Test Records have been saved.");

                else MessageBox.Show("Failed to save the test records.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            

            //------------------------------------------------------------------------------------------------------------------------------ 
          
            
            getresults.Visible = true;








            if (Convert.ToDouble(Heightlist.Text) == 15)
            {
                if (FourthRead.Text == "" || FifthRead.Text == "")
                {
                    double[] xcords = new double[] { 11, 14, 18 };
                    double[] ycords = new double[] { Convert.ToDouble(this.FirstRead.Text), Convert.ToDouble(this.SecondRead.Text), Convert.ToDouble(this.ThirdRead.Text) };

                    for (int i = 0; i < xcords.Length; i++)
                    {
                        this.chart1.Series["Series2"].Points.AddXY(xcords[i], ycords[i]);

                    }
                    double xsum = xcords.Sum();
                    double ysum = ycords.Sum();

                    //square of xcords
                    double squarex = 0;
                    for (int k = 0; k < xcords.Length; k++)
                    {
                        squarex = squarex + (xcords[k] * xcords[k]);
                    }

                    // sum ofxy
                    double sumxy = 0;
                    for (int l = 0; l < ycords.Length; l++)
                    {
                        sumxy = sumxy + (xcords[l] * ycords[l]);

                    }

                    //slope calculation
                    double slope = (sumxy - (xsum * ysum) / xcords.Length) / (squarex - (xsum * xsum) / xcords.Length);


                    double ytop = ysum / ycords.Length;
                    double xtop = xsum / xcords.Length;

                    //y-intercept calculation
                    double yintercept = ytop - slope * xtop;
                    for (int i = 0; i < xcords.Length; i++)
                    {
                        // Coordinates for line of best fit: x = (y-b)/m

                        double highline = (Convert.ToDouble(Maxhr.Text) - yintercept) / slope;//max
                        double lowline = (Convert.ToDouble(Maxhr.Text) / 2 - yintercept) / slope;//50%


                        // Plotting Line of so called Best Fit
                        this.chart1.Series["Line"].Points.AddXY(xcords[i], (slope * xcords[i] + yintercept));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(lowline), Convert.ToInt32(Maxhr.Text) / 2);

                        // Plotting Base line
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), 0);
                        int aero = Convert.ToInt32(highline);
                        Aerobic.Text = Convert.ToString(aero);

                    }
                }
                else if ((FirstRead.Text!="") || (SecondRead.Text!="")|| (ThirdRead.Text!="")||(FourthRead.Text!="")||(FifthRead.Text!=""))
                {
                    double a, b, c, d, f;
                    a = Convert.ToDouble(this.FirstRead.Text);
                    b = Convert.ToDouble(this.SecondRead.Text);
                    c = Convert.ToDouble(this.ThirdRead.Text);
                    d = Convert.ToDouble(this.FourthRead.Text);
                    f = Convert.ToDouble(this.FifthRead.Text);
                    double[] xcords = new double[] { 11, 14, 18, 21, 25 };
                    double[] ycords = new double[] { a, b, c, d, f };

                    for (int i = 0; i < 5; i++)
                    {
                        this.chart1.Series["Series2"].Points.AddXY(xcords[i], ycords[i]);

                    }
                    double xsum = xcords.Sum();
                    double ysum = ycords.Sum();

                    //square of xcords
                    double squarex = 0;
                    for (int k = 0; k < 5; k++)
                    {
                        squarex = squarex + (xcords[k] * xcords[k]);
                    }

                    // sum ofxy
                    double sumxy = 0;
                    for (int l = 0; l < 5; l++)
                    {
                        sumxy = sumxy + (xcords[l] * ycords[l]);

                    }

                    //slope calculation
                    double slope = (sumxy - (xsum * ysum) / xcords.Length) / (squarex - (xsum * xsum) / xcords.Length);


                    double ytop = ysum / ycords.Length;
                    double xtop = xsum / xcords.Length;

                    //y-intercept calculation
                    double yintercept = ytop - slope * xtop;
                    for (int i = 0; i < 5; i++)
                    {
                        // Coordinates for line of best fit: x = (y-b)/m

                        double highline = (Convert.ToDouble(Maxhr.Text) - yintercept) / slope;//max
                        double lowline = (Convert.ToDouble(Maxhr.Text) / 2 - yintercept) / slope;//50%


                        // Plotting Line of so called Best Fit
                        this.chart1.Series["Line"].Points.AddXY(xcords[i], (slope * xcords[i] + yintercept));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(lowline), Convert.ToInt32(Maxhr.Text) / 2);

                        // Plotting Base line
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), 0);
                        int aero = Convert.ToInt32(highline);
                        Aerobic.Text = Convert.ToString(aero);


                    }
                }
            }
        
                
            //--------------------------------------------------------------------------------------------------------------------------------------

            if (Convert.ToInt32(Heightlist.Text) == 20)
            {
                if (FourthRead.Text == "" || FifthRead.Text == "")
                {
                    double[] xcords = new double[] { 12, 17, 21 };
                    double[] ycords = new double[] { Convert.ToDouble(this.FirstRead.Text), Convert.ToDouble(this.SecondRead.Text), Convert.ToDouble(this.ThirdRead.Text) };

                    for (int i = 0; i < xcords.Length; i++)
                    {
                        this.chart1.Series["Series2"].Points.AddXY(xcords[i], ycords[i]);

                    }
                    double xsum = xcords.Sum();
                    double ysum = ycords.Sum();

                    //square of xcords
                    double squarex = 0;
                    for (int k = 0; k < xcords.Length; k++)
                    {
                        squarex = squarex + (xcords[k] * xcords[k]);
                    }

                    // sum ofxy
                    double sumxy = 0;
                    for (int l = 0; l < ycords.Length; l++)
                    {
                        sumxy = sumxy + (xcords[l] * ycords[l]);

                    }

                    //slope calculation
                    double slope = (sumxy - (xsum * ysum) / xcords.Length) / (squarex - (xsum * xsum) / xcords.Length);


                    double ytop = ysum / ycords.Length;
                    double xtop = xsum / xcords.Length;

                    //y-intercept calculation
                    double yintercept = ytop - slope * xtop;
                    for (int i = 0; i < xcords.Length; i++)
                    {
                        // Coordinates for line of best fit: x = (y-b)/m

                        double highline = (Convert.ToDouble(Maxhr.Text) - yintercept) / slope;//max
                        double lowline = (Convert.ToDouble(Maxhr.Text) / 2 - yintercept) / slope;//50%


                        // Plotting Line of so called Best Fit
                        this.chart1.Series["Line"].Points.AddXY(xcords[i], (slope * xcords[i] + yintercept));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(lowline), Convert.ToInt32(Maxhr.Text) / 2);

                        // Plotting Base line
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), 0);
                        int aero = Convert.ToInt32(highline);
                        Aerobic.Text = Convert.ToString(aero);

                    }
                }
                else if ((FirstRead.Text != "") || (SecondRead.Text != "") || (ThirdRead.Text != "") || (FourthRead.Text != "") || (FifthRead.Text != ""))
                {
                    double a, b, c, d, f;
                    a = Convert.ToDouble(this.FirstRead.Text);
                    b = Convert.ToDouble(this.SecondRead.Text);
                    c = Convert.ToDouble(this.ThirdRead.Text);
                    d = Convert.ToDouble(this.FourthRead.Text);
                    f = Convert.ToDouble(this.FifthRead.Text);
                    double[] xcords = new double[] { 12,17,21,25,29 };
                    double[] ycords = new double[] { a, b, c, d, f };

                    for (int i = 0; i < 5; i++)
                    {
                        this.chart1.Series["Series2"].Points.AddXY(xcords[i], ycords[i]);

                    }
                    double xsum = xcords.Sum();
                    double ysum = ycords.Sum();

                    //square of xcords
                    double squarex = 0;
                    for (int k = 0; k < 5; k++)
                    {
                        squarex = squarex + (xcords[k] * xcords[k]);
                    }

                    // sum ofxy
                    double sumxy = 0;
                    for (int l = 0; l < 5; l++)
                    {
                        sumxy = sumxy + (xcords[l] * ycords[l]);

                    }

                    //slope calculation
                    double slope = (sumxy - (xsum * ysum) / xcords.Length) / (squarex - (xsum * xsum) / xcords.Length);


                    double ytop = ysum / ycords.Length;
                    double xtop = xsum / xcords.Length;

                    //y-intercept calculation
                    double yintercept = ytop - slope * xtop;
                    for (int i = 0; i < 5; i++)
                    {
                        // Coordinates for line of best fit: x = (y-b)/m

                        double highline = (Convert.ToDouble(Maxhr.Text) - yintercept) / slope;//max
                        double lowline = (Convert.ToDouble(Maxhr.Text) / 2 - yintercept) / slope;//50%


                        // Plotting Line of so called Best Fit
                        this.chart1.Series["Line"].Points.AddXY(xcords[i], (slope * xcords[i] + yintercept));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(lowline), Convert.ToInt32(Maxhr.Text) / 2);

                        // Plotting Base line
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), 0);
                        int aero = Convert.ToInt32(highline);
                        Aerobic.Text = Convert.ToString(aero);


                    }
                }
            }

            //----------------------------------------------------------------------------------------------------------------------------------------


            if (Convert.ToInt32(Heightlist.Text) == 25)
            {


                if (FourthRead.Text == "" || FifthRead.Text == "")
                {
                    double[] xcords = new double[] { 14,19,24};
                    double[] ycords = new double[] { Convert.ToDouble(this.FirstRead.Text), Convert.ToDouble(this.SecondRead.Text), Convert.ToDouble(this.ThirdRead.Text) };

                    for (int i = 0; i < xcords.Length; i++)
                    {
                        this.chart1.Series["Series2"].Points.AddXY(xcords[i], ycords[i]);

                    }
                    double xsum = xcords.Sum();
                    double ysum = ycords.Sum();

                    //square of xcords
                    double squarex = 0;
                    for (int k = 0; k < xcords.Length; k++)
                    {
                        squarex = squarex + (xcords[k] * xcords[k]);
                    }

                    // sum ofxy
                    double sumxy = 0;
                    for (int l = 0; l < ycords.Length; l++)
                    {
                        sumxy = sumxy + (xcords[l] * ycords[l]);

                    }

                    //slope calculation
                    double slope = (sumxy - (xsum * ysum) / xcords.Length) / (squarex - (xsum * xsum) / xcords.Length);


                    double ytop = ysum / ycords.Length;
                    double xtop = xsum / xcords.Length;

                    //y-intercept calculation
                    double yintercept = ytop - slope * xtop;
                    for (int i = 0; i < xcords.Length; i++)
                    {
                        // Coordinates for line of best fit: x = (y-b)/m

                        double highline = (Convert.ToDouble(Maxhr.Text) - yintercept) / slope;//max
                        double lowline = (Convert.ToDouble(Maxhr.Text) / 2 - yintercept) / slope;//50%


                        // Plotting Line of so called Best Fit
                        this.chart1.Series["Line"].Points.AddXY(xcords[i], (slope * xcords[i] + yintercept));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(lowline), Convert.ToInt32(Maxhr.Text) / 2);

                        // Plotting Base line
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), 0);
                        int aero = Convert.ToInt32(highline);
                        Aerobic.Text = Convert.ToString(aero);

                    }
                }
                else if ((FirstRead.Text != "") || (SecondRead.Text != "") || (ThirdRead.Text != "") || (FourthRead.Text != "") || (FifthRead.Text != ""))
                {
                    double a, b, c, d, f;
                    a = Convert.ToDouble(this.FirstRead.Text);
                    b = Convert.ToDouble(this.SecondRead.Text);
                    c = Convert.ToDouble(this.ThirdRead.Text);
                    d = Convert.ToDouble(this.FourthRead.Text);
                    f = Convert.ToDouble(this.FifthRead.Text);
                    double[] xcords = new double[] { 14, 19, 24, 28, 33 };
                    double[] ycords = new double[] { a, b, c, d, f };

                    for (int i = 0; i < 5; i++)
                    {
                        this.chart1.Series["Series2"].Points.AddXY(xcords[i], ycords[i]);

                    }
                    double xsum = xcords.Sum();
                    double ysum = ycords.Sum();

                    //square of xcords
                    double squarex = 0;
                    for (int k = 0; k < 5; k++)
                    {
                        squarex = squarex + (xcords[k] * xcords[k]);
                    }

                    // sum ofxy
                    double sumxy = 0;
                    for (int l = 0; l < 5; l++)
                    {
                        sumxy = sumxy + (xcords[l] * ycords[l]);

                    }

                    //slope calculation
                    double slope = (sumxy - (xsum * ysum) / xcords.Length) / (squarex - (xsum * xsum) / xcords.Length);


                    double ytop = ysum / ycords.Length;
                    double xtop = xsum / xcords.Length;

                    //y-intercept calculation
                    double yintercept = ytop - slope * xtop;
                    for (int i = 0; i < 5; i++)
                    {
                        // Coordinates for line of best fit: x = (y-b)/m

                        double highline = (Convert.ToDouble(Maxhr.Text) - yintercept) / slope;//max
                        double lowline = (Convert.ToDouble(Maxhr.Text) / 2 - yintercept) / slope;//50%


                        // Plotting Line of so called Best Fit
                        this.chart1.Series["Line"].Points.AddXY(xcords[i], (slope * xcords[i] + yintercept));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(lowline), Convert.ToInt32(Maxhr.Text) / 2);

                        // Plotting Base line
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), 0);
                        int aero = Convert.ToInt32(highline);
                        Aerobic.Text = Convert.ToString(aero);


                    }
                }
            }
            //----------------------------------------------------------------------------
            if (Convert.ToInt32(Heightlist.Text) == 30)
            {
                if (FourthRead.Text == "" || FifthRead.Text == "")
                {
                    double[] xcords = new double[] { 16, 21, 27};
                    double[] ycords = new double[] { Convert.ToDouble(this.FirstRead.Text), Convert.ToDouble(this.SecondRead.Text), Convert.ToDouble(this.ThirdRead.Text) };

                    for (int i = 0; i < xcords.Length; i++)
                    {
                        this.chart1.Series["Series2"].Points.AddXY(xcords[i], ycords[i]);

                    }
                    double xsum = xcords.Sum();
                    double ysum = ycords.Sum();

                    //square of xcords
                    double squarex = 0;
                    for (int k = 0; k < xcords.Length; k++)
                    {
                        squarex = squarex + (xcords[k] * xcords[k]);
                    }

                    // sum ofxy
                    double sumxy = 0;
                    for (int l = 0; l < ycords.Length; l++)
                    {
                        sumxy = sumxy + (xcords[l] * ycords[l]);

                    }

                    //slope calculation
                    double slope = (sumxy - (xsum * ysum) / xcords.Length) / (squarex - (xsum * xsum) / xcords.Length);


                    double ytop = ysum / ycords.Length;
                    double xtop = xsum / xcords.Length;

                    //y-intercept calculation
                    double yintercept = ytop - slope * xtop;
                    for (int i = 0; i < xcords.Length; i++)
                    {
                        // Coordinates for line of best fit: x = (y-b)/m

                        double highline = (Convert.ToDouble(Maxhr.Text) - yintercept) / slope;//max
                        double lowline = (Convert.ToDouble(Maxhr.Text) / 2 - yintercept) / slope;//50%


                        // Plotting Line of so called Best Fit
                        this.chart1.Series["Line"].Points.AddXY(xcords[i], (slope * xcords[i] + yintercept));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(lowline), Convert.ToInt32(Maxhr.Text) / 2);

                        // Plotting Base line
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), 0);
                        int aero = Convert.ToInt32(highline);
                        Aerobic.Text = Convert.ToString(aero);

                    }
                }
                else if ((FirstRead.Text != "") || (SecondRead.Text != "") || (ThirdRead.Text != "") || (FourthRead.Text != "") || (FifthRead.Text != ""))
                {
                    double a, b, c, d, f;
                    a = Convert.ToDouble(this.FirstRead.Text);
                    b = Convert.ToDouble(this.SecondRead.Text);
                    c = Convert.ToDouble(this.ThirdRead.Text);
                    d = Convert.ToDouble(this.FourthRead.Text);
                    f = Convert.ToDouble(this.FifthRead.Text);
                    double[] xcords = new double[] { 16,21,27,32,37 };
                    double[] ycords = new double[] { a, b, c, d, f };

                    for (int i = 0; i < 5; i++)
                    {
                        this.chart1.Series["Series2"].Points.AddXY(xcords[i], ycords[i]);

                    }
                    double xsum = xcords.Sum();
                    double ysum = ycords.Sum();

                    //square of xcords
                    double squarex = 0;
                    for (int k = 0; k < 5; k++)
                    {
                        squarex = squarex + (xcords[k] * xcords[k]);
                    }

                    // sum ofxy
                    double sumxy = 0;
                    for (int l = 0; l < 5; l++)
                    {
                        sumxy = sumxy + (xcords[l] * ycords[l]);

                    }

                    //slope calculation
                    double slope = (sumxy - (xsum * ysum) / xcords.Length) / (squarex - (xsum * xsum) / xcords.Length);


                    double ytop = ysum / ycords.Length;
                    double xtop = xsum / xcords.Length;

                    //y-intercept calculation
                    double yintercept = ytop - slope * xtop;
                    for (int i = 0; i < 5; i++)
                    {
                        // Coordinates for line of best fit: x = (y-b)/m

                        double highline = (Convert.ToDouble(Maxhr.Text) - yintercept) / slope;//max
                        double lowline = (Convert.ToDouble(Maxhr.Text) / 2 - yintercept) / slope;//50%


                        // Plotting Line of so called Best Fit
                        this.chart1.Series["Line"].Points.AddXY(xcords[i], (slope * xcords[i] + yintercept));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Line"].Points.AddXY(Convert.ToInt32(lowline), Convert.ToInt32(Maxhr.Text) / 2);

                        // Plotting Base line
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), Convert.ToInt32(Maxhr.Text));
                        this.chart1.Series["Base"].Points.AddXY(Convert.ToInt32(highline), 0);
                        int aero = Convert.ToInt32(highline);
                        Aerobic.Text = Convert.ToString(aero);


                    }
                }
            }
            //----------------------------------------------------------------------------------------------------------------------------------------
            chart1.Visible = true;


        }


        
        private void FirstRead_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(FirstRead.Text) > Convert.ToInt32(Maxhr.Text))
            {
                MessageBox.Show("You are not fit to Participate!");
            }
            
            if (Heightlist.Text == "")
            {
                MessageBox.Show("please select the step height!");
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            TestCusId.Text = Class1.id;
            Testname.Text = Class1.name;
            Testlast.Text = Class1.lastname;
            Testage.Text = Class1.age;
            Testsex.Text = Class1.sex;
        }

        private void getresults_Click(object sender, EventArgs e)
        {
            Class1.dates = testdate.Text;
            Class1.aerobic = Aerobic.Text;
            Class1.testingid = TestId.Text;
            FinalResult finale = new FinalResult();
            finale.Show();
                    }

        private void Testage_TextChanged(object sender, EventArgs e)
                    {
                        double max = 220 - Convert.ToInt32(Testage.Text);
                        Maxhr.Text = Convert.ToString(max);
                           double c = (0.8 * max);
                         Eightperhr.Text = Convert.ToString(c);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            GettestID();
        }

        private void SecondRead_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SecondRead.Text) > Convert.ToInt32(Maxhr.Text))
            {
                MessageBox.Show("You are not fit to Participate!");
            }
            
        }

        private void ThirdRead_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ThirdRead.Text) > Convert.ToInt32(Maxhr.Text))
            {
                MessageBox.Show("You are not fit to Participate!");
            }
            
        }

        private void FourthRead_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(FourthRead.Text) > Convert.ToInt32(Maxhr.Text))
            {
                MessageBox.Show("You are not fit to Participate!");
            }
            
        }

        private void FifthRead_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(FifthRead.Text) > Convert.ToInt32(Maxhr.Text))
            {
                MessageBox.Show("You are not fit to Participate!");
            }
        }

            }

    

        }
    