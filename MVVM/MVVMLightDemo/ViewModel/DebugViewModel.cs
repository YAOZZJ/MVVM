using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLightDemo.ViewModel
{
   public class DebugViewModel
    {
        public List<Book> Books { get; set; }
        public string Test1 { get => test1; set => test1 = value; }

        private string test1 = "fdfdasfd";
        //public ObservableCollection<Book> Books = new ObservableCollection<Book>();
        public DebugViewModel()
        {
            Test1 = "啦啦啦";
            //ObservableCollection<Member> Items1 = new ObservableCollection<Member>();
            //this.Books = new ObservableCollection<Book>
            this.Books = new List<Book>
            {
                new Book { Author = "Peter", ISBN = "0001", Price = 39.9, Publisher = "Pearsong", Title = "Up in the air" },
                new Book { Author = "John", ISBN = "0002", Price = 29.9, Publisher = "Longmon", Title = "101 tips to write a letter" },
                new Book { Author = "Ross", ISBN = "0003", Price = 49.9, Publisher = "Tree", Title = "How to become a programmer" },
                new Book { Author = "Monica", ISBN = "0004", Price = 23.6, Publisher = "People's pub", Title = "c# for all" },
                new Book { Author = "Bill", ISBN = "0005", Price = 37.5, Publisher = "Computer House", Title = "VB dummy" },
                new Book { Author = "Jil", ISBN = "0005", Price = 18.3, Publisher = "Redist", Title = "Health care for children" }
            };
        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
    }
}
