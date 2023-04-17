using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class MemberList : IMember
    {
        private ArrayList memberList;

        public MemberList()
        {
            memberList = new ArrayList();
        }

        public void searchMemberList()
        {
            string memberName;
            // ĐẶT CỜ HIỆU KIỂM TRA
            bool flag = false;
            Console.Clear();
            Console.WriteLine("\n\t=============== SEARCH BOOK ==============\n");
            Console.Write("\n\tENTER A MEMBER TO SEACH: ");
            memberName = Console.ReadLine();
            foreach (Member m in memberList)
            {
                if (m.MemberName == memberName)
                {
                    Console.WriteLine(m.ToString());
                    flag = true;
                    break;
                }
            }
            if (flag == true)
            {

                Console.WriteLine("\n\t THIS MEMBER HAS BEEN FOUND IN THE LIST !!!\n");
            }
            else
            {
                Console.WriteLine("\n\t THIS MEMBER HAS NOT BEEN FOUND IN THE LIST !!!\n");
            }
            Console.ReadKey();
        }

        public void inputMemberList()
        {

            Member m = new Member();
            m.inputMember();
            memberList.Add(m);
            
        }

        public void printMemberList()
        {
            Console.WriteLine("\n\t\t\t===================== MEMBER LIST INFORMATION =======================\n");
            Console.WriteLine(string.Format("\n\tNAME                    |  AGE           |  BOOK HAS BORROWED                   "));
            Console.WriteLine("_______________________________________________________________________________________________________________________");
            foreach (Member m in memberList)
            {
                m.outputMember();
            }
            Console.ReadKey();
        }

        public void deleteMemberList()
        {
            string memberName;
            bool checkName = false;  // ĐẶT CỜ HIỆU
            Console.Clear();
            Console.WriteLine("\n\t============== DELETE BOOK ===============\n\t");
            Console.Write("\n\tENTER A MEMBER TO DELETE: ");
            memberName = Console.ReadLine();
            ArrayList memberTempo = new ArrayList();

            memberTempo = (ArrayList)memberList.Clone();
            foreach (Member m in memberTempo)
            {
                if (m.MemberName == memberName)
                {
                    memberList.Remove(m);
                    checkName = true;
                }
            }

            if (checkName == true)
                Console.WriteLine("\n\tDELETE SUCESSFULLY !");
            else
                Console.WriteLine("\n\tCANNOT FIND THIS MEMBER TO DELETE !");

            Console.ReadKey();
        }

        public void updateMemberList()
        {
            string memberName;
            bool flag = false;
            Console.Clear();
            Console.WriteLine("\n\t=============== SEARCH MEMBER ==============\n");
            Console.Write("\n\tENTER A MEMBER TO UPDATE: ");
            memberName = Console.ReadLine();
            foreach (Member m in memberList)
            {
                if (m.MemberName == memberName)
                {
                    m.updateMember();
                    flag = true;
                    break;
                }
            }
            if (flag == true)
                Console.WriteLine("\n\tUPDATE SUCESSFULLY !");
            else
                Console.WriteLine("\n\tCANNOT FIND A MEMBER TO UPDATE !");

            Console.ReadKey();
        }
    }
    
}
