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

            else if(imc < 18.5)
            {
                resultado = "Abaixo do peso";
            }

            else if(imc < 25)
            {
                resultado = "Peso normal";
            }

            else if(imc < 30)
            {
                resultado = "Acima do peso";
            }

            else if(imc < 35)
            {
                resultado = "Obesidade I";
            }
            
            else if(imc < 40)
            {
                resultado = "Obesidade II";
            }

            else
            {
                resultado = "Obesidade III";
            }

            Console.WriteLine("{0}, sua altura é {1} metros e seu peso é {2} quilos.", nome, altura, peso);

            Console.WriteLine("Seu IMC é {0}.", imc);

            Console.WriteLine("Situação: {0}.", resultado); 

            if(imc >= 25)
            {
                double pesoIdeal = (24.99 * peso) / imc;
                double perderPeso = peso - pesoIdeal;
                Console.WriteLine("Você deve perder {0} quilos para chegar ao seu peso ideal.", perderPeso);
            }

            if(imc < 18.5)
            {
                double pesoIdeal = (18.5 * peso) / imc;
                double ganharPeso = pesoIdeal - peso;
                Console.WriteLine("Você deve ganhar {0} quilos para chegar ao seu peso ideal.", ganharPeso);
            }
        }
    }
}
