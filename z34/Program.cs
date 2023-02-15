Console.Clear();

Console.WriteLine("Введите длину массива: ");

int n = Convert.ToInt32(Console.ReadLine()), count = 0;

int[] arr = new int[n];


for (int i = 0; i < arr.Length; i++)

arr[i] = new Random().Next(100, 1000);

Console.WriteLine($"[{string.Join(", ", arr)}]");

for (int j = 0; j < arr.Length; j++)
{
if (arr[j] % 2 == 0)
count = count + 1;};
Console.WriteLine(count);