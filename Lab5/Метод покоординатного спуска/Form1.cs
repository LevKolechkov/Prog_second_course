using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;
using org.matheval;

namespace Метод_покоординатного_спуска
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    public double MainFunc(double x, double y)
    {
      Expression expression = new Expression(textBoxFunction.Text.ToLower());
      expression.Bind("x", x);
      expression.Bind("y", y);
      decimal value = expression.Eval<decimal>();
      return (double)value;
    }

    public double ReverseMainFunc(double x, double y)
    {
      return -MainFunc(x, y);
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

      double numberOfMin = CoordinateDescent(intervalA, intervalB, accuracy);
      string resultOfCoordDesc;

      if (!numberOfMin.Equals(double.NaN))
      {
        resultOfCoordDesc = numberOfMin.ToString();
      }
      else
      {
        resultOfCoordDesc = "Нет точки минимума на заданном интервале";
      }

      textBoxMin.Text = resultOfCoordDesc;

      CreateChart(intervalA, intervalB, accuracy);
    }

    public double GetXWhereDirectionChanges(ref double x, ref double y, double delta, double a, double b, double pastResultOfFunc, double accuracy)
    {
      double resultOfFunction = MainFunc(x, y);

      if (x.ToString().Length - x.ToString().IndexOf('.') - x.ToString().IndexOf('-') - 1 > accuracy)
      {
        return double.NaN;
      }

        if (resultOfFunction > pastResultOfFunc)
      {
        return x;
      }
      else
      {
        x += delta;
        return GetXWhereDirectionChanges (ref x, ref y, delta ,a, b, pastResultOfFunc, accuracy);
      }
    }

    public double GetYWhereDirectionChanges(ref double x, ref double y, double delta, double a, double b, double pastResultOfFunc, double accuracy)
    {
      double resultOfFunction = MainFunc(x, y);

      if (y.ToString().Length - y.ToString().IndexOf('.') - y.ToString().IndexOf('-') - 1 > accuracy)
      {
        return double.NaN;
      }

      if (resultOfFunction > pastResultOfFunc)
      {
        return y;
      }
      else
      {
        y += delta;
        return GetYWhereDirectionChanges(ref x, ref y, delta, a, b, pastResultOfFunc, accuracy);
      }
    }

    public double CoordinateDescent(double interval1, double interval2, int accuracy)
    {
      double a = interval1;
      double b = interval2;

      double x = a;
      double y = a;
      double delta = Math.Pow(10, -accuracy);

      double pastResultOfFunc = MainFunc(x, y);
      x += delta;

      while (x < b || y < b)
      {
        GetXWhereDirectionChanges(ref x, ref y, delta, a, b, pastResultOfFunc, accuracy);
        GetYWhereDirectionChanges(ref x, ref y, delta, a, b, pastResultOfFunc, accuracy);
        
        if (x != double.NaN && y != double.NaN)
        {
          pastResultOfFunc = MainFunc(x, y);
        }
        else
        {
          return pastResultOfFunc;
        }
      }

      return pastResultOfFunc;
    }

    private void CreateChart(double a, double b, double accuracy)
    {
      double intervalA = a, intervalB = b, step = 1, x, y, z;
      this.chart.Series[0].Points.Clear();
      x = a;
      y = a;
      while (x <= b)
      {
        z = Math.Round(MainFunc(x, y), Byte.Parse(accuracy.ToString()));
        this.chart.Series[0].Points.AddXY(x, z);
        x += step;
      }
    }
  }
}
