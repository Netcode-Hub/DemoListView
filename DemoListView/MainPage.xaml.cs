using System.Collections.ObjectModel;

namespace DemoListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
        //Model - class
        public class BookInfo
        {
            public string BookName { get; set; }
            public string BookDescription { get; set; }
            public string BookImage { get; set; }
        }

        // Repository
        public class BookInfoRepository
        {
            public BookInfoRepository()
            {

            }

            internal ObservableCollection<BookInfo> GetBookList()
            {
                var bookInfo = new ObservableCollection<BookInfo>();

                bookInfo.Add(new BookInfo() { BookName = "Object-Oriented Programming in C#", BookDescription = "Object-oriented programming is a programming paradigm based on the concept of objects", BookImage = "bookone.jpg" });
                bookInfo.Add(new BookInfo() { BookName = "C# Code Contracts", BookDescription = "Code Contracts provide a way to convey code assumptions", BookImage = "booktwo.jpg" });
                bookInfo.Add(new BookInfo() { BookName = "Machine Learning Using C#", BookDescription = "You will learn several different approaches to applying machine learning", BookImage = "bookthree.jpg" });
                bookInfo.Add(new BookInfo() { BookName = "Neural Networks Using C#", BookDescription = "Neural networks are an exciting field of software development", BookImage = "bookfour.jpg" });
                bookInfo.Add(new BookInfo() { BookName = "Visual Studio Code", BookDescription = "It is a powerful tool for editing code and serves for end-to-end programming", BookImage = "bookfive.jpg" });
                bookInfo.Add(new BookInfo() { BookName = "Android Programming", BookDescription = "It provides a useful overview of the Android application life cycle", BookImage = "booksix.jpg" });
                bookInfo.Add(new BookInfo() { BookName = "iOS Succinctly", BookDescription = "It is for developers looking to step into frightening world of iPhone", BookImage = "bookseven.jpg" });
                bookInfo.Add(new BookInfo() { BookName = "Visual Studio 2015", BookDescription = "The new version of the widely-used integrated development environment", BookImage = "bookeight.jpg" });
                bookInfo.Add(new BookInfo() { BookName = "Xamarin.Forms", BookDescription = "It creates mappings from its C# classes and controls directly", BookImage = "booknine.jpg" }); ;
                bookInfo.Add(new BookInfo() { BookName = "Windows Store Apps", BookDescription = "Windows Store apps present a radical shift in Windows development", BookImage = "booktwo.jpg" });

                return bookInfo;
            }
        }

        // Viewmodel
        public class BookInfoViewModel
        {
            public ObservableCollection<BookInfo> MyBooks { get; set; } = new();
            public BookInfoViewModel()
            {
                LoadBooks();
            }

            private void LoadBooks()
            {
                BookInfoRepository bookInfoRepository = new BookInfoRepository();
                var response = bookInfoRepository.GetBookList();
                if (response is null)
                    return;

                if (MyBooks.Count > 0)
                    MyBooks.Clear();

                foreach (var book in response)
                    MyBooks.Add(book);

            }
        }
    }