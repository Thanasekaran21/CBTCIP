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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EVENTPLANNER360
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.SizeToContent = SizeToContent.WidthAndHeight;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Wedding weddingwindow = new Wedding();

            this.Hide();

            weddingwindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            party partywindow = new party();

            this.Hide();

            partywindow.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Conference conferencewindow = new Conference();

            this.Hide();

            conferencewindow.Show();

        }
    }
}
