
using System;
using System.IO;
using FameDirecBL;
using BL;
using Model;


namespace FameDirector
{
    public class Program
    {
        public static void Main(string[] args)
        {

            DirectorList Direc = new DirectorList();

            Directors Greta = new Directors();
            Greta.director = "Greta Gerwig";
            Greta.moviesName = """

                Hannah Takes the Stairs, co-writer. (2007)
                Nights and Weekends, co-writer, co-director. (2008)
                Northern Comfort, writer. (2010)
                Lady Bird, director. (2017)pa
                Little Women, director. (2019)
                Barbie, director. (2023)
                """;
            Greta.tvSeriesName = """

                China, IL (2008)
                On Story (2018)
                """
            ;


            Directors Nolan = new Directors();
            Nolan.director = "Christopher Nolan";
            Nolan.moviesName = """ 
                 Following (1998)
                Insomnia (2002)
                The Dark Knight Rises (2012)
                Batman Begins (2005)
                Tenet (2020)
                Memento (2000)
                Inception (2010)
                Interstellar (2014)
                The Prestige (2006)
                The Dark Knight (2008)
                Oppenheimer (2023)
                Dunkirk (2017)
                """;
            Nolan.tvSeriesName = """ 
                100 Years of Warner Bros (2023)
                The Story of Film: An Odyssey (2011)
                """
            ;
            Directors DanielKwan = new Directors();

            DanielKwan.director = "Daniel Kwan";
            DanielKwan.moviesName = "Everything Everywhere All at Once (2022)";
            DanielKwan.tvSeriesName = """
                Awkwafina Is Nora from Queens TV (2020)
                Legion TV (2017-2019)
                Childrens Hospital TV (2008 - 2016)
                """
            ;

            Directors Speilberg = new Directors();
            Speilberg.director = "Steven Speilberg";
            Speilberg.moviesName = """
                Empire of the Sun (1987)
                Indiana Jones and the Last Crusade (1989)
                Always (1989)
                Hook (1991)
                Schindler's List (1993)
                Jurassic Park (1993)
                Catch me if you Can (2002)
                War of Worlds (2005)
                Lincoln (2012)
                The BFG (2016)
                West Side Story (2021)
                """;
            Speilberg.tvSeriesName = """ 
            Five Came Back (2017)
            Ready Player One (2018)
            James Cameron Story of Science Fiction (2018) 
            """
            ;

            Directors Woody = new Directors();
            Woody.director = "Woody Allen";
            Woody.moviesName = """ 
                Everyone Says I Love You (1996)
                Antz(1998)
                New York Stories (1989)
                Anything Else (2003)
                """;
            Directors Heckerling = new Directors();
            Heckerling.director = "Amy Heckerling";
            Heckerling.moviesName = """  
                 Life on the Flips (1988)
                 A night at the Roxbury (1998) 
                 Loser (2000)
               """;
            Heckerling.tvSeriesName = """
                Clueless (1996)
                The Office (2005)
                Gossip Girl (2007)
                The Carrie Diaries (2013)
                Weird City (2019)
               """;
            Console.Write("Enter Username: ");
            string userName = Console.ReadLine();
            Console.Write("Enter Username: ");
            

            Verify Verify = new Verify();
            bool result = Verify.VerifyUser(userName);

            if (result)
            {
                DirectorList Directs = new DirectorList();

                Console.WriteLine("Select a Director:");
                Console.WriteLine();

                while (true)
                {
                    Console.WriteLine("1. Greta Gerwig");
                    Console.WriteLine("2. Christopher Nolan");
                    Console.WriteLine("3. Daniel Kwan");
                    Console.WriteLine("4. Steven Speilberg");
                    Console.WriteLine("5. Woody Allen");
                    Console.WriteLine("6. Amy Heckerling");
                    Console.WriteLine();
                    Console.WriteLine("Select a Director:");

                    string choices = Console.ReadLine();

                    switch (choices)
                    {
                        case "1":
                            Direc.DisplayDirectorsInfo(Greta);
                            break;

                        case "2":
                            Direc.DisplayDirectorsInfo(Nolan);
                            break;

                        case "3":
                            Direc.DisplayDirectorsInfo(DanielKwan);
                            break;
                        case "4":
                            Direc.DisplayDirectorsInfo(Speilberg);
                            break;
                        case "5":
                            Direc.DisplayDirectorsInfo(Woody);
                            break;
                        case "6":
                            Direc.DisplayDirectorsInfo(Heckerling);
                            return;

                        
                            


                        default:
                            Console.WriteLine("Invalid Input.");
                            Console.WriteLine();
                            Console.WriteLine("-------------------");
                            break;
                            return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error...");
            }
        }
    }
}
