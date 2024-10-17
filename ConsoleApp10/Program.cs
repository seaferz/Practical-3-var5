/*В зависимости от параметров a, b, c квадратного уравнения вывести одно из 
сообщений: «корней нет», «корни действительные и различные», «корни действительные 
и равные».*/

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
