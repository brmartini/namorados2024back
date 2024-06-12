Console.WriteLine("OI...");
Thread.Sleep(1000);
Console.WriteLine("\nSABIA QUE EU...\n");
Thread.Sleep(1000);

int n = 6;
for (int i = n / 2; i <= n; i += 2)
{
    for (int j = 1; j < n - i; j += 2)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    for (int j = 1; j <= n - i; j++)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

for (int i = n; i >= 1; i--)
{
    for (int j = i; j < n; j++)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= (i * 2) - 1; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

Thread.Sleep(1000);
Console.WriteLine("\nVOCÊ ? ");
Thread.Sleep(1000);
Console.WriteLine("\nQUER NAMORAR COMIGO ?");
string? resposta = Console.ReadLine();
if (String.IsNullOrEmpty(resposta) || resposta.ToLower() != "sim")
{
    Console.WriteLine("\nResposta errada, acho que você se enganou. Vou entender como um SIM.");
    Console.ReadKey();
}
else
{
    Console.WriteLine("\nResposta certa.");
}
