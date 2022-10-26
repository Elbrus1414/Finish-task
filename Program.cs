string[] Array;
Console.Write("Введите массив строк через , : ");
string line = Console.ReadLine();
Array = line.Split(",");
var result = new string[Array.Length];
var size = 0; //  var realSize = 0;
foreach (var elements in Array)
{
    if (elements.Length <= 3)
    {
        result[size] = elements;
        size++;
    }
}
Console.Write(string.Join(Environment.NewLine, result, 0, size));
