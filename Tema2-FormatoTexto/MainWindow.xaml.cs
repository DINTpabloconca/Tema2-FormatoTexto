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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            azulRadioButton.IsChecked = true;
        }

        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            resultadoTextBlock.Text = inputTextBox.Text;
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (negritaCheckBox.IsChecked == true)
            {
                resultadoTextBlock.FontWeight = FontWeights.Bold;
            }
            if (negritaCheckBox.IsChecked == false)
            {
                resultadoTextBlock.FontWeight = FontWeights.Normal;
            }
        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (cursivaCheckBox.IsChecked == true)
            {
                resultadoTextBlock.FontStyle = FontStyles.Italic;
            }
            if (cursivaCheckBox.IsChecked == false)
            {
                resultadoTextBlock.FontStyle = FontStyles.Normal;
            }
        }

        private void azulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (azulRadioButton.IsChecked == true)
            {
                resultadoTextBlock.Foreground = Brushes.Blue;
            }
        }

        private void rojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (rojoRadioButton.IsChecked == true)
            {
                resultadoTextBlock.Foreground = Brushes.Red;
            }
        }

        private void verdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (verdeRadioButton.IsChecked == true)
            {
                resultadoTextBlock.Foreground = Brushes.Green;
            }
        }
    }
}
