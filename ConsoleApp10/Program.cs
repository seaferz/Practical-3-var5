/*В зависимости от параметров a, b, c квадратного уравнения вывести одно из 
сообщений: «корней нет», «корни действительные и различные», «корни действительные 
и равные».*/


Введите произвольные числа – n (целое), a и b. В зависимости от остатка k, 
получаемого в результате деления n на 6, вычислите значение переменной y по одной из 
следующих формул: y=1, если k=0; y=a+b, если k=1; y=a2+b2
, если k=2 или 3; y=asin(b), 
если k=4; y=aln(b), если k=5

//Просим пользователя ввести параметры
Console.Write("Введи a = ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи b = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи c = ");
double c = Convert.ToDouble(Console.ReadLine());

//вычисляем дискриминант
double discriminant = b * b - 4 * a * c;

//оперделяем тип корней
if (discriminant > 0)
{
    Console.WriteLine("Корни действительные и различные");
}
else if (discriminant == 0)
{
    Console.WriteLine("Корни действительные и равные");
}
else
{
    Console.WriteLine("Корней нет");
}
