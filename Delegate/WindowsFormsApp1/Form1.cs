using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.label1.Text = "안녕하세요 저는 머한민국 대통령 문재인입니다";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.button1.Text = "적폐청산하기";
    }
  }
}