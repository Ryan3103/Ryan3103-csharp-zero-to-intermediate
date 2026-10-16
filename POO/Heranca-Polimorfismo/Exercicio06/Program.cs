List<Funcionario> funcionarios = new List<Funcionario>();

funcionarios.Add(new FuncionarioCLT("Ana", 3000));
funcionarios.Add(new FuncionarioFreelancer("Bruno", 800, 3));
funcionarios.Add(new FuncionarioCLT("Carla", 4500));
funcionarios.Add(new FuncionarioFreelancer("Diego", 500, 2));

foreach (Funcionario funcionario in funcionarios)
{
    Console.WriteLine($"{funcionario.Nome} - R$ {funcionario.CalcularPagamento():0.##}");
}