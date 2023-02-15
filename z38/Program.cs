Console.Clear();

Console.WriteLine("Введите длину массива: ");

int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < arr.Length; i++)

arr[i] = new Random().Next(-100, 101);

Console.WriteLine($"[{string.Join(", ", arr)}]");

int max = arr[0], min = arr[0];

for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] > max)
    max = arr[j];

    if (arr[j] < min)
    min = arr[j];
};

Console.WriteLine(max - min);