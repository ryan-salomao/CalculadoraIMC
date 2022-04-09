using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Individuo i1 = new Individuo("Fulano", 1.75, 90.0);

            Console.WriteLine("{0}, sua altura é {1} metros e seu peso é {2} quilos.", i1.Nome, i1.Altura, i1.Peso);
            Console.WriteLine("Seu IMC é {0}.", i1.Imc);
            Console.WriteLine("Situação: {0}.", i1.Situação());

            if(i1.Imc >= 25)
            {
                Console.WriteLine("Você deve perder {0} quilos para chegar ao seu peso ideal.", i1.PesoIdeal());
            }

            if(i1.Imc < 18.5)
            {
                Console.WriteLine("Você deve ganhar {0} quilos para chegar ao seu peso ideal.", i1.PesoIdeal());
            }
        }
    }
}
