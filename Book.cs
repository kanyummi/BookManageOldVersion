using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
        internal abstract class Book
        {
            protected string title;
            protected string authorsName;
            protected int year;

            public Book() { }
            public Book(string title, string authorsName, int year)
            {
                this.title = title;
                this.authorsName = authorsName;
                this.year = year;
            }

            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            public string AuThorsName
            {
                get { return authorsName; }
                set { authorsName = value; }
            }

            public int Year
            {
                get { return year; }
                set { year = value; }
            }
            public abstract void inputBook();
            public abstract void printBook();
            public abstract void updateBook();


        }  
}
