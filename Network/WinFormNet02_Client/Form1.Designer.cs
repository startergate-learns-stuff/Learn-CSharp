namespace WinFormNet02_Client
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
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.labelConnectionState = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(21, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(108, 22);
      this.label1.TabIndex = 0;
      this.label1.Text = "서버 IP";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(147, 18);
      this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(355, 23);
      this.textBox1.TabIndex = 1;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(147, 48);
      this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(355, 23);
      this.textBox2.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(21, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(108, 22);
      this.label2.TabIndex = 4;
      this.label2.Text = "클라이언트 IP";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(528, 18);
      this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(96, 22);
      this.button1.TabIndex = 5;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(528, 48);
      this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(96, 22);
      this.button2.TabIndex = 6;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // labelConnectionState
      // 
      this.labelConnectionState.Location = new System.Drawing.Point(21, 82);
      this.labelConnectionState.Name = "labelConnectionState";
      this.labelConnectionState.Size = new System.Drawing.Size(622, 22);
      this.labelConnectionState.TabIndex = 7;
      this.labelConnectionState.Text = "서버 연결 상태";
      this.labelConnectionState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 562);
      this.Controls.Add(this.labelConnectionState);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label labelConnectionState;
  }
}