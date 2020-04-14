using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Ingreso_Producto
{
    class Program
    {
        static void Main(string[] args)
        {
            string Producto;
            int Cantidad;
            double Precio;
            Double TotalaPagar;
            Console.WriteLine("*****Programa Prueba******");

            do
            {                 
                Console.WriteLine("Ingrese Producto");
                Producto = Console.ReadLine();  
            } while (Producto.Length <= 0 );

            Console.WriteLine("Ingrese Cantidad");
            Cantidad = Convert.ToInt32(Console.ReadLine());

            while (Cantidad<=0)
            { 
                Console.WriteLine("Ingrese Cantidad");                
                Cantidad = Convert.ToInt32(Console.ReadLine());
            }
            
               Console.WriteLine("Ingrese Precio");                 
               Precio = Convert.ToDouble(Console.ReadLine());         
                         
            while (Precio <=0)             
               
             {
                    Console.WriteLine("Ingrese Precio");
                    Precio = Convert.ToDouble(Console.ReadLine());
                }
            
              TotalaPagar = Precio * Cantidad;

            Console.WriteLine("******************************************");
            Console.WriteLine("El Total  A pagar Del Producto {0} es de {1} $ ",Producto,TotalaPagar);
            Console.WriteLine("******************************************");








        }   






            

    }
}
