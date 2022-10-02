Commands();
string[] array = new string[] {};
Console.WriteLine("Введите номер варианта (от 1 до 3): ");
string fromUser = Console.ReadLine();
if (fromUser=="1")
{
  array = new string[] { "Hello", "2", "world", ":-)" }; 
}
else if (fromUser=="2")
{
    array = new string[] { "1234", "1567", "-2", "computer science" }; 
}
else if (fromUser=="3")
{
   array = new string[] { "Russia", "Denmark", "Kazan" };
}
else
{
    Console.WriteLine($"{fromUser} - Такого варианта нет");
}


int NewArrayLength = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) NewArrayLength=NewArrayLength+1;
}

string[] newArray = new string[NewArrayLength];
int index = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[index] = array[i];
        index=index+1;
    }
}

PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);

// Функция: Вывод вариантов для работы с программой
void Commands()
{
    Console.WriteLine();
    Console.WriteLine("СПИСОК ВАРИАНТОВ:");
    Console.WriteLine("1 – использовать массив: [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2 – использовать массив: [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3 – использовать массив: [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine();
}

// Функция ввода
string ReadInput(string msg)
{
    Console.Write(msg);
    return Console.ReadLine();
}

//  Функция вывода массива в терминал
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}
