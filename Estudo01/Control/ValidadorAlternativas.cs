using System;

namespace Estudo01.Control
{
    public class ValidadorAlternativas
    {
        public void Processar(int numero)
        {
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Numero 1");
                    break;
                case 2:
                    Console.WriteLine("switch");
                    break;
                case 3:
                    Console.WriteLine("Numero 3");
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Numero 2");
                    break;
                default:
                    Console.WriteLine("Numero invalido");
                    break;
            }
        }
    }
}