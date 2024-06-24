//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

public class Answer {

static public int  InputFromConsole(){
    Console.Write("Введите натуральное число : ");
    string? input =Console.ReadLine();
    int num = Convert.ToInt32(input);
    return num;

}

 
    static public void Main(string[] args) {
        
         int xNumber=InputFromConsole();

        
        var digitArray = new int[100];
        int i=0;
        while( xNumber >0){


            digitArray[i]=(xNumber % 10);
            xNumber = xNumber/10;
            i++;

        }
        Array.Resize(ref digitArray, i);
        Array.Reverse(digitArray);

        Console.WriteLine(string.Join(", ", digitArray));
     
    }
}