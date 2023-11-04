void numberAB(double a , double b)
{
    
    while(a < 10 && b < 10)
    {
        double result = Math.Pow(a,b);
        Console.WriteLine($" {a} ^ {b} = {result}");
        a++;
        b++;
    }
  
}

Console.Write("Введите число A : ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B : ");
double y = Convert.ToDouble(Console.ReadLine());
numberAB(x,y);
