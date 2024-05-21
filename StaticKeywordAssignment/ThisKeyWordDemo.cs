using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordAssignment
{
     public class ThisKeyWordDemo
    {
        private string title;
        private string author;
        private int year;

        public ThisKeyWordDemo(string title, string author, int year)
        {
            this.title = title; 
            this.author = author; 
            this.year = year; 
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Author: " + this.author); 
            Console.WriteLine("Year: " + this.year); 
        }

        public void SetTitle(string title)
        {
            this.title = title; 
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }

        public void SetYear(int year)
        {
            this.year = year; 
        }

    }
}
