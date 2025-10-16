using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marca;
            double precio = 0, descuento = 0, importCompra = 0, importDescu = 0, importPago = 0;
            int cantidad, obsequio;

            Console.Write("Ingrese la marca (Dell,HP,Apple,Asus):");
            marca = Console.ReadLine();

            Console.Write("Ingrese la cantidad:");
            cantidad = int.Parse(Console.ReadLine());

            if (marca == "Dell")
                precio = 11000.00;
            else if (marca == "HP")
                precio = 9000.00;
            else if (marca == "Apple")
                precio = 13000.00;
            else
                precio = 12500.00;

            //Calculo importe de compra sin descuento

            importCompra = cantidad * precio;

            if (cantidad <= 3)
                descuento = 0.035;
            else if (cantidad >= 4 && cantidad < 6)
                descuento = 0.05;
            else if (cantidad >= 6 && cantidad < 9)
                descuento = 0.065;
            else
                descuento = 0.08;

           // Calculo importe de  descuento
            importDescu =descuento * importCompra;

           // Calculo importe de pago
            importPago=importCompra-descuento;

            //Calculo obsequio
            if (marca == "HP")
                obsequio = 3 * (cantidad / 3);
            else
                obsequio=0;

            Console.WriteLine("Importe de compra:" + importCompra);
            Console.WriteLine("Importe de descuento:" + importDescu);
            Console.WriteLine("Importe de pago:"+importPago);
            Console.WriteLine("Obsequio-Mouse pad:"+obsequio);
        }   
    }
}
