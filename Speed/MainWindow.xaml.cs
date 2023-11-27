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

namespace Speed
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
            // formel
            // s = vt;
            double speedOfLight = 1224;
            double earth = 40075;
            int hours = 10; // ska hämtas från gränssnittet
            double flashFactor = 11.5;
            double distanceFlash = speedOfLight * hours * flashFactor;

            double roundFlash = Math.Floor( distanceFlash / earth);
        }
    }
}
