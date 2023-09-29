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

namespace Music_Player
{
    /// <summary>
    /// Interaction logic for Registery.xaml
    /// </summary>
    public partial class Registery : Window
    {
        public Registery()
        {
            InitializeComponent();
        }

        private void btnSing_Click(object sender, RoutedEventArgs e)
        {
            signin sign = new signin();
            sign.Show();
            this.Close();
        }

        private void btnActivate_Click(object sender, RoutedEventArgs e)
        {
            Activat activat = new Activat();
            activat.Show(); 
            this.Close();
        }
    }
}
