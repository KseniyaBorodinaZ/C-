﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write ("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());

if(numberOne > numberTwo && numberTwo > numberThree)
{
    Console.Write ($"max = {numberOne} min = {numberThree}");
   
}
else if (numberOne < numberTwo && numberOne > numberThree)
{
    Console.Write($"max = {numberTwo} min = {numberThree}");
}
else if (numberOne < numberThree && numberOne > numberTwo)
{
Console.Write ($"max = {numberThree} min = {numberTwo}");
}
else if (numberTwo < numberThree && numberOne < numberTwo)
{
    Console.Write ($"max = {numberThree} min = {numberOne}");
}
else
{
    Console.Write ("Они равны!");
}