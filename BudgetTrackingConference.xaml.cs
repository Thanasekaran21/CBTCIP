using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace EVENTPLANNER360
{
    /// <summary>
    /// Interaction logic for BudgetTrackingConference.xaml
    /// </summary>
    public partial class BudgetTrackingConference : Window
    {
        List<Budget_Tracking> Conference = new List<Budget_Tracking>(); int TotalAmount = 25000;

        public BudgetTrackingConference()
        {
            InitializeComponent();

            Conference.Add(new Budget_Tracking("Stage Design", 5000));
            Conference.Add(new Budget_Tracking("Seat Design", 100));
            Conference.Add(new Budget_Tracking("Electricity", 2000));
            Conference.Add(new Budget_Tracking("Water", 2000));
            Conference.Add(new Budget_Tracking("Venue Decoration", 3500));
            Conference.Add(new Budget_Tracking("Veg", 100));
            Conference.Add(new Budget_Tracking("Non Veg", 200));
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            if (stage.IsChecked == true)
            {
                var A = Conference.Where(temp => temp.TYPE == stage.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();
            }


        }

        private void seat_Checked_1(object sender, RoutedEventArgs e)
        {
            if (seat.IsChecked == true)
            {
                var A = Conference.Where(temp => temp.TYPE == seat.Content.ToString()).Select(temp => temp.AMOUNT);
            

                if (strength.Text != "")
                {
                    int B = int.Parse(strength.Text);

                    B = B * A.First();

                    TotalAmount = TotalAmount + B;
                }
            }

        }

        private void electricity_Checked_1(object sender, RoutedEventArgs e)
        {
            if (electricity.IsChecked == true)
            {
                var A = Conference.Where(temp => temp.TYPE == electricity.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();
            }

        }

        private void water_Checked_1(object sender, RoutedEventArgs e)
        {
            if (water.IsChecked == true)
            {
                var A = Conference.Where(temp => temp.TYPE == water.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();
            }

        }

        private void venue_Checked_1(object sender, RoutedEventArgs e)
        {
            if (venue.IsChecked == true)
            {
                var A = Conference.Where(temp => temp.TYPE == venue.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

                pay.Text = TotalAmount.ToString() + " " + "RS";
            }

        }

        private void vegcheckbox2_Checked_1(object sender, RoutedEventArgs e)
        {
            if (vegcheckbox2.IsChecked == true)
            {

                veg.Visibility = Visibility.Visible;


                var A = Conference.Where(temp => temp.TYPE == vegcheckbox2.Content.ToString()).Select(temp => temp.AMOUNT);

                int X = int.Parse(str.Text);

                int Y = X * A.First();

                TotalAmount = TotalAmount + Y;

                pay.Text = TotalAmount.ToString() + " " + "RS";


            }
        }

        private void Nonvegcheckbox2_Checked_1(object sender, RoutedEventArgs e)
        {
            if (Nonvegcheckbox2.IsChecked == true)
            {
                veg.Visibility = Visibility.Hidden;

                Nonvg.Visibility = Visibility.Visible;

                var A = Conference.Where(temp => temp.TYPE == Nonvegcheckbox2.Content.ToString()).Select(temp => temp.AMOUNT);

                int X = int.Parse(str.Text);

                int Y = X * A.First();

                TotalAmount = TotalAmount + Y;

                pay.Text = TotalAmount.ToString() + " " + "RS";
            }

        }

        private void payment_Click_1(object sender, RoutedEventArgs e)
        {

            string D = "Done";

            SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-1RVCTQKL\MSSQLSERVER01;Initial Catalog=EventPlanner360;Integrated Security=True");

            Con.Open();

            SqlCommand Com = new SqlCommand();

            Com.CommandText = "insert into EventplannerConferenceDB(PaymentStatus) values ( '" + D + "')";

            Com.Connection = Con;

            Com.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Event Confirmed");
        }
    }
}
