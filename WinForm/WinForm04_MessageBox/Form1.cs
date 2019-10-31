using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm04_MessageBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private MessageBoxButtons msgBoxBtn;
    private MessageBoxIcon msgBoxIcon;

    private void btnShow_Click(object sender, EventArgs e)
    {
      if (rbOK.Checked)
        msgBoxBtn = MessageBoxButtons.OK;
      else if (rbOKCancel.Checked)
        msgBoxBtn = MessageBoxButtons.OKCancel;
      else if (rbYesNo.Checked)
        msgBoxBtn = MessageBoxButtons.YesNo;
      
      if (rbError.Checked)
        msgBoxIcon = MessageBoxIcon.Error;
      else if (rbInfo.Checked)
        msgBoxIcon = MessageBoxIcon.Information;
      else if (rbQuestion.Checked)
        msgBoxIcon = MessageBoxIcon.Question;

      MessageBox.Show("메시지 박스입니다.", "알림", msgBoxBtn, msgBoxIcon);
    }
  }
}