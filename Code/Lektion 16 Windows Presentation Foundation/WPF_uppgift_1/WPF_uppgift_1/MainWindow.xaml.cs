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

namespace WPF_uppgift_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float fValue1 = 0.0f;
        float fValue2 = 0.0f;
        float fResult = 0.0f;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            fValue1 = float.Parse(tbValue1.Text);
            fValue2 = float.Parse(tbValue2.Text);
            fResult = fValue1 + fValue2;
            tbResult.Text = fResult.ToString();
        }

        private void btnSubtraction_Click(object sender, RoutedEventArgs e)
        {
            fValue1 = float.Parse(tbValue1.Text);
            fValue2 = float.Parse(tbValue2.Text);
            fResult = fValue1 - fValue2;
            tbResult.Text = fResult.ToString();
        }

        private void btnMultiplication_Click(object sender, RoutedEventArgs e)
        {
            fValue1 = float.Parse(tbValue1.Text);
            fValue2 = float.Parse(tbValue2.Text);
            fResult = fValue1 * fValue2;
            tbResult.Text = fResult.ToString();
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            fValue1 = float.Parse(tbValue1.Text);
            fValue2 = float.Parse(tbValue2.Text);
            fResult = fValue1 / fValue2;
            tbResult.Text = fResult.ToString();
        }

        private void btnModulus_Click(object sender, RoutedEventArgs e)
        {
            fValue1 = float.Parse(tbValue1.Text);
            fValue2 = float.Parse(tbValue2.Text);
            fResult = fValue1 % fValue2;
            tbResult.Text = fResult.ToString();
        }
    }
}
