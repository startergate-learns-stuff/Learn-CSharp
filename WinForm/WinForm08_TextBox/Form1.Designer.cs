namespace WinForm08_TextBox
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
      this.txtSampleText = new System.Windows.Forms.TextBox();
      this.chbItalic = new System.Windows.Forms.CheckBox();
      this.chbBold = new System.Windows.Forms.CheckBox();
      this.cboFont = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtSampleText);
      this.groupBox1.Controls.Add(this.chbItalic);
      this.groupBox1.Controls.Add(this.chbBold);
      this.groupBox1.Controls.Add(this.cboFont);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(23, 22);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox1.Size = new System.Drawing.Size(389, 98);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "ComboBox, CheckBox, TextBox";
      // 
      // txtSampleText
      // 
      this.txtSampleText.Location = new System.Drawing.Point(15, 58);
      this.txtSampleText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtSampleText.Name = "txtSampleText";
      this.txtSampleText.Size = new System.Drawing.Size(363, 23);
      this.txtSampleText.TabIndex = 4;
      this.txtSampleText.Text = "Hello C#";
      // 
      // chbItalic
      // 
      this.chbItalic.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic);
      this.chbItalic.Location = new System.Drawing.Point(321, 22);
      this.chbItalic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.chbItalic.Name = "chbItalic";
      this.chbItalic.Size = new System.Drawing.Size(57, 22);
      this.chbItalic.TabIndex = 3;
      this.chbItalic.Text = "Italic";
      this.chbItalic.UseVisualStyleBackColor = true;
      this.chbItalic.CheckedChanged += new System.EventHandler(this.chbItalic_CheckedChanged);
      // 
      // chbBold
      // 
      this.chbBold.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
      this.chbBold.Location = new System.Drawing.Point(265, 22);
      this.chbBold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.chbBold.Name = "chbBold";
      this.chbBold.Size = new System.Drawing.Size(57, 22);
      this.chbBold.TabIndex = 2;
      this.chbBold.Text = "Bold";
      this.chbBold.UseVisualStyleBackColor = true;
      this.chbBold.CheckedChanged += new System.EventHandler(this.chbBold_CheckedChanged);
      // 
      // cboFont
      // 
      this.cboFont.FormattingEnabled = true;
      this.cboFont.Location = new System.Drawing.Point(71, 22);
      this.cboFont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cboFont.Name = "cboFont";
      this.cboFont.Size = new System.Drawing.Size(176, 23);
      this.cboFont.TabIndex = 1;
      this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(20, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 22);
      this.label1.TabIndex = 0;
      this.label1.Text = "Font: ";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(434, 142);
      this.Controls.Add(this.groupBox1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cboFont;
    private System.Windows.Forms.CheckBox chbBold;
    private System.Windows.Forms.CheckBox chbItalic;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtSampleText;
  }
}