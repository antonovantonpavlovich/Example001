/*int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}
//               0   1   2   3   4   5   6   7   8   - индекс массива  
int [] array = {11, 21, 31, 41, 51, 61, 17, 18, 19};
//array[0] = 12;
//Console.WriteLine(array[4]);

int result = Max (Max(array[0], array[1], array[2]), 
Max(array[3], array[4], array[5]), 
Max(array[6], array[7], array[8]));

Console.WriteLine(result);

/*int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);*/

/*int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine (max);*/

/*int [] array = {1, 2, 3, 4, 5, 15, 4, 17, 18};

int n = array.Length;
int find = 4;

int index = 0;
while (index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;//index = index + 1;
}*/

void FillArray(int[]collection)
{
    int Length = collection.Length; // получаем длину массива
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);// кладем значение рандомное от 1 до 10
        index ++;//index = index + 1;
    }
}

void PrintArray(int[] col) //метод который печатает массив
{
    int count = col.Length;//обозначаем колличество элементов
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10]; // определили массив, который состоит из 10 эллементов

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 444);
Console.WriteLine(pos);
