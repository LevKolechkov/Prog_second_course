using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Дихотомия
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

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
      {
        e.Handled = true;
      }
    }

    private void расToolStripMenuItem_Click(object sender, EventArgs e)
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
        MessageBox.Show(new AccuracyException("Ошибка при вводе точности. Необходимо ввести число").Message);
        return;
      }
      else if (accuracy < 0 || accuracy >= 15)
      {
        MessageBox.Show(new AccuracyException("Точность должна быть задана в интервале от 0 до 14").Message);
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

      double resultOfDichotomy = Dichotomy(intervalA, intervalB, accuracy);
      double resultOfMinGoldenSelection = GoldenSelection(intervalA, intervalB, accuracy);
      double resultOfMaxGoldenReverseSelection = GoldenReverseSelection(intervalA, intervalB, accuracy);

      CreateChart(intervalA, intervalB);
      string messageOfDichotomy = double.IsNaN(resultOfDichotomy) ? "Нет пересечения с осью OX" : $"Значение функции: {resultOfDichotomy}";
      string messageOfMinGoldenSelection = $"Точка минимума {resultOfMinGoldenSelection}";
      string messageOfMaxGoldenReverseSelection = $"Точка максимума {resultOfMaxGoldenReverseSelection}";

      MessageBox.Show(messageOfDichotomy + '\n' + messageOfMinGoldenSelection + '\n' + messageOfMaxGoldenReverseSelection);
    }

    private double MainFunc(double x)
    {
      return (27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp(-x / 3);
    }

    private double MainReverseFunc(double x)
    {
      return -((27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp(-x / 3));
    }

    private double DerivativeOfFunc(double x)
    {
      return -((2 * x * x * Math.Exp(-x / 3)) / 3 + 10 * x * Math.Exp(-x / 3) - 27 * Math.Exp(-x / 3));
    }

    private double Dichotomy(double intervalA, double intervalB, int accuracy)
    {
      double a = intervalA;
      double b = intervalB;
      double c = (a + b) / 2;
        
      while (Math.Abs(b - a) > 2 * Math.Pow(10, -accuracy))
      {
        double y1 = MainFunc(a), y2 = MainFunc(b), y3 = MainFunc(c);
        if (y1 * y3 < 0)
        {
          b = c;
        }
        else
        {
          a = c;
        }

        c = (a + b) / 2;

      }

      if (Math.Abs(MainFunc(c)) < Math.Pow(10, -accuracy))
      {
        return Math.Round(c, accuracy);
      }
      else
      {
        return double.NaN;
      }
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
        if (MainReverseFunc(x1) < MainReverseFunc(x2))
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

    private void CreateChart(double a, double b)
    {
      double intervalA = a, intervalB = b, step = 0.1, x, y;
      this.chartOfDichotomy.Series[0].Points.Clear();
      x = a;
      while(x <= b)
      {
        y = MainFunc(x);
        this.chartOfDichotomy.Series[0].Points.AddXY(x, y);
        x += step;
      }
    }

    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      textBoxIntervalA.Clear();
      textBoxIntervalB.Clear();
      textBoxAccuracy.Clear();

      chartOfDichotomy.Series[0].Points.Clear();
    }
  }
}
