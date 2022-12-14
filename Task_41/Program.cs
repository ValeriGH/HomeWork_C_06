// Пользователь вводит m чисел. 
// Посчитать количество чисел > 0 

Console.Clear();
Console.Write("Сколько чисел будете вводить? ");
int m = int.Parse(Console.ReadLine());
int[] numbers = new int[m];
int count = 0;
for (int i = 0; i < m; i++)
{
    Console.Write($"Введите {i + 1} число: ");
    numbers[i] = int.Parse(Console.ReadLine());
    if (numbers[i] > 0) count++;
}
Console.WriteLine($"Вы ввели чисел больше нуля: {count}");
