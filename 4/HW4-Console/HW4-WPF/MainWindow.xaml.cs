using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace HW4_WPF
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

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Console.WriteLine("Input date in dd/mm/yyyy format:");
            StringBuilder s = new StringBuilder(DateTextBox.Text);
            s.Replace(" ", "");
            string format = "dd/MM/yyyy";
            DateTime d = DateTime.ParseExact(s.ToString(), format, CultureInfo.InvariantCulture);

            
            #region Edge Days

            DateTime d1 = new DateTime(d.Year, 1, 21);
            DateTime d2 = new DateTime(d.Year, 2, 22);
            DateTime d3 = new DateTime(d.Year, 3, 21);
            DateTime d4 = new DateTime(d.Year, 4, 22);
            DateTime d5 = new DateTime(d.Year, 5, 22);
            DateTime d6 = new DateTime(d.Year, 6, 23);
            DateTime d7 = new DateTime(d.Year, 7, 23);
            DateTime d8 = new DateTime(d.Year, 8, 23);
            DateTime d9 = new DateTime(d.Year, 9, 22);
            DateTime d10 = new DateTime(d.Year, 10, 24);
            DateTime d11 = new DateTime(d.Year, 11, 22);
            DateTime d12 = new DateTime(d.Year, 12, 22);

            #endregion
                
            StringBuilder path = new StringBuilder(Environment.CurrentDirectory);
            path.Replace("\\","/");
            path.Append("/images/");
            
            //MessageBox.Show(path.ToString());



            if (IsInInterval(d1, d2, d))
            {
                Result.Text="Aquaries";
                SignImage.Source = new BitmapImage(new Uri(@path.ToString() + "aquries.jpg"));

            }
            if (IsInInterval(d2, d3, d))
            {
                Result.Text = "Picses";
                SignImage.Source = new BitmapImage(new Uri(@path.ToString() + "picses.jpg"));
            };
            if (IsInInterval(d3, d4, d))
            {
                Result.Text = "Aries";
                SignImage.Source = new BitmapImage(new Uri(@path.ToString() + "aries.jpg"));
            }
            if (IsInInterval(d4, d5, d))
            {
                Result.Text="Taurus";
                SignImage.Source = new BitmapImage(new Uri(@path.ToString() + "taurus.jpg"));
            }
            if (IsInInterval(d5, d6, d)) 
            {
                SignImage.Source = new BitmapImage(new Uri(@path.ToString() + "gemini.jpg"));
                Result.Text = "Gemini";
            }

            if (IsInInterval(d6, d7, d))
            {
                Result.Text = "Cancer";
                SignImage.Source = new BitmapImage(new Uri(@path.ToString() + "cancer.jpg"));
            }

            if (IsInInterval(d7, d8, d))
            {
                Result.Text = "Leo";
                SignImage.Source = new BitmapImage(new Uri(@path.ToString() + "leo.jpg"));
            }

            if (IsInInterval(d8, d9, d))
            {
                Result.Text = "Virgo";
                SignImage.Source = new BitmapImage(new Uri(@path.ToString() + "virgo.jpg"));
            }

            if (IsInInterval(d9, d10, d))
            {
                Result.Text = "Libra";
                SignImage.Source = new BitmapImage(new Uri(@path.ToString() + "libra.jpg"));
            }

            if (IsInInterval(d10, d11, d))
            {
                Result.Text = "Scorpio";
                SignImage.Source = new BitmapImage(new Uri(@path.ToString() + "scorpio.jpg"));
            }

            if (IsInInterval(d11, d12, d))
            {
                Result.Text = "Sagittarius";
                SignImage.Source = new BitmapImage(new Uri(@path.ToString() + "sagittarius.jpg"));
            }
            if (IsInInterval(d12, d1, d))
            {
                Result.Text = "Capricorn";
                SignImage.Source = new BitmapImage(new Uri(@path.ToString() + "capricorn.jpg"));
            };
            

        }
        private static bool IsInInterval(DateTime left, DateTime right, DateTime d)
        {
            return (d >= left && d < right);
        }



    }
}
