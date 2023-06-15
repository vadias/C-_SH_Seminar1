// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int res = 0;
res = a%2;
if(res == 0) {
    Console.WriteLine("число чётное");
} else {
    Console.WriteLine("число не чётное");
}