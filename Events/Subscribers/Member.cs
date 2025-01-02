using Events.EventHandlers;
using Events.Models;

namespace Events.Subscribers
{
    internal class Member
    {
        private static List<Book> books = new List<Book>();
        public void OnBookArrived(object sender, NewBookArrivalEventArgs e)
        {
            books.Add(new Book { BookId = books.Count + 1, Title = e.Title, Author = e.Author });
            //Console.WriteLine($"New book arrived: {e.Title} by {e.Author}");
        }

        public void OnBookRemoved(object sender, ExistingBookRemovalEventArgs e)
        {
            var book = books.FirstOrDefault(b => b.BookId == e.BookId);
            if (book != null)
            {
                books.Remove(book);
                Console.WriteLine($"Book removed: {book.Title}");
            }
        }

        public void OnFindExistingBook(object sender, FindExistingBookEventArgs e)
        {
            var book = books.FirstOrDefault(b => b.BookId == e.BookId);
            if (book != null)
            {
                Console.WriteLine($"Book found: {book.Title}");
            }
        }

        public void OnDisplayAllBooks(object sender, EventArgs e)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Book found: {book.Title}");
            }
        }
    }
}
