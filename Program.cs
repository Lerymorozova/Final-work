string[] array;
Console.WriteLine("Введите массив строк через пробел");
string a = Console.ReadLine();
array = a.Split(' ');
var result = new string[array.Length];
var Size = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[Size] = value;
        Size++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, Size));
Console.WriteLine();
