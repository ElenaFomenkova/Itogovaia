string[] fillArray(string inStr)
{
    return inStr.Split(" ");
}
void printArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            Console.WriteLine(array[i]);
        }
    }
}
Console.Write("Введите слова через пробел");

string str = Convert.ToString(Console.ReadLine());

string[] array = fillArray(str);
printArray(array);