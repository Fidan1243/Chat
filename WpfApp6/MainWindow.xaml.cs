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

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Answers s = new Answers();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, RoutedEventArgs e)
        {
            Button bt = new Button();
            bt.Content = tb1.Text;
            bt.BorderThickness = new Thickness(0);
            bt.Width = 200;
            bt.Background = Brushes.Azure;
            HorizontalAlignment = HorizontalAlignment.Right;
            bt.IsEnabled = false;
            lb.Items.Add(bt);
            lb2.Items.Add(" ");
            if (tb1.Text == "salam" || tb1.Text == "slm" || tb1.Text == "Salam" || tb1.Text == "salamun aleykum")
            {
                string a = s.Answer("salam");
                Button bt2 = new Button();
                bt2.Content = a;
                bt2.BorderThickness = new Thickness(0);
                bt2.Width = 200;
                bt2.IsEnabled = false;
                bt2.Background = Brushes.Azure;
                HorizontalAlignment = HorizontalAlignment.Right;
                lb2.Items.Add(bt2);
            }
            else if(tb1.Text == "necesen" || tb1.Text == "necesen?" || tb1.Text == "Necesen" || tb1.Text == "Necesen?")
            {
                string a = s.Answer("necesen");
                Button bt2 = new Button();
                bt2.Content = a;
                bt2.BorderThickness = new Thickness(0);
                bt2.Width = 200;
                bt2.IsEnabled = false;
                bt2.Background = Brushes.Azure;
                HorizontalAlignment = HorizontalAlignment.Right;
                lb2.Items.Add(bt2);
            }
            else if (tb1.Text == "Ne var ne yox" || tb1.Text == "ne var ne yox?" || tb1.Text == "ne var ne yox" || tb1.Text == "Ne is gorursen"
                || tb1.Text == "Ne is gorursen?" || tb1.Text == "ne is gorursen" || tb1.Text == "ne is gorursen?")
            {
                string a = s.Answer("ne is gorursen?");
                Button bt2 = new Button();
                bt2.Content = a;
                bt2.BorderThickness = new Thickness(0);
                bt2.Width = 200;
                bt2.IsEnabled = false;
                bt2.Background = Brushes.Azure;
                HorizontalAlignment = HorizontalAlignment.Right;
                lb2.Items.Add(bt2);
            }
            else
            {
                string a = s.Answer("bla bla");
                Button bt2 = new Button();
                bt2.Content = a;
                bt2.BorderThickness = new Thickness(0);
                bt2.Width = 200;
                bt2.IsEnabled = false;
                bt2.Background = Brushes.Azure;
                HorizontalAlignment = HorizontalAlignment.Right;
                lb2.Items.Add(bt2);
            }
            lb.Items.Add(" ");
        }
    }
}
