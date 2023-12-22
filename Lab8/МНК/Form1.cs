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

        Expression expression = new Expression(linFuncLabel.Text);
        expression.Bind("a", a);
        expression.Bind("b", b);

        linFuncTextBox.Text = $"y = {a}x + {b}";
      }
      catch (Exception ex)
      {
        ShowError(ex.Message);
      }

      // y = ax^2 + bx + c
      try
      {

      }
      catch (Exception ex)
      {
        ShowError("Неизвестная ошибка");
      }
    }

    private void dataGridViewOfArray_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      dataGridViewOfArray.AllowUserToAddRows = true;
    }
  }
}
