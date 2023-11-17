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
using org.matheval;

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
      string resultOfGoldenSelection = GoldenSelection(intervalA, intervalB, accuracy).ToString();
      string resultOfGoldenReverseSelection = GoldenReverseSelection(intervalA, intervalB, accuracy).ToString();
      double numberOfNewton = 0;

      string messageOfNewton = double.TryParse(resultOfNewton, out numberOfNewton) == false ? resultOfNewton : $"Корень равен {Math.Round(numberOfNewton, accuracy)}";
      messageOfNewton += $"\nX в точке минимума: {resultOfGoldenSelection}";
      messageOfNewton += $"\nX в точке максимума: {resultOfGoldenReverseSelection}";

      MessageBox.Show(messageOfNewton);
    }

    public double MainFunc(double x)
    {
      //return (27 - 18 * x + 2 * x * x) * Math.Exp(-x/3);
      return (27 - 18 * x + 2 * x * x) * Math.Exp(-x / 3);
      //Expression expression = new Expression(textBoxFunction.Text);
      //expression.Bind("x", x);
      //return double.Parse(expression.Eval<decimal>().ToString());
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

    private double GoldenSelection(double intervalA, double intervalB, int accuracy)
    {
      double FI = (1 + Math.Sqrt(5)) / 2;

      double a = intervalA;
      double b = intervalB;
      double x1 = b - (b - a) / FI;
      double x2 = a + (b - a) / FI;

      while (Math.Abs(b - a) > Math.Pow(10, -accuracy))
      {
        if (MainFunc(x1) < MainFunc(x2))
        {
          b = x2;
        }
        else
        {
          a = x1;
        }

        x1 = b - (b - a) / FI;
        x2 = a + (b - a) / FI;
      }

      return Math.Round((a + b) / 2, accuracy);
    }

    private double GoldenReverseSelection(double intervalA, double intervalB, int accuracy)
    {
      double FI = (1 + Math.Sqrt(5)) / 2;

      double a = intervalA;
      double b = intervalB;
      double x1 = b - (b - a) / FI;
      double x2 = a + (b - a) / FI;

      while (Math.Abs(b - a) > Math.Pow(10, -accuracy))
      {
        if (ReverseMainFunc(x1) < ReverseMainFunc(x2))
        {
          b = x2;
        }
        else
        {
          a = x1;
        }

        x1 = b - (b - a) / FI;
        x2 = a + (b - a) / FI;
      }

      return Math.Round((a + b) / 2, accuracy);
    }

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

      for (double x = a; x <= b; x += Math.Pow(10, -5))
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
        FuncException funSignException = new FuncException("Знак значения функции в точке а, должен отличаться от значения функции в точке б. Попробуйте другой интервал");
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
