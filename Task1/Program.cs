//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//Заполнения массива из строки  

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];
for(int i = 0; i < size; i++)
{
    Console.Write("Введите {0}-й элемент: ", i + 1);
    massive[i] = Convert.ToInt32(Console.ReadLine());
}
void PrintArry(int[] massive)
{
    int count = massive.Length;
    int index = 0;
    Console.Write("Ваш массив: ");
    Console.Write("[");
while(index < count)
    {
    Console.Write(massive[index]);
    index++;
if (index < count)
        {
        Console.Write(", ");
        }
    }
  Console.WriteLine("]");
} 
PrintArry(massive);

int QuantityPositive(int[] massive) 
{
    int quantity = 0;
    for (int i = 0; i<massive.Length; i++ ) //Вычисление четных чисел в массиве
    {
    if (massive[i] % 2 == 1)
    {
      quantity++;
    }
  }
  return quantity;
}
int quantity = QuantityPositive(massive);
Console.WriteLine($"Количество чётных чисел в массиве = {quantity}");