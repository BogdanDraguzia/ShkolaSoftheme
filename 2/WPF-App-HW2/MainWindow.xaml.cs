using System.Windows;
using static System.Double;

namespace WPF_App_HW2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBlock1.Text+="byte:(" +byte.MinValue +","+byte.MaxValue+")";
            TextBlock1.Text += "\nshort:(" + short.MinValue + "," + short.MaxValue + ")";
            TextBlock1.Text += "\nint:(" + int.MinValue + "," + int.MaxValue + ")";
            TextBlock1.Text += "\nlong:(" + long.MinValue + "," + long.MaxValue + ")";
            TextBlock1.Text += "\ndecimal:(" + decimal.MinValue + "," + decimal.MaxValue + ")";
            TextBlock1.Text += "\nfloat:(" + float.MinValue + "," + float.MaxValue + ")";
            TextBlock1.Text += "\ndouble:(" + MinValue + "," + MaxValue + ")";

        }

    }
}
