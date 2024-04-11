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
    /// Interaction logic for Conference.xaml
    /// </summary>
    public partial class Conference : Window
    {
        List<Detailsclass> Clist = new List<Detailsclass>();

        List<payment> conferencepayment = new List<payment>();

        public Conference()
        {
            InitializeComponent();

            dateselection.DisplayDateStart = DateTime.Today;

            Clist.Add(new Detailsclass("Chennai", "The Conference Centre","500"));
            Clist.Add(new Detailsclass("Chennai", "Ramachandra Conventional Centre", "500"));
            Clist.Add(new Detailsclass("Chennai", "JMA Convention Hall","1000"));
            Clist.Add(new Detailsclass("Chennai", "Ruckmani Ramjee Convention hall", "1000"));
            Clist.Add(new Detailsclass("Chennai", "GRT  hall", "500"));
            Clist.Add(new Detailsclass("Chennai", "B.M Convention hall","500"));
            Clist.Add(new Detailsclass("Chennai", "Ramjee Meeting hall", "1000"));
            Clist.Add(new Detailsclass("Chennai", "META Convention hall", "800"));
            Clist.Add(new Detailsclass("Trichy", "AMIRTHA Mini Hall","1000"));
            Clist.Add(new Detailsclass("Trichy", "Sri Krishna's Hall", "500"));
            Clist.Add(new Detailsclass("Trichy", "MNS Mini Hall", "500"));
            Clist.Add(new Detailsclass("Trichy", "summit Banquat hall","500"));
            Clist.Add(new Detailsclass("Trichy", "Lotus hall","1000"));
            Clist.Add(new Detailsclass("Trichy", "Sri Prakash Mahal","1000"));
            Clist.Add(new Detailsclass("Coiambotre", "MSN Conference hall","1500"));
            Clist.Add(new Detailsclass("Coiambotre", "Hall 360", "1200"));
            Clist.Add(new Detailsclass("Coiambotre", "JJ Conference mini hall", "700"));
            Clist.Add(new Detailsclass("Coiambotre", "Utsava", "700"));
            Clist.Add(new Detailsclass("Coiambotre", "SPR hall", "900"));
            Clist.Add(new Detailsclass("Madurai", "Meenakshi meeting hall", "400"));
            Clist.Add(new Detailsclass("Madurai", "Sivani meeting hall", "800"));
            Clist.Add(new Detailsclass("Madurai", "Sri Ram meeting hall", "1000"));
            Clist.Add(new Detailsclass("Madurai", "Amaran Meeting hall", "800"));
            Clist.Add(new Detailsclass("Madurai", "Lotus Hall madurai", "800"));

            conferencepayment.Add(new payment("UPI"));
            conferencepayment.Add(new payment("Debit Card"));
            conferencepayment.Add(new payment("Credit Card"));
            conferencepayment.Add(new payment("Digitalmobile wallet"));
            conferencepayment.Add(new payment("Bank Transfer"));

            var X = conferencepayment.Select(temp => temp.paymentmethod);

            Paymentportal.ItemsSource = X.ToList();

            var A = Clist.Select(temp => temp.City);

            Locationcmbox.ItemsSource = A.Distinct().ToList();
        }

        private void Locationcmbox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

            var B = Clist.Where(temp => temp.City == Locationcmbox.SelectedItem.ToString()).Select(temp => temp.Venues);

            hallslist.ItemsSource = B.Distinct().ToList();

        }

        private void hallslist_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {


        }


   
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {




            SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-1RVCTQKL\MSSQLSERVER01;Initial Catalog=EventPlanner360;Integrated Security=True");

            Con.Open();

            SqlCommand Checkingdateofbooking = new SqlCommand();

            Checkingdateofbooking.CommandText = "select dateofbooking from EventplannerConferenceDB where dateofbooking ='" + dateselection.Text + " ' ";

            Checkingdateofbooking.Connection = Con;

            string Datecheck =(string) Checkingdateofbooking.ExecuteScalar();

            SqlCommand checkingVenuename = new SqlCommand();

            checkingVenuename.CommandText = " select venuename from EventplannerConferenceDB where venuename = '"+hallslist.SelectedItem.ToString()+"'";

            checkingVenuename.Connection = Con;

            string Venuecheck = (string ) checkingVenuename.ExecuteScalar();

            if (Datecheck == dateselection.Text && Venuecheck == hallslist.SelectedItem.ToString())
            {
                MessageBox.Show("Sorry :( venue has been booked already on the selected date Choose Some other date");

            }

            else
            {
                namel.Visibility = Visibility.Visible;
                Nametxt.Visibility = Visibility.Visible;
                numl.Visibility = Visibility.Visible;
                Numbertxt.Visibility = Visibility.Visible;
                Addressl.Visibility = Visibility.Visible;
                Addresstxt.Visibility = Visibility.Visible;
                Detailsl.Visibility = Visibility.Visible;
                detailstxt.Visibility = Visibility.Visible;
                Paymentl.Visibility = Visibility.Visible;
                Paymentportal.Visibility = Visibility.Visible;
                officetxt.Visibility = Visibility.Visible;
                cnfrmbooking.Visibility = Visibility.Visible;
                trackingbudget.Visibility = Visibility.Visible;
                officel.Visibility = Visibility.Visible;
               
               
            }
 
        }



        private void Button_Click_3(object sender, RoutedEventArgs e)
        {


           

        }

       

        private void cnfrmbooking_Click_1(object sender, RoutedEventArgs e)

        {

           

            SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-1RVCTQKL\MSSQLSERVER01;Initial Catalog=EventPlanner360;Integrated Security=True");

            Con.Open();

            SqlCommand Com = new SqlCommand();

            Com.CommandText = "insert into EventPlannerConferenceDB(venuename,dateofbooking,customername,customeraddress,customernumber) values ('" + hallslist.SelectedItem.ToString() + "' , '" + dateselection.Text + "', '" + Nametxt.Text + "','" + Numbertxt.Text + " ' , ' " + Addresstxt.Text + " ' )";

            Com.Connection = Con;

            Com.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Confirmation will be done after payment ");


           
        }

        private void trackingbudget_Click_1(object sender, RoutedEventArgs e)
        {
            BudgetTrackingConference tracking = new BudgetTrackingConference();

            this.Hide();

            tracking.Show();

        }

    }
}

