Console.Clear();

Console.WriteLine("Введите длину массива: ");

int n = Convert.ToInt32(Console.ReadLine()), sum = 0;

int[] arr = new int[n];

for (int i = 0; i < arr.Length; i++)

arr[i] = new Random().Next(-100, 101);

Console.WriteLine($"[{string.Join(", ", arr)}]");

for (int j = 0; j < arr.Length; j++)

{if (j % 2 == 1)
sum = sum + arr[j];};

Console.WriteLine($"Результат: {sum}");



