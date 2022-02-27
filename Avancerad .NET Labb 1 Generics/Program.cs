using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Avancerad_.NET_Labb_1_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            LådaCollection Boxes = new LådaCollection();
            Boxes.Add(new Låda(10, 10, 10));
            Boxes.Add(new Låda(20, 20, 20));
            Boxes.Add(new Låda(30, 30, 30));
            Boxes.Add(new Låda(40, 40, 40));
            Boxes.Add(new Låda(50, 50, 50));


            Boxes.Add(new Låda(10, 10, 10));
            Boxes.Remove(new Låda(10, 10, 10));


            DisplayBoxes(Boxes);

            if (Boxes.Contains(new Låda(50,50,50)))
            {
                Console.WriteLine("Låda finns");
            }
            else
            {
                Console.WriteLine("Låda finns inte");
            }   
        }

        public static void DisplayBoxes(LådaCollection Boxes)
        {
            foreach (var item in Boxes)
            {
                Console.WriteLine(item);
            }
        }        
    }
}
    
