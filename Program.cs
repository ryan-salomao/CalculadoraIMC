using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua altura em metros?");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso em kg?");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);
            string resultado = "";

            if(imc < 17) 
            {
                resultado = "Muito abaixo do peso";
            }

            if(imc >= 17 || imc < 18.5)
            {
                resultado = "Abaixo do peso";
            }

            if(imc >= 18.5 || imc < 25)
            {
                resultado = "Peso normal";
            }

            if(imc >= 25 || imc < 30)
            {
                resultado = "Acima do peso";
            }

            if(imc >= 30 || imc < 35)
            {
                resultado = "Obesidade I";
            }

            if(imc >= 35 || imc < 40)
            {
                resultado = "Obesidade II";
            }

            if(imc >= 40)
            {
                resultado = "Obesidade III";
            }

            Console.WriteLine("{0} sua altura é {1} e seu peso é {2}", nome, altura, peso);

            Console.WriteLine("Seu IMC é {0}", imc);

            Console.WriteLine("Situação: {0}.", resultado);
        }
    }
}
