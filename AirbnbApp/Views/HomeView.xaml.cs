﻿using AirbnbApp.ViewModels;
using Models;
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
using System.Windows.Shapes;

namespace AirbnbApp.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : Window
    {
        public HomeView(Publication publication, Account account)
        {
            InitializeComponent();
            DataContext = new HomeViewVM(publication, account);
        }
    }
}