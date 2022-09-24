// >Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// >>456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();
// Console.WriteLine("Task #10");
// Console.WriteLine("Insert number from 100 to 999");
// int x = Convert.ToInt32(Console.ReadLine());
// if((x <  100) || (x > 1000))
// {
//     Console.WriteLine("Your number is wrong :try again");
// }
// else{

//     double newX = (x / 10) % 10;
//     Console.WriteLine(newX);
// }

///////////////////////////////////////////////////////////////////////////////////

// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.

// >>645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.WriteLine("Task #13");
// Console.Write("Input any number: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2){
//   Console.WriteLine("third number is -> " + anyNumberText[2]);
// }
// else {
//   Console.WriteLine("-> third number missing");
// }
///////////////////////////////////////////////////////////////////////////////////  
   
// >Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// >>6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Task #15");
Console.WriteLine(" Input a number of a week's day (1-7) ");
int daynumber = Convert.ToInt32(Console.ReadLine());
if(daynumber == 6 || daynumber == 7)
    {
        Console.WriteLine("It's Weekends --> yes");
    }
else if (daynumber < 1 || daynumber > 7)
    {
        Console.WriteLine("Maximum 7 days in a Week");
    }
else
    {
        Console.WriteLine("It's NOT Weekends --> No");
    }

