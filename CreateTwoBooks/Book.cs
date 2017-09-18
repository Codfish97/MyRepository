using System;

namespace CreateTwoBooks
{
    class Book
    {
        private string title;
        private int numPages;
        private double price;
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public void AdvertisingMessage()
        {
            Console.WriteLine("Buy it now: {0}", this.Title);
        }
    }
}
