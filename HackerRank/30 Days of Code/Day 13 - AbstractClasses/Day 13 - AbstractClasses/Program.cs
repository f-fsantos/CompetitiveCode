using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13___AbstractClasses {
    class Program {
        static void Main(string[] args) {
        }
    }
    abstract class Book {

        protected String title;
        protected String author;

        public Book(String t, String a) {
            title = t;
            author = a;
        }
        public abstract void display();
    }
    class MyBook : Book {
        private int price;
        public MyBook(string title,  string author, int price) : base(title, author) {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public override void display() {
            Console.WriteLine($"Title: {this.title}");
            Console.WriteLine($"Author: {this.author}");
            Console.WriteLine($"Price: {this.price}");
        }
    }
}
