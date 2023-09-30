using System;

namespace Lab
{
  class V
  {
    static void Main(string[] args)
    {
      double L, a, b, l, r, volumeOfBlock, volumeOfCylinder;
      double Pi = Math.PI;

      Exception checkForException(string param)
      {
        if (Convert.ToDouble(param) <= 0) throw new Exception();
        if (param.IndexOf(" ") >= 0) throw new Exception();
        return null;
        
      }

      try
      {
        Console.WriteLine("Введите длину бруска (L)");
        string L1 = Console.ReadLine();
        checkForException(L1);
        L = Convert.ToDouble(L1);

        Console.WriteLine("Введите длину ребра бруска (a)");
        string a1 = Console.ReadLine();
        checkForException(a1);
        a = Convert.ToDouble(a1);

        Console.WriteLine("Введите длину ребра бруска (b)");
        string b1 = Console.ReadLine();
        checkForException(b1);
        b = Convert.ToDouble(b1);

        Console.WriteLine("Введите длину цилиндра (l)");
        string l1 = Console.ReadLine();
        checkForException(l1);
        l = Convert.ToDouble(l1);

        Console.WriteLine("Введите радиус цилиндра (r)");
        string r1 = Console.ReadLine();
        checkForException (r1);
        r = Convert.ToDouble(r1);

        if (r > a / 2 || r > b / 2 || l > L) throw new Exception();
      }
      catch (Exception)
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