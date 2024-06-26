﻿using System;
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
    /// Interaction logic for party.xaml
    /// </summary>
    public partial class party : Window
    {
       List<Detailsclass> Mlist = new List<Detailsclass>();

       List<string> partytypes = new List<string>();

       List<payment> partypayments = new List<payment>();

        public party()
        {

            InitializeComponent();

            dateselection.DisplayDateStart = DateTime.Today;

            partytypes.Add("Birthday");
            partytypes.Add("Pre-Wedding");
            partytypes.Add("Reception");
            partytypes.Add("Business"); 
            partytypes.Add("Adult");
            partytypes.Add("Religious");

            partylist.ItemsSource = partytypes.ToList();

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

            partypayments.Add (new payment ("UPI"));
            partypayments.Add(new payment("Debit Card"));
            partypayments.Add(new payment("Credit Card"));
            partypayments.Add(new payment("Digitalmobile wallet"));
            partypayments.Add(new payment("Bank Transfer"));

            var X = partypayments.Select(temp => temp.paymentmethod);

            paymentportal.ItemsSource = X.ToList();

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

            strengthdetails.Text = strength;
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-1RVCTQKL\MSSQLSERVER01;Initial Catalog=EventPlanner360;Integrated Security=True");

            Con.Open();

            SqlCommand Checkingdateofbooking = new SqlCommand();

            Checkingdateofbooking.CommandText = "select DateOfBooking from EventPlannerPartyDB where dateofbooking ='" + dateselection.Text + " ' ";

            Checkingdateofbooking.Connection = Con;

            string Datecheck = (string)Checkingdateofbooking.ExecuteScalar();

            SqlCommand checkingVenuename = new SqlCommand();

            checkingVenuename.CommandText = " select venuname from EventplannerPartyDB where venuname = '" + hallslist.SelectedItem.ToString() + "'";

            checkingVenuename.Connection = Con;

            string Venuecheck = (string)checkingVenuename.ExecuteScalar();

            SqlCommand checkingpayment = new SqlCommand();

            checkingpayment.CommandText = "select PaymentStatus from EventplannerPartyDB where PaymentStatus = '" + "Done" + "' ";

            checkingpayment.Connection = Con;

            string paymentcheck = (string) checkingpayment.ExecuteScalar();

            if (Datecheck == dateselection.Text && Venuecheck == hallslist.SelectedItem.ToString() && paymentcheck == "Done")
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
                paymentportal.Visibility = Visibility.Visible;
                cnfrmbooking.Visibility = Visibility.Visible;
                BudgettrackingParty.Visibility = Visibility.Visible;


            }

        }

        private void cnfrmbooking_Click_1(object sender, RoutedEventArgs e)
        {
            

            SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-1RVCTQKL\MSSQLSERVER01;Initial Catalog=EventPlanner360;Integrated Security=True");

            Con.Open();

            SqlCommand Com = new SqlCommand();

            Com.CommandText = "insert into EventPlannerPartyDB(venuname,party,dateofbooking,customername,customeraddress,customernumber) values ('" + hallslist.SelectedItem.ToString() + "' , ' " + partylist.SelectedItem.ToString() + " ' , '" + dateselection.Text + "', '" + Nametxt.Text + "','" + Numbertxt.Text + " ' , ' " + Addresstxt.Text + " ' )";

            Com.Connection = Con;

            Com.ExecuteNonQuery();

            Con.Close();


            MessageBox.Show("Confirmation will be done after payment ");
        }

        private void Budgettracking_Click_1(object sender, RoutedEventArgs e)
        {

            BudgetTrackingParty tracker = new BudgetTrackingParty();

            this.Hide();

            tracker.Show();
            

        }

        private void partylist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MainWindow mainpage = new MainWindow();

            this.Close();

            mainpage.Show();

        }

    }
}
