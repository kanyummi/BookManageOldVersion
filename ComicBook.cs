using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class ComicBook : Book
    {
        private int chapters;

        public ComicBook()
        {

        }
        public ComicBook(string title, string authorsName, int chapters, int year) : base(title, authorsName, year)
        {
            this.chapters = chapters;
        }

        public int Chapters
        {
            get { return chapters; }
            set { chapters = value;  }
        }

        public override void inputBook()
        {
            Console.Clear();
            Console.WriteLine("\n\t================= COMIC BOOK INPUT =================\n");
            Console.Write("\n\tInput the title of your comic: ");
            title = Console.ReadLine();
            Console.Write("\n\tInput author's name : ");
            authorsName = Console.ReadLine();
            Console.Write("\n\tInput a number of chapters: ");
            chapters = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tInput year: ");
            year = Convert.ToInt32(Console.ReadLine());

        }

        public override void printBook()
        {
            //Console.Clear();
            Console.WriteLine(string.Format("\n\t{0, -23}  |  {1, -29}  |  {2, -20}  |  {3, -5}", title, authorsName, chapters, year));
            Console.WriteLine("_______________________________________________________________________________________________________________________");
        }

        public override string ToString()
        {
            return "\n\tTitle: " + this.title + "   |      " + "Author: " + this.authorsName + "   |      " + "Chapters: " + this.chapters + "   |       " + "Year: " + this.year;
        }

        public override void updateBook()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\t============== UPDATE COMIC BOOK ===============\n\t");
                Console.WriteLine("\n\t1. UPDATE TITLE. \n");
                Console.WriteLine("\n\t2. UPDATE AUTHOR. \n");
                Console.WriteLine("\n\t3. UPDATE CHAPTERS. \n");
                Console.WriteLine("\n\t4. UPADTE YEAR. \n");
                Console.WriteLine("\n\t0. EXIT. \n");
                Console.WriteLine("\n\t================================================\n");
                Console.Write("\n\tPlease choose an option: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("\n\tInput a new title:  ");
                        title = Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("\n\tInput a new subject:  ");
                        authorsName = Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("\n\tInput new chapters:  ");
                        chapters = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("\n\tInput a new year:  ");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        break;
                }
            } while (choice != 0);

        }
    }
}
