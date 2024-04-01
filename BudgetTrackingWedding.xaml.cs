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
    /// Interaction logic for BudgetTracking.xaml
    /// </summary>
    public partial class BudgetTracking : Window
    {
        List<Budget_Tracking> budgettrackingwedding = new List<Budget_Tracking>(); int TotalAmount = 0;

        public BudgetTracking()
        {
            InitializeComponent();

            budgettrackingwedding.Add(new Budget_Tracking("Stage Decorations", 8000));
            budgettrackingwedding.Add(new Budget_Tracking("Ceremony Music", 1000));
            budgettrackingwedding.Add(new Budget_Tracking("Music", 1000));
            budgettrackingwedding.Add(new Budget_Tracking("Seat Decoration", 5000));
            budgettrackingwedding.Add(new Budget_Tracking("Electricity", 1000));
            budgettrackingwedding.Add(new Budget_Tracking("Water", 6000));
            budgettrackingwedding.Add(new Budget_Tracking("Venue Decoration", 3500));
            budgettrackingwedding.Add(new Budget_Tracking("Light Decoration", 3500));
            budgettrackingwedding.Add(new Budget_Tracking("DJ", 7500));
            budgettrackingwedding.Add(new Budget_Tracking("Veg", 100));
            budgettrackingwedding.Add(new Budget_Tracking("Non Veg", 200));
            budgettrackingwedding.Add(new Budget_Tracking("Band", 10000));
            budgettrackingwedding.Add(new Budget_Tracking("Photography", 20000));

           
        }

        private void vegcheckbox_Checked_1(object sender, RoutedEventArgs e)
        {
            if (vegcheckbox.IsChecked == true)
            {

                Nonvg.Visibility = Visibility.Hidden;

                veg.Visibility = Visibility.Visible;

                var A = budgettrackingwedding.Where(temp => temp.TYPE == vegcheckbox.Content.ToString()).Select(temp => temp.AMOUNT);

                int X = int.Parse(str.Text);

                int Y = X * A.First();

                TotalAmount = TotalAmount + Y;

                pay.Text = TotalAmount.ToString() + " " + "RS";






            }
        }

        private void Nonvegcheckbox_Checked_1(object sender, RoutedEventArgs e)
        {
            if (Nonvegcheckbox.IsChecked == true)
            {

                veg.Visibility = Visibility.Hidden;

                Nonvg.Visibility = Visibility.Visible;
               

                var A = budgettrackingwedding.Where(temp => temp.TYPE == Nonvegcheckbox.Content.ToString()).Select(temp => temp.AMOUNT);

                int X = int.Parse(str.Text);

                int Y = X * A.First();

                TotalAmount = TotalAmount + Y;

                pay.Text = TotalAmount.ToString() + " " + "RS";
            }
        }

        private void stage_Checked_1(object sender, RoutedEventArgs e)
        {
            if (stage.IsChecked == true)
            {

                var A = budgettrackingwedding.Where(temp => temp.TYPE == stage.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }

        }

        private void musci_Checked_1(object sender, RoutedEventArgs e)
        {
            if (musci.IsChecked == true)
            {

                var A = budgettrackingwedding.Where(temp => temp.TYPE == musci.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }

        }

        private void seat_Checked_1(object sender, RoutedEventArgs e)
        {
            if (seat.IsChecked == true)
            {

                var A = budgettrackingwedding.Where(temp => temp.TYPE == seat.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }

        private void electricity_Checked_1(object sender, RoutedEventArgs e)
        {
            if (electricity.IsChecked == true)
            {

                var A = budgettrackingwedding.Where(temp => temp.TYPE == electricity.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }

        private void water_Checked_1(object sender, RoutedEventArgs e)
        {
            if (water.IsChecked == true)
            {

                var A = budgettrackingwedding.Where(temp => temp.TYPE == water.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }

        private void venue_Checked_1(object sender, RoutedEventArgs e)
        {
            if (venue.IsChecked == true)
            {

                var A = budgettrackingwedding.Where(temp => temp.TYPE == venue.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }

        private void light_Checked_1(object sender, RoutedEventArgs e)
        {
            if (light.IsChecked == true)
            {

                var A = budgettrackingwedding.Where(temp => temp.TYPE == light.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }

        private void band_Checked_1(object sender, RoutedEventArgs e)
        {
            if (band.IsChecked == true)
            {

                var A = budgettrackingwedding.Where(temp => temp.TYPE == band.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }

        private void photo_Checked_1(object sender, RoutedEventArgs e)
        {
            if (photo.IsChecked == true)
            {

                var A = budgettrackingwedding.Where(temp => temp.TYPE == photo.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }

        private void dj_Checked_1(object sender, RoutedEventArgs e)
        {
            if (dj.IsChecked == true)
            {

                var A = budgettrackingwedding.Where(temp => temp.TYPE == dj.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string D = "Done";

            SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-1RVCTQKL\MSSQLSERVER01;Initial Catalog=EventPlanner360;Integrated Security=True");

            Con.Open();

            SqlCommand Com = new SqlCommand();

            Com.CommandText = "insert into EventplannerPartyDB(PaymentStatus) values ( '" + D + "')";

            Com.Connection = Con;

            Com.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Event Confirmed");

        }
    }
}
