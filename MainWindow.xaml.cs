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

namespace ISRPO_Palashicheva_PR4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int R;
        int k;
        int i;

        private void py_Click(object sender, RoutedEventArgs e)
        {

             k = Int32.Parse(tb.Text);

            
                if (k == i)
                {
                    lb.Content = "Угадал";
                   
                }
                else if (k > i)
                {
                    lb.Content = "Меньше";
                   
                }
                else
                {
                    lb.Content = "Больше";
                   
                }


            
        }

        private void randok_Click(object sender, RoutedEventArgs e)
        {
            R = Int32.Parse(tbRAND.Text);
            Random rand = new Random();
            i = rand.Next(0, R);
        }
    }
}
