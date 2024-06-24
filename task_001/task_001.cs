//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

using System;
using System.Globalization;


public class Answer {

static public int  InputFromConsole(){
    Console.Write("Введите число или 0 для выхода: ");
    string? input =Console.ReadLine();
    int num = Convert.ToInt32(input);
    return num;

}

 
    static public void Main(string[] args) {
        int num;
        do{  num=InputFromConsole();

        if (0==num%7 && 0==num%23)
         {
            Console.WriteLine("число кратно 7 и 23");
            continue;

        } else {
          
            Console.WriteLine("число не кратно 7 и 23");
            continue;
        }
        }while(num != 0);
        
      
        
        
    }
}