using SkolaV6.Models;
using System;
using System.Linq;

namespace SkolaV6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SkolaDbContext context = new SkolaDbContext();

            bool logout = false;
            while (logout == false)
            {

                Console.WriteLine("1: Hämta ut alla elever");
                Console.WriteLine("2: Hämta ut alla elever i en viss klass");
                Console.WriteLine("3: Lägga till ny personal");
                Console.WriteLine("4: Hämta personal per avdelning");
                Console.WriteLine("5: Visa information om alla elever");
                Console.WriteLine("6: Visa en lista på alla aktiva kurser");
                Console.WriteLine("7: Stäng av applikationen");
                string menuoption = Console.ReadLine();
                switch (menuoption)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Vill du se alla elever sorterade på förnamn eller efternamn");
                            Console.WriteLine("Mata in förnamn / efternamn");
                            string svar = Console.ReadLine();

                            if (svar != "förnamn" && svar != "efternamn")
                            {
                                throw new Exception("Du mata in nått könstigt");
                            }

                            Console.WriteLine("Vill du ha stigande eller fallande ordning");
                            Console.WriteLine("Mata in stigande / fallande");
                            string ordning = Console.ReadLine();
                            if (ordning != "stigande" && ordning != "fallande")
                            {
                                throw new Exception("Du mata in nått könstigt");
                            }



                            if (ordning == "stigande")
                            {
                                if (svar == "förnamn")
                                {
                                    Console.Clear();
                                    var a = from s in context.Elev orderby s.Fnamn ascending select s;
                                    foreach (var item in a)
                                    {
                                        Console.WriteLine(item.Fnamn);
                                    }
                                    Console.WriteLine("");
                                }
                                else if (svar == "efternamn")
                                {
                                    Console.Clear();
                                    var b = from s in context.Elev orderby s.Lnamn ascending select s;
                                    foreach (var item in b)
                                    {
                                        Console.WriteLine(item.Lnamn);
                                    }
                                    Console.WriteLine("");
                                }
                            }
                            else
                            {
                                if (svar == "förnamn")
                                {
                                    Console.Clear();
                                    var c = from s in context.Elev orderby s.Fnamn descending select s;
                                    foreach (var item in c)
                                    {
                                        Console.WriteLine(item.Fnamn);
                                    }
                                    Console.WriteLine("");

                                }
                                else if (svar == "efternamn")
                                {
                                    Console.Clear();
                                    var d = from s in context.Elev orderby s.Lnamn descending select s;
                                    foreach (var item in d)
                                    {
                                        Console.WriteLine(item.Lnamn);
                                    }
                                    Console.WriteLine("");
                                }
                            }

                            break;
                        }
                    case "2":
                        {
                            Console.Clear();


                            var e = from k in context.Klass orderby k.KlassId ascending select k;
                            foreach (var item in e)
                            {
                                Console.WriteLine(item.KlassNamn);
                            }
                            Console.WriteLine("");

                            Console.WriteLine("Välj en klass");

                            string selection = Console.ReadLine();
                            Console.Clear();

                            switch (selection)
                            {
                                case "AB":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 1
                                            select c;

                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                                case "CD":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 2
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                                case "SQ":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 3
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                                case "PR":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 4
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                                case "YT":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 5
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                                case "KJ":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 6
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                                case "PA":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 7
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                                case "RE":
                                    {
                                        var query =
                                            from c in context.Elev
                                            where c.KlassId == 8
                                            select c;


                                        foreach (var item in query)
                                        {
                                            Console.WriteLine(" {0}" + " {1}", item.Fnamn, item.Lnamn);
                                        }

                                        Console.WriteLine("");
                                        break;
                                    }
                            }





                            break;
                        }
                    case "3":
                        {
                            Console.Clear();

                            Console.WriteLine("Förnamn?");
                            string förnamn = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Efternamn?");
                            string efternamn = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("PersonNr?");
                            string personnr = Console.ReadLine();
                            Console.Clear();


                            Console.WriteLine("DepartmentId?");
                            Console.WriteLine("");
                            int x = 1;
                            var e = from k in context.Befattning orderby k.DepartmentName ascending select k;
                            foreach (var item in e)
                            {
                                Console.WriteLine(item.DepartmentName);
                                Console.WriteLine(x);
                                x++;
                            }
                            Console.WriteLine("");
                            int departmentid = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            var personal = new Personal { Fnamn = förnamn, Lnamn = efternamn, PrsNr = personnr, DepartmentId = departmentid };
                            context.Add<Personal>(personal);
                            context.SaveChanges();

                            Console.Clear();
                            Console.WriteLine("Ny personal sparad");
                            Console.WriteLine("");



                            break;

                        }
                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Välj Avdelning");
                            Console.WriteLine("1: Rektorer");
                            Console.WriteLine("2: Lärare");
                            Console.WriteLine("3: HR");
                            Console.WriteLine("4: Vaktmästare");
                            // Hämta personal per avdelning
                            string selection2 = Console.ReadLine();
                            Console.Clear();
                            switch (selection2)

                            {
                                case "1":
                                    {

                                        var query =
                                                        from c in context.Personal
                                                        where c.DepartmentId == 1
                                                        select c;

                                        int count = 1;

                                        Console.Clear();
                                        Console.Write("Rektorer:");
                                        foreach (var item in query)
                                        {


                                            count++;
                                        }

                                        Console.WriteLine(count);
                                        Console.WriteLine("");
                                        break;
                                    }
                                case "2":
                                    {
                                        var query =
                                                        from c in context.Personal
                                                        where c.DepartmentId == 2
                                                        select c;
                                        int count = 1;
                                        Console.Clear();
                                        Console.Write("Lärare:");
                                        foreach (var item in query)
                                        {
                                            count++;
                                        }
                                        Console.WriteLine(count);
                                        Console.WriteLine("");
                                        break;
                                    }
                                case "3":
                                    {
                                        var query =
                                                        from c in context.Personal
                                                        where c.DepartmentId == 3
                                                        select c;
                                        int count = 1;
                                        Console.Clear();
                                        Console.Write("HR:");
                                        foreach (var item in query)
                                        {
                                            count++;
                                        }
                                        Console.WriteLine(count);
                                        Console.WriteLine("");
                                        break;
                                    }
                                case "4":
                                    {
                                        var query =
                                                        from c in context.Personal
                                                        where c.DepartmentId == 4
                                                        select c;
                                        int count = 1;
                                        Console.Clear();
                                        Console.Write("Vaktmästare:");
                                        foreach (var item in query)
                                        {
                                            count++;
                                        }
                                        Console.WriteLine(count);
                                        Console.WriteLine("");
                                        break;
                                    }
                                default:
                                    break;
                            }
                            break;

                        }
                    case "5":
                        {
                            Console.Clear();
                            //// Visa information om varje elev
                            //var e = from k in context.Elev orderby k.ElevId ascending select k;
                            //foreach (var item in e)
                            //{
                            //    Console.WriteLine(item.Fnamn, "", item.Lnamn, "", item.PrsNr);
                            //}
                            var data = context.Elev.OrderBy(a => a.ElevId);

                            foreach (var item in data)
                            {
                                Console.Write("ElevId: ");
                                Console.Write(item.ElevId);
                                Console.Write(" , Förnamn: ");
                                Console.Write(item.Fnamn);
                                Console.Write(", Efternamn: ");
                                Console.Write(item.Lnamn);
                                Console.Write(", PrsNr: ");
                                Console.Write(item.PrsNr);
                                Console.Write(", KlassId: ");
                                Console.WriteLine(item.KlassId);

                            }

                            Console.ReadKey();




                            break;
                        }
                    case "6":
                        {
                            Console.Clear();
                            var o = from k in context.Kurser where k.AktivKurs == true select k;
                            Console.WriteLine("Aktiva Kurser: ");
                            foreach (var item in o)
                            {
                                Console.WriteLine(item.KursNamn);
                            }
                            Console.WriteLine("");
                            break;
                        }
                    case "7":
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Ogilitgt val.\nSkriv en siffra i menyn.\n\n");

                            break;
                        }
                }




            }
        }
    }
}

