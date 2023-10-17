using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }

    public double MainFunc(double x)
    {
      return ((27 - 18 * x + 2 * x * x) * Math.Exp(-x/3));
    }
    public bool IsContinuous(double a, double b, double e)
    {
      double x = 0;

      for (x = a; x <= b - e; x += e)
      {
        double y1 = MainFunc(x);
        double y2 = MainFunc(x + e);

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
      if (!IsContinuous(a, b, e))
      {
        FuncException funException = new FuncException("Функция должна быть непрерывной");
        return funException.Message;
      }


    }

  }
}
