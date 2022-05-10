using BookSpot.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BookSpot.ViewModel
{
    public class DetailsViewModel : BaseViewModel
    {
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

        private int position;
        public int Position
        {
            get
            {
                if (position != books.IndexOf(selectedBook))
                    return books.IndexOf(selectedBook);

                return position;
            }
            set
            {
                position = value;
                selectedBook = books[position];

                OnPropertyChanged();
                OnPropertyChanged(nameof(SelectedBook));
            }
        }

        public ICommand ChangePositionCommand => new Command(ChangePosition);

        private void ChangePosition(object obj)
        {
            string direction = (string)obj;

            if (direction == "L")
            {
                if (position == 0)
                {
                    Position = books.Count - 1;
                    return;
                }

                Position -= 1;
            }
            else if (direction == "R")
            {
                if (position == books.Count - 1)
                {
                    Position = 0;
                    return;
                }

                Position += 1;
            }

        }

    }
}
