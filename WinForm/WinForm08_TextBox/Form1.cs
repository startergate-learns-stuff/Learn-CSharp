using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm08_TextBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }


    private void Form1_Load(object sender, EventArgs e)
    {
      var Fonts = FontFamily.Families;
      foreach (FontFamily font in Fonts)
      {
        cboFont.Items.Add(font.Name);
      }
    }

    void ChangeFont()
    {
      if (cboFont.SelectedIndex < 0) return;

      FontStyle style = FontStyle.Regular;

      if (chbBold.Checked) style |= FontStyle.Bold;
      if (chbItalic.Checked) style |= FontStyle.Italic;
      
      txtSampleText.Font = new Font((string) cboFont.SelectedItem, 20, style);
    }

    private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
    { 
      ChangeFont();
    }

    private void chbBold_CheckedChanged(object sender, EventArgs e)
    {
      ChangeFont();
    }

    private void chbItalic_CheckedChanged(object sender, EventArgs e)
    {
      ChangeFont();
    }
  }
}