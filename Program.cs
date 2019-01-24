using System;

namespace assn1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, check;
            bool age;
            char a;
            string name, x;
            decimal cost = 7.85M;
            double amount = 0;

            do
            {
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            } while (name == "");

            do
            {
                Console.WriteLine("Enter your age ?");
                //String x = int.Parse(Console.ReadLine());
                x = Console.ReadLine();
            } while (x == "");
            do
            {
                check = int.Parse(x);

                if (check >= 18)
                {
                    age = true;
                }
                else
                {
                    age = false;
                    Console.WriteLine($"Sorry! {name} you have to be above 18+ to buy movie ticket.");
                }

                while (age)
                {
                    String[] movies_tiers = { "Standard", "Imax", "Imax-3D" };
                    for (int i = 0; i < movies_tiers.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {movies_tiers[i]}");
                    }
                    int selection = Convert.ToInt32(Console.ReadLine());

                    switch (selection)
                    {
                        case 1:
                            Console.WriteLine("you have selected {0} type.", movies_tiers[0]);
                            break;
                        case 2:
                            Console.WriteLine("you have selected {0} type.", movies_tiers[1]);
                            break;
                        case 3:
                            Console.WriteLine("you have selected {0} type.", movies_tiers[2]);
                            break;
                        default:
                            Console.WriteLine("No option selected, standard ticket is selected as deafult !!");
                            break;
                    }
                    Console.WriteLine("Enter number of tickets");
                    int num = int.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine($"The Total cost of ticket(s) is {calculate(num, cost)}");
                            count += 1;
                            break;
                        case 2:
                            Console.WriteLine($"The Total cost of ticket(s) is {calculate(num, cost)}");
                            count += 2;
                            break;
                        case 3:
                            Console.WriteLine($"The Total cost of ticket(s) is {calculate(num, cost)}");
                            count += 3;
                            break;
                        default:
                            Console.WriteLine($"{name} you can only buy 1 or 2 or 3 tickets per Transaction.\nsorry !!");
                            break;
                    }
                    age = false;
                }

                double calculate(int c, decimal d)
                {
                    double result = decimal.ToDouble(c * d);
                    amount += result;
                    return amount;
                }

                Console.WriteLine("Do you want to continue again (y/n)?");
                a = char.Parse(Console.ReadLine());
            } while (a.Equals('y') || a.Equals('Y'));
            Console.WriteLine("{0}Total Number of Tickets are {1} and total cost is {2}.\nThank You! and have a nice day.", name, count, amount);
        }
    }
}
