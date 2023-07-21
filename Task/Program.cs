﻿Console.Clear();

int Prompt(string msg)
{
  Console.Write(msg);
  string value = Console.ReadLine();
  int result = int.Parse(value);
  return result;
}

string[] AS; // массив строк
int count; // длина массива
string s; // дополнительная переменная-строка

// 2. Ввести количество строк

count = Prompt("Введите длину массива: ");

// 3. Выделить память для массива из count строк
AS = new string[count];

// 4. Ввести данные массива с клавиатуры
Console.WriteLine("Enter array:");

for (int i=0; i<AS.Length; i++)
{
  Console.Write("AS[{0}] = ", i);
  AS[i] = Console.ReadLine();
}

// 5. Сортировка методом вставки
for (int i = 0; i < AS.Length - 1; i++)
  for (int j = i; j >= 0; j--)
    if (String.Compare(AS[j], AS[j + 1]) > 0) // функция Compare()
    {
      // поменять значения местами
      s = AS[j];
      AS[j] = AS[j + 1];
      AS[j + 1] = s;
    }

// 6. Вывести массив AS
Console.WriteLine("Sorted array:");
Console.WriteLine($"[{string.Join(", ",AS)}]");

Console.ReadKey();

