using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Member
    {
        private string memberName;
        private int memberAge;
        private string bookBorrowed;
        
        public Member()
        {

        }
        public Member(string memberName, int memberAge, string bookBorrowed)
        {
            this.memberName = memberName;
            this.memberAge = memberAge;
            this.bookBorrowed = bookBorrowed;
        }

        public string MemberName
        {
            get { return memberName;  }
            set { memberName = value;  }
        }
        public int MemberAge
        {
            get { return memberAge; }
            set { memberAge = value; }
        }
        public string BookBorrowed
        {
            get { return bookBorrowed; }
            set { bookBorrowed = value; }
        }

        public void inputMember()
        {
            Console.Clear();
            Console.WriteLine("\n\t================= MEMBER INPUT =================\n");
            Console.Write("\n\tInput member's name: ");
            memberName = Console.ReadLine();
            do
            {
                Console.Write("\n\tInput member's age : ");
                memberAge = int.Parse(Console.ReadLine());
                if(memberAge <= 0 || memberAge >= 150)
                {
                    Console.WriteLine("\nInvalid input. Please input again. ");
                    Console.ReadKey();
                }
            } while (memberAge <= 0 || memberAge >= 150);
            
            Console.Write("\n\tInput a book to borrow: ");
            bookBorrowed = Console.ReadLine();

        }

        public void outputMember()
        {
            Console.WriteLine(string.Format("\n\t{0, -22}  |  {1, -12}  |  {2, -20}", memberName, memberAge, bookBorrowed));
            Console.WriteLine("_______________________________________________________________________________________________________________________");
        }

        public override string ToString()
        {
            return "\n\tMember's name: " + this.memberName + " |      " + "Age: " + this.memberAge + "  |      " + "Book has borrow: " + this.bookBorrowed;
        }

        public void updateMember()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\t============== UPDATE MEMBER ===============\n\t");
                Console.WriteLine("\n\t1. UPDATE MEMBER NAME. \n");
                Console.WriteLine("\n\t2. UPDATE MEMBER AGE. \n");
                Console.WriteLine("\n\t3. UPDATE BOOK HAS BORROWED. \n");
                Console.WriteLine("\n\t0. EXIT. \n");
                Console.WriteLine("\n\t================================================\n");
                Console.Write("\n\tPlease choose an option: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("\n\tInput a new member name:  ");
                        memberName = Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("\n\tInput a new member age:  ");
                        memberAge = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("\n\tInput a new book has been borrowed:  ");
                        bookBorrowed = Console.ReadLine();
                        break;
                    default:
                        break;
                }
            } while (choice != 0);

        }

    }
}
