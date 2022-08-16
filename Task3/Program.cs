//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for(int i = 0; i < size; i++)
{
    Console.Write("Введите {0}-й элемент: ", i + 1);
    array[i] = Convert.ToInt32(Console.ReadLine());
}
void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("Ваш массив: ");
    Console.Write("[");
while(index < count)
    {
    Console.Write(coll[index]);
    index++;
if (index < count)
        {
        Console.Write(", ");
        }
    }
  Console.WriteLine("]");
} 
PrintArry(array);
int min = Int32.MaxValue;
int max = Int32.MinValue;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
    max = array[i];
    }
    if (array[i] < min)
    {
    min = array[i];
    }
}
Console.WriteLine($"Всего чисел = {array.Length}"); 
Console.WriteLine($"Максимальное число = {max}");
Console.WriteLine($"минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");