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
    }

    private void buttonLoadExcel_Click(object sender, EventArgs e)
    {
        string PathConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBoxWayToFile.Text + ";Extended Properties='Excel 12.0;IMEX=1;'";
        OleDbConnection conn = new OleDbConnection(PathConn);

        OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + textBoxNameOfSheet.Text + "$]", conn);
        DataTable dt = new DataTable();

        myDataAdapter.Fill(dt);

        dataGridViewOfArray.DataSource = dt;

    }

    
  }
}
