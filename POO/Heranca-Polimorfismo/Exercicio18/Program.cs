List<Funcionario> funcionarios = new List<Funcionario>();

funcionarios.Add(new Funcionario("Ana", 2000));
funcionarios.Add(new Gerente("Bruno", 3000));
funcionarios.Add(new Freelancer("Carla", 500, 4));

foreach (Funcionario funcionario in funcionarios)
{
    Console.WriteLine($"{funcionario.Nome} - R$ {funcionario.NovoValor():F2}");
}