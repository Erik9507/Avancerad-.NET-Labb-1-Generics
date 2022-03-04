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
            //lägger till låder
            LådaCollection Boxes = new LådaCollection();
            Boxes.Add(new Låda(10, 10, 10));
            Boxes.Add(new Låda(20, 20, 20));
            Boxes.Add(new Låda(30, 30, 30));
            Boxes.Add(new Låda(40, 40, 40));
            Boxes.Add(new Låda(50, 50, 50));


            //lägger till låda som redan finns
            Boxes.Add(new Låda(10, 10, 10));

            //tar bort låda
            Boxes.Remove(new Låda(10, 10, 10));


            //visar alla lådor 
            DisplayBoxes(Boxes);

            //kollar om collection contains objekt
            if (Boxes.Contains(new Låda(1,5,3)))
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
    
