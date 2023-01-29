Console.WriteLine("Введите количество элементов массива: ");
int elementssize = int.Parse(Console.ReadLine());
string[] array = new string[elementssize];



for (int i = 0; i < elementssize; i++)
{
    Console.WriteLine("Введите элемент массива: ");
    string element = Console.ReadLine();
    array[i] = element;
}

Console.WriteLine();
Console.WriteLine("Вывод массива: ");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {

        count++;
    }
}

Console.WriteLine();
Console.Write("Полученный массив: ");
string[] arraynew = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        arraynew[j] = array[i];
        Console.WriteLine(arraynew[j]);
        j++;
    }
}


