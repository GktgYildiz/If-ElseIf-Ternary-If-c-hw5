using System;

namespace if_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            //** 1. yöntem **//
            
            if (time >= 6 && time < 11)
                Console.WriteLine("Günaydın");

            else if(time <= 18)
                Console.WriteLine("İYİ GÜNLER");
            else
                Console.WriteLine("İYİ GECELER");

            //** 2. yöntem **//

            string sonuc = time <= 18 ? "iyi günler" : "iyi geceler";
            Console.WriteLine(sonuc);

            //** 3. yöntem **//

            sonuc= time>=6 && time<11 ? "Günaydın!": time<=18 ?  "iyi günler!" : "iyi geceler"; 
            Console.WriteLine(sonuc);

        }
    }
}
