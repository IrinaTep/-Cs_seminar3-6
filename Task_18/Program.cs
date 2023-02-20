/*
 Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/

Console.Write("Введите номер четверти: ");
string number = Console.ReadLine();

string quarter = Quarter(number);

Console.WriteLine(quarter);

string Quarter(string num)
{

 //   if(num == 1) return "Диапазон возможных координат: x > 0 и y > 0";
 //  if(num == 2) return "Диапазон возможных координат: x < 0 и y > 0";
 //   if(num == 3) return "Диапазон возможных координат: x < 0 и y < 0";
 //   if(num == 4) return "Диапазон возможных координат: x < 0 и y < 0";
 //   return "Введены некорректные координаты";

switch(num)
{
    case "1": return "Диапазон возможных координат: x > 0 и y > 0";
    case "2": return "Диапазон возможных координат: x < 0 и y > 0";
    case "3": return "Диапазон возможных координат: x < 0 и y < 0";
    case "4": return "Диапазон возможных координат: x < 0 и y < 0";
    default: return "Введены некорректные координаты";
}
}