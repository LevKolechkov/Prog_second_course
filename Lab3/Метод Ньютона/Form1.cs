using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet;
using MathNet.Numerics;
using System.Windows.Forms;

namespace Метод_Ньютона
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      textBoxIntervalA.KeyPress += TextBox_KeyPress;
      textBoxIntervalB.KeyPress += TextBox_KeyPress;
      textBoxAccuracy.KeyPress += TextBox_KeyPress;
    }

    private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
      {
        e.Handled = true;
      }
    }

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      double intervalA, intervalB;
      int accuracy;

      if (!double.TryParse(textBoxIntervalA.Text, out intervalA))
      {
        IntervalAException ex = new IntervalAException("Неправильный ввод интервала A");
        MessageBox.Show(ex.Message);
        return;
      }


      if (!double.TryParse(textBoxIntervalB.Text, out intervalB))
      {
        IntervalBException ex = new IntervalBException("Неправильный ввод интервала Б");
        MessageBox.Show(ex.Message);
        return;
      }

      if (!int.TryParse(textBoxAccuracy.Text, out accuracy))
      {
        MessageBox.Show(new AccuracyException("Ошибка при вводе количества знаков после запятой. Необходимо ввести число").Message);
        return;
      }
      else if (accuracy < 0 || accuracy >= 15)
      {
        MessageBox.Show(new AccuracyException("Количество знаков после запятой должно быть задано в интервале от 0 до 14").Message);
        return;
      }

      if (intervalA >= intervalB)
      {
        IntervalAException ex = new IntervalAException("Начало интервала не может совпадать или быть больше конца интервала");
        MessageBox.Show(ex.Message);
        return;
      }

      if (intervalB <= intervalA)
      {
        IntervalBException ex = new IntervalBException("Конец интервала не может совпадать или быть меньше начала интервала");
        MessageBox.Show(ex.Message);
        return;
      }

      CreateChart(intervalA, intervalB, accuracy);

      string resultOfNewton = MethodOfNewton(intervalA, intervalB, accuracy);
      double numberOfNewton = 0;

      string messageOfNewton = double.TryParse(resultOfNewton, out numberOfNewton) == false ? resultOfNewton : $"Корень равен {Math.Round(numberOfNewton, accuracy)}";

      MessageBox.Show(messageOfNewton);
    }

    public double MainFunc(double x)
    {
      return (27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp(-x / 3);
    }

    public double ReverseMainFunc(double x)
    {
      return -MainFunc(x);
    }

    public bool IsFuncContinuous(Func<double, double> func, double a, double b, double accuracy)
    {
      double x = 0;
      double e = Math.Pow(10, -accuracy);

      for (x = a; x <= b - e; x += e)
      {
        double y1 = func(x);
        double y2 = func(x + e);

        if (Math.Abs(y2 - y1) > e)
        {
          return false; // не является непрерывной
        }
      }

      return true; // является непрервывной
    }

    public bool IsFirstDerivativeContinuoues(Func<double, double> func, double a, double b, double accuracy)
    {
      double x = 0;
      double e = Math.Pow(10, -accuracy);

      for (x = a; x <= b - e; x += e)
      {
        double y1 = Differentiate.FirstDerivative(func, x);
        double y2 = Differentiate.FirstDerivative(func, x + e);

        if (Math.Abs(y2 - y1) > e)
        {
          return false; // не является непрерывной
        }
      }

      return true; // является непрервывной
    }

    public bool IsSecondDerivativeContinuoues(Func<double, double> func, double a, double b, double accuracy)
    {
      double x = 0;
      double e = Math.Pow(10, -accuracy);

      for (x = a; x <= b - e; x += e)
      {
        double y1 = Differentiate.SecondDerivative(func, x);
        double y2 = Differentiate.SecondDerivative(func, x + e);

        if (Math.Abs(y2 - y1) > e)
        {
          return false; // не является непрерывной
        }
      }

      return true; // является непрервывной
    }

    //public string TypeTextOfError(string textOfException)
    //{
    //  double numberFromException = double.Parse(textOfException);

    //  switch (numberFromException) 
    //  {
    //    case 1:
    //      return "Ошибка интервала А";

    //    case 2:
    //      return "Ошибка интервала Б";

    //    case 3:
    //      return "Ошибка при задании точности";

    //    case 4:
    //      return "Ошибка функции";
    //    case 4.1:
    //      return "Функция должна быть непрерывной";

    //    default:
    //      return "Неизвестная ошибка";
    //  }
    //}

    public string MethodOfNewton(double a, double b, double accuracy)
    {
      double e = Math.Pow(10, -accuracy);

      /*
      //if (!IsFuncContinuous(MainFunc, a, b, e))
      //{
      //  FuncException funContException = new FuncException("Функция должна быть непрерывной на интервале [a, b]");
      //  return funContException.Message;
      //}

      //if (!IsFirstDerivativeContinuoues(MainFunc, a, b, e))
      //{
      //  DerivativeException firstDerivativeException = new DerivativeException("Первая производная функции должна быть непрерывной на интервале [a, b]");
      //  return firstDerivativeException.Message;
      //}

      //if (!IsSecondDerivativeContinuoues(MainFunc, a, b, e))
      //{
      //  DerivativeException secondDerivativeException = new DerivativeException("Вторая производная функции должна быть непрерывной на интервале [a, b]");
      //  return secondDerivativeException.Message;
      //}
      */

      for (double x = a; x <= b; x += e)
      {
        double valueOfFirstDerivative = Differentiate.FirstDerivative(MainFunc, x);
        double valueOfSecondDerivative = Differentiate.SecondDerivative(MainFunc, x);

        if (valueOfFirstDerivative == 0)
        {
          return new DerivativeException("Первая производная функции не должна обращаться в 0. Используйте другую функцию").Message;
        }
        else if (valueOfSecondDerivative == 0)
        {
          return new DerivativeException("Вторая производная функции не должна обращаться в 0. Используйте другую функцию").Message;
        }
      }

      if (!((MainFunc(a) < 0 && MainFunc(b) > 0) || (MainFunc(a) > 0 && MainFunc(b) < 0)))
      {
        FuncException funSignException = new FuncException("Знак значения функции в точке а, должен отличаться от значения функции в точке б");
        return funSignException.Message;
      }

      if (Differentiate.FirstDerivative(MainFunc, a) > 0 && Differentiate.SecondDerivative(MainFunc, b) > 0)
      {
        double g = b; // g (гамма) - приближённое значение функции

        if (MainFunc(g) < 0)
        {
          while (ReverseMainFunc(g) >= e)
          {
            double g1 = g - ReverseMainFunc(g) / (Differentiate.FirstDerivative(ReverseMainFunc, g));

            g = g1;
          }
        }
        else
        {
          while (MainFunc(g) >= e)
          {
            double g1 = g - MainFunc(g) / (Differentiate.FirstDerivative(MainFunc, g));

            g = g1;
          }
        }

        return g.ToString();
      }

      if (Differentiate.FirstDerivative(MainFunc, a) > 0 && Differentiate.SecondDerivative(MainFunc, b) < 0)
      {
        double g = a; // g (гамма) - приближённое значение функции

        if (MainFunc(g) < 0)
        {
          while (ReverseMainFunc(g) >= e)
          {
            double g1 = g - ReverseMainFunc(g) / (Differentiate.FirstDerivative(ReverseMainFunc, g));

            g = g1;
          }
        }
        else
        {
          while (MainFunc(g) >= e)
          {
            double g1 = g - MainFunc(g) / (Differentiate.FirstDerivative(MainFunc, g));

            g = g1;
          }
        }

        return g.ToString();
      }

      if (Differentiate.FirstDerivative(MainFunc, a) < 0 && Differentiate.SecondDerivative(MainFunc, b) > 0)
      {
        double g = a; // g (гамма) - приближённое значение функции

        if (MainFunc(g) < 0)
        {
          while (ReverseMainFunc(g) >= e)
          {
            double g1 = g - ReverseMainFunc(g) / (Differentiate.FirstDerivative(ReverseMainFunc, g));

            g = g1;
          }
        }
        else
        {
          while (MainFunc(g) >= e)
          {
            double g1 = g - MainFunc(g) / (Differentiate.FirstDerivative(MainFunc, g));

            g = g1;
          }
        }

        return g.ToString();
      }

      if (Differentiate.FirstDerivative(MainFunc, a) > 0 && Differentiate.SecondDerivative(MainFunc, b) > 0)
      {
        double g = b; // g (гамма) - приближённое значение функции

        if (MainFunc(g) < 0)
        {
          while (ReverseMainFunc(g) >= e)
          {
            double g1 = g - ReverseMainFunc(g) / (Differentiate.FirstDerivative(ReverseMainFunc, g));

            g = g1;
          }
        }
        else
        {
          while (MainFunc(g) >= e)
          {
            double g1 = g - MainFunc(g) / (Differentiate.FirstDerivative(MainFunc, g));

            g = g1;
          }
        }

        return g.ToString();
      }

      return (new Exception(("Неизвестная ошибка")).Message);
    }

    private void CreateChart(double a, double b, double accuracy)
    {
      double intervalA = a, intervalB = b, step = 1, x, y;
      this.chartOfNewton.Series[0].Points.Clear();
      x = a;
      while (x <= b)
      {
        y = Math.Round(MainFunc(x), Byte.Parse(accuracy.ToString()));
        this.chartOfNewton.Series[0].Points.AddXY(x, y);
        x += step;
      }
    }

    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      textBoxIntervalA.Clear();
      textBoxIntervalB.Clear();
      textBoxAccuracy.Clear();

      chartOfNewton.Series[0].Points.Clear();
    }
  }
}
