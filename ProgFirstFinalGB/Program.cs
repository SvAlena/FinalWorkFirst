Console.WriteLine("Enter an array of three lines: ");

string[] array = new string[3];
CreateArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
SortArray(array);

void CreateArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine("The entered array: ");
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}
void SortArray(string[] array)
{
    Console.WriteLine("A new array, where 3 characters or less: ");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i].Length <= 3)
        {
            Console.Write(array[i] + ", "); 
        }
    }
    Console.Write("]");
    Console.WriteLine();
}