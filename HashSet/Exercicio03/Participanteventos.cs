HashSet<string> eventoA = new HashSet<string>();
HashSet<string> eventoB = new HashSet<string>();


for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Digite seu nome: ");
    string nome = Console.ReadLine();

    eventoA.Add(nome);
}

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Digite seu nome: ");
    string nome = Console.ReadLine();

    eventoB.Add(nome);
}

HashSet<string> ambos = new HashSet<string>(eventoA);
ambos.IntersectWith(eventoB);

HashSet<string> todos = new HashSet<string>(eventoA);
todos.UnionWith(eventoB);

Console.WriteLine("Pessoas nos dois eventos:");

foreach (string pessoa in ambos)
{
    Console.WriteLine(pessoa);
}

Console.WriteLine($"Quantidade nos dois eventos: {ambos.Count}");

Console.WriteLine("Pessoas em pelo menos um evento:");

foreach (string todo in todos)
{
    Console.WriteLine(todo);
}

Console.WriteLine($"Quantidade em pelo menos um evento: {todos.Count}");