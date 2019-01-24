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
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            while (name == "")
            {
                Console.WriteLine("Sorry, Please Enter you name ?");
                name = Console.ReadLine();
            }
            do
            {
                do
                {
                    Console.WriteLine("Enter your age(>=15, <= 90) ?");
                    //String x = int.Parse(Console.ReadLine());
                    x = Console.ReadLine();
                } while (x == "");
                check = int.Parse(x);

                if (check >= 15 && check <= 90)
                {
                    age = true;
                }
                else if (check > 90)
                {
                    Console.WriteLine("You are too old to watch a movie");
                    age = false;
                }
                else
                {
                    age = false;
                    Console.WriteLine("Your Age is below 15, you need a guardian to book a ticket.");
                    Console.WriteLine($"Sorry! {name} you have to be above 15+ to buy movie ticket.");
                }
                int selection;
                String[] movies_tiers = { "Standard", "Imax", "Imax-3D" };
                while (age)
                {
                    do
                    {
                        for (int i = 0; i < movies_tiers.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {movies_tiers[i]}");
                        }
                        selection = Convert.ToInt32(Console.ReadLine());
                        if (selection > 3)
                        {
                            Console.WriteLine("Wrong option selected !!");
                        }
                    } while (selection > 3);
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
                            char glasses_check;
                            do
                            {
                                Console.WriteLine("Do you have 3D glasses (y/n)?");
                                glasses_check = char.Parse(Console.ReadLine());
                                if (glasses_check == 'y')
                                {
                                    Console.WriteLine("Great !!");
                                    selection = 2;
                                    break;
                                }
                                else if (glasses_check == 'n')
                                {
                                    Console.WriteLine("Extra 2$ for each ticket will be added");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("please type y or n !!");
                                }
                            } while (glasses_check != 'y' || glasses_check != 'n');
                            break;
                    }
                    Console.WriteLine("Enter number of tickets");
                    int num = int.Parse(Console.ReadLine());
                    if (selection == 1 || selection == 2)
                    {
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
                    }
                    else
                    {
                        switch (num)
                        {
                            case 1:
                                Console.WriteLine($"The Total cost of ticket(s) is {calculate(num, cost)+2}");
                                amount += 2;
                                count += 1;
                                break;
                            case 2:
                                Console.WriteLine($"The Total cost of ticket(s) is {calculate(num, cost)+4}");
                                amount += 4;
                                count += 2;
                                break;
                            case 3:
                                Console.WriteLine($"The Total cost of ticket(s) is {calculate(num, cost)+6}");
                                amount += 6;
                                count += 3;
                                break;
                            default:
                                Console.WriteLine($"{name} you can only buy 1 or 2 or 3 tickets per Transaction.\nsorry !!");
                                break;

                        }

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
            Console.WriteLine("{0}, Total Number of Tickets are {1} and total cost is {2}.\nThank You! and have a nice day.", name, count, amount);
        }
    }
}