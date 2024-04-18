using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Media;
using System.IO;
using System.Threading;

namespace Button
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer player = null;
        public MediaPlayer mediaPlayer = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string sound1 = @"D:\Проекты VS\_MyMessageBox_\Button\Звуки\win31.mp3";
            mediaPlayer.Open(new Uri(sound1));
            mediaPlayer.Play();
            Thread.Sleep(1000);
            CustomMessageBox customMessageBox = new CustomMessageBox();
            customMessageBox.Show();
        }
    }
}
