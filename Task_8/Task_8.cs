// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int num = 2;
while(num < n) {
    Console.Write(num);
    num = num + 2;
    if(num < n) {Console.Write(",");}
}