using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR21_101_Ivanchikov_1
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

        private void checkBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal number = decimal.Parse(Num.Text);
                if (Num.Text.Length !=12)
                {
                    MessageBox.Show("Введенно число не с 12 символами", "Error");
                }
                else
                {
                    decimal sum = 0;
                    decimal mult = 1;
                    for (int i = 0;i<9;i++)
                    {
                        sum += number % 10;
                        number =(Math.Truncate(number / 10));
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        mult *= number % 10;
                        number = (Math.Truncate(number / 10));
                    }
                    if (sum == mult)
                    {
                        MessageBox.Show("Произведение первых трёх цифр равно сумме девяти последих", "Succsses");
                    }
                    else
                    {
                        MessageBox.Show("Произведение первых трёх цифр неравно сумме девяти последих", "Fault");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка преобразования данных", "Error");
            }
        }
    }
}
