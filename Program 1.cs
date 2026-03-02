
Console.WriteLine("Exercicio 1");
double distancia, x1, x2, y1, y2;

Console.WriteLine("digite o x1");
x1 = double.Parse(Console.ReadLine());

Console.WriteLine("digite o y1");
y1 = double.Parse(Console.ReadLine());

Console.WriteLine("digite o x2");
x2 = double.Parse(Console.ReadLine());

Console.WriteLine("digite o y2");
y2 = double.Parse(Console.ReadLine());

distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("A distancia é :" + distancia);
