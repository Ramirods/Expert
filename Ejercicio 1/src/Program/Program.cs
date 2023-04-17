using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            Sector sector1 = new Sector();
            Sector sector2 = new Sector();

            Shelve shelve1 = new Shelve();
            Shelve shelve2 = new Shelve();

            shelve1.BookAdd("7", book1);
            shelve2.BookAdd("3", book2);

            sector1.ShelveAdd("A", shelve1);
            sector2.ShelveAdd("B", shelve2);


        }
    }
}