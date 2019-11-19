namespace WinFormDB06_DataGridView
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btnEnter = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.rbFemale = new System.Windows.Forms.RadioButton();
      this.rbMale = new System.Windows.Forms.RadioButton();
      this.textBoxAge = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridView1.ColumnHeadersHeightSizeMode =
        System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(14, 19);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(509, 188);
      this.dataGridView1.TabIndex = 0;
      // 
      // btnEnter
      // 
      this.btnEnter.Location = new System.Drawing.Point(16, 210);
      this.btnEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnEnter.Name = "btnEnter";
      this.btnEnter.Size = new System.Drawing.Size(165, 40);
      this.btnEnter.TabIndex = 1;
      this.btnEnter.Text = "입력";
      this.btnEnter.UseVisualStyleBackColor = true;
      this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Location = new System.Drawing.Point(187, 210);
      this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(165, 40);
      this.btnEdit.TabIndex = 2;
      this.btnEdit.Text = "수정";
      this.btnEdit.UseVisualStyleBackColor = true;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(358, 210);
      this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(165, 40);
      this.btnDelete.TabIndex = 3;
      this.btnDelete.Text = "삭제";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(564, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 15);
      this.label1.TabIndex = 4;
      this.label1.Text = "이름";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(663, 38);
      this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(102, 23);
      this.textBoxName.TabIndex = 5;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rbFemale);
      this.groupBox1.Controls.Add(this.rbMale);
      this.groupBox1.Location = new System.Drawing.Point(551, 96);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox1.Size = new System.Drawing.Size(237, 171);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "성별";
      // 
      // rbFemale
      // 
      this.rbFemale.Location = new System.Drawing.Point(123, 38);
      this.rbFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbFemale.Name = "rbFemale";
      this.rbFemale.Size = new System.Drawing.Size(91, 26);
      this.rbFemale.TabIndex = 1;
      this.rbFemale.TabStop = true;
      this.rbFemale.Text = "여자";
      this.rbFemale.UseVisualStyleBackColor = true;
      // 
      // rbMale
      // 
      this.rbMale.Location = new System.Drawing.Point(21, 38);
      this.rbMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rbMale.Name = "rbMale";
      this.rbMale.Size = new System.Drawing.Size(91, 26);
      this.rbMale.TabIndex = 0;
      this.rbMale.TabStop = true;
      this.rbMale.Text = "남자";
      this.rbMale.UseVisualStyleBackColor = true;
      // 
      // textBoxAge
      // 
      this.textBoxAge.Location = new System.Drawing.Point(663, 68);
      this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.textBoxAge.Name = "textBoxAge";
      this.textBoxAge.Size = new System.Drawing.Size(102, 23);
      this.textBoxAge.TabIndex = 8;
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(564, 70);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(79, 15);
      this.label2.TabIndex = 7;
      this.label2.Text = "나이";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 322);
      this.Controls.Add(this.textBoxAge);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnEdit);
      this.Controls.Add(this.btnEnter);
      this.Controls.Add(this.dataGridView1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RadioButton rbFemale;
    private System.Windows.Forms.RadioButton rbMale;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.TextBox textBoxAge;
    private System.Windows.Forms.Button btnEnter;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnDelete;
  }
}