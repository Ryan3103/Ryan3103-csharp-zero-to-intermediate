abstract class Desconto
{
    public abstract double Calcular(double valor);
}
 class CalculadoraDesconto 
    {
        public double CalcularPrecoFinal(Desconto desconto, double valor)
    {
        return desconto.Calcular(valor);
    }
    }