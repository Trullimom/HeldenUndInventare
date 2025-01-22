using HeldenUndInventare;
using System.ComponentModel;

namespace HelndeUndInventare
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Held held1 = new Held("Gale Glare", 10);
            Held held2 = new Held("Magician Fire", 13);
            // jojo
            held1.AddItem(CreateItems.waffe1);
            held1.AddItem(CreateItems.waffe2);
            held1.AddItem(CreateItems.waffe3);
            held1.AddItem(CreateItems.waffe4);
            held1.AddItem(CreateItems.waffe5);
            held1.AddItem(CreateItems.trank1);
            held1.AddItem(CreateItems.trank2);
            held1.AddItem(CreateItems.waffe1);
            held1.AddItem(CreateItems.waffe2);
            held1.AddItem(CreateItems.waffe3);
            held1.AddItem(CreateItems.waffe4);
            held1.AddItem(CreateItems.waffe5);

            held2.AddItem(CreateItems.waffe1);
            held2.AddItem(CreateItems.waffe2);
            held2.AddItem(CreateItems.waffe3);
            held2.AddItem(CreateItems.waffe4);
            held2.AddItem(CreateItems.waffe5);
            held2.AddItem(CreateItems.trank1);
            held2.AddItem(CreateItems.trank2);




            Console.WriteLine($"#####{held1.Name} gegen {held2.Name}#####");
            Console.WriteLine();
            while (true)
            {
                try
                {
                    Console.WriteLine($"{held1.Name} ist dran\n");
                    held2.LpAnzeigen(held2);
                    if (held1.Invent.waffenList.Count() > 0)
                    {
                        Console.WriteLine($"Wähle Waffe aus: 1 bis {held1.Invent.waffenList.Count()}");
                        held1.Invent.WaffenmenuAnzeigen();
                        int auswahl1 = int.Parse(Console.ReadLine());
                        held1.GreifAn(held2, auswahl1 - 1);
                        if (held2.Lebenspunkte <= 0)
                        {
                            Console.WriteLine($"{held2.Name} ist tot\n"
                                            + $"{held1.Name} hat gewonnen\n"
                                            + $"###### GAME OVER ######");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{held1.Name}, du hast keine Waffe mehr");
                    }
                    Console.WriteLine();
                    Console.ReadKey();

                    if (held2.Invent.trankList.Count() > 0)
                    {
                        Console.WriteLine($"{held2.Name}, Du kannst dich heilen. Wähle Trank aus: 1 bis {held2.Invent.trankList.Count()}");
                        held2.Invent.TrankmenuAnzeigen();
                        int auswahl5 = int.Parse(Console.ReadLine());
                        held2.Heilen(auswahl5 - 1);
                    }
                    else
                    {
                        Console.WriteLine($"{held2.Name}, du hast keinen Trank mehr");
                    }
                    Console.WriteLine();
                    Console.ReadKey();


                    Console.WriteLine($"{held2.Name} ist dran\n");
                    held1.LpAnzeigen(held1);
                    if (held2.Invent.waffenList.Count() > 0)
                    {
                        Console.WriteLine($"Wähle Waffe aus: 1 bis {held2.Invent.waffenList.Count()} ");
                        held2.Invent.WaffenmenuAnzeigen();
                        int auswahl2 = int.Parse(Console.ReadLine());
                        held2.GreifAn(held1, auswahl2 - 1);
                        if (held1.Lebenspunkte <= 0)
                        {
                            Console.WriteLine($"{held1.Name} ist tot\n"
                                            + $"{held2.Name} hat gewonnen\n"
                                            + $"###### GAME OVER ######");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{held2.Name}, du hast keine Waffe mehr");
                    }
                    Console.WriteLine();
                    Console.ReadKey();

                    if (held1.Invent.trankList.Count() > 0)
                    {
                        Console.WriteLine($"{held1.Name}, Du kannst dich heilen. Wähle Trank aus: 1 bis {held1.Invent.waffenList.Count()} ");
                        held1.Invent.TrankmenuAnzeigen();
                        int auswahl6 = int.Parse(Console.ReadLine());
                        held1.Heilen(auswahl6 - 1);
                    }
                    else
                    {
                        Console.WriteLine($"{held1.Name}, du hast keinen Trank mehr");
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine();
            }

        }
    }
}