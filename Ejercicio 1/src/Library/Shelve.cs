using System;
using System.Collections.Generic;


public class Shelve
{
    public Dictionary<string, Book> Books = new Dictionary<string, Book>();

    public void BookAdd(string Place, Book NewBook)
    {
        this.Books.Add(Place, NewBook);
    }
}