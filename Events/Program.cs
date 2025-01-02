using Events.Publishers;
using Events.Subscribers;

Library library = new Library();
Member member = new Member();
library.OnNewBookArrival += member.OnBookArrived;
library.AddNewBook("The Fellowship of the Ring", "J.R.R. Tolkien");
library.OnNewBookArrival -= member.OnBookArrived;

library.OnFindingExistingBook += member.OnFindExistingBook;
library.FindExistingBook(1);
library.OnFindingExistingBook -= member.OnFindExistingBook;

library.OnExistingBookRemoval += member.OnBookRemoved;
library.ExistingBookRemoval(1);
library.OnExistingBookRemoval -= member.OnBookRemoved;

library.OnDiaplayingAllBooks += member.OnDisplayAllBooks;
library.DisplayAllBooks();
library.OnDiaplayingAllBooks -= member.OnDisplayAllBooks;