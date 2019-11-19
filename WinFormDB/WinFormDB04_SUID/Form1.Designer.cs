namespace WinFormDB04_SUID
{
partial class Form1
{
/// <summary>
/// 필수 디자이너 변수입니다.
/// </summary>
private System.ComponentModel.IContainer components = null;

/// <summary>
/// 사용 중인 모든 리소스를 정리합니다.
/// </summary>
/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
protected override void Dispose(bool disposing)
{
if (disposing && (components != null))
{
components.Dispose();
}
base.Dispose(disposing);
}

#region Windows Form 디자이너에서 생성한 코드

/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent()
{
  this.panel1 = new System.Windows.Forms.Panel();
  this.textBox5 = new System.Windows.Forms.TextBox();
  this.label5 = new System.Windows.Forms.Label();
  this.textBox4 = new System.Windows.Forms.TextBox();
  this.label4 = new System.Windows.Forms.Label();
  this.textBox3 = new System.Windows.Forms.TextBox();
  this.label3 = new System.Windows.Forms.Label();
  this.textBox2 = new System.Windows.Forms.TextBox();
  this.label2 = new System.Windows.Forms.Label();
  this.textBox1 = new System.Windows.Forms.TextBox();
  this.label1 = new System.Windows.Forms.Label();
  this.button1 = new System.Windows.Forms.Button();
  this.button2 = new System.Windows.Forms.Button();
  this.button3 = new System.Windows.Forms.Button();
  this.button4 = new System.Windows.Forms.Button();
  this.button5 = new System.Windows.Forms.Button();
  this.labelConnectionState = new System.Windows.Forms.Label();
  this.label7 = new System.Windows.Forms.Label();
  this.panel1.SuspendLayout();
  this.SuspendLayout();
  // 
  // panel1
  // 
  this.panel1.Controls.Add(this.textBox5);
  this.panel1.Controls.Add(this.label5);
  this.panel1.Controls.Add(this.textBox4);
  this.panel1.Controls.Add(this.label4);
  this.panel1.Controls.Add(this.textBox3);
  this.panel1.Controls.Add(this.label3);
  this.panel1.Controls.Add(this.textBox2);
  this.panel1.Controls.Add(this.label2);
  this.panel1.Controls.Add(this.textBox1);
  this.panel1.Controls.Add(this.label1);
  this.panel1.Location = new System.Drawing.Point(26, 30);
  this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
  this.panel1.Name = "panel1";
  this.panel1.Size = new System.Drawing.Size(372, 209);
  this.panel1.TabIndex = 0;
  // 
  // textBox5
  // 
  this.textBox5.Location = new System.Drawing.Point(111, 170);
  this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
  this.textBox5.Name = "textBox5";
  this.textBox5.Size = new System.Drawing.Size(239, 23);
  this.textBox5.TabIndex = 9;
  // 
  // label5
  // 
  this.label5.AutoSize = true;
  this.label5.Location = new System.Drawing.Point(36, 172);
  this.label5.Name = "label5";
  this.label5.Size = new System.Drawing.Size(65, 15);
  this.label5.TabIndex = 8;
  this.label5.Text = "Population";
  // 
  // textBox4
  // 
  this.textBox4.Location = new System.Drawing.Point(111, 108);
  this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
  this.textBox4.Name = "textBox4";
  this.textBox4.Size = new System.Drawing.Size(239, 23);
  this.textBox4.TabIndex = 7;
  // 
  // label4
  // 
  this.label4.AutoSize = true;
  this.label4.Location = new System.Drawing.Point(22, 111);
  this.label4.Name = "label4";
  this.label4.Size = new System.Drawing.Size(78, 15);
  this.label4.TabIndex = 6;
  this.label4.Text = "CountryCode";
  // 
  // textBox3
  // 
  this.textBox3.Location = new System.Drawing.Point(111, 139);
  this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
  this.textBox3.Name = "textBox3";
  this.textBox3.Size = new System.Drawing.Size(239, 23);
  this.textBox3.TabIndex = 5;
  // 
  // label3
  // 
  this.label3.AutoSize = true;
  this.label3.Location = new System.Drawing.Point(59, 142);
  this.label3.Name = "label3";
  this.label3.Size = new System.Drawing.Size(45, 15);
  this.label3.TabIndex = 4;
  this.label3.Text = "District";
  // 
  // textBox2
  // 
  this.textBox2.Location = new System.Drawing.Point(111, 78);
  this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
  this.textBox2.Name = "textBox2";
  this.textBox2.Size = new System.Drawing.Size(239, 23);
  this.textBox2.TabIndex = 3;
  // 
  // label2
  // 
  this.label2.AutoSize = true;
  this.label2.Location = new System.Drawing.Point(68, 80);
  this.label2.Name = "label2";
  this.label2.Size = new System.Drawing.Size(39, 15);
  this.label2.TabIndex = 2;
  this.label2.Text = "Name";
  // 
  // textBox1
  // 
  this.textBox1.Location = new System.Drawing.Point(111, 46);
  this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
  this.textBox1.Name = "textBox1";
  this.textBox1.Size = new System.Drawing.Size(239, 23);
  this.textBox1.TabIndex = 1;
  // 
  // label1
  // 
  this.label1.AutoSize = true;
  this.label1.Location = new System.Drawing.Point(86, 49);
  this.label1.Name = "label1";
  this.label1.Size = new System.Drawing.Size(19, 15);
  this.label1.TabIndex = 0;
  this.label1.Text = "ID";
  // 
  // button1
  // 
  this.button1.Location = new System.Drawing.Point(424, 49);
  this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
  this.button1.Name = "button1";
  this.button1.Size = new System.Drawing.Size(231, 32);
  this.button1.TabIndex = 1;
  this.button1.Text = "SELECT";
  this.button1.UseVisualStyleBackColor = true;
  this.button1.Click += new System.EventHandler(this.button1_Click);
  // 
  // button2
  // 
  this.button2.Location = new System.Drawing.Point(424, 89);
  this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
  this.button2.Name = "button2";
  this.button2.Size = new System.Drawing.Size(231, 32);
  this.button2.TabIndex = 2;
  this.button2.Text = "INSERT";
  this.button2.UseVisualStyleBackColor = true;
  this.button2.Click += new System.EventHandler(this.button2_Click);
  // 
  // button3
  // 
  this.button3.Location = new System.Drawing.Point(424, 128);
  this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
  this.button3.Name = "button3";
  this.button3.Size = new System.Drawing.Size(231, 32);
  this.button3.TabIndex = 3;
  this.button3.Text = "UPDATE";
  this.button3.UseVisualStyleBackColor = true;
  this.button3.Click += new System.EventHandler(this.button3_Click);
  // 
  // button4
  // 
  this.button4.Location = new System.Drawing.Point(424, 168);
  this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
  this.button4.Name = "button4";
  this.button4.Size = new System.Drawing.Size(231, 32);
  this.button4.TabIndex = 4;
  this.button4.Text = "DELETE";
  this.button4.UseVisualStyleBackColor = true;
  this.button4.Click += new System.EventHandler(this.button4_Click);
  // 
  // button5
  // 
  this.button5.Location = new System.Drawing.Point(424, 206);
  this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
  this.button5.Name = "button5";
  this.button5.Size = new System.Drawing.Size(231, 32);
  this.button5.TabIndex = 5;
  this.button5.Text = "텍스트박스 지우기";
  this.button5.UseVisualStyleBackColor = true;
  // 
  // labelConnectionState
  // 
  this.labelConnectionState.Location = new System.Drawing.Point(424, 18);
  this.labelConnectionState.Name = "labelConnectionState";
  this.labelConnectionState.Size = new System.Drawing.Size(231, 29);
  this.labelConnectionState.TabIndex = 6;
  this.labelConnectionState.Text = "DB 연결 상태";
  this.labelConnectionState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
  // 
  // label7
  // 
  this.label7.AutoSize = true;
  this.label7.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold,
    System.Drawing.GraphicsUnit.Point, ((byte) (129)));
  this.label7.Location = new System.Drawing.Point(134, 36);
  this.label7.Name = "label7";
  this.label7.Size = new System.Drawing.Size(120, 19);
  this.label7.TabIndex = 7;
  this.label7.Text = "WORLD.CITY";
  // 
  // Form1
  // 
  this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
  this.ClientSize = new System.Drawing.Size(700, 252);
  this.Controls.Add(this.label7);
  this.Controls.Add(this.labelConnectionState);
  this.Controls.Add(this.button5);
  this.Controls.Add(this.button4);
  this.Controls.Add(this.button3);
  this.Controls.Add(this.button2);
  this.Controls.Add(this.button1);
  this.Controls.Add(this.panel1);
  this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
  this.Name = "Form1";
  this.Text = "Form1";
  this.Load += new System.EventHandler(this.Form1_Load);
  this.panel1.ResumeLayout(false);
  this.panel1.PerformLayout();
  this.ResumeLayout(false);
  this.PerformLayout();
}

#endregion

private System.Windows.Forms.Panel panel1;
private System.Windows.Forms.TextBox textBox5;
private System.Windows.Forms.Label label5;
private System.Windows.Forms.TextBox textBox4;
private System.Windows.Forms.Label label4;
private System.Windows.Forms.TextBox textBox3;
private System.Windows.Forms.Label label3;
private System.Windows.Forms.TextBox textBox2;
private System.Windows.Forms.Label label2;
private System.Windows.Forms.TextBox textBox1;
private System.Windows.Forms.Label label1;
private System.Windows.Forms.Button button1;
private System.Windows.Forms.Button button2;
private System.Windows.Forms.Button button3;
private System.Windows.Forms.Button button4;
private System.Windows.Forms.Button button5;
private System.Windows.Forms.Label label7;
private System.Windows.Forms.Label labelConnectionState;
}
}
