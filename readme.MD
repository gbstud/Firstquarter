Итоговая проверочная работа (1 блок)
Условие задачи
Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:
1.	Создать репозиторий на GitHub
2.	Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3.	Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4.	Написать программу, решающую поставленную задачу
5.	Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)
Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Решение:
1. Создал репозиторий Firstquarter
2. Блок-схема  
![image](.\Block-scheme.drawio.png)
3.	Вся информация в файле README.md
4.	Программа находится в ветке main
Код программы:
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
