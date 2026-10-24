List<Funcionario> funcionarios = new List<Funcionario>();

funcionarios.Add(new FuncionarioCLT("Ryan", 3000m));
funcionarios.Add(new FuncionarioPJ("Ana", 5000m));

foreach (Funcionario funcionario in funcionarios)
{
    Console.WriteLine($"Nome: {funcionario.Nome}");
    Console.WriteLine($"Salário: {funcionario.Salario}");
    Console.WriteLine($"Bônus: {funcionario.CalcularBonus()}");
    Console.WriteLine();
}

foreach (Funcionario funcionario in funcionarios)
{
    if (funcionario is IRelatorio relatorio)
    {
        relatorio.GerarRelatorio();
    }
}