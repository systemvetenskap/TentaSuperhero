﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace SuperHeroes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HeadQuarters hq = new HeadQuarters();
            int distance = hq.CalculateTotalDistance(1234);
            int distance2 = hq.CalculateTotalDistance(5366);
            Hero hero;
            hero = hq.GetNearestHero(1234);

            hq.GetEncryptedMessage("Erik");
        }
    }
}
