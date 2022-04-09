public class Individuo 
{
    public string Nome { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double Imc { get => Peso / (Altura * Altura); }

    public Individuo(string nome, double altura, double peso)
    {
        this.Nome = nome;
        this.Altura = altura;
        this.Peso = peso;
    }

    public string Situação()
    {
        string resultado = "";

        if(Imc < 17) 
        {
            resultado = "Muito abaixo do peso";
        }

        else if(Imc < 18.5)
        {
            resultado = "Abaixo do peso";
        }

        else if(Imc < 25)
        {
            resultado = "Peso normal";
        }

        else if(Imc < 30)
        {
            resultado = "Acima do peso";
        }

        else if(Imc < 35)
        {
            resultado = "Obesidade I";
        }
            
        else if(Imc < 40)
        {
            resultado = "Obesidade II";
        }

        else
        {
            resultado = "Obesidade III";
        }

        return resultado;
    }

    public double PesoIdeal()
    {
        if(Imc >= 25)
        {
            double pesoIdeal = Peso - ((24.99 * Peso) / Imc);
            return pesoIdeal;
        }

        else if(Imc < 18.5)
        {
            double pesoIdeal = ((18.5 * Peso) / Imc) - Peso;
            return pesoIdeal;
        }

        return 0;
    }
}