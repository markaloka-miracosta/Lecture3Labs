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

namespace Lab1
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
            String piglatinFirstName;// to output
            String PiglatinLastName;//to ouput 
            String firstName = fntxtBox.Text; // = "Mark";
            String lastName = lntxtBox.Text; // = "Aloka"; 

            //to process first name
            piglatinFirstName = firstName.Substring(1, firstName.Length - 1) + firstName.Substring(0, 1).ToLower() + "ay";
            piglatinFirstName = piglatinFirstName.Substring(0, 1).ToUpper() + piglatinFirstName.Substring(1, piglatinFirstName.Length - 1);

            //to process last name 
            PiglatinLastName = lastName.Substring(1, lastName.Length - 1) + lastName.Substring(0, 1).ToLower() + "ay";
            PiglatinLastName = PiglatinLastName.Substring(0, 1).ToUpper() + PiglatinLastName.Substring(1, PiglatinLastName.Length - 1);
            MessageBox.Show("Your name in piglatin is: " + piglatinFirstName + " " + PiglatinLastName); 
        }
    }
}
