using System;
using System.Collections.Generic;


namespace FameDirecBL
{
    public class DirectorList
    {
        public string name;
        List<Directors> directors = new List<Directors>();

        public void DisplayDirectorsInfo(Directors directors)
        {
            Console.WriteLine(name);
            Console.WriteLine("Director Name: " + directors.director);
            Console.WriteLine("Movies Directed: " + directors.moviesName);
            Console.WriteLine("TV Series Directed: " + directors.tvSeriesName);
            Console.WriteLine("  ");
        }
    }
}
