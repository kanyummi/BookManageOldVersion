using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    internal class BookList : IBookManagementSystem
    {
        private ArrayList bookList;

            
        // ArrayList bookList = new ArrayList();

        public BookList()
        {
            bookList = new ArrayList();
        }

        public class myComparer : IComparer
        {
            int IComparer.Compare(Object xx, Object yy)
            {
                Book x = (Book)xx;
                Book y = (Book)yy;

                //sort by title
                return x.Title.CompareTo(y.Title);
            }

        }

        public void addComicBook()
        {
            // Polymorphism -> Overriding 
            Book x = new ComicBook();
            x.inputBook();
            bookList.Add(x);
        }
        public void addMaterial()
        {
            // Polymorphism -> Overriding
            Book y = new Material();
            y.inputBook();
            bookList.Add(y);
        }

        public void inputBookList()
        {
  
            int options;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\t1. INPUT COMIC.");
                Console.WriteLine("\n\t2. INPUT MATERIAL.");
                Console.WriteLine("\n\t========================================================\n\t");
                Console.Write("\n\tChoose your option: ");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        addComicBook();
                        break;
                    case 2:
                        addMaterial();
                        break;
                    default:
                        break;
                }
                if(options != 1 && options != 2)
                {
                    Console.WriteLine("\nInvalid input. Please input again ");
                    Console.ReadKey();
                }
            } while (options != 1 && options != 2);
        }
        public void outputComic()
        {
            foreach (Book b in bookList)
            {
                if(b is ComicBook bookList)
                {
                    b.printBook();
                }
            }
        }

        public void outputMaterial()
        {
            foreach (Book b in bookList)
            {
                if (b is Material bookList)
                {
                    b.printBook();
                }
            }
        }
        public void printBookList()
        {

            int options;
            do {
                Console.Clear();
                Console.WriteLine("\n\t1. PRINT COMIC BOOK.");
                Console.WriteLine("\n\t2. PRINT MATERIAL.");
                Console.WriteLine("\n\t========================================================\n\t");
                Console.Write("\n\tChoose your option: ");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n\t\t\t========================  COMIC BOOK OUTPUT ===========================\n");
                        Console.WriteLine(string.Format("\n\tTITLE                    |  AUTHOR'S NAME                  |  CHAPTERS              |  YEAR          "));
                        Console.WriteLine("_______________________________________________________________________________________________________________________");
                        outputComic();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n\t\t\t========================== MATERIAL OUTPUT ============================\n");
                        Console.WriteLine(string.Format("\n\tTITLE                     |  SUBJECT                         |  AUTHOR'S NAME         |  YEAR         "));
                        Console.WriteLine("_______________________________________________________________________________________________________________________");
                        outputMaterial();
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }
                if (options != 1 && options != 2)
                {
                    Console.WriteLine("\nInvalid input. Please input again ");
                    Console.ReadKey();
                }
            } while (options != 1 && options != 2);
        }
        public void searchBookList()
        {
            string bookTitle;
            // ĐẶT CỜ HIỆU KIỂM TRA
            bool flag = false;
            Console.Clear();
            Console.WriteLine("\n\t=============== SEARCH BOOK ==============\n");
            Console.Write("\n\tENTER A BOOK TO SEACH: ");
            bookTitle = Console.ReadLine();
            foreach (Book b in bookList)
            {
                if(b.Title == bookTitle)
                {
                    Console.WriteLine(b.ToString());
                    flag = true;
                    break;
                }
            }
            if(flag == true)
            {

                Console.WriteLine("\n\t THIS BOOK HAS BEEN FOUND IN THE LIST !!!\n");
            } else
            {
                Console.WriteLine("\n\t THIS BOOK HAS NOT BEEN FOUND IN THE LIST !!!\n");
            }
            Console.ReadKey();
        }


        public void sortBookList()
        {
            bookList.Sort(new myComparer());
        }

        public void deleteBook()
        {
            string bookName;
            bool flag = false;  // ĐẶT CỜ HIỆU
            Console.Clear();
            Console.WriteLine("\n\t============== DELETE BOOK ===============\n\t");
            Console.Write("\n\tENTER A BOOK TO DELETE: ");
            bookName = Console.ReadLine();
            ArrayList bookTempo = new ArrayList();

            bookTempo = (ArrayList)bookList.Clone();
            foreach (Book b in bookTempo)
            {
                if(b.Title == bookName)
                {
                    bookList.Remove(b);
                    flag = true;
                    break;
                }
            }
            if (flag == true)
                Console.WriteLine("\n\tDELETE SUCESSFULLY !");
            else
                Console.WriteLine("\n\tCANNOT FIND A BOOK TO DELETE !");

            Console.ReadKey();
        }

        public void updateBookList()
        {
            string bookTitle;
            bool flag = false;
            Console.Clear();
            Console.WriteLine("\n\t=============== SEARCH BOOK ==============\n");
            Console.Write("\n\tENTER A BOOK TO UPDATE: ");
            bookTitle = Console.ReadLine();
            foreach (Book b in bookList)
            {
                if(b.Title == bookTitle)
                {
                    if(b is ComicBook bookComic)
                    {
                        b.updateBook();
                        flag = true;
                        break;
                    } else if(b is Material bookMaterial)
                    {
                        b.updateBook();
                        flag = true;
                        break;
                    }
                }
            }
            if (flag == true)
                Console.WriteLine("\n\tUPDATE SUCESSFULLY !");
            else
                Console.WriteLine("\n\tCANNOT FIND A BOOK TO UPDATE !");

            Console.ReadKey();

        }

        
    }

}
