// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exemplo de uso de array!");

MediaIdades();

void MediaIdades()
{

    // exemplos de declarações de array
    string[] palavras = new string[5] { "André", "Jose", "Andressa", "Neia", "Sarah" };
    double[] valores = { 2.6, 9.7, 7.5, 1.8 };

    // teste prático
    int[] idades = new int[5];

    Console.WriteLine("Entre com o número das 5 idades:");
    idades[0] = int.Parse(Console.ReadLine());
    idades[1] = int.Parse(Console.ReadLine());
    idades[2] = int.Parse(Console.ReadLine());
    idades[3] = int.Parse(Console.ReadLine());
    idades[4] = int.Parse(Console.ReadLine());

    Console.WriteLine($"Tamanho do arrary: {idades.Length}");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"índice: [{i}] = {idade}");
        acumulador += idade;
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idade: {media}");
}


