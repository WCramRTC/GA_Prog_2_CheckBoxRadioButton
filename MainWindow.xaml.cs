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

namespace GA_Prog_2_CheckBoxRadioButton
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

        private void btnDisplayInfo_Click(object sender, RoutedEventArgs e)
        {
            string formattedString = "";


            // Grabbing Check Box Information
            bool isRaining = chkRaining.IsChecked.Value;
            bool isTimeSensitive = chkTimeSensitive.IsChecked.Value;
            bool useMailingAddress = chkUseMailing.IsChecked.Value;

            formattedString += $"Is Raining : {isRaining}\n\n";
            formattedString += $"Is Time Sensitive : {isTimeSensitive}\n\n";
            formattedString += $"Use Mailing Address : {useMailingAddress}\n\n";

            // Which Color
            bool isRed = rbRed.IsChecked.Value;
            bool isGreen = rbGreen.IsChecked.Value;
            bool isBlue = rbBlue.IsChecked.Value;

            formattedString += "Your favorite color is ";

            if(isRed) { formattedString += "red\n"; }
            else if(isGreen) { formattedString += "green\n"; }
            else { formattedString += "blue\n"; }


            // Which Size
            bool small = rbSmall.IsChecked.Value;
            bool medium = rbMedium.IsChecked.Value;
            bool large = rbLarge.IsChecked.Value;

            formattedString += "\nYour pizza size is ";

            if (small) { formattedString += "small\n"; }
            else if (medium) { formattedString += "medium\n"; }
            else { formattedString += "large\n"; }

            rtbDisplay.Text = formattedString;
        } // End btnDisplayInfo_Click()

        private void chkLightSwitch_Checked(object sender, RoutedEventArgs e)
        {

            byte r = 0;
            byte g = 0;
            byte b = 0;
            bool isOn = chkLightSwitch.IsChecked.Value;

            if(isOn)
            {
                SwapColors();
            }
            else
            {
                canvasLight.Background = new SolidColorBrush(Colors.DarkGray);
            }

    
        } // chkLightSwitch

        public void SwapColors()
        {
            if(chkLightSwitch.IsChecked.Value)
            {
                Color selectedColor = Colors.White;
                if (rbPurple.IsChecked.Value) selectedColor = Colors.Purple;
                else if (rbOrange.IsChecked.Value) selectedColor = Colors.Orange;
                else if (rbGreen1.IsChecked.Value) selectedColor = Colors.Green;
                else if (rbWhite.IsChecked.Value) selectedColor = Colors.WhiteSmoke;
                else if (rbBlack.IsChecked.Value) selectedColor = Colors.Black;
                else selectedColor = Colors.Yellow;

                canvasLight.Background = new SolidColorBrush(selectedColor);
            }

        }

        private void rbChangeColor_Click(object sender, RoutedEventArgs e)
        {
            SwapColors();
        }
    } // class

} // namespace
