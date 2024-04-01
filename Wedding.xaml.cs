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
    /// Interaction logic for Wedding.xaml
    /// </summary>
    public partial class Wedding : Window
    {
        List<Detailsclass> Mlist = new List<Detailsclass>();

        public Wedding()
        {
            InitializeComponent();

            dateselection.DisplayDateStart = DateTime.Today;

            Mlist.Add(new Detailsclass("Chennai", "The Conference Centre", "500"));
            Mlist.Add(new Detailsclass("Chennai", "Ramachandra Conventional Centre", "500"));
            Mlist.Add(new Detailsclass("Chennai", "JMA Convention Hall", "1000"));
            Mlist.Add(new Detailsclass("Chennai", "Ruckmani Ramjee Convention hall", "1000"));
            Mlist.Add(new Detailsclass("Chennai", "GRT  hall", "500"));
            Mlist.Add(new Detailsclass("Chennai", "B.M Convention hall", "500"));
            Mlist.Add(new Detailsclass("Chennai", "Ramjee Meeting hall", "1000"));
            Mlist.Add(new Detailsclass("Chennai", "META Convention hall", "800"));
            Mlist.Add(new Detailsclass("Trichy", "AMIRTHA Mini Hall", "1000"));
            Mlist.Add(new Detailsclass("Trichy", "Sri Krishna's Hall", "500"));
            Mlist.Add(new Detailsclass("Trichy", "MNS Mini Hall", "500"));
            Mlist.Add(new Detailsclass("Trichy", "summit Banquat hall", "500"));
            Mlist.Add(new Detailsclass("Trichy", "Lotus hall", "1000"));
            Mlist.Add(new Detailsclass("Trichy", "Sri Prakash Mahal", "1000"));
            Mlist.Add(new Detailsclass("Coiambotre", "MSN Conference hall", "1500"));
            Mlist.Add(new Detailsclass("Coiambotre", "Hall 360", "1200"));
            Mlist.Add(new Detailsclass("Coiambotre", "JJ Conference mini hall", "700"));
            Mlist.Add(new Detailsclass("Coiambotre", "Utsava", "700"));
            Mlist.Add(new Detailsclass("Coiambotre", "SPR hall", "900"));
            Mlist.Add(new Detailsclass("Madurai", "Meenakshi meeting hall", "400"));
            Mlist.Add(new Detailsclass("Madurai", "Sivani meeting hall", "800"));
            Mlist.Add(new Detailsclass("Madurai", "Sri Ram meeting hall", "1000"));
            Mlist.Add(new Detailsclass("Madurai", "Amaran Meeting hall", "800"));
            Mlist.Add(new Detailsclass("Madurai", "Lotus Hall madurai", "800"));

            var City = Mlist.Select(temp => temp.City);

            Locationcmbox.ItemsSource = City.Distinct().ToList();
        }

        private void Locationcmbox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

            var Venues = Mlist.Where(temp =>temp.City==Locationcmbox.SelectedItem.ToString()).Select(temp => temp.Venues);

            hallslist.ItemsSource = Venues.ToList();
        }

        private void hallslist_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

            var strength = Mlist.Where(temp => temp.City == Locationcmbox.SelectedItem.ToString() && temp.Venues == hallslist.SelectedItem.ToString()).Select(temp => temp.Strength.ToString()).FirstOrDefault();
           // var strength = Mlist.Where(temp => temp.City == Locationcmbox.SelectedItem.ToString() && temp.Venues == hallslist.SelectedItem.ToString()).FirstOrDefault();

            strengthdetails.Text = strength.ToString();        
           
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            venuespanel.Visibility = Visibility.Visible;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-1RVCTQKL\MSSQLSERVER01;Initial Catalog=EventPlanner360;Integrated Security=True");

            Con.Open();

            SqlCommand Checkingdateofbooking = new SqlCommand();

            Checkingdateofbooking.CommandText = "select dateofbooking from EventplannerWeddingDB where dateofbooking ='" + dateselection.Text + " ' ";

            Checkingdateofbooking.Connection = Con;

            string Datecheck = (string)Checkingdateofbooking.ExecuteScalar();

            SqlCommand checkingVenuename = new SqlCommand();

            checkingVenuename.CommandText = " select venuename from EventplannerWeddingDB where venuename = '" + hallslist.SelectedItem.ToString() + "'";

            checkingVenuename.Connection = Con;

            string Venuecheck = (string)checkingVenuename.ExecuteScalar();

            if (Datecheck == dateselection.Text && Venuecheck == hallslist.SelectedItem.ToString())
            {
                MessageBox.Show("Sorry :( venue has been booked already on the selected date Choose Some other date");

            }

            else
            {

                D1.Visibility = Visibility.Visible;

                D2.Visibility = Visibility.Visible;


            }

        }

        private void cnfrmbooking_Click_1(object sender, RoutedEventArgs e)
        {
    

            SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-1RVCTQKL\MSSQLSERVER01;Initial Catalog=EventPlanner360;Integrated Security=True");

            Con.Open();

            SqlCommand Com = new SqlCommand();

            Com.CommandText = "insert into EventplannerWeddingDB(venuename,dateofbooking,customername,customeraddress,customernumber) values ('" + hallslist.SelectedItem.ToString() + "' , '" + dateselection.Text + "', '" + Nametxt.Text + "','" + Numbertxt.Text + " ' , ' " + Addresstxt.Text + " ' )";

            Com.Connection = Con;

            Com.ExecuteNonQuery();

            Con.Close();


            MessageBox.Show("Confirmation will be done after payment ");
        }

        private void Budgettracking_Click_1(object sender, RoutedEventArgs e)
        {

            BudgetTracking tracker = new BudgetTracking();

            this.Hide();

            tracker.Show();
            
        }

    }
}
