﻿namespace WinForm03_TextBox
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(67, 51);
      this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(319, 23);
      this.textBox1.TabIndex = 0;
      this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(156, 134);
      this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(147, 58);
      this.button1.TabIndex = 1;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.Font = new System.Drawing.Font("Noto Sans CJK KR Black", 22F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte) (129)));
      this.label1.Location = new System.Drawing.Point(66, 78);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(320, 45);
      this.label1.TabIndex = 2;
      this.label1.Text = "결과: ";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(464, 218);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
  }
}