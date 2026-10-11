Usuario usuario = new Usuario();

usuario.Nome = "Ryan";
usuario.Idade = 18;
usuario.Email = "Email@gmail.com";

usuario.MostrarDados();

usuario.Nome = "Cu";
usuario.Idade = 5;
usuario.Email = "Email.Invalido";

usuario.MostrarDados();