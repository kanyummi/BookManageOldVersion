using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    interface IBookManagementSystem
    {
        void inputBookList();
        void printBookList();
        void searchBookList();
        void updateBookList();
        void deleteBook();
    }

    interface IMember
    {
        void inputMemberList();
        void printMemberList();
        void searchMemberList();
        void updateMemberList();
        void deleteMemberList();
    }
}
