using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //this is how we instantiate a new instance of our pet
            VirtualPet myPet = new VirtualPet();


            //TODO add a greeting for the user. you can also let the user name the pet if you like
            

            Console.WriteLine("Welcome to Utopia!");
            Console.WriteLine("This is a magical place where anything can happen, it's filled mystical powers all you have to do is get a unicorn and take care of it to unleash your powers.");
            Console.WriteLine("Your in luck, we have a unicorn that needs a caretaker!");
            Console.WriteLine("His name is PeeWee, would you like to be his caretaker?");
            Console.ReadLine();

            //Attemping to add an if else/statement in the beginning to give more complexity
            string userOp;
            userOp = Console.ReadLine();
            if (userOp.Equals("Yes"))
            {
                Console.WriteLine("Great! I hope you enjoy your visit.");
            }
            else if (userOp.Equals("No"))
            {
                Console.WriteLine("Utopia is epic! I'm sorry you didn't get a chance to experice it. Come again!");
            }

            int selectedOption;

            do
            {
                //TODO fill this out with more options to interact with the pet
                Console.WriteLine();
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Feed the pet");
                Console.WriteLine("2. Play with the pet");
                Console.WriteLine("3. Get pet groomed");
                Console.WriteLine("4. Hydrate the pet");
                Console.WriteLine("5. Quit");
                bool true1;
                true1 = int.TryParse(Console.ReadLine(), out selectedOption);

                myPet.MyPetStatus();

                //In case user hits a wrong ket it will give an invalid option
                while (true1 == false)
                {
                    Console.WriteLine("No-can do,try again!");
                    true1 = int.TryParse(Console.ReadLine(), out selectedOption);
                }
                if (true1 == true)
                {
                    switch (selectedOption)
                    {
                        //It was hard making sure the cases alighed with the constant numbers going up and 
                        //down. I tried to make it seem as real as possible

                        case 1:

                            myPet.HungerDecrease();
                            Console.WriteLine("Thank you for feeding the pet. He loves to eat!");
                            break;

                        case 2:

                            myPet.BoredomDecrease();
                            Console.WriteLine("Thank you for playing with the pet, don't let PeeWee ware you out!");
                            break;

                        case 3:

                            myPet.DirtyDecrease();
                            Console.WriteLine("Thank you for getting the pet groomed, he loves getting pampered.");
                            break;


                        case 4:

                            myPet.ThirstyDecrease();
                            Console.WriteLine("Thank you for getting water. Whew I needed that.");
                            break;

                                               
                        case 5:

                            Console.WriteLine("If you are done taking care of PeeWee, bring him back for observation.");
                            Console.WriteLine("Yes, there is a catch! You will get your powers released tomorrow after determining if he was properly cared for.");
                            Console.WriteLine("Thanks for coming to Utopia!.");
                            break;

                           default:

                            Console.WriteLine("Invalid option selected.");
                            break;
                    }
                }

                //In the assignment it said here we put method calls here so the pet can have some values change automatically.
                //I already did that but just in case I tried to call again- It is wrong. It just repeats what
                //I wrote write after the the gives an answer
                //myPet.HungerIncrease();

                //console.writeline("hunger: mypet.hunger");
                //console.writeline("play: mypet.play");
                //console.writeline("groom: mypet.groom");
                //console.writeline("hydrate: mypet.hydrate");

            } while (selectedOption != 5) ;

        
            
                






        }
    }
}
