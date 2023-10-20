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
  }
}
