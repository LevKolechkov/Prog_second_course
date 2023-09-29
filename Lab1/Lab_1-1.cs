using System;

namespace Lab
{
  class V
  {
    static void Main(string[] args)
    {
      double L, a, b, l, r, volumeOfBlock, volumeOfCylinder;
      double Pi = Math.PI;

      try
      {
        Console.WriteLine("Введите длину бруска (L)");
        L = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите длину ребра бруска (a)");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите длину ребра бруска (b)");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите длину цилиндра (l)");
        l = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите радиус цилиндра (r)");
        r = Convert.ToDouble(Console.ReadLine());
      }
      catch (FormatException)
      {
        Console.WriteLine("Неправильно введенные данные. Попробуйте снова.");
        return;
      }

      volumeOfBlock = L * a * b;
      volumeOfCylinder = l * Pi * r * r;

      double perc = 100 - (volumeOfCylinder / volumeOfBlock) * 100;

      Console.WriteLine($"Объем бруска: {volumeOfBlock}");
      Console.WriteLine($"Объем цилиндра: {volumeOfCylinder}");
      Console.WriteLine($"Процент материала, ушедшего в отходы: {perc}%");
    }
  }
}