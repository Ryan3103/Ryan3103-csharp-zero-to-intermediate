List<Funcionario> funcionarios = new List<Funcionario>();

funcionarios.Add(new Funcionario("Ana", 2000));
funcionarios.Add(new FuncionarioComBonus("Bruno", 3000, 500));

foreach(Funcionario funcionario in funcionarios)
{
    Console.WriteLine($"{funcionario.Nome}: R$ {funcionario.CalcularSalario():F2}");
}