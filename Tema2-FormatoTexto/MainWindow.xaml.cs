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
        }

        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            inputTextBox.Text = resultadoTextBlock.Text;
            if (negritaCheckBox.IsChecked == true)
            {
                resultadoTextBlock.FontWeight = FontWeights.Bold; 
            }else if (cursivaCheckBox.IsChecked == true)
            {
                resultadoTextBlock.FontStyle = FontStyles.Italic;
            }

            if (azulRadioButton.IsChecked == true)
            {
                resultadoTextBlock.Foreground = Brushes.Blue;
            }
            else if (rojoRadioButton.IsChecked == true)
            {
                resultadoTextBlock.Foreground = Brushes.Red;
            }
            else if (verdeRadioButton.IsChecked == true)
            {
                resultadoTextBlock.Foreground = Brushes.Green;
            }
        }
    }
}
