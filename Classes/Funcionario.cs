using System;

namespace Polimorfismo_Overload.Classes
{
    public class Funcionario
    {
        private string[] lista = {"Paulo", "Tsuka", "Priscila", "Fernanda", "Paulo"};
        
        public void Mostrar()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice){
            Console.WriteLine("Busca por índice: " + lista[indice]);
        }

        public void Mostrar(string busca)
        {
            foreach (var item in lista)
            {
                if (item == busca)
                {
                    Console.WriteLine("Resultado da Busca: " + item);
                }
            }
        }
        
    }
}