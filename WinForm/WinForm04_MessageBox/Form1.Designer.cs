namespace WinForm04_MessageBox
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }

      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.rbYesNo = new System.Windows.Forms.RadioButton();
      this.rbOKCancel = new System.Windows.Forms.RadioButton();
      this.rbOK = new System.Windows.Forms.RadioButton();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.rbQuestion = new System.Windows.Forms.RadioButton();
      this.rbInfo = new System.Windows.Forms.RadioButton();
      this.rbError = new System.Windows.Forms.RadioButton();
      this.btnShow = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rbYesNo);
      this.groupBox1.Controls.Add(this.rbOKCancel);
      this.groupBox1.Controls.Add(this.rbOK);
      this.groupBox1.Location = new System.Drawing.Point(43, 11);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox1.Size = new System.Drawing.Size(219, 126);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Type";
      // 
      // rbYesNo
      // 
      this.rbYesNo.Location = new System.Drawing.Point(13, 78);
      this.rbYesNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbYesNo.Name = "rbYesNo";
      this.rbYesNo.Size = new System.Drawing.Size(92, 22);
      this.rbYesNo.TabIndex = 2;
      this.rbYesNo.TabStop = true;
      this.rbYesNo.Text = "YesNo";
      this.rbYesNo.UseVisualStyleBackColor = true;
      // 
      // rbOKCancel
      // 
      this.rbOKCancel.Location = new System.Drawing.Point(13, 49);
      this.rbOKCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbOKCancel.Name = "rbOKCancel";
      this.rbOKCancel.Size = new System.Drawing.Size(103, 22);
      this.rbOKCancel.TabIndex = 1;
      this.rbOKCancel.TabStop = true;
      this.rbOKCancel.Text = "OKCancel";
      this.rbOKCancel.UseVisualStyleBackColor = true;
      // 
      // rbOK
      // 
      this.rbOK.Location = new System.Drawing.Point(13, 20);
      this.rbOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbOK.Name = "rbOK";
      this.rbOK.Size = new System.Drawing.Size(54, 22);
      this.rbOK.TabIndex = 0;
      this.rbOK.TabStop = true;
      this.rbOK.Text = "OK";
      this.rbOK.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.rbQuestion);
      this.groupBox2.Controls.Add(this.rbInfo);
      this.groupBox2.Controls.Add(this.rbError);
      this.groupBox2.Location = new System.Drawing.Point(310, 11);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox2.Size = new System.Drawing.Size(219, 126);
      this.groupBox2.TabIndex = 3;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Icon";
      // 
      // rbQuestion
      // 
      this.rbQuestion.Location = new System.Drawing.Point(13, 78);
      this.rbQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbQuestion.Name = "rbQuestion";
      this.rbQuestion.Size = new System.Drawing.Size(89, 22);
      this.rbQuestion.TabIndex = 2;
      this.rbQuestion.TabStop = true;
      this.rbQuestion.Text = "Question";
      this.rbQuestion.UseVisualStyleBackColor = true;
      // 
      // rbInfo
      // 
      this.rbInfo.Location = new System.Drawing.Point(13, 49);
      this.rbInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbInfo.Name = "rbInfo";
      this.rbInfo.Size = new System.Drawing.Size(114, 22);
      this.rbInfo.TabIndex = 1;
      this.rbInfo.TabStop = true;
      this.rbInfo.Text = "Information";
      this.rbInfo.UseVisualStyleBackColor = true;
      // 
      // rbError
      // 
      this.rbError.Location = new System.Drawing.Point(13, 20);
      this.rbError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbError.Name = "rbError";
      this.rbError.Size = new System.Drawing.Size(99, 22);
      this.rbError.TabIndex = 0;
      this.rbError.TabStop = true;
      this.rbError.Text = "Error";
      this.rbError.UseVisualStyleBackColor = true;
      // 
      // btnShow
      // 
      this.btnShow.Location = new System.Drawing.Point(456, 141);
      this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnShow.Name = "btnShow";
      this.btnShow.Size = new System.Drawing.Size(73, 28);
      this.btnShow.TabIndex = 4;
      this.btnShow.Text = "Show";
      this.btnShow.UseVisualStyleBackColor = true;
      this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(576, 224);
      this.Controls.Add(this.btnShow);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.Text = "MessageBox";
      this.groupBox1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton rbOK;
    private System.Windows.Forms.RadioButton rbYesNo;
    private System.Windows.Forms.RadioButton rbOKCancel;
    private System.Windows.Forms.RadioButton rbError;
    private System.Windows.Forms.RadioButton rbQuestion;
    private System.Windows.Forms.RadioButton rbInfo;
    private System.Windows.Forms.Button btnShow;
  }
}