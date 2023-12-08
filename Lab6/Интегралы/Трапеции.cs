using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Интегралы
{
  partial class Form1
  {
    public void CreateChartOfTrapezoid(double intervalA, double intervalB, double accuracy)
    {
      double step = accuracy;

      this.chartOfIntegrals.Series[0].Points.Clear();
      this.chartOfIntegrals.Series[1].Points.Clear();
      this.chartOfIntegrals.Series[2].Points.Clear();
      //this.chartOfIntegrals.Series[3].Points.Clear();

      double x = intervalA;

      while (x <= intervalB)
      {
        double y = Math.Round(MainFunc(x), 3);
        this.chartOfIntegrals.Series[0].Points.AddXY(x, y);
        x += 1;
      }

      x = intervalA;

      while (x <= intervalB)
      {
        double y = Math.Round(MainFunc(x), 3);
        this.chartOfIntegrals.Series[2].Points.AddXY(x, y);
        x += step;
      }
    }

    private void трапецииToolStripMenuItem_Click(object sender, EventArgs e)
    {
      double intervalA, intervalB;
      double accuracy;

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

      accuracy = Double.Parse(textBoxAccuracy.Text);

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

      double valueOfTrapezoidIntegral = 0;
      int amountOfSteps = 0;

      for (double x = intervalA + accuracy; x <= intervalB; x += accuracy)
      {
        ++amountOfSteps;

        double valueOfFuncA = MainFunc(x - accuracy);
        double valueOfFuncB = MainFunc(x);

        valueOfTrapezoidIntegral += ((valueOfFuncA + valueOfFuncB) / 2) * (x - (x - accuracy));
      }

      textBoxTrapezoidValue.Text = valueOfTrapezoidIntegral.ToString();

      CreateChartOfTrapezoid(intervalA, intervalB, accuracy);
    }
  }
}
