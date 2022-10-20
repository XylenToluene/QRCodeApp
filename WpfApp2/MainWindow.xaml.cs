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

namespace QRCodeApp
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

        private void BtGenerate_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string s = random.Next(10000000, 99999999).ToString();
            s+= random.Next(10000,99999).ToString();
            CodeTxtB.Text = s;
            CodeStP.Children.Clear();
            for(int i = 0; i <= 20 ; i++)
            {
                CodeStP.Children.Add(GetLines(i));
            }
        }

        private void BtGenerateWithCode_Click(object sender, RoutedEventArgs e)
        {
            if (TxtBForCode.Text.Length != 13 || String.IsNullOrWhiteSpace(TxtBForCode.Text))
            {
                MessageBox.Show("Цифр должно быть 13");
                return;
            }
            CodeStP.Children.Clear();
            for (int i = 0; i <= 20; i++)
            {
                CodeStP.Children.Add(GetLines(i));
            }
            CodeTxtB.Text = TxtBForCode.Text;
        }

        private Line GetLines(int count)
        {
            Random random = new Random();
            var line = new Line();

            line.X1 = count * 6;
            line.Y1 = 0;
            line.X2 = count * 6;
            line.Y2 = 100;
            line.StrokeThickness = random.Next(1,5);
            line.Stroke = Brushes.Black;
            return line;
        }

    }
}
