using BookSpot.Model;
using BookSpot.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookSpot.ViewModel
{
    public class LandingViewModel : BaseViewModel
    {
        public LandingViewModel()
        {
            books = GetBooks();
        }

        ObservableCollection<Book> books;
        public ObservableCollection<Book> Books
        {
            get { return books; }
            set
            {
                books = value;
                OnPropertyChanged();
            }
        }

        private Book selectedBook;
        public Book SelectedBook
        {
            get { return selectedBook; }
            set
            {
                selectedBook = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectionCommand => new Command(DisplayBook);

        private void DisplayBook()
        {
            if (selectedBook != null)
            {
                var viewModel = new DetailsViewModel { SelectedBook = selectedBook, Books = books, Position = books.IndexOf(selectedBook) };
                var detailsPage = new DetailsPage { BindingContext = viewModel };

                var navigation = Application.Current.MainPage as NavigationPage;
                navigation.PushAsync(detailsPage, true);
            }
        }

        private ObservableCollection<Book> GetBooks()
        {
            return new ObservableCollection<Book>
            {
                new Book { Name = "Цар Плъх", Price = 19.99f, Image = "KingRat.png", Author = "Джеймс Клавел"},
                new Book { Name = "Направени от вина", Price = 13.99f, Image = "MadeOfGuilt.png", Author = "Йоанна Елми"},
                new Book { Name = "Майка нощ", Price = 17.39f, Image = "MotherNight.png", Author = "Кърт Вонегът"},
                new Book { Name = "Автентичната котка", Price = 9.99f, Image = "TheAuthenricCat.png", Author = "Тери Пратчет"},
                new Book { Name = "Кестеновия човек", Price = 15.99f, Image = "TheChestnutMan.png", Author = "Сьорен Свайструп"},
                new Book { Name = "Танц с дракони", Price = 23.99f, Image = "DanceWithDragons.png", Author = "Джордж Р. Р. Мартин"},
                new Book { Name = "Жени под влияние", Price = 11.99f, Image = "WomenUnder.png", Author = "Мари-Франс Иригоайен"},
                new Book { Name = "Човек на име Уве", Price = 14.99f, Image = "AManNamedUve.png", Author = "Фредрик Бакман"}
            };
        }
    }
}
