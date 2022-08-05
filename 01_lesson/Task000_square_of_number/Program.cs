// Task000_square_of_number: input a number and output it a square
Console.Write("Введите число ");
double.TryParse(Console.ReadLine(), out double number);
//double number = Console.ReadLine();
Console.Write("Квадрат этого числа равен ");
Console.WriteLine(number * number);