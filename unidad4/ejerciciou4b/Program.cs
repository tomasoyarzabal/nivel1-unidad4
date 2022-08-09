using System;

namespace ejerciciou4b
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, l, imf, d;
            Console.WriteLine("ingrese el importe");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de litros");
            l = int.Parse(Console.ReadLine());
            if(l > 100 && l < 301){
                d = i * 10 / 100;
                imf = i - d;
                Console.WriteLine("el importe final es " + imf);
            }if(l > 300 && l < 500){
                d = i * 15 /100;
                imf = i -d;
                Console.WriteLine("el importe final es " + imf);
            }if(l > 500){
                d = i * 25 / 100;
                imf = i - d;
                Console.WriteLine("el importe final es " + imf);
            }else{
                Console.WriteLine("no hay descuento");
            }
            
            
            
        }
    }
}
