using System;

namespace ejerciciou4c
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float precio = 0;
            int procesador, memoria, disco;
            Console.WriteLine("ingrese un tipo de microprocesador");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la memoria ram deseada");
            memoria = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Amplia disco?");
            disco = int.Parse(Console.ReadLine());
             
            switch(procesador)
            {
             case 1:
              switch(memoria)
                {
                    case 1:
                    precio = 800;
                    break;
                    case 2:
                    precio = 900;
                    break;
                    case 3:
                    precio = 1000;
                    break;
                }
                break;
             case 2:
               switch(memoria)
               {
                   case 1:
                   precio = 900;
                   break;
                   case 2:
                   precio = 1000;
                   break;
                   case 3:
                   precio = 1400;
                   break;
               }   
               break;
             case 3:
               switch(memoria)
               {
                   case 1:
                   precio = 1200;
                   break;
                   case 2:
                   precio = 1400;
                   break;
                   case 3:
                   precio = 2000;
                   break;
               }
               break;
            }
            if(disco == 1){
                precio = precio + 300;  
                Console.WriteLine("El precio es " + precio);
            }
        }
    }
}
