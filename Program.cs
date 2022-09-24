// >Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// >>456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Task #10");
Console.Clear();
Console.WriteLine("Insert number from 100 to 999");
int x = Convert.ToInt32(Console.ReadLine());
if((x <  100) || (x > 1000))
{
    Console.WriteLine("Your number is wrong :try again");
}
else{

    double newX = (x / 10) % 10;
    Console.WriteLine(newX);
}


