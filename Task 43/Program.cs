double b1 = inputNumber("Введите число b1: ");
double k1 = inputNumber("Введите число k1: ");
double b2 = inputNumber("Введите число b2: ");
double k2 = inputNumber("Введите число k2: ");

double[] Point = new double[2];
Count(Point);



void Count(double[] Point)
{
    if ((k1 == k2) && (b1 == b2))
    {
        System.Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
    System.Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Point[0] = x;
        Point[1] = y;
        print(Point);
    }
return;
}


void print(double[] arr)
{
System.Console.WriteLine($"[{String.Join("; ", arr)}]");
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


