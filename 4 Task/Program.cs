
Console.WriteLine("Введите число =>");  // вывод пргилащшеня для ввода
string strValue = Console.ReadLine();   // ввод строки

int value = int.Parse(strValue);        // преобразуем строку в целое число

int A = 1;
Console.Write(A+"");
while (A<value)
{
    A = A+1;
    Console.Write(A+"");
}
