while (true)
{
    try
    {
        Console.WriteLine($"Menu\n________________________");
        Console.WriteLine($"1 Quadrat\n2 Rechteck\n3 Dreieck\n4 kreis\n5 Gleichschenkliges Trapez\n6 Abbrechen");
        Console.Write($"________________________\nAuswählen: ");
        double eingabe = Convert.ToDouble(Console.ReadLine());
        switch (eingabe)
        {
            case 1:
                Console.WriteLine($"\nErgebniss: {quadrat()}");
                Console.Write($"Drücken sie enter um fortzufahren");
                Console.ReadKey();
                Console.Clear();

                continue;
            case 2:
                Console.Write($"Geben sie a ein: ");
                double ar = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Geben sie b ein: ");
                double br = Convert.ToDouble(Console.ReadLine());
                rechteck(ar, br);
                Console.Write($"Drücken sie enter um fortzufahren");
                Console.ReadKey();
                Console.Clear();


                continue;
            case 3:

                dreieck();
                Console.Write($"Drücken sie enter um fortzufahren");
                Console.ReadKey();
                Console.Clear();

                continue;
            case 4:
                Console.Write($"Geben sie radius ein: ");
                double ak = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine($"Ergebniss: {kreis(ak)}");
                Console.Write($"Drücken sie enter um fortzufahren");
                Console.ReadKey();
                Console.Clear();

                continue;
            case 5:
                Console.Write($"Geben sie a ein: ");
                double at = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Geben sie c ein: ");
                double ct = Convert.ToDouble(Console.ReadLine());
                Console.Write($"Geben sie h ein: ");
                double ht = Convert.ToDouble(Console.ReadLine());

                double trapez = trapezrechnen(at, ct, ht);


                Console.WriteLine($"Ergebniss: {trapez}");
                Console.ReadKey();
                Console.Clear();
                continue;
            case 6:
                break;


        }
        static double quadrat()
        {
            Console.Write($"Geben sie a ein: ");
            double aq = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Geben sie b ein: ");
            double bq = Convert.ToDouble(Console.ReadLine());
            return aq* bq;

        }
        static void dreieck()
        {
            Console.Write($"Geben sie grundseite ein: ");
            double ad = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Geben sie höhe ein: ");
            double bd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{(ad * bd) / 2}"); 
        }
        static double kreis(double ak)
        {
            return ak * ak * 3.1415926535897931;
        }
        static void rechteck(double ar, double br)
        {

            Console.WriteLine($"Ergebniss: {ar * br}");
        }

        static double trapezrechnen(double a, double c, double h)
        {
            double ergebniss = ((a + c) / 2) * h;
            return ergebniss;
        }
        break;
    }
    catch (Exception ex) { 
        Console.WriteLine(ex.Message); 
    }
}
