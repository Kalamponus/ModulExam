﻿using System;
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

namespace ModulExam.Pages
{
    /// <summary>
    /// Логика взаимодействия для CartPage.xaml
    /// </summary>
    public partial class CartPage : Page
    {
        List<Books> cartBooks;
        public CartPage(List<Books> selectedBooks)
        {
            InitializeComponent();
            cartBooks = new List<Books>();
            bookList.ItemsSource = selectedBooks;
            cbPlaces.ItemsSource = DBConnect.bookEntities.DeliveryPlaces.ToList();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
