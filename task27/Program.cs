/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int sumOfNumberDigits1 (int number){
    //первый вариант алгоритма, без применения строковых функций:

    int divisor = 1;
    int previousRemainder = 0;
    int sum = 0;

    while ( number/divisor > 0 ){
        
        int thisRemainder = number % (divisor * 10);
        sum += (thisRemainder - previousRemainder) / divisor;
        
        previousRemainder = thisRemainder;
        divisor *= 10;        
    }

    return sum;

}

int sumOfNumberDigits2 (int number){
    
    //второй вариант решения, с использованием строковых функций:
    int sum = 0;   
    
    string strNumber = Convert.ToString(number);
    for (int i = 0; i < strNumber.Length; i++){
        sum += strNumber[i] - 48; //ASCII conversion
    }
    return sum;

}


int number;
Console.Write($"Введите целое число: ");
if ( int.TryParse(Console.ReadLine(), out number) )
{
    
    Console.WriteLine("Алгоритм 1: Сумма всех цифр в числе {0}", sumOfNumberDigits1(number));


    
    Console.WriteLine("Алгоритм 2: Сумма всех цифр в числе {0}", sumOfNumberDigits2(number));

}
else
{
    Console.WriteLine("Ошибка ввода");
}