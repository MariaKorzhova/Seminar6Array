int M = inputNumber("Введите количество чисел: ");
int[] Array= new int[M];
int[] NewArray = WriteArray(Array);
print(NewArray);
CheckArray(NewArray);
int Count = CheckArray(NewArray);
System.Console.WriteLine($"Количество чисел больше нуля равно: {Count}");





int CheckArray(int[] NewArray)
{
    int count = 0;
for (int i = 0; i < NewArray.Length; i++)
{
    if (NewArray[i] > 0)
    {
        count = count + 1;
    }
}
return count;
}


int[] WriteArray (int[] Array)
{
for (int i = 0; i < M; i++)
{
    System.Console.Write("Введите число: ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
return Array;
}

void print(int[] arr)
{
System.Console.WriteLine($"[{String.Join(", ", arr)}]");
}



int inputNumber(string str)
{
int number;
string text;

while (true)
{
Console.Write(str);
text = Console.ReadLine();
if (int.TryParse(text, out number))
{
break;
}
Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}
return number;
}

