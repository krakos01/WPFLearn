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
using System.Collections.ObjectModel;
using System.ComponentModel;

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

		private void CutCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = (txtEditor != null) && (txtEditor.SelectionLength > 0);
		}

		private void CutCommand_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			txtEditor.Cut();
		}

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
			e.CanExecute = (txtEditor != null) && (txtEditor.SelectionLength > 0);
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
			txtEditor.Copy();
        }
    }
}
