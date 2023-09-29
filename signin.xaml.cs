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
    /// Interaction logic for signin.xaml
    /// </summary>
    public partial class signin : Window
    {
        public signin()
        {
            InitializeComponent();
        }

        private void login_click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRegisterhere_Click(object sender, RoutedEventArgs e)
        {
            Registery registery = new Registery();
            registery.Show();
            this.Hide();
             
        }
    }
}
