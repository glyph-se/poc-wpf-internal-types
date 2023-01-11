using System.Windows.Controls;

namespace WpfApp1
{
	/// <summary>
	/// Interaction logic for UserControl1.xaml
	/// </summary>
	internal partial class UserControl1 : UserControl
	{
		// This constructor causes the issues
		internal UserControl1()
		{
			InitializeComponent();
		}
	}
}
