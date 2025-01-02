using Events.EventHandlers;

namespace Events.Publishers
{
    internal class Library
    {
        public EventHandler<NewBookArrivalEventArgs> OnNewBookArrival;
        public EventHandler<ExistingBookRemovalEventArgs> OnExistingBookRemoval;
        public EventHandler<FindExistingBookEventArgs> OnFindingExistingBook;
        public EventHandler OnDiaplayingAllBooks;

        public void AddNewBook(string title, string Author)
        {
            var newBook = new NewBookArrivalEventArgs { Title = title, Author = Author };
            OnNewBookArrival?.Invoke(this, newBook);
        }

        public void ExistingBookRemoval(int bookId)
        {
            var existingBook = new ExistingBookRemovalEventArgs { BookId = bookId };
            OnExistingBookRemoval?.Invoke(this, existingBook);
        }

        public void FindExistingBook(int bookId)
        {
            var existingBook = new FindExistingBookEventArgs { BookId = bookId };
            OnFindingExistingBook?.Invoke(this, existingBook);
        }

        public void DisplayAllBooks()
        {
            OnDiaplayingAllBooks?.Invoke(this, EventArgs.Empty);
        }
    }
}
