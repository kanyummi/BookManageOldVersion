using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class Material : Book
    {
        private string subject;

        public Material()
        {

        }
        public Material(string title, string subject, string authorsName, int year) : base(title, authorsName, year)
        {
            this.subject = subject;
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public override void inputBook()
        {
            Console.Clear();
            Console.WriteLine("\n\t================= MATERIAL INPUT =================\n\t");
            Console.Write("\n\tInput the title of your material: ");
            title = Console.ReadLine();
            Console.Write("\n\tInput the subject: ");
            subject = Console.ReadLine();
            Console.Write("\n\tInput author's name : ");
            authorsName = Console.ReadLine();
            Console.Write("\n\tInput year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }

        public override void printBook()
        {

            Console.WriteLine(string.Format("\n\t{0, -23}   |  {1, -29}   |  {2, -20}  |  {3, -5}", title, subject, authorsName, year));
            Console.WriteLine("_______________________________________________________________________________________________________________________");
        }

        public override string ToString()
        {
            return  "\n\tTitle: " + this.title + "   |      " + "Subject: " + this.subject + "  |      " + "Author: " + this.authorsName + "   |      " + "Year: " + this.year;
        }

        public override void updateBook()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\t============== UPDATE MATERIAL ===============\n\t");
                Console.WriteLine("\n\t1. UPDATE TITLE. \n");
                Console.WriteLine("\n\t2. UPDATE SUBJECT. \n");
                Console.WriteLine("\n\t3. UPDATE AUTHOR. \n");
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
                        subject = Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("\n\tInput a new author:  ");
                        authorsName = Console.ReadLine();
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
