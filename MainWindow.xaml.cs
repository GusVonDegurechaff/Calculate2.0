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

namespace calculate2._0
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x = double.Parse(txtX.Text);
            double b = double.Parse(txtb.Text);
            double s;
            lstResult.Items.Add("Лаб.раб.№2. Выполнил Smirnov Y.A.");
            lstResult.Items.Add($"X={x}");
            lstResult.Items.Add($"Y={b}");
            int n = 0;
            if (rbtCos.IsChecked == true) n = 1;
            else if (rbtExp.IsChecked == true) n = 2;
            switch (n)
            {
                case 0:
                    if (1 < x * b && x * b < 10) s = Math.Exp(Math.Sin(x));
                    else if (12 < x * b && x * b < 40) s = Math.Sqrt(Math.Abs(Math.Sin(x) + 4 * b));
                    else s = b * Math.Pow(Math.Sin(x), 2);
                    lstResult.Items.Add($"Результат S={Math.Round(s, 3)}");
                    break;
                case 1:
                    if (1 < x * b && x * b < 10) s = Math.Exp(Math.Cos(x));
                    else if (12 < x * b && x * b < 40) s = Math.Sqrt(Math.Abs(Math.Cos(x) + 4 * b));
                    else s = b * Math.Pow(Math.Cos(x), 2);
                    lstResult.Items.Add($"Результат S={Math.Round(s, 3)}");
                    break;
                case 2:
                    if (1 < x * b && x * b < 10) s = Math.Exp(Math.Exp(x));
                    else if (12 < x * b && x * b < 40) s = Math.Sqrt(Math.Abs(Math.Exp(x) + 4 * b));
                    else s = b * Math.Pow(Math.Exp(x), 2);
                    lstResult.Items.Add($"Результат S={Math.Round(s, 3)}");
                    break;
                default:
                    lstResult.Items.Add("Решение не найдено");
                    break;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtb.Clear();
            lstResult.Items.Clear();
        }
    }
}