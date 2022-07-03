using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tooler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void LIB_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()==true)
            {
                Uri uri = new Uri(openFileDialog.FileName);
                imgimg.Source = new BitmapImage(uri);
            }
        }

        private void LIB_Click2(object sender, RoutedEventArgs e)
        {
            if (imgimg.Height != ActualHeight)
            {
                imgimg.Height = ActualHeight;
                imgimg.Width = ActualWidth;
            }
            else
            {
                imgimg.Height = 200;
                imgimg.Width = 200;
            }
        }
    }
}
