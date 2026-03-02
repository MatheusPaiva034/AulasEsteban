Console.WriteLine("Matheus Paiva Batista 032064");

int A, B, C, maior;

Console.Write("Digite o valor de A - ");
A = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de B - ");
B = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de C - ");
C = int.Parse(Console.ReadLine());


if (A > B && A > C)
{
    maior = A;
}
else if (B > A && B > C)
{
    maior = B;
}
else
{
    maior = C;
}

Console.WriteLine("O valor maior é:" + maior);

int soma = A + B + C;

if (soma % 2 == 0)
{
    Console.WriteLine("A soma é um número par.");
}
else
{
    Console.WriteLine("A soma é um número impar.");
}

