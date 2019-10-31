using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm03_TextBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private string strResult;

    private void Form1_Load(object sender, EventArgs e)
    {
      strResult = label1.Text;
    }
    
    private void button1_Click(object sender, EventArgs e)
    {
      if (TextChecker())
      {
        label1.Text = strResult + textBox1.Text;
      }
    }

    private bool TextChecker()
    {
      if (textBox1.Text != "") return true;
      return false;
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char) Keys.Enter)
      {
        if (TextChecker())
        {
          label1.Text = strResult + textBox1.Text;
        }
      }
    }
  }
}