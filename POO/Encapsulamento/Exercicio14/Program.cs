Tarefa tarefa = new Tarefa("Estudar C#", "Praticar propriedades em C#");

tarefa.MostrarDados();

tarefa.Concluir();
tarefa.MostrarDados();

tarefa.Reabrir();
tarefa.MostrarDados();

// Testes de valores inválidos
tarefa.Titulo = "Oi";
tarefa.Descricao = "ABC";
tarefa.MostrarDados();