using System;
using System.Text;
using System.Windows;

namespace HW3
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

       
        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errMsg = new StringBuilder();

            #region First Name Processing
            if (FirstNameInput.Text.Length >= 255)
            {
                errMsg.AppendLine("\nFirst name: your name is too long!");
            }

            foreach (var s in FirstNameInput.Text)
            {
                if (!Char.IsLetter(s))
                {
                    errMsg.AppendFormat("\nFirst name: Only letters allowed in name!!!");
                    break;
                }
            }
            #endregion

            #region Second Name Processing
            if (LastNameInput.Text.Length>=255)
            {
                errMsg.AppendLine("\nLast name: your name is too long!");
            }

            foreach (var s in LastNameInput.Text)
            {
                if (!Char.IsLetter(s))
                {
                    errMsg.AppendFormat("\nLast name: Only letters allowed in name!!!");
                    break;
                }
            }

            #endregion

            #region Birth Date Processing

            //Day and Month info is processed automatically by DatePicker
            if (BirthDateInput.DisplayDate.Year > DateTime.Today.Year
                || BirthDateInput.DisplayDate.Year<1900)
            {
                errMsg.AppendLine("\nBirth date: Incorrect year!");
            }
            #endregion

            #region Gender Checking

            if (!(GenderInput.Text.ToLower()=="male"|| 
                GenderInput.Text.ToLower()=="female"))
            {
                errMsg.AppendLine("\nGender: Incorrect Gender!");
            }

            #endregion

            #region Email Checking

            if (!EmailInput.Text.Contains("@"))
            {
                errMsg.AppendLine("Email:Email should contain @");
            }

            if (EmailInput.Text.Length>=255)
            {
                errMsg.AppendLine("\nEmail:Too long email adress");
            }

            #endregion

            #region Phone Number Checking

            if (PhoneNumberInput.Text.Length!=12)
            {
                errMsg.AppendLine("\nPnone number: should be 12-digital!");
            }

            foreach (var s in PhoneNumberInput.Text)
            {
                if (!Char.IsDigit(s))
                {
                    errMsg.AppendLine("\nPhone number: Only digits allowed!");
                }
            }

            #endregion

            #region Additional Info Checking

            if (AdditionalInfoInput.Text.Length > 2000)
            {
                errMsg.AppendLine("\nAdditioonal info: Too long text!");
            }

            #endregion

            if (errMsg.ToString()=="")
            {
                MessageBox.Show("Successfully validated!");

            }
            else
            {
                MessageBox.Show(errMsg.ToString());
            }

        }

       
        


    }
}
