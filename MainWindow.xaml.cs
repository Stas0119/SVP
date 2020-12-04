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
using Lib;
namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double chislo = double.Parse(Text1.Text.Replace(".",","));
            double stepen = double.Parse(Text2.Text.Replace(".", ","));
            double result = Lib.Lib.multiplication(chislo, stepen);
            Text3.Text = $"{result}";
        }

  

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Text2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
