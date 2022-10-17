
//              Entrada de Dados

string nome;

do {
    Console.Write("Qual é o seu nome? ");
    nome  = Console.ReadLine();
    if (nome == "") {
        Console.WriteLine("Nome não pode ser nulo, por favor, use um nome válido.");
    }
} while (nome == "");
Console.WriteLine("Muito preazer em te conheçer, " + nome + "!");
