namespace WinForm07_ProgressBar
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
      this.components = new System.ComponentModel.Container();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.labelStatus = new System.Windows.Forms.Label();
      this.btnStart = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(19, 21);
      this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(323, 34);
      this.progressBar1.TabIndex = 0;
      // 
      // labelStatus
      // 
      this.labelStatus.Location = new System.Drawing.Point(20, 71);
      this.labelStatus.Name = "labelStatus";
      this.labelStatus.Size = new System.Drawing.Size(138, 22);
      this.labelStatus.TabIndex = 1;
      this.labelStatus.Text = "진행 상태: ";
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(247, 71);
      this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(95, 22);
      this.btnStart.TabIndex = 2;
      this.btnStart.Text = "GO";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // timer1
      // 
      this.timer1.Interval = 10;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(361, 109);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.labelStatus);
      this.Controls.Add(this.progressBar1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label labelStatus;
  }
}