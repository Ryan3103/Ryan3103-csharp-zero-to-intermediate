List<Funcionario> funcionarios = new List<Funcionario>();

funcionarios.Add(new Desenvolvedor("Ana"));
funcionarios.Add(new Desenvolvedor("Lucas"));
funcionarios.Add(new Designer("Mariana"));

foreach (Funcionario funcionario in funcionarios)
{
    Console.WriteLine($"{funcionario.Nome} - {funcionario.DescreverAtividade()}");
}