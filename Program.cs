void PrintMassiv(string []mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
}

void StringLessFoureCharackers(string []mass)
{
    List<string> Massiv = new List<string>();
    int count = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {        
        char[] arr = mass[i].ToArray();
        if (arr.GetLength(0) < 4)
        {
            Massiv.Add(new string(mass[i]));
            count++;                       
        }
    }
    
    Console.WriteLine("В данном массиве строки менее 4 символов ");
    if (Massiv.Count == 0)
    {
       Console.WriteLine("отсутствуют"); 
    }
    for (int i = 0; i < Massiv.Count; i++)
    {
        Console.Write($"{Massiv[i]} ");
    }
    Console.WriteLine();
}

string []array1 = {"hello", "2", "world", ":-)"};
string []array2 = {"1234", "1567", "-2", "computer"};
string []array3 = {"Russia", "Denmark", "Kazan"};

PrintMassiv(array1);
StringLessFoureCharackers(array1);

PrintMassiv(array2);
StringLessFoureCharackers(array2);
PrintMassiv(array3);
StringLessFoureCharackers(array3);

