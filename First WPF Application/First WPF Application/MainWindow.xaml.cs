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

namespace First_WPF_Application
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Bttn1_Click(object sender, RoutedEventArgs e)
        {
            int currentMonth = DateTime.Now.Month;
            int input1 = Convert.ToInt32(TxtBxMonth.Text);
            int currentDay = DateTime.Now.Day;
            int input2 = Convert.ToInt32(TxtBxDay.Text);
            int currentYear = DateTime.Now.Year;
            int input3 = Convert.ToInt32(TxtBxYear.Text);
            int age;
            if (input1 > currentMonth && input2 > currentDay)
            {
                age = (currentYear - input3) -1;
            }
            else
            {
                age = (currentYear - input3);
            }
            string ageS = Convert.ToString(age);
            TxtBxResult.Text = $" You are {ageS} years old";
        }

        private void Bttn1_MouseEnter(object sender, MouseEventArgs e)
        {
            MW.Background = new SolidColorBrush(Color.FromArgb(90, 200, 90, 100));
        }

        private void Bttn1_MouseLeave(object sender, MouseEventArgs e)
        {
            MW.Background = new SolidColorBrush(Color.FromRgb(200, 90, 200));
        }

        private void TxtBxResult_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
