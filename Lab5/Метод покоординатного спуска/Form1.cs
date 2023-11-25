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

      double[] arrayOfMinFun = MinCoordinateDescent(intervalA, intervalB, accuracy);
      string resultOfMinCoordDesc, xOfMinCoordDesc, yOfMinCoordDesc;

      if (!arrayOfMinFun[0].Equals(double.NaN))
      {
        resultOfMinCoordDesc = arrayOfMinFun[0].ToString();
        xOfMinCoordDesc = arrayOfMinFun[1].ToString();
        yOfMinCoordDesc = arrayOfMinFun[2].ToString();

        textBoxFunMin.Text = resultOfMinCoordDesc;
        textBoxXMin.Text = xOfMinCoordDesc; 
        textBoxYMin.Text = yOfMinCoordDesc;
      }
      else
      {
        resultOfMinCoordDesc = "Нет точки минимума на заданном интервале";
        MessageBox.Show(resultOfMinCoordDesc);
      }

      double[] arrayOfMaxFun = MaxCoordinateDescent(intervalA, intervalB, accuracy);
      string resultOfMaxCoordDesc, xOfMaxCoordDesc, yOfMaxCoordDesc;

      if (!arrayOfMaxFun[0].Equals(double.NaN))
      {
        resultOfMaxCoordDesc = arrayOfMaxFun[0].ToString();
        xOfMaxCoordDesc = arrayOfMaxFun[1].ToString();
        yOfMaxCoordDesc = arrayOfMaxFun[2].ToString();

        textBoxFunMax.Text = resultOfMinCoordDesc;
        textBoxXMax.Text = xOfMaxCoordDesc;
        textBoxYMax.Text = yOfMaxCoordDesc;
      }
      else
      {
        resultOfMinCoordDesc = "Нет точки минимума на заданном интервале";
        MessageBox.Show(resultOfMinCoordDesc);
      }

      CreateChart(intervalA, intervalB, accuracy);
    }

    public double GetXWhereDirectionChanges(Func<double, double,double> MainFunc,ref double x, ref double y, double delta, double a, double b, double pastResultOfFunc, double accuracy)
    {
      double resultOfFunction = MainFunc(x, y);

      int lengthOfX = x.ToString().Length;
      int indexOfDotOfX = x.ToString().IndexOf(',');
      int indexOfMinusOfX = x.ToString().IndexOf('-') == -1 ? 0 : x.ToString().IndexOf('-');

      if (lengthOfX - indexOfDotOfX - indexOfMinusOfX - 1 > accuracy)
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
        return GetXWhereDirectionChanges (MainFunc, ref x, ref y, delta ,a, b, pastResultOfFunc, accuracy);
      }
    }

    public double GetYWhereDirectionChanges(Func<double, double, double> MainFunc, ref double x, ref double y, double delta, double a, double b, double pastResultOfFunc, double accuracy)
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
        return GetYWhereDirectionChanges(MainFunc, ref x, ref y, delta, a, b, pastResultOfFunc, accuracy);
      }
    }

    public double[] MinCoordinateDescent(double interval1, double interval2, int accuracy)
    {
      double[] toReturnValues = new double[3];

      double a = interval1;
      double b = interval2;

      double x = a;
      double y = a;
      double delta = Math.Pow(10, -accuracy);

      double pastResultOfFunc = MainFunc(x, y);
      x = Math.Round(x + delta, accuracy);

      while (x < b)
      {
        x = Math.Round(x, accuracy);
        y = Math.Round(y, accuracy);

        GetXWhereDirectionChanges(MainFunc, ref x, ref y, delta, a, b, pastResultOfFunc, accuracy);
        GetYWhereDirectionChanges(MainFunc, ref x, ref y, delta, a, b, pastResultOfFunc, accuracy);
        
        if (x != double.NaN && y != double.NaN)
        {
          pastResultOfFunc = MainFunc(x, y);
        }
        else
        {
          toReturnValues[0] = pastResultOfFunc;
        }
      }

      toReturnValues[1] = x; 
      toReturnValues[2] = y;

      return toReturnValues;
    }

    public double[] MaxCoordinateDescent(double interval1, double interval2, int accuracy)
    {
      double[] toReturnValues = new double[3];

      double a = interval1;
      double b = interval2;

      double x = a;
      double y = a;
      double delta = Math.Pow(10, -accuracy);

      double pastResultOfFunc = ReverseMainFunc(x, y);
      x = Math.Round(x + delta, accuracy);

      while (x < b)
      {
        x = Math.Round(x, accuracy);
        y = Math.Round(y, accuracy);

        GetXWhereDirectionChanges(ReverseMainFunc, ref x, ref y, delta, a, b, pastResultOfFunc, accuracy);
        GetYWhereDirectionChanges(ReverseMainFunc, ref x, ref y, delta, a, b, pastResultOfFunc, accuracy);

        if (x != double.NaN && y != double.NaN)
        {
          pastResultOfFunc = ReverseMainFunc(x, y);
        }
        else
        {
          toReturnValues[0] = pastResultOfFunc;
        }
      }

      toReturnValues[1] = x;
      toReturnValues[2] = y;

      return toReturnValues;
    }

    private void CreateChart(double a, double b, double accuracy)
    {
      double step = Math.Pow(10, -accuracy);
      double x, y;
      this.chart.Series[0].Points.Clear();
      x = a;
      y = a;
      while (y <= b && x <= b)
      {
        double resultOfFunc = MainFunc(x, y);
        this.chart.Series[0].Points.AddXY(x, resultOfFunc);
        x += step;
        y += step;
      }
    }
  }
}
