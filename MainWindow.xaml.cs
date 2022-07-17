using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
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

		private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
		{
			int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
			int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
			lblCursorPosition.Text = "Line " + (row + 1) + ", Char " + (col + 1);
			
			Path.Text = DateTime.Now.ToString();
		}
	}
}
