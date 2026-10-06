namespace CastTheDice;

class Program
{
    static void Main()
    {
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Välkommen till Cast The Die");
        Console.WriteLine("Detta spelet går ut på att kasta två tärningar och få talet 12 vid addering");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("För att starta spelet, klicka på 's'");
        Console.WriteLine("För att stänga ner spelet, klicka på 'x'");
        Console.WriteLine("---------------------------------------------------");


        try
        {
            var key = Console.ReadLine();

            if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(key))
            {
                Console.WriteLine("Du måste skriva in något av alternativen i menyn");
            }

            while (true)
            {
                switch (key)
                {
                    case "s":
                        Random random = new();
                        int dice1 = random.Next(1, 7);
                        int dice2 = random.Next(1, 7);

                        if (dice1 + dice2 == 12)
                        {
                            Console.WriteLine("Du vann! Summan av tärningarna blev 12");
                        }
                        else
                        {
                            Console.WriteLine("Tyvärr förlorade du");
                            Console.WriteLine($"Första tärningen blev en {dice1} och den andra blev {dice2} vilket blir {dice1 + dice2}");
                        }

                        Console.WriteLine("Om du vill spela igen klicka på 'y'");
                        Console.WriteLine("Annars klickar du på vilket tanget för att stänga ner spelet");
                        var x = Console.ReadLine();
                        if (x == "y" || x == "Y")
                        {
                            break;
                        }
                        else { throw new Exception("Tack för att du spelade!"); }

                    case "x":
                        throw new Exception("Stänger ner spelet");

                    default:
                        Console.WriteLine("Du måste välja något av valen i menyn");
                        continue;

                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(0);
        }
    }
}

