List<Funcionario> funcionarios = new List<Funcionario>();

funcionarios.Add(new Gerente("Ana", 5000));
funcionarios.Add(new Desenvolvedor("Bruno", 4000));
funcionarios.Add(new Gerente("Carla", 6000));
funcionarios.Add(new Desenvolvedor("Diego", 3500));

foreach (Funcionario funcionario in funcionarios)
{
    Console.WriteLine($"{funcionario.Nome} - Salário: R$ {funcionario.CalcularSalario():F2}");
}