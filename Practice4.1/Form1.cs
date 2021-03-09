using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice4._1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    double factorial(double n)
    {
      if (n == 0) return 1;
      else return n * factorial(n - 1);
    }

    private void button1_Click(object sender, EventArgs e)
        {
      Double n = Convert.ToDouble(textBox1.Text);
      Double eps = Convert.ToDouble(textBox1.Text);
      textBox2.Text = "Результаты работы программы ст. Хвостова И.И. " + Environment.NewLine;
      int m = 0;
      if (radioButton2.Checked) m = 1;
      double s = 0, p = 1, ch;
      double i = 1;
      switch (m)
      {
        case 0:
          int k = 1;
          while (k <= n)
          {
            ch = 1 / (2*k + factorial(k)) ;
            s += ch;
            k++;
          }
          textBox2.Text += "При eps = " + textBox1.Text + Environment.NewLine;
          textBox2.Text += "Расчет суммы ряда S = " + Convert.ToString(s) + Environment.NewLine;
          break;
        case 1:
          for (i = 1; i <= n; i++)
          {
            ch = (2 + 0.1*factorial(i))/2;
            p *= ch;
          }
          textBox2.Text += "При m = " + textBox1.Text + Environment.NewLine;
          textBox2.Text += "Расчет произведения ряда P = " + Convert.ToString(p) + Environment.NewLine;
          break;
      }

    }
  }
}
