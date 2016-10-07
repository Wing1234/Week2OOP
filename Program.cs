using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {           
        
        Player player1 = new Player(); 
        Player player2 = new Player(); 

        Console.WriteLine("Hello Jamie!");
        Console.ReadLine(); 

        Console.Clear();
        player1.Draw();
        player2.Draw();

        while(true)
        {

        string direction = ""; 
        ConsoleKeyInfo keyPress = Console.ReadKey(true);
        if(keyPress.Key == ConsoleKey.UpArrow)
        {
            direction = "up";
        }
        else if(keyPress.Key == ConsoleKey.RightArrow)
        {
            direction = "right";
        }
        else if (keyPress.Key == ConsoleKey.DownArrow)
        {
            direction = "down";
        }
        else if (keyPress.Key == ConsoleKey.LeftArrow)
        {
            direction = "left"; 
        }

        player1.Move(direction);
        Console.Clear();
        player1.Draw();
        }   
        Console.ReadKey(true);
            }   
        }
    }
            
            



    
