using System;
using Polimorfismo_Overload.Classes;

namespace Polimorfismo_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("Paulo");
            fun.Mostrar(2);

            Console.Beep(3000, 5000);
        }
    }
}
