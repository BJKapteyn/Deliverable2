using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Hello agent, what're you feeling today?" +
                                "\nHere are your options:" +
                                "\n     1) Action" +
                                "\n     2) Chilling out" +
                                "\n     3) Danger" +
                                "\n     4) Hunger" +
                                "\n" +
                                "Choose option 1-4: ");
                while (true)
                {
                    string userAnswer = Console.ReadLine();
                    switch (userAnswer)
                    {
                        case "1":
                            Console.WriteLine("Let's go squirrel suit flying through a mountain.");
                            break;
                        case "2":
                            Console.WriteLine("The lights in your gunrange have been activated, please don't shoot them out this time.");
                            break;
                        case "3":
                            Console.WriteLine("A hit squad has been dispatched to your house. Please prepare your defenses. Thank you.");
                            break;
                        case "4":
                            Console.WriteLine("I've gone ahead and booked you a table at Nelly Ferrelli's Italian Cuisine and Massage Parlor." +
                                "\nThe code word to get in today is \"Spicy Pepperoni\".");
                            break;
                        default:
                            Console.WriteLine("Please choose 1-4");
                            continue;
                    }
                    break;
                }
                Console.Write("How many people are going?  ");
                while (true)
                {
                    string userPeople = Console.ReadLine();
                    if (int.TryParse(userPeople, out int x)) 
                    {
                        int numberPeople = Convert.ToInt32(userPeople);
                        if (numberPeople == 0)
                        {
                            Console.WriteLine("Your motorcycle is being transported from your autogarage");
                        }
                        else if (numberPeople > 100)
                        {
                            Console.WriteLine("A Super Class air frigate has been dispatched to your location and 1.2 million USD" +
                                " has been wired from your account. \nMaybe invite fewer people next time.");
                        }
                        else if (numberPeople > 30)
                        {
                            Console.WriteLine(userPeople + " human pulled rickshaws have been dispatched to your location." +
                                "\nThank you for single handely supporting the rickshaw industry.");
                        }
                        else if (numberPeople > 20)
                        {
                            Console.WriteLine("A bus driven by John Williams has been dispatched." +
                                "\nPlease bring instruments for in-route Star Wars theme rehersal.");
                        }
                        else if (numberPeople > 7)
                        {
                            Console.WriteLine("Let's take the small jet.");
                        }
                        else if (numberPeople > 4)
                        {
                            Console.WriteLine("Your mother has been dispatched in the minivan");
                        }
                        else
                        {
                            Console.WriteLine("Your Miata is being prepped from the autogarage. " +
                                "\nI've taked the liberty of quing up your \"Fabulous Roadtrip\" playlist.");
                        }

                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.Write("Would you like to start again? (Y/N)");
                string yesNo = Console.ReadLine().ToUpper();
                if (yesNo == "Y")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye agent. Please don't blow up anything I wouldn't." +
                        "\nAny key to exit");
                    Console.ReadKey();
                    break;
                }
            }

        }
    }
}
