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
using Microsoft.Win32;
using System.IO;

namespace WpfTextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // We access the fonts (.ttf) files avalible on the computer located in the windows folder
            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            
            // We create a list and fill it with values for font sizes
            cmbFontSize.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 28, 36, 48, 72 };
        }

        // What happens when we select text i our Rich Text Box
        private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            // Create a temp object which will hold our values for if the button is pressed and what will happen.
            object temp = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));
            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
            temp = rtbEditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(TextDecorations.Underline));

            // What happens when we change font family or font size
            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;
            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontSizeProperty);
            cmbFontSize.SelectedItem = temp;
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // We create a Open Filer Dialog window
            OpenFileDialog openFile = new OpenFileDialog();

            // We create a filter which will show different kinds of files
            openFile.Filter = "Rich Text Format (*.rtf)|*.rft|All Files (*.*)|*.*";

            // What happens when we show the window
            if (openFile.ShowDialog() == true)
            {
                // Create a File Stream to open and import the text contained in the document.
                FileStream fileStream = new FileStream(openFile.FileName, FileMode.Open);
                TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
            }
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // We create a save file dialog variable
            SaveFileDialog saveFile = new SaveFileDialog();

            // We crete a filter to sort out all .rtf files
            saveFile.Filter = "Rich Text Format (*.rtf)|(*.rtf)|All Files (*.*)|*.*";

            // Check if we show the dialog window
            if (saveFile.ShowDialog() == true)
            {
                // Create a file stream to save and export the text contained in the document
                FileStream fileStream = new FileStream(saveFile.FileName, FileMode.Create);
                TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
            }
        }

        private void cmbFontFamily_SelectedChanged(object sender, SelectionChangedEventArgs e)
        {
            // First we check if the font menu has an assigned value
            if (cmbFontFamily.SelectedItem != null)
            { 
                // And then we change the selected text to our new font
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem); 
            }
        }

        private void cmbFontSize_TextChange(object sender, TextChangedEventArgs e)
        {
            // Here we apply the font size change to our selected text
            rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, cmbFontSize.Text);
        }
    }
}
