using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEE_Task2.Crud
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
           
            List <userDetails> usersList = new List <userDetails> ();
            for ( ; ; )
            {
                
                Console.WriteLine("1) Add user");
                Console.WriteLine("2) Update data of user");
                Console.WriteLine("3) Delete user");
                Console.WriteLine("4) Print all users");
                // Console.WriteLine("==============================");
                Console.WriteLine();
                Console.Write("Enter ur Choice : ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine();
                userDetails user1 = new userDetails();
                if (c == 1)
                {
                    Console.WriteLine("==============================");
                    Console.WriteLine();
                    
                    Console.Write("What is ur name ? ");
                    user1.Name = Console.ReadLine();
                    Console.Write("What is ur Email ? ");
                    user1.Email = Console.ReadLine();
                    Console.Write("What is ur number ? ");
                    user1.phoneNum = (Console.ReadLine());
                    usersList.Add (user1);
                    Console.WriteLine();
                    Console.WriteLine("==========( User information U Entered )==========");
                    Console.WriteLine();
                    user1.printDetails();
                    Console.WriteLine();
                    Console.WriteLine("==============================");
                }
                
                else if (c == 2) 
                {
                   
                    Console.Write("Enter the user's number : ");
                    string checkPhoneNum = Console.ReadLine();
                    userDetails user = usersList.FirstOrDefault(a => a.phoneNum == checkPhoneNum);
                    // userDetails sUSER = new userDetails();

                    bool flag = false;

                    if (checkPhoneNum != null)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("==========( Ur Information before updating )========== ");
                        Console.WriteLine();
                        user.printDetails();
                        Console.WriteLine();
                        Console.WriteLine("==============================");
                        Console.WriteLine();
                        Console.WriteLine("What do u want to edit ?");
                        Console.WriteLine("1) Edit name");
                        Console.WriteLine("2) Edit Email");
                        Console.WriteLine("3) Edit number");
                        Console.WriteLine("\n");
                        Console.Write("==> The Detail u wanna Edit is : ");
                        int editChoice = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        if (editChoice == 1)
                        {
                            Console.Write("Enter ur new name :");
                            user.Name = Console.ReadLine();
                            flag = true;
                        }
                        else if (editChoice == 2)
                        {
                            Console.Write("Enter ur new Email :");
                            user.Email = Console.ReadLine();
                            flag = true;
                        }
                        else if (editChoice == 3)
                        {
                            Console.Write("Enter ur new number :");
                            user.phoneNum = Console.ReadLine();
                            flag = true;
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("==========( Ur Information after updating )==========");
                        Console.WriteLine();
                        user.printDetails();
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("Invaild number");
                    }

                }

                else if (c == 3) 
                {
                    Console.Write("Enter the user's number : ");
                    string checkPhoneNum = Console.ReadLine();
                    Console.WriteLine("\n");
                    userDetails user = usersList.FirstOrDefault(a => a.phoneNum == checkPhoneNum);
                    if ( checkPhoneNum != null )
                    {
                        Console.WriteLine("* Are u Sure u want to remove '" + user.Name + "' ?");
                        Console.WriteLine("If yes plz write 'Y' || If no just write 'N' ");
                        Console.Write("===>");
                        char checkRemoving = char.Parse(Console.ReadLine());
                        if ( checkRemoving == 'Y' || checkRemoving == 'y')
                        {
                            usersList.Remove(user);
                            Console.WriteLine();
                            Console.WriteLine("User Removed Successfully.");
                        }
                        else 
                        {
                            Console.WriteLine("Ok , Nothing Happend.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invaild number");
                    }

                }

                else if (c == 4) 
                {
                    Console.WriteLine("=============== (PRINT ALL USERS) ===============");
                    Console.WriteLine();

                    foreach (userDetails user in usersList)
                    {
                        Console.WriteLine("User " + (usersList.IndexOf(user) +1 ) );
                        user.printDetails();
                        Console.WriteLine();
                        Console.WriteLine("----------");
                        Console.WriteLine();
                    }
                }

                else
                {
                    Console.WriteLine("U enterd Invaild number");
                    Console.WriteLine();
                    Console.WriteLine("==============================");
                }

                Console.WriteLine("Do u Wanna try any thing else ?");
                Console.WriteLine("Type : Y for YES || N for No");
                char tryying = char.Parse(Console.ReadLine());
                Console.WriteLine();
                if (tryying == 'n' || tryying == 'N')
                {
                    Console.WriteLine("Thanks, See U Soon.");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
