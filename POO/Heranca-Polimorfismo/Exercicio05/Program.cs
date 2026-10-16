List<Veiculo> veiculos = new List<Veiculo>();

veiculos.Add(new Carro("Civic"));
veiculos.Add(new Moto("CG 160"));
veiculos.Add(new Carro("Corolla"));
veiculos.Add(new Moto("Biz"));

foreach (Veiculo veiculo in veiculos)
{
    Console.WriteLine($"{veiculo.Modelo} - {veiculo.CalcularConsumo()} km/L");
}