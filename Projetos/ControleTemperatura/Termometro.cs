class Termometro
{
    public double Temperatura {get; private set;}

    public Termometro(double temperatura)
    {
        Temperatura = temperatura;
    }

    public void AumentarTemperatura(double valor)
    {
        if (valor <= 0)
            throw new ArgumentException("Valor inválido");
        
        Temperatura += valor;
    }
    public void DiminuirTemperatura(double valor)
    {
        if (valor <= 0)
            throw new ArgumentException("Valor inválido");
        
        Temperatura -= valor;
    }
}