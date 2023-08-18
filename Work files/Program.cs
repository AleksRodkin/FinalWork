// Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито 
// одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateNewArray(int length)
{
  string[] array = new string[length];
  for (int i = 0; i < array.Length; i++)
  {
    Console.WriteLine($"\nВведите строку(слово, цифру, символы) для {i + 1} элемента массива");
    string input = Console.ReadLine()!;
    array[i] = input;
  }
  return array;
}

void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    if (i == 0) Console.Write($"['{array[i]}', ");
    else if (i < array.Length - 1)
      Console.Write($"'{array[i]}', ");
    else Console.Write($"'{array[i]}']");
  }
  Console.WriteLine("");
}

string[] CreateNewStringArray(string[] array)
{
  int length = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3) length++;
  }

  string[] ResultArr = new string[length];
  int jindex = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3 && jindex < length)
    {
      ResultArr[jindex] = array[i];
      jindex++;
    }
  }
  return ResultArr;
}

Console.WriteLine("***********************************************************************");
Console.WriteLine("Данная программа принимает на вход длину массива, элементы массива в формате строки (string), создаёт и выводит массив, а затем формирует новый массив из строк, длина которых меньше, либо равна 3 символам.");
Console.WriteLine();
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = CreateNewArray(size);
Thread.Sleep(1000);
Console.WriteLine();
Console.WriteLine("Первоначальный массив: ");
PrintArray(array);
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine("Новый массив: ");
PrintArray(CreateNewStringArray(array));
Thread.Sleep(2000);
Console.WriteLine();
Console.WriteLine("*** Ну вот и всё, ребята! ***");
Console.WriteLine();
Console.WriteLine("***********************************************************************");