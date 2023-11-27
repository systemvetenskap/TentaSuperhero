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

namespace Energy
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
        private bool HasEnoughEnergy(int distance, int energyLevel, int windDirection )
        {
            if ( windDirection == 0)
            {
                return energyLevel >= distance;
            }
            else if ( windDirection < 0)
            {
                return energyLevel >= distance * 1.5;
            }
            else
            {
                return energyLevel >= distance * 0.8;
            }
            switch ( windDirection )
            {
                case 0:
                    break;
                case -1:
                    break;
                case 1:
                   break;
            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
