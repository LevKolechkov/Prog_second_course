using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using org.matheval;

namespace МНК
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    public void ClearChart()
    {
      this.chart1.Series[0].Points.Clear();
      this.chart1.Series[1].Points.Clear();
      this.chart1.Series[2].Points.Clear();
    }

    public void DrawDots(DataGridView dt)
    {
      try
      {
        ClearChart();

        for (int index = 0; index < dt.RowCount - 1; ++index)
        {
          this.chart1.Series[0].Points.AddXY
            (
              Double.Parse(dt[0, index].Value.ToString()),
              Double.Parse(dt[1, index].Value.ToString())
            );
        }
      }
      catch (Exception ex) 
      {
        ShowError(ex.Message);
      }
    }

    public void ShowError (string message)
    {
      MessageBox.Show(message);
    }

    private void buttonChooseFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();

      if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        this.textBoxWayToFile.Text = openFileDialog1.FileName;
      }
    }

    private void buttonLoadExcel_Click(object sender, EventArgs e)
    {
      string PathConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBoxWayToFile.Text + ";Extended Properties='Excel 12.0;IMEX=1;'";
      OleDbConnection conn = new OleDbConnection(PathConn);

      OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + textBoxNameOfSheet.Text + "$]", conn);
      DataTable dt = new DataTable();

      myDataAdapter.Fill(dt);

      dataGridViewOfArray.DataSource = dt;

      DrawDots(dataGridViewOfArray);
    }

    public double[] SolveSystemOfLinearEquations(double[,] matrix)
    {
      int rows = matrix.GetLength(0);
      int cols = matrix.GetLength(1) - 1; // -1, так как последний столбец - столбец свободных членов

      // Приведение матрицы к верхнетреугольному виду методом Гаусса
      for (int k = 0; k < rows; k++)
      {
        for (int i = k + 1; i < rows; i++)
        {
          double factor = matrix[i, k] / matrix[k, k];
          for (int j = k; j <= cols; j++)
          {
            matrix[i, j] -= factor * matrix[k, j];
          }
        }
      }

      // Обратный ход метода Гаусса
      double[] solution = new double[cols];
      for (int i = rows - 1; i >= 0; i--)
      {
        double sum = 0.0;
        for (int j = i + 1; j < cols; j++)
        {
          sum += matrix[i, j] * solution[j];
        }
        solution[i] = (matrix[i, cols] - sum) / matrix[i, i];
      }

      return solution;
    }

    private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // y = ax + b
      try
      {
        double sumOfXi, sumOfYi, sumOfXXi, sumOfXiYi;

        // sumOfXi
        sumOfXi = 0;
        for (int index = 0; index < dataGridViewOfArray.RowCount; ++index)
        {
          sumOfXi += Double.Parse(dataGridViewOfArray[0, index].Value.ToString());
        }

        // sumOfYi
        sumOfYi = 0;
        for (int index = 0; index < dataGridViewOfArray.RowCount; ++index)
        {
          sumOfYi += Double.Parse(dataGridViewOfArray[1, index].Value.ToString());
        }

        // sumOfXXi
        sumOfXXi = 0;
        for (int index = 0; index < dataGridViewOfArray.RowCount; ++index)
        {
          sumOfXXi += Math.Pow((Double.Parse(dataGridViewOfArray[0, index].Value.ToString())), 2);
        }

        // sumOfXiYi
        sumOfXiYi = 0;
        for (int index = 0; index < dataGridViewOfArray.RowCount; ++index)
        {
          sumOfXiYi += (Double.Parse(dataGridViewOfArray[0, index].Value.ToString()) *
            Double.Parse(dataGridViewOfArray[1, index].Value.ToString()));
        }

        double a =  (sumOfXiYi * (dataGridViewOfArray.RowCount) - sumOfXi * sumOfYi)
                    /
                    (sumOfXXi * (dataGridViewOfArray.RowCount) - sumOfXi * sumOfXi);

        double b = (sumOfXXi * sumOfYi - sumOfXiYi * sumOfXi)
                   /
                   (sumOfXXi * (dataGridViewOfArray.RowCount) - sumOfXi * sumOfXi);

        linFuncTextBox.Text = $"y = {a}x + {b}";

        CreateLinChart(Double.Parse(dataGridViewOfArray[0, 0].Value.ToString()), Double.Parse(dataGridViewOfArray[0, dataGridViewOfArray.RowCount - 1].Value.ToString()), a, b);
      }
      catch (Exception ex)
      {
        ShowError(ex.Message);
      }

      // y = ax^2 + bx + c
      try
      {
        double sumOfX4, sumOfX3, sumOfX2, sumOfX,
        sumOfX2Y, sumOfXY, sumOfY;
        double n = dataGridViewOfArray.RowCount;

        // sumOfX4
        sumOfX4 = 0;
        for (int index = 0; index < dataGridViewOfArray.RowCount; ++index)
        {
          sumOfX4 += Math.Pow((Double.Parse(dataGridViewOfArray[0, index].Value.ToString())), 4);
        }

        // sumOfX3
        sumOfX3 = 0;
        for (int index = 0; index < dataGridViewOfArray.RowCount; ++index)
        {
          sumOfX3 += Math.Pow((Double.Parse(dataGridViewOfArray[0, index].Value.ToString())), 3);
        }

        // sumOfX2
        sumOfX2 = 0;
        for (int index = 0; index < dataGridViewOfArray.RowCount; ++index)
        {
          sumOfX2 += Math.Pow((Double.Parse(dataGridViewOfArray[0, index].Value.ToString())), 2);
        }

        // sumOfX
        sumOfX = 0;
        for (int index = 0; index < dataGridViewOfArray.RowCount; ++index)
        {
          sumOfX += Math.Pow((Double.Parse(dataGridViewOfArray[0, index].Value.ToString())), 1);
        }

        // sumOfX2Y
        sumOfX2Y = 0;
        for (int index = 0; index < dataGridViewOfArray.RowCount; ++index)
        {
          sumOfX2Y += (Math.Pow((Double.Parse(dataGridViewOfArray[0, index].Value.ToString())), 2) *
            Double.Parse(dataGridViewOfArray[1, index].Value.ToString()));
        }

        // sumOfXY
        sumOfXY = 0;
        for (int index = 0; index < dataGridViewOfArray.RowCount; ++index)
        {
          sumOfXY += (Math.Pow((Double.Parse(dataGridViewOfArray[0, index].Value.ToString())), 1) *
            Double.Parse(dataGridViewOfArray[1, index].Value.ToString()));
        }

        // sumOfY
        sumOfY = 0;
        for (int index = 0; index < dataGridViewOfArray.RowCount; ++index)
        {
          sumOfY += Double.Parse(dataGridViewOfArray[1, index].Value.ToString());
        }

        double[,] matrix = 
          { {sumOfX4, sumOfX3, sumOfX2, sumOfX2Y},
            {sumOfX3, sumOfX2, sumOfX, sumOfXY},
            {sumOfX2, sumOfX, n, sumOfY}
          };

        double[] solution = SolveSystemOfLinearEquations(matrix);

        for (int index = 0; index < solution.Length; ++index) solution[index] = Math.Round(solution[index]);

        squareFuncTextBox.Text = $"{solution[0]}x^2 + {solution[1]}x + {solution[0]}";

        CreateSquareChart(Double.Parse(dataGridViewOfArray[0, 0].Value.ToString()), Double.Parse(dataGridViewOfArray[0, dataGridViewOfArray.RowCount - 1].Value.ToString()),
          solution[0], solution[1], solution[2]);
      }
      catch (Exception ex)
      {
        ShowError("Неизвестная ошибка");
      }
    }

    public double LinFunc(double a, double b, double x)
    {
      Expression expression = new Expression("a * x + b");
      expression.Bind("a", a);
      expression.Bind("b", b);
      expression.Bind("x", x);
      return double.Parse(expression.Eval<decimal>().ToString());
    }

    public double SquareFunc(double a, double b, double c, double x)
    {
      Expression expression = new Expression("a * x * x + b * x + c");
      expression.Bind("a", a);
      expression.Bind("b", b);
      expression.Bind("c", c);
      expression.Bind("x", x);
      return double.Parse(expression.Eval<decimal>().ToString());
    }

    public void CreateLinChart(double intervalA, double intervalB, double linA, double linB)
    {
      double step = 1, x, y;

      this.chart1.Series[1].Points.Clear();
      this.chart1.Series[2].Points.Clear();

      x = intervalA;
      while (x <= intervalB)
      {
        y = Math.Round(LinFunc(linA, linB, x));
        this.chart1.Series[1].Points.AddXY(x, y);
        x += step;
      }
    }

    public void CreateSquareChart (double intervalA, double intervalB, double sqA, double sqB, double sqC)
    {
      double step = 1, x, y;

      this.chart1.Series[1].Points.Clear();
      this.chart1.Series[2].Points.Clear();
      
      x = intervalA;
      while (x <= intervalB) 
      {
        y = Math.Round(SquareFunc(sqA, sqB, sqC, x));
        this.chart1.Series[2].Points.AddXY(x, y);
        x+= step;
      }
    }

    private void dataGridViewOfArray_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      dataGridViewOfArray.AllowUserToAddRows = true;
    }
  }
}
