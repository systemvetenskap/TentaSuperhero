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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Stones
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
            string[] infinityStones = { "Space stone", "Mind stone", "Reality stone","Time stone", "Power stone", "Soul stone" };
            string[] stones = {"Back stone", "Order stone", "Suit stone", "Research stone", "Remark stone", "Reality stone", "Tremble stone","Release stone", "Weaken stone", "Lock stone", "Import stone", "View stone", "Judge stone", "Soul stone", "Sort stone", "Gather stone", "Operate stone", "Involve stone", "Fail stone", "Rate stone", "Shake stone", "Burst stone", "Deposit stone","Enable stone"};

            // loopar
            // ska jag påverka listan på något sätt?
            // nej bara kika

            // foreach
            int count = 0;
            foreach (string infinity in stones)
            {
                foreach (string stone in infinityStones)
                {
                    if(stone == infinity)
                    {
                        count++;
                    }
                }
            }
        }
    }
}
