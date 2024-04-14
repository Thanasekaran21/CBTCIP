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
    /// Interaction logic for BudgetTrackingParty.xaml
    /// </summary>
    public partial class BudgetTrackingParty : Window
    {
        List<Budget_Tracking> budgettrackingparty = new List<Budget_Tracking>();

        int TotalAmount = 25000;

        public BudgetTrackingParty()
        {
            InitializeComponent();

            budgettrackingparty.Add(new Budget_Tracking("Stage Decorations", 8000));
            budgettrackingparty.Add(new Budget_Tracking("Music", 1000));
            budgettrackingparty.Add(new Budget_Tracking("Seat Decoration", 5000));
            budgettrackingparty.Add(new Budget_Tracking("Electricity", 1000));
            budgettrackingparty.Add(new Budget_Tracking("Water", 6000));
            budgettrackingparty.Add(new Budget_Tracking("Venue Decoration", 3500));
            budgettrackingparty.Add(new Budget_Tracking("Light Decoration", 3500));
            budgettrackingparty.Add(new Budget_Tracking("DJ", 4500));
            budgettrackingparty.Add(new Budget_Tracking("Veg", 100));
            budgettrackingparty.Add(new Budget_Tracking("Non Veg", 200));


          

        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            if (Stage.IsChecked == true)
            {

                var A = budgettrackingparty.Where(temp => temp.TYPE == Stage.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount +  A.First();

            }
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            if (music.IsChecked == true)
            {
                var A = budgettrackingparty.Where(temp => temp.TYPE == music.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }


        private void seat_Checked_1(object sender, RoutedEventArgs e)
        {
            if (seat.IsChecked == true)
            {
                var A = budgettrackingparty.Where(temp => temp.TYPE == seat.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }

        }

        private void electricity_Checked_1(object sender, RoutedEventArgs e)
        {

            if (electricity.IsChecked == true)
            {
                var A = budgettrackingparty.Where(temp => temp.TYPE == electricity.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }

        private void water_Checked_1(object sender, RoutedEventArgs e)
        {

            if (water.IsChecked == true)
            {
                var A = budgettrackingparty.Where(temp => temp.TYPE == water.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }

        private void light_Checked_1(object sender, RoutedEventArgs e)
        {

            if (light.IsChecked == true)
            {
                var A = budgettrackingparty.Where(temp => temp.TYPE == light.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }

        private void venue_Checked_1(object sender, RoutedEventArgs e)
        {
            if (venue.IsChecked == true)
            {
                var A = budgettrackingparty.Where(temp => temp.TYPE == venue.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }

        private void dj_Checked_1(object sender, RoutedEventArgs e)
        {

            if (dj.IsChecked == true)
            {
                var A = budgettrackingparty.Where(temp => temp.TYPE == dj.Content.ToString()).Select(temp => temp.AMOUNT);

                TotalAmount = TotalAmount + A.First();

            }
        }


        private void vegcheckbox_Checked_1(object sender, RoutedEventArgs e)
        {

            if (vegcheckbox.IsChecked == true)
            {

                veg.Visibility = Visibility.Visible;

               
                    var A = budgettrackingparty.Where(temp => temp.TYPE == vegcheckbox.Content.ToString() ).Select(temp => temp.AMOUNT);

                    int X = int.Parse(str.Text);

                     int Y = X * A.First();

                    TotalAmount = TotalAmount + Y;

                    pay.Text = TotalAmount.ToString()+" " +"RS";

               
            }

            else if (vegcheckbox.IsChecked == false)
            {

                veg.Visibility = Visibility.Hidden;
            }



        }

        private void Nonvegcheckbox_Checked_1(object sender, RoutedEventArgs e)
        {
            if (Nonvegcheckbox.IsChecked == true)
            {
                veg.Visibility = Visibility.Hidden;

                Nonvg.Visibility = Visibility.Visible;

                var A = budgettrackingparty.Where(temp => temp.TYPE == Nonvegcheckbox.Content.ToString()).Select(temp => temp.AMOUNT);

                int X = int.Parse(str.Text);

                int Y = X * A.First();

                TotalAmount = TotalAmount + Y;

                pay.Text = TotalAmount.ToString() + " " + "RS";
            }

        }

        private void backbtn_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-1RVCTQKL\MSSQLSERVER01;Initial Catalog=EventPlanner360;Integrated Security=True");

            Con.Open();

            SqlCommand Com = new SqlCommand();

            Com.CommandText = "insert into EventplannerPartyDB(PaymentStatus) values ( '" + "Not Done" + "')";

            Com.Connection = Con;

            Com.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show(" Unable to Book Your Slot SORRY :(");

            party party = new party();

            this.Hide();

            party.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string D = "Done";

            SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-1RVCTQKL\MSSQLSERVER01;Initial Catalog=EventPlanner360;Integrated Security=True");

            Con.Open();

            SqlCommand Com = new SqlCommand();

            Com.CommandText = "insert into EventplannerPartyDB(PaymentStatus) values ( '"+ D +"')";

            Com.Connection = Con;

            Com.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Event Confirmed");
        }


      
      
    }
}
