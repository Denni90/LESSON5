//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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
int sum = 0;
for (int z = 0; z < massive.Length; z+=2)
{
    sum = sum + massive[z];
}
PrintArry(massive);
Console.WriteLine($"Cумма элементов на нечётных позициях = {sum}");
