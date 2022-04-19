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
using BookDiscountLibrary;

namespace ModulExam.Pages
{
    /// <summary>
    /// Логика взаимодействия для BookPage.xaml
    /// </summary>
    public partial class BookPage : Page
    {
        List<Books> books;
        List<Books> selectedBooks;
        int selectedBooksCount = 0;
        double selectedBooksCost = 0;
        DiscountCalc calc;
        public BookPage()
        {
            InitializeComponent();
            books = new List<Books>();
            selectedBooks = new List<Books>();

            books = DBConnect.bookEntities.Books.ToList();
            BookList.ItemsSource = books;

            tbBookCount.Text = "Количество выбранных книг: 0";
            tbTotalCost.Text = "Стоимость покупки ";
            tbCutTotalCost.Text = "0 руб.";
            tbTotalDiscount.Text = "Размер скидки: 0%";            

            calc = new DiscountCalc();
        }

        private void btnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Books selectedBook;
            int id = Convert.ToInt32(btn.Uid);
            int discount = calc.Discount(selectedBooksCost, selectedBooksCount);

            selectedBook = books.Where(x => x.id == id).FirstOrDefault();
            if (selectedBooks.Contains(selectedBook))
            {               
                if(selectedBooks.Where(x => x.id == id).Count() > selectedBook.shopQuant && selectedBooks.Where(x => x.id == id).Count() > selectedBook.stockQuant)
                {
                    MessageBox.Show("На складе не имеется достаточного количества книг!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    selectedBooks.Add(selectedBook);
                    selectedBooksCount++;
                    selectedBooksCost += selectedBook.price;

                    tbBookCount.Text = "Количество выбранных книг: " + selectedBooksCount;
                    if (discount > 0)
                    {
                        tbOriginalTotalCost.Text = selectedBooksCost.ToString() + " ";
                    }

                    tbTotalDiscount.Text = "Размер скидки: " + discount + "%";
                    tbCutTotalCost.Text = (selectedBooksCost - ((selectedBooksCost / 100) * discount)).ToString() + " руб.";
                }
            }
            else if(selectedBook.stockQuant > 0 || selectedBook.stockQuant > 0)
            {
                selectedBooks.Add(selectedBook);
                selectedBooksCount++;
                selectedBooksCost += selectedBook.price;

                tbBookCount.Text = "Количество выбранных книг: " + selectedBooksCount;
                if (discount > 0)
                {
                    tbOriginalTotalCost.Text = selectedBooksCost.ToString() + " ";
                }

                tbTotalDiscount.Text = "Размер скидки: " + discount + "%";
                tbCutTotalCost.Text = (selectedBooksCost - ((selectedBooksCost / 100) * discount)).ToString() + " руб.";
            }
            else
            {
                ;
            }
        }

        private void btnToCart_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.MainFrame.Navigate(new CartPage(selectedBooks));
        }
    }
}
