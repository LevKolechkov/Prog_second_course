using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.matheval;
using MathNet.Numerics;


namespace Интегралы
{
  public partial class Form1 : Form
  {
    private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
      {
        e.Handled = true;
      }
    }

    public double MainFunc(double x)
    {
      org.matheval.Expression expression = new org.matheval.Expression(textBoxFunction.Text.ToLower());
      expression.Bind("x", x);
      decimal value = expression.Eval<decimal>();
      return (double)value;
    }

    public Form1()
    {
      InitializeComponent();
    }

    
  }
}
