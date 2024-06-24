//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
using System;

class Answer
{
static public int  InputFromConsole(){
    Console.Write("Введите число в диапазоне [10, 99]или 0 для выхода: ");
    string? input =Console.ReadLine();
    int num = Convert.ToInt32(input);
    return num;

}

    static public void Main()
    {   
        int maxDig,num;
        do{
        
        num = InputFromConsole();
        
        if (num < 10 || num > 99)
        {
            Console.WriteLine("Число должно быть в диапазоне [10, 99].");
            num = InputFromConsole();;
        }
  
        int fstDig = num / 10;
        int secDig = num % 10;
      
        if (fstDig >= secDig){
           maxDig = fstDig;}
        else 
           maxDig = secDig;
        
        Console.WriteLine($"Наибольшая цифра числа {num} - {maxDig}.");
        }while(num != 0);
    }
}


