using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejer1_Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marca;
            double precio = 0, descuento = 0, importCompra = 0, importDescu = 0, importPago = 0, pordescuento = 0;
            int cantidad, obsequio;

            Console.Write("Ingrese la marca (Dell,HP,Apple,Asus):");
            marca = Console.ReadLine();

            Console.Write("Ingrese la cantidad:");
            cantidad = int.Parse(Console.ReadLine().ToLower());

            //Llamando a las funciones
            precio = Calcularprecio(marca);
            importCompra = Calcularimporcompra(cantidad, precio);
            pordescuento = Calculcularporcedescuento(cantidad, precio);
            importDescu = Calcularimportdescu(cantidad, precio);
            importPago = Calcularimportpago(descuento, importCompra);
            obsequio = Calcularobsequio(marca, cantidad);

            //Imprimir resultados
            Console.WriteLine("Importe de compra:" + importCompra);
            Console.WriteLine("Importe de descuento:" + importDescu);
            Console.WriteLine("Importe de pago:" + importPago);
            Console.WriteLine("Obsequio-Mouse pad:" + obsequio);
        }
        //Función para determinar el precio
        //Se declara como parámetro las variables  que han sido leídos
        //o que han sido calculados en otras funciones
        static double Calcularprecio(string marca)
        {
            double precio = 0;
            if (marca == "Dell")
                precio = 11000.00;
            else if (marca == "HP")
                precio = 9000.00;
            else if (marca == "Apple")
                precio = 13000.00;
            else
                precio = 12500.00;

            return precio;
        }
        //Función para calcular importe de compra
        static double Calcularimporcompra(int cantidad, double precio)
        {
            double importCompra = 0;
            importCompra = cantidad * precio;
            return importCompra;
        }
        // Función para calcular el importe de compra sin descuento
        static double Calculcularporcedescuento(int cantidad, double precio)
        {
            double descuento = 0;
            if (cantidad <= 3)
                descuento = 0.035;
            else if (cantidad >= 4 && cantidad < 6)
                descuento = 0.05;
            else if (cantidad >= 6 && cantidad < 9)
                descuento = 0.065;
            else
                descuento = 0.08;
            return descuento;
        }
        //Función para calcular el importe de descuento
        static double Calcularimportdescu(double descuento, double importCompra)
        {
            double importDescu = 0;
            importDescu = descuento * importCompra;
            return importDescu;
        }
        //Función para calcular el importe de pago
        static double Calcularimportpago(double descuento, double importCompra)
        {
            double importPago = 0;
            importPago = importCompra - descuento;
            return importPago;
        }

        //Función para calcular el obsequio
        static int Calcularobsequio(string marca, int cantidad)
        {
            int obsequio;
            if (marca == "HP")
                obsequio = 3 * (cantidad / 3);
            else
                obsequio = 0;
            return obsequio;
        }
    }
}
