using System;
public class Program
{

    public static void Main()
    {
        //HelloWorld();
        //ChangeNumbers();
        //NumbersCount();
        GeronsFormula();
    }
    public static void HelloWorld()
    {
        // 1. Запросить имя пользователя. Вывести Hello, [имя пользователя].
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}.");
    }

    public static void ChangeNumbers()
    {
        //2. Запросить у пользователя два целых числа и сохранить в двух переменных.
        //   Вывести значения.Обменять значения переменных: например, если в переменной
        //   x было записано число 3, а в y число 5, сделать так, чтобы в y стало 3, а в x стало 5.
        //   Вывести значения после обмена
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
    
    public static void NumbersCount()
    {
        //3. Запросить у пользователя целое положительное число. Вывести количество цифр числа.
        //   Например, в числе 156 - 3 цифры.
        string number = Console.ReadLine();
        Console.WriteLine(number.Length);
    }
    public static void GeronsFormula()
    {
        //4. Запросить у пользователя длины трёх сторон треугольника. Длины могут быть представлены дробными значениями.
        //   После получения длин сторон - использовать формулу Герона для вычисления площади треугольника.
        //   Чтобы жизнь не казалась мёдом найдите формулу самостоятельно.После вычисления площади - вывести результат на консоль
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double perimeter = a + b + c;
        double area = Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));

        Console.WriteLine(area);
    }
    
    public static void 
}
