using System;
using System.Collections.Generic;


public class Sector
{

    public Dictionary<string, Shelve> Shelves = new Dictionary<string, Shelve>();

    public void ShelveAdd(string ShelvePlace, Shelve NewShelve)
    {
        this.Shelves.Add(ShelvePlace, NewShelve);
    }

}