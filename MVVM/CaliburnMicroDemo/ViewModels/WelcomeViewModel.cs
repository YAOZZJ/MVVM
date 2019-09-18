using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CaliburnMicroDemo.ViewModels
{
    public class WelcomeViewModel : PropertyChangedBase
    {
        public WelcomeViewModel()
        {
            _instruction = "YAOZHIJIAN";
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
        private string _instruction;
        public List<Book> Books { get; set; }
        /// <summary>
        /// 对应View:x:Name="XXXX"
        /// </summary>
        public string TxtInstruction
        {
            get { return _instruction; }
            set
            {
                _instruction = value;
                NotifyOfPropertyChange(()=> TxtInstruction);
                NotifyOfPropertyChange(() => CanBtnClickMe);
            }
        }
        /// <summary>
        /// 关联到方法BtnClickMe的可用性
        /// </summary>
        public bool CanBtnClickMe
        {
            get { return !string.IsNullOrWhiteSpace(TxtInstruction); }
        }
        /// <summary>
        /// 对应VIew的Button :x:Name="XXXX"
        /// </summary>
        public void BtnClickMe()
        {
            MessageBox.Show($"Hello {TxtInstruction}");
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
