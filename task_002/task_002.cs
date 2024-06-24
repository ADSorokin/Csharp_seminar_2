
//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.




using System;

class Answer


{
static public int  InputFromConsole(){
    string? input =Console.ReadLine();
    int num = Convert.ToInt32(input);
    return num;

}


    static public void Main()
    {
        Console.Write("Введите координату X: ");
        int x = InputFromConsole();

        Console.Write("Введите координату Y: ");
        double y = InputFromConsole();

        if (x == 0 || y == 0)
        {
            Console.WriteLine("Координаты не должны быть равны 0.");
            return;
        }

        int quarter;
        if (x > 0 && y > 0)
        {
            quarter = 1;
        }
        else if (x < 0 && y > 0)
        {
            quarter = 2;
        }
        else if (x < 0 && y < 0)
        {
            quarter = 3;
        }
        else
        {
            quarter = 4;
        }

        Console.WriteLine($"Точка с координатами ({x}, {y}) находится в {quarter}-й координатной четверти.");
    }
}