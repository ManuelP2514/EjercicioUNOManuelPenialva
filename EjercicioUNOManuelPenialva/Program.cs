using System;

namespace EjercicioUNOManuelPenialva
{
    class Program
    {
        static void Main(string[] args)
        {
            double CantidadDeDolares, PesosArg, PesosArgConDolarParalelo, Euros;

            Console.WriteLine("Ingrese La Cantidad De Dolares ");
            CantidadDeDolares = double.Parse(Console.ReadLine());

            PesosArg = (CantidadDeDolares * 230);
            Console.WriteLine($" La Cantidad De Pesos Que Puede Comprar Es {PesosArg} En El Mercado Oficial");

            PesosArgConDolarParalelo = (CantidadDeDolares * 280);
            Console.WriteLine($" La Cantidad De Pesos Que Puede Comprar Es {PesosArgConDolarParalelo} En El Mercado Paralelo ");

            Euros = (CantidadDeDolares/1.17);
            Console.WriteLine($" El Equivalente en Euros A La Cantidad De Dolares Ingresados Es {Euros}");
        }
    }
}
