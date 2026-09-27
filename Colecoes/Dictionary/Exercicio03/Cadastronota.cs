Dictionary<string, int> notas = new Dictionary<string, int>();

int maior = 0;
int soma = 0;
string alunonota = "";

notas.Add("Ryan", 10);
notas.Add("Gui", 6);
notas.Add("Fernanda", 8);
notas.Add("Pedro", 4);
notas.Add("Maria", 3);

foreach (KeyValuePair<string, int> nota in notas)
{
    soma += nota.Value;
    if (nota.Value > maior)
    {
        maior = nota.Value;
        alunonota = nota.Key;
    }

    Console.WriteLine($"Nome: {nota.Key} - Nota: {nota.Value}");

}

int media = soma / notas.Count;

Console.WriteLine($"O aluno com maior nota é {alunonota} com a nota: {maior}");
Console.WriteLine($"Média da turma: {media}");

Console.WriteLine("Digite o nome de um aluno: ");
string nome = Console.ReadLine();

if (notas.ContainsKey(nome))
{
    Console.WriteLine($"Nota dele: {notas[nome]}");
}
else
{
    Console.WriteLine("Aluno não encontrado.");
}