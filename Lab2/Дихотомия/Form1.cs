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

    private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

      MessageBox.Show($"Значение функции: {resultOfDichotomy}");
    }

    private double mainFunc(double x)
    {
      return (27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Exp(-x / 3);
    }
    
    private double mainReverseFunc(double x)
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
        double y1 = mainFunc(a), y2 = mainFunc(b), y3 = mainFunc(c);
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
  }
}