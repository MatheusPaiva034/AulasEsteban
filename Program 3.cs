double n1, n2, n3;
double resultado;

Console.WriteLine("Digite a primeira nota");
n1 = double.Parse(Console.ReadLine());
n1 = (n1 * 2);

Console.WriteLine("Digite a segunda nota");
n2 = double.Parse(Console.ReadLine());
n2 = (n2 * 3);

Console.WriteLine("Digite a terceira nota");
n3 = double.Parse(Console.ReadLine());
n3 = (n3 * 5);

resultado = (n1 + n2 + n3) / 10;
Console.WriteLine("A media final é:" + resultado);