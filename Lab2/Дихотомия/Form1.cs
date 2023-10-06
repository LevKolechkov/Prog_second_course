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
      if (!double.TryParse(textBoxIntervalA.Text, out intervalA) || !double.TryParse(textBoxIntervalB.Text, out intervalB)
        || !int.TryParse(textBoxAccuracy.Text, out accuracy) || intervalA >= intervalB)
      {
        MessageBox.Show("Ошибка при вводе значений интервала или точности. Повторите попытку ввода.");
        return;
      }

      double resultOfDichotomy = Dichotomy(intervalA, intervalB, accuracy);
      double resultOfMaxGoldenSelection = GoldenSelection(intervalA, intervalB, accuracy);
      double resultOfMinGoldenReverseSelection = GoldenReverseSelection(intervalA, intervalB, accuracy);

      CreateChart(intervalA, intervalB);
      MessageBox.Show($"Значение функции: {resultOfDichotomy}\n" + $"Точка минимума {resultOfMaxGoldenSelection}\n" + $"Точка максимума: {resultOfMinGoldenReverseSelection}");
    }

    private double MainFunc(double x)
    {
      return (27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp(-x / 3);
    }

    private double MainReverseFunc(double x)
    {
      return -((27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp(-x / 3));
    }

    private double Dichotomy(double intervalA, double intervalB, int accuracy)
    {
      double a = intervalA;
      double b = intervalB;
      double c = (a + b) / 2;

      while (Math.Abs(a - b) > Math.Pow(10, -accuracy))
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

      return Math.Round(c, accuracy);
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
      double x = a;
      double y;
      double step = 0.01;

      chart.Series[0].Points.Clear();

      chart.ChartAreas[0].AxisX.Crossing = 0;

      if (a - b == 0)
      {
        b += 10;
      }

      while (x <= b)
      {
        y = MainFunc(x);

        chart.Series[0].Points.AddXY(x,y);
        x += step;
      }
    }

    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      textBoxIntervalA.Clear();
      textBoxIntervalB.Clear();
      textBoxAccuracy.Clear();

      chart.Series[0].Points.Clear();
    }
  }
}
