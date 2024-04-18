using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Button
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class CustomMessageBox : Window
    {
        SoundPlayer player = null;
        public MediaPlayer mediaPlayer = new MediaPlayer();
        public CustomMessageBox()
        {
            InitializeComponent();
            
        }

        private void Button_Yes_Click(object sender, RoutedEventArgs e)
        {
            SoundPlay();
            Close();
        }

        private void Button_No_Click(object sender, RoutedEventArgs e)
        {
            SoundPlay();
            Thread.Sleep(1000);
            Application.Current.Shutdown();
        }
        private void SoundPlay() 
        {
            string sound1 = @"D:\Проекты VS\_MyMessageBox_\Button\Звуки\53811-ston-kri.mp3";
            mediaPlayer.Open(new Uri(sound1));
            mediaPlayer.Play();
        }
    }
}
