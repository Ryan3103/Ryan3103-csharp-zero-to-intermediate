List<Entrega> entregas = new List<Entrega>();

entregas.Add(new EntregaExpressa("São Paulo", 5));
entregas.Add(new EntregaEconomica("Rio de Janeiro", 5));
entregas.Add(new EntregaExpressa("Curitiba", 3));
entregas.Add(new EntregaEconomica("Salvador", 7));

foreach (Entrega entrega in entregas)
{
    Console.WriteLine($"{entrega.Destino} - Prazo: {entrega.CalcularPrazo()} dias");
}