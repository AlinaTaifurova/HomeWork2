/* Задача 4 * : Напишите программу, которая выводит случайное трёхзначное 
число и удаляет вторую цифру этого числа. Не использовать строки для расчета.*/


Random rnd = new Random();
int number = rnd.Next(99, 1000);
Console.WriteLine("Рандомное трехзначное чило: " + number);
{
    string buf = number.ToString();
    Console.WriteLine("Это же число, но без второго разряда: " + buf.Remove(1,1));
}