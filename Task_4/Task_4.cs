// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите 3 числа");
int[] nums = new int[3];

nums[0] = Convert.ToInt32(Console.ReadLine());
nums[1] = Convert.ToInt32(Console.ReadLine());
nums[2] = Convert.ToInt32(Console.ReadLine());

int max = nums[0];

for(int t = 0; t < 3; t++){

    if (max < nums[t]) {
        max = nums[t];
    }
}
Console.Write("максимальное = ");
Console.WriteLine(max);