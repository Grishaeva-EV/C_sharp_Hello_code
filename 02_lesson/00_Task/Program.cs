﻿//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98 

int number = new Random().Next(100, 999);
System.Console.WriteLine("случайное число = " + number);
System.Console.WriteLine("первая цифра = " + number/100);
System.Console.WriteLine("последняя цифра = " + number % 10);
System.Console.WriteLine("результат вычисления = " + ((number/100)*10 + number % 10)); //вычисляем число
System.Console.WriteLine("результат конкатенации = " + (number/100) + number % 10); //конкатенация строки и цифр

//ну а здесь перевод числа в строки, вычленение первого и последнего символов, конкатенация и вывод результата. 
//Осталось только в этом языке научисться  работать со строками