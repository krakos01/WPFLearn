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



        private void SexyButton_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NameBox.Text = "wracam do normy...";
        }


        static int ile = 0;
        private void SexyButton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (ile < 4)
            {
                ile++;
                MessageBox.Show("MAMMA MIA " + ile + " " + e.GetPosition(this));
                NameBox.Text = "oh yah, more daddy";
            }
        }

        private void SexyButton_Click(object sender, RoutedEventArgs e)
        {
            NameBox.Text = "I'm clicked...\nI'M CLICKED!!!!!!!!!!!!!!!";
            GBTN_button.IsEnabled = true;
        }

        private void GBTN_button_Click(object sender, RoutedEventArgs e)
        {
            NameBox.Text = string.Empty;
        }
    }
}
