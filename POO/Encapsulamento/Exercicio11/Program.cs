ContaUsuario conta = new ContaUsuario();

conta.Usuario = "Ryan";
conta.Senha = "abc123";
conta.Tentativas = 3;

conta.MostrarDados();

conta.Usuario = "Ry";
conta.Senha = "123";
conta.Tentativas = 8;

conta.MostrarDados();