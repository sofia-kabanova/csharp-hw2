//Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 ->  да
// 1 -> нет
Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
bool Weekend(int num)
{
    return num == 6 || num == 7;
}
if (day >0 && day < 8 )
{
bool result = Weekend(day); 
if(result) Console.WriteLine($"{day} - выходной");
else Console.WriteLine($"{day} - не выходной");
}
else Console.WriteLine($"{day} - нет такого дня недели");
