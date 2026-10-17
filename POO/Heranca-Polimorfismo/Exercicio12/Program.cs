List<Transporte> transportes = new List<Transporte>();

transportes.Add(new Onibus(10));
transportes.Add(new Taxi(20));
transportes.Add(new Onibus(15));
transportes.Add(new Taxi(40));

foreach (Transporte transporte in transportes)
{
    Console.WriteLine($"{transporte.Nome} - Tarifa: R$ {transporte.CalcularTarifa():F2}");
}