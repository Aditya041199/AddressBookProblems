using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addressbook book = new Addressbook();
            book.CreateContact();
        }
    }
}