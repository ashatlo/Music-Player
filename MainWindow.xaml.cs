using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
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
using static System.Net.Mime.MediaTypeNames;

namespace Music_Player
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = "";
        int currentsong = 0;
        MediaPlayer soundplayer = new MediaPlayer();
        Registery registery = new Registery();
        signin signin = new signin(); 
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private void import_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "wav,mp3,m4a|*.wav;*.mp3;*.m4a" ;
            opf.Title = "Select a Song";
            opf.Multiselect = true;
            if (opf.ShowDialog() == true)
            {
              foreach (string file in opf.FileNames)
              {   
                 filePath = opf.FileName;
                 // string songName = new DirectoryInfo(file).Name;
                 if (playList.Items.Contains(file))
                 {
                    MessageBox.Show("file already exist", "Erorr", MessageBoxButton.OK, MessageBoxImage.Error);
                 }
                 else
                 {
                     playList.Items.Add(file); 
                 }
              }
            }
        }
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            for (int i = playList.SelectedItems.Count - 1; i >= 0; i--)
            {
                playList.Items.Remove(playList.SelectedItems[i]);
                soundplayer.Stop();
            }
        }

        private void btnRemoveAll_Click(object sender, RoutedEventArgs e)
        {
            playList.Items.Clear();
            soundplayer.Stop();
        }

        private void btnplay_Click(object sender, RoutedEventArgs e)
        {
            for (int i = playList.SelectedItems.Count - 1; i >= 0; i--)
            {
                string soundId = playList.SelectedItems[i].ToString();
                currentsong = playList.SelectedIndex;
                if (filePath != null && filePath != string.Empty)
                { 
                  soundplayer.Open(new Uri(soundId));
                  soundplayer.Play();
                }
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            soundplayer.Stop();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (currentsong <= playList.Items.Count - 2)
            {
                currentsong++;
                soundplayer.Open(new Uri(playList.Items[currentsong].ToString()));
                soundplayer.Play();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (currentsong >= 1)
            {
                currentsong--;
                soundplayer.Open(new Uri(playList.Items[currentsong].ToString()));
                soundplayer.Play();
            }
        }

        private void btnReplay_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i >= 0;)
            {
                if (i <= playList.Items.Count)
                {
                    string soundplay = playList.Items[i].ToString();
                    soundplayer.Open(new Uri(soundplay));
                    soundplayer.Play();
                    return;
                }
            }
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           soundplayer.Volume= volumeSlider.Value;
            
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        { 
               signin.Show();
               this.Close();
        }
        private void btnRegisteration_Click(object sender, RoutedEventArgs e)
        {
            registery.Show();
            this.Close();
        }
      }
    
}
