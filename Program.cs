// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string[] array1 = new string[5] {"Russia", "Kazan", "D", "Yes", "2"};
string[] array2 = new string[array1.Length];
void NewArray(string[] array1, string[] array2)
{
    int num = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length<=3)
        {
            array2[num] = array1[i];
            num++;
        }
    }
}

void PrintArray(string[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
    Console.WriteLine();

NewArray(array1, array2);

PrintArray(array2);