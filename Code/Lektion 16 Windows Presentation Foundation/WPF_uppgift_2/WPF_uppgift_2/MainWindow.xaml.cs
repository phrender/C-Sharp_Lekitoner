using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_uppgift_2
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

        // Create variables to hold the values of the two text boxes
        int iTextLengthOne = 0;
        int iTextLengthTwo = 0;

        private void btnCompare_Click(object sender, RoutedEventArgs e)
        {
            // Give the ints the lengths of the text
            iTextLengthOne = tbCompareBox1.Text.Length;
            iTextLengthTwo = tbCompareBox2.Text.Length;

            // Compare the texts
            if (iTextLengthOne > iTextLengthTwo)
            {
                lbResult.Content = "Text one is longer.";
            }

            else if (iTextLengthTwo > iTextLengthOne)
            {
                lbResult.Content = "Text two is longer.";
            }

            else
            {
                lbResult.Content = "Both texts are equaly long.";
            }
        }
    }
}
