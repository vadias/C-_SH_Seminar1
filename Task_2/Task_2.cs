// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите два числа");
int a;
int b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

Console.Write("max = ");

if (a > b) {
    Console.WriteLine(a);
} else {
    Console.WriteLine(b);
}