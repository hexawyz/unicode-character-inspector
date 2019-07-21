using System.Globalization;
using System.Threading;
using System.Windows;

namespace UnicodeCharacterInspector
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			// Workaround for WPF bug.
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

			InitializeComponent();
		}
	}
}
