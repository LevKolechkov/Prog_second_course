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

      string resultOfNewton = MethodOfNewton(intervalA, intervalB, accuracy);
      double numberOfNewton = 0;

      string messageOfNewton = double.TryParse(resultOfNewton, out numberOfNewton) == false ? resultOfNewton : $"Корень равен {numberOfNewton}";

      MessageBox.Show(messageOfNewton);
    }

    public double MainFunc(double x)
    {
      return 5 * x + 1;
    }

    public bool IsFuncContinuous(Func<double, double> func, double a, double b, double e)
    {
      double x = 0;

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

    public bool IsFirstDerivativeContinuoues(Func<double, double> func, double a, double b, double e)
    {
      double x = 0;

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

    public bool IsSecondDerivativeContinuoues(Func<double, double> func, double a, double b, double e)
    {
      double x = 0;

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

    public string MethodOfNewton(double a, double b, double e)
    {
      if (!IsFuncContinuous(MainFunc, a, b, e))
      {
        FuncException funException = new FuncException("Функция должна быть непрерывной на интервале [a, b]");
        return funException.Message;
      }

      if (!IsFirstDerivativeContinuoues(MainFunc, a, b, e))
      {
        DerivativeException firstDerivativeException = new DerivativeException("Первая производная функции должна быть непрерывной на интервале [a, b]");
        return firstDerivativeException.Message;
      }

      if(!IsSecondDerivativeContinuoues(MainFunc, a, b, e))
      {
        DerivativeException secondDerivativeException = new DerivativeException("Вторая производная функции должна быть непрерывной на интервале [a, b]");
        return secondDerivativeException.Message;
      }

      return "0";
    }

  }
}
