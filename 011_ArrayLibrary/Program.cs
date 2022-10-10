//Найди ошибку, не работает!!!
void FillArray(int[] collection) // Метод Void ничего не возвращает return не нужен
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] col)  // Метод void который будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Если выпало значение -1, значит элемент не нйден, его нет.
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;   // В случае парных элементов показывается первый из них.
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);   //Заполняет массив
PrintArray(array);  //Распечатывает массив на экран
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
