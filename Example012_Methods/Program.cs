// Вид 1.
void Method1()
{
    Console.WriteLine("Автор ...");
}
//Method1(); // вызов метода

// Вид 2.
void Method2_1(string msg)
{
    Console.WriteLine(msg);
}
//Method2_1(msg: "Текст сообщения");

void Method2_2(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
//Method2_2(msg: "Текст сообщения", count: 4);
//Method2_2( count: 4, msg: "Текст");

//вид 3.
int Method3()
{
    return DateTime.Now.Year; 
}
int year = Method3();
//Console.WriteLine(year);

// Вид 4.
/*string Method4 (int count, string text)
{
    int i = 0;
    string result = String.Empty; // String.Empty - пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4 (10, "Текст");
Console.WriteLine (res);*/

string Method4 (int count, string text)
{
    string result = String.Empty; // String.Empty - пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }

    /*while (i < count)
    {
        result = result + text;
        i++;
    }*/
    return result;
}
string res = Method4 (10, "Текст");
//Console.WriteLine (res);
/*

for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }

    Console.WriteLine();
}

*/

// Задача
/*
string text = "Я думаю, - сказал князь, улыбаясь, что , - "
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля. "
+ " Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length; // обозначаем длину строки
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine (newText);
Console.WriteLine ();
newText = Replace(newText, 'к', 'К');
Console.WriteLine (newText); 
*/

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray (int[] array)
{
    int count = array.Length; 
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPossition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPossition]) minPossition = j;
        }



        int temporary = array[i];
        array[i] = array[minPossition]; 
        array[minPossition] = temporary;  
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
