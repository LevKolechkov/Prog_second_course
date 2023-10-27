using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Diagnostics;
using System.Reflection;

namespace Олимпиадные_сортировки
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      dataGridViewOfArray.AllowUserToAddRows = false;
    }

    public struct myMatrix
    {
      public int[] array1;
      public int[] array2;

      public myMatrix(int[] _matrix1, int[] _matrix2)
      {
        array1 = _matrix1;
        array2 = _matrix2;
      }
    }

    private void buttonChooseFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog1 = new OpenFileDialog();

      if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        this.textBoxWayToFile.Text = openFileDialog1.FileName;
      }
    }

    private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      dataGridViewOfArray.DataSource = null;

      textBoxWayToFile.Clear();
      textBoxNameOfSheet.Clear();

      chartOfSort.Series[0].Points.Clear();
    }

    private void buttonLoadExcel_Click(object sender, EventArgs e)
    {
      try
      {
        string PathConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBoxWayToFile.Text + ";Extended Properties='Excel 12.0;IMEX=1;'";
        OleDbConnection conn = new OleDbConnection(PathConn);

        OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + textBoxNameOfSheet.Text + "$]", conn);
        DataTable dt = new DataTable();

        myDataAdapter.Fill(dt);

        dataGridViewOfArray.DataSource = dt;
      }
      catch (Exception ex)
      {
        MessageBox.Show("Данной таблицы или листа не существует");
      }

    }

    public void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int totalChecked = 0;

      List<double> originalList = new List<double>();

      try
      {
        for (int index = 0; index < dataGridViewOfArray.RowCount; ++index)
        {
          double value = 0;

          value = Convert.ToDouble(dataGridViewOfArray[0, index].Value.ToString());

          originalList.Add(value);
        }
      }
      catch (FormatException forEx)
      {
        MessageBox.Show("Не все элементы масссива являются числами");
      }
      
      // Сортировка пузырьком
      List<double> bubbleSortList = new List<double>();
      Stopwatch bubbleStopWatch = new Stopwatch();
      if (checkBoxBubble.Checked)
      {
        bubbleSortList.AddRange(originalList);
        bubbleStopWatch.Start();

        bool swapped;
        do
        {
          swapped = false;
          for (int index = 1; index < bubbleSortList.Count; ++index)
          {
            if (bubbleSortList[index - 1] > bubbleSortList[index])
            {
              double temporaryValue = bubbleSortList[index - 1];
              bubbleSortList[index - 1] = bubbleSortList[index];
              bubbleSortList[index] = temporaryValue;
              swapped = true;
            }
          }
        } while (swapped);
        bubbleStopWatch.Stop();

        sortedArrayTextBox.Clear();
        sortedArrayTextBox.Visible = true;
        for (int index = 0; index < bubbleSortList.Count; ++index)
        {
          sortedArrayTextBox.Text += bubbleSortList[index];
          sortedArrayTextBox.Text += " ";
        }
      }

      // Сортировка вставками
      List<double> insertSortList = new List<double>();
      Stopwatch insertStopWatch = new Stopwatch();
      if (checkBoxInsert.Checked)
      {
        insertSortList.AddRange(originalList);
        insertStopWatch.Start();

        for (int index = 1; index < insertSortList.Count; ++index)
        {
          double currentElement = insertSortList[index];
          int lastIndex = index - 1;

          while (lastIndex >= 0 && insertSortList[lastIndex] > currentElement)
          {
            insertSortList[lastIndex + 1] = insertSortList[lastIndex];
            --lastIndex;
          }

          insertSortList[lastIndex + 1] = currentElement;
        }
        insertStopWatch.Stop();

        sortedArrayTextBox.Clear();
        sortedArrayTextBox.Visible = true;
        for (int index = 0; index < insertSortList.Count; ++index)
        {
          sortedArrayTextBox.Text += insertSortList[index];
          sortedArrayTextBox.Text += " ";
        }
      }

      // Сортировка шейкером
      List<double> shakerSortList = new List<double>();
      Stopwatch shakerStopWatch = new Stopwatch();
      if (checkBoxShaker.Checked) 
      {
        shakerSortList.AddRange(originalList);
        shakerStopWatch.Start();

        bool swapped;
        do
        {
          swapped = false;
          for (int index = 0; index < shakerSortList.Count - 1; ++index)
          {
            if (shakerSortList[index] > shakerSortList[index + 1])
            {
              double temporaryValue = shakerSortList[index];
              shakerSortList[index] = shakerSortList[index + 1];
              shakerSortList[index + 1] = temporaryValue;
              swapped = true;
            }
          }
          if (!swapped) break;
          swapped = false;
          for (int index = shakerSortList.Count - 2; index >= 0; --index)
          {
            if (shakerSortList[index] > shakerSortList[index + 1])
            {
              double temporaryValue = shakerSortList[index];
              shakerSortList[index] = shakerSortList[index + 1];
              shakerSortList[index + 1] = temporaryValue;
              swapped = true;
            }
          }
        } while (swapped);
        shakerStopWatch.Stop();

        sortedArrayTextBox.Clear();
        sortedArrayTextBox.Visible = true;
        for (int index = 0; index < shakerSortList.Count; ++index)
        {
          sortedArrayTextBox.Text += shakerSortList[index];
          sortedArrayTextBox.Text += " ";
        }
      }

    }
  }
}
