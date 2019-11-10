using System;

namespace _1st_app
{
    class GuessGame
    {
        static void Main(string[] args)
        {
            String choice;
            Console.WriteLine("Καλώς όρισες στο παιχνίδι μου.");
            Console.WriteLine("Έδώ έχεις 3 επιλογές:");
            do
            {
                Console.WriteLine("Διάλεξε τι θες να κάνεις:");
                Console.WriteLine("1. Να μαντέψει ο υπολογιστής έναν αριθμό που σκέφτηκες!");
                Console.WriteLine("2. Να μαντέψεις εσύ έναν αριθμό που σκέφτηκε ο υπολογιστής!");
                Console.WriteLine("3. Να μη μαντέψει κανείς τίποτα και να συνεχίσετε τις με ζωές σας.");
                choice = Console.ReadLine();
                while (choice != "1" && choice != "2" && choice != "3") {
                    Console.WriteLine("Δεν μάρεσε η επιλογή σου. Ξαναπροσπάθησε:");
                    choice = Console.ReadLine();
                }
                if (choice == "1")
                {
                    Guess();
                }
                else if (choice == "2") {
                    Guess2();
                }
            } while (choice != "3");
            Console.WriteLine("Καλή συνέχεια! Πάτα ένα enter για να κλείσεις το παράθυρο.");
            Environment.Exit(0);

        }
        public static void Guess() {
            int min = 1;
            int max = 101;
            Boolean flag = true;
            int tries = 0;
            String answr;
            Random rnd = new Random();
            Console.WriteLine("Σκέψου έναν αριθμό΄από το 1-100 και θα προσπαθήσω να τον βρώ.");
            Console.WriteLine("Παρακαλώ απάντησε με Y για ναί και N για όχι.");
            Console.WriteLine("Όταν είσαι έτοιμος, πάτα το πλήκτρο Enter.");
            Console.ReadLine();
            do
            {
                tries++;
                int n = rnd.Next(min, max);
                Console.WriteLine("Μήπως σκέφτηκες το " + n);
                answr = Console.ReadLine();
                while (answr != "N" && answr != "Y")
                {
                    Console.WriteLine("Δεν μπορώ να καταλάβω την απάτηση σου. Ξαναπροσπάθησε: ");
                    answr = Console.ReadLine();
                }
                if (answr == ("Y"))
                {
                    flag = false;
                    Console.WriteLine("Τέλεια, το παιχνίδι τελείωσε. Το βρήκα με την " + tries + " προσπάθεια!");
                }
                else
                {
                    Console.WriteLine("Ο αριθμός σου είναι μεγαλύτερος από το " + n + ";");
                    answr = Console.ReadLine();
                    while (answr != "N" && answr != "Y")
                    {
                        Console.WriteLine("Δεν μπορώ να καταλάβω την απάτηση σου. Ξαναπροσπάθησε: ");
                        answr = Console.ReadLine();
                    }
                    if (answr == "Y")
                    {
                        min = n+1;
                    }
                    else
                    {
                        max = n;
                    }
                }

            } while (flag);
        }
        public static void Guess2() {
            Console.WriteLine("Σε αυτό το παιχνίδί, εγώ σκέφτομαι έναν αριθμό απ' το 1-10 και εσύ πρέπει να το βρείς.");
            Console.WriteLine("Πάτα το πλήκτρο Enter για να ξεκινήσουμε.");
            Console.ReadLine();
            Random rnd = new Random();
            int n = rnd.Next(1,11);
            int g;
            int tries = 0;
            Boolean flag = true;
            Console.WriteLine("Μάντεψε έναν αριθμό και γράψ' τον:");
            do
            {
                tries++;
                g = Convert.ToInt32(Console.ReadLine());
                if (g > n)
                {
                    Console.WriteLine("Ο αριθμός σου είναι μεγαλύτερος από αυτόν που σκέφτηκα. Ξαναπροσπάθησε:");
                }
                else if (g < n)
                {
                    Console.WriteLine("Ο αριθμός σου είναι μικρότερος από αυτόν που σκέφτηκα. Ξαναπροσπάθησε:");
                }
                else {
                    flag = false;
                }
            } while (flag);
            Console.WriteLine("Συγχαρητήρια! Το βρήκες με την " +tries+ " προσπάθεια.");

        }
    }
}
