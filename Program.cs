
/* Homework 1
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a, b;
Console.Write("Enter first num: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second num: " );
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine("max = a, min = b");
else 
    Console.WriteLine("max = b, min = a");  
    */

/*Homework 2
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 

int num1, num2, num3;
Console.WriteLine("Enter First num: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second num: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third num: ");
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
 if (num1 > max) max = num1;
 if (num2 > max) max = num2;
 if (num3 > max) max = num3;


Console.Write("max = ");
Console.WriteLine(max);
*/

//Homework 3
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
int number;
Console.WriteLine("Enter num:");
number = Convert.ToInt32(Console.ReadLine());
if ((number % 2) == 0)

    Console.WriteLine("Even number ");
else 

    Console.WriteLine("Odd number ");
*/

/*  * NO GOOD *
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int numb ,twDignumb ,sDignumb;
Console.WriteLine("Enter three digit num: ");
numb = Convert.ToInt32(Console.ReadLine());
twDignumb = numb / 10;
sDignumb =  twDignumb % 100;
Console.WriteLine("sDignumb");
*/


/*
//use .ToLower//
Console.Write("Enput name:");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Yee, it's Masha! ");
}
else 
{
    Console.Write("Hi, ");
    Console.WriteLine(username);

}
*/

// Find max//
/*
int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;
if (d > max ) max = d;
if (e > max ) max = e;

Console.Write("max = ");
Console.WriteLine(max);

*/

/*
//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

 
int FindQuadrant(double x ,double y)
{
    if (x > 0 && y >0)return 1;
    if (x < 0 && y >0)return 2;
    if (x < 0 && y <0)return 3;
    if (x > 0 && y <0)return 4;
    return 0;
}

Console.Write("Input an x - coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input an y - coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadNum = FindQuadrant(xA,xA);

Console.WriteLine($"The point A({xA}), {yA}) is DateOnly the {quadNum}");

*/



//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


void FindCoordinates (int quadrant);
{
if (quadrant == 1)
    Console.WriteLine("x > 0 and y > 0");
if (quadrant == 2)
    Console.WriteLine("x > 0 and y > 0");
if (quadrant == 3)
    Console.WriteLine("x > 0 and y > 0");
if (quadrant == 4)
    Console.WriteLine("x > 0 and y > 0");
    }

Console.WriteLine("Please, input quandrant");
int quadrant = Convert.ToInt32(Console.ReadLine());
if (quadrant > 5 && quadrant< 5);
else 
    Console.WriteLine("No coordinates for this quadrant.");




