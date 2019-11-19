using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDB06_DataGridView
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private DataTable dataTable;
    
    private void Form1_Load(object sender, EventArgs e)
    {
      // 1 단계: 테이블과 컬럼 만들기
      dataTable = new DataTable();
      DataColumn col;

      col = new DataColumn("name", typeof(string));
      col.MaxLength = 10;
      col.AllowDBNull = false;
      dataTable.Columns.Add(col);
      
      col = new DataColumn("age", typeof(int));
      dataTable.Columns.Add(col);
      
      col = new DataColumn("male", typeof(bool));
      dataTable.Columns.Add(col);

      // 2 단계: 행 만들기, 데이터 입력
      DataRow row = dataTable.NewRow();
      row["name"] = "아이유";
      row["age"] = 26;
      row["male"] = false;
      dataTable.Rows.Add(row);

      row = dataTable.NewRow();
      row["name"] = "조승우";
      row["age"] = 39;
      row["male"] = true;
      dataTable.Rows.Add(row);
      
      row = dataTable.NewRow();
      row["name"] = "장만월";
      row["age"] = 1000;
      row["male"] = false;
      dataTable.Rows.Add(row);

      dataGridView1.DataSource = dataTable;
    }

    private void btnEnter_Click(object sender, EventArgs e)
    {
      DataRow row = dataTable.NewRow();
      row["name"] = textBoxName.Text;
      row["age"] = textBoxAge.Text;
      row["male"] = rbMale.Checked;

      dataTable.Rows.Add(row);
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      int selectedIndex = dataGridView1.SelectedRows[0].Index;
      DataRow row = dataTable.Rows[selectedIndex];
      row["name"] = textBoxName.Text;
      row["age"] = textBoxAge.Text;
      row["male"] = rbMale.Checked;
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      int selectedIndex = dataGridView1.SelectedRows[0].Index;
      DataRow row = dataTable.Rows[selectedIndex];
      row.Delete();
    }
  }
}