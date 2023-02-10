// Напишите программу, котоая принимает на вход координаты точки,
// и выдаёт номер четверти, в которой находиться эта точка.

//Задание 1:
/*
int GetQuadrant(int x, int y)
{
    int quadNum = 0;
    if(x > 0 && y > 0) quadNum = 1;
    else if(x < 0 && y > 0) quadNum = 2;
    else if(x < 0 && y < 0) quadNum = 3;
    else if(x > 0 && y < 0) quadNum = 4;

    return quadNum;
}


Console.Write("Input a first coordinate: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second coordinate: ");
int yA = Convert.ToInt32(Console.ReadLine());

int result = GetQuadrant(xA, yA);

if(result == 0)
    Console.WriteLine("Your point is on axes");
else
    Console.WriteLine($"Your point is on {result} quadrant");
*/

//Задание 2:

// Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координатточек в этой четверти (x и y).

/*
void RangeQuardinat(int quadNum)
{
    if(quadNum == 1) Console.Write("x > 0 && y > 0");
    else if(quadNum == 2) Console.Write("x < 0 && y > 0");
    else if(quadNum == 3) Console.Write("x < 0 && y < 0");
    else if(quadNum == 4) Console.Write("x > 0 && y < 0");
}

Console.Write("Input a number quadNum ");
int quadNum = Convert.ToInt32(Console.ReadLine());

RangeQuardinat(quadNum);
*/
//Задание 3: Напишите программу, которая принимает число N и выводит
// квадраты чисел от 1 до N.
/*
void SquareNumbers(int N)
{
    int i = 1;
    while( i <= N)
    {
        Console.Write( i * i + ", ");
        i++;
    }
}

Console.WriteLine("Input a number ");
int N = Convert.ToInt32(Console.ReadLine());

SquareNumbers(N);
*/

//Задание 4: Напишите программу, которая принимает координаты двух точек
// и находит расстояние между ними в 2D пространстве.
/*
double Length(double x1, double y1, double x2, double y2)
{
    double n1 = x2 - x1;
    double n2 = y2 - y1;
    double result = Math.Sqrt(Math.Pow(n1,2) + Math.Pow(n2,2));
    return result;
}

Console.Write("Введите координату X первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Длина отрезка: " + Math.Round(Length(x1, y1, x2, y2), 2));
*/
// Домашнее задание:
// Задание 19:
/*
bool Palindrome(int number)
{
    bool result = false;
     if (number[0] == number[4] && number[1] == number[3]);
    {
        result = true;
    }    
    return result;
}

Console.WriteLine("Введите число: ");
string number = Convert.ToInt32(Console.ReadLine());
int len = number.Length;
*/
// Задание 21:
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Length (double x1, double y1, double x2, double y2, double z1, double z2)
{
    double n1 = x2 - x1;
    double n2 = y2 - y1;
    double n3 = z2 - z1;
    double result = Math.Sqrt(Math.Pow(n1,2) + Math.Pow(n2,2) + Math.Pow(n3,2));
    return result;
}


Console.Write("Введите координату X первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Длина отрезка: " + Math.Round(Length(x1, y1, x2, y2, z1, z2), 2));
*/

// Задание 23:
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void SquareNumbers(int N)
{
    int i = 1;
    while( i <= N)
    {
        Console.Write( i * i * i + ", ");
        i++;
    }
}

Console.WriteLine("Input a number ");
int N = Convert.ToInt32(Console.ReadLine());

SquareNumbers(N);
*/