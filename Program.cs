
/* number2
double DistanceAB(int xa, int ya ,int za, int xb , int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distAB = Math.Round(Math.Sqrt(deltaX*deltaX+deltaY*deltaY+deltaZ*deltaZ), 2);
    return distAB;
}
Console.Write("input X coordinat is A:  ");
int xAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("input Y coordinat is A:  ");
int yAcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("input Z coordinat is A:  ");
int zAcoord = Convert.ToInt32(Console.ReadLine());

Console.Write("input X coordinat is B:  ");
int xBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("input Y coordinat is B:  ");
int yBcoord = Convert.ToInt32(Console.ReadLine());
Console.Write("input Z coordinat is B:  ");
int zBcoord = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB(xAcoord , yAcoord , zAcoord, xBcoord, yBcoord, zBcoord );
Console.WriteLine($"distance between A & Bis :{distanceAB} ");
*/



//Number 3
/*
void CubeNumber (int Un)
{
    int current =1 ;
    while(current <= Un)
    {
        int res = current * current * current;
        Console.Write($"{res}, ");
        current++;
    }
    Console.WriteLine("\b\b. ");

}
Console.Write("input number N:  ");
int user_number = Convert.ToInt32(Console.ReadLine());
if(user_number>=1)
{
    Console.Write($"{user_number}->");
    CubeNumber (user_number);
}
else
Console.Write("Error");
*/


//number 1
/*
void Palindrom(int Un)
{
    int num1=Un/10000;
    int num2=Un%10;
    if(num1==num2)
    {
    int num3=Un/1000;
    int num4=num3%10;
    int num5=Un/10;
    int num6=num5%10;
    if(num4==num6)
    {
        Console.WriteLine("This is palindrom");
    }
    else
    Console.WriteLine("Not palindrom");
    }
    else
    Console.WriteLine("Not palindrom");
}
Console.Write("input your number :  ");
int user_number = Convert.ToInt32(Console.ReadLine());
if(user_number<9999 && 100000<user_number)
{
    Console.WriteLine("Error");
}
else
Palindrom(user_number);
*/
