const string senhaCorreta = "1234abcd";
string senha, permissaoAcesso;

Console.Write("Olá, usuário. Por favor, digite sua senha:");
senha = Console.ReadLine()!;

permissaoAcesso = senha == senhaCorreta ? "permitido" : "negado";

Console.WriteLine($" Acesso {permissaoAcesso}");