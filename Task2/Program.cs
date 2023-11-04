int Promt(string message)           
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int SumAllNumbers(int number)
{
    int result = 0;
    while (number > 0)
    {                                                                                                                                           // 3
        result+= number % 10; 
        number = number / 10;   
    }
    return result;
}
int number = Promt("Введи число: ");
Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllNumbers(number)}");