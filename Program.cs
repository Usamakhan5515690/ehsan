int a, b,c;
Console.WriteLine("Please type a first number");
a=int.Parse(Console.ReadWriteLine());
Console.WriteLine("Please type a second number");
b=int.Parse(Console.ReadWriteLine());
c=a;
a=b;
b=c;
Conosole.WriteLine($"YOur 1st value is{a}and 2nd value is{b}");