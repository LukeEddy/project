using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>();

            while (true)





            {



                Console.WriteLine("What is the command? your options are add remove list and q as quit");
                    
                  


                string command = Console.ReadLine();
                if (command == "add")
                {
                    Console.WriteLine("What is the name of the game");

                    // add to list 
                    string name = Console.ReadLine();
                    //what is the name of the game
                    videoGames.Add(name);

                    Console.WriteLine("item is now on list ");
                    //when done say done

                }



                if (command == "remove")
                {
                    Console.WriteLine("What is the name of the game");

                    // remove from list 
                    string name = Console.ReadLine();
                    //what is the name of the game
                    videoGames.Remove(name);

                    Console.WriteLine("item is now off list ");
                    //when done say done

                }

                if (command == "list")
                {

                    videoGames.ForEach(Console.WriteLine);

                }

                if (command == "q")
                    break;


            }
             
        }

    }

}
                

                
 
                
                
            
        
    

