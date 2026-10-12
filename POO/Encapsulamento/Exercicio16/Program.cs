Funcionario funcionario = new Funcionario("Mariana", 2000);

funcionario.MostrarDados();

funcionario.AumentarSalario(10);
funcionario.MostrarDados();

funcionario.AumentarSalario(0);
funcionario.AumentarSalario(-5);
funcionario.MostrarDados();

funcionario.Nome = "Oi";
funcionario.MostrarDados();