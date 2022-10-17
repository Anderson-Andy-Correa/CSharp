
Random gerador = new Random(); // Nome_da_classe Nome_do_Objeto = Instânciador Método_Construtor

for (int i = 0; i < 10; i++) {
    int n1 = gerador.Next();
    int n2 = gerador.Next(10);
    int n3 = gerador.Next(5, 20);
    Console.WriteLine("Acabei de gerar os números " + n1 + ", " + n2 + ", " + n3);
}


int[] vetor = {321, 123};

for(int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine(vetor[i]);
}