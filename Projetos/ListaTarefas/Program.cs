GerenciadorTarefas gerenciador = new GerenciadorTarefas();

Tarefa tarefa1 = new Tarefa("Estudar C#");
Tarefa tarefa2 = new Tarefa("Fazer exercícios");
Tarefa tarefa3 = new Tarefa("Estudar SQL");

gerenciador.AdicionarTarefa(tarefa1);
gerenciador.AdicionarTarefa(tarefa2);
gerenciador.AdicionarTarefa(tarefa3);


gerenciador.ExibirTarefas();

tarefa1.Concluir();

gerenciador.ExibirTarefas();