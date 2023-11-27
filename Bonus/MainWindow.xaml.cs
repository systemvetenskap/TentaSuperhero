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

namespace Bonus
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // 67171
            int power = GetSuperheroSuperPowerByLevel(6);
            power = GetSuperheroSuperPowerByLevel(1);
            power = GetSuperheroSuperPowerByLevel(2);
            power = GetSuperheroSuperPowerByLevel(3);
            power = GetSuperheroSuperPowerByLevel(4);
        }

        private int GetSuperheroSuperPowerByLevel(int level)
        {
            string powerbank = "123456";
            double superPower = 0;
            foreach (char digit in powerbank)
            {
                double value = char.GetNumericValue(digit);
                superPower += Math.Pow(value, level);
            }
            return (int)superPower;
        }
    }
}
