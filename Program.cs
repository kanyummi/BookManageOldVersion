using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList uBookList = new BookList();

            MemberList uMemberList = new MemberList();

            int option;

            do
            {
                Console.Clear();
                Console.WriteLine("\n\t====================== MENU ====================\n");
                Console.WriteLine("\n\t1. ADD BOOK. \n");
                Console.WriteLine("\n\t2. PRINT BOOK. \n");
                Console.WriteLine("\n\t3. MEMBER. \n");
                Console.WriteLine("\n\t4. UPDATE BOOK. \n");
                Console.WriteLine("\n\t5. SEARCH BOOK.\n");
                Console.WriteLine("\n\t6. DELETE BOOK.\n");
                Console.WriteLine("\n\t0. EXIT.\n");
                Console.WriteLine("\n\t================================================\n");
                Console.Write("\n\tPlease choose an option: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        uBookList.inputBookList();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        uBookList.printBookList();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        int choices;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t====================== MENU ====================\n");
                            Console.WriteLine("\n\t1. ADD MEMBER. \n");
                            Console.WriteLine("\n\t2. PRINT MEMBER. \n");
                            Console.WriteLine("\n\t3. UPDATE MEMBER. \n");
                            Console.WriteLine("\n\t4. SEARCH MEMBER. \n");
                            Console.WriteLine("\n\t5. DELETE MEMBER. \n");
                            Console.WriteLine("\n\t0. EXIT.\n");
                            Console.WriteLine("\n\t================================================\n");
                            Console.Write("\n\tPlease choose an option: ");
                            choices = Convert.ToInt32(Console.ReadLine());
                            switch(choices)
                            {
                                case 1:
                                    uMemberList.inputMemberList();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    uMemberList.printMemberList();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.Clear();
                                    uMemberList.updateMemberList();
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    //Console.Clear();
                                    uMemberList.searchMemberList();
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    uMemberList.deleteMemberList();
                                    break;
                                default:
                                    break;

                            }      
                        } while (choices != 0);
                        break;
                    case 4:
                        Console.Clear();
                        uBookList.updateBookList();
                        Console.ReadKey();
                        break;
                    case 5:
                        uBookList.searchBookList();
                        Console.ReadKey();
                        break;
                    case 6:
                        uBookList.deleteBook();
                        Console.ReadKey();
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            } while (option != 0);
            
            
                
        }
    }
}
