Console.Clear();

//Criar um vetor de valores numéricos
int[] vetor = new int[100];

//Necessário um laço de repetição - FOR
Random random = new Random();
for(int i = 0; i < vetor.Length; i++)
{
    //Gerar os valores aleatórios
    //Guardar os valores dentro do vetor
    vetor[i] = random.Next(1000);
}

//Imprimir o vetor não ordenado
for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

Array.Sort(vetor);

//Imprimir o vetor ordenado
Console.WriteLine("\n\n");
for(int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

