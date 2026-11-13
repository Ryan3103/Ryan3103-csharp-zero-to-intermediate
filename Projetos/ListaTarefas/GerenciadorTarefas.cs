class GerenciadorTarefas
{
    List<Tarefa> tarefas = new List<Tarefa>();

    public void AdicionarTarefa(Tarefa tarefa)
    {
        tarefas.Add(tarefa);
    }

    public void ExibirTarefas()
    {
        foreach (Tarefa tarefa in tarefas)
        {
            Console.WriteLine($"{tarefa.Descricao} - Concluída: {tarefa.Concluida}");
        }
    }
}