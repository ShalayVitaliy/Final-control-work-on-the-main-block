Console.Clear();

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

Console.WriteLine($"[{string.Join(", ",AS)}]");

void newStrings(string[] massive)
{
  string[] BS;
  int rand_size = new Random().Next(1,4);
  Console.WriteLine($"Длинна нового массива: {rand_size}");
  BS = new string[rand_size];
  for (int i = 0; i < rand_size; i++)
  {
    int rand = new Random().Next(0, massive.Length);
    BS[i] = massive[rand];
  }
  Console.WriteLine($"[{string.Join(", ",BS)}]");
}

newStrings(AS);

