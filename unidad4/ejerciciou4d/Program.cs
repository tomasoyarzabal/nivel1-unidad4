using System;

namespace ejerciciou4d
{
    class Program
    {
        //Hacer un programa para ingresar 4 números. 
        //Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
        static void Main(string[] args)
        {
            int a,b,c,d;
            Console.WriteLine("ingrese el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el cuarto numero");
            d = int.Parse(Console.ReadLine());
            if(a > b && b > c && c > d){
             Console.WriteLine("ESTAN ORDENADOS");
            }else{
                Console.WriteLine("NO ESTAN ORDENADOS");
            }
        }
    }
}
