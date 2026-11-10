class ImpressoraMultifuncional : IImpressora, IDigitalizadora
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimindo documento...");
    }
    public void Digitalizar()
    {
        Console.WriteLine("Digitalizando documento...");
    }
    public void EnviarFax()
    {
        Console.WriteLine("Enviando fax...");
    }
}