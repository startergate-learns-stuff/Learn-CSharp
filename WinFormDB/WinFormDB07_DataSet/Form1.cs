using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormDB07_DataSet
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private MySqlConnection conn;
    private MySqlDataAdapter adapter;
    private DataSet dataSet;

    private void Form1_Load(object sender, EventArgs e)
    {
      string connStr = "server=db.donote.co;port=3306;database=world;uid=world;pwd=1111";
      conn = new MySqlConnection(connStr);
      adapter = new MySqlDataAdapter();
      dataSet = new DataSet();

      try
      {
        conn.Open();
        if (conn.State == ConnectionState.Open)
        {
          labelConnectionState.Text = "DB 연결 성공";
          labelConnectionState.ForeColor = Color.Green;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string sql = "SELECT * FROM CITY WHERE countrycode = @countrycode";

      adapter.SelectCommand = new MySqlCommand(sql, conn);
      adapter.SelectCommand.Parameters.AddWithValue("@countrycode", textBox3.Text);

      if (adapter.Fill(dataSet) > 0)
      {
        dataGridView1.DataSource = dataSet.Tables["CITY"];
      }
      else
      {
        MessageBox.Show("검색된 데이터가 없습니다.");
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      string sql =
        "INSERT INTO CITY (name, countrycode, district, population) VALUES (@name, @countrycode, @district, @population)";
      
      adapter.InsertCommand = new MySqlCommand(sql, conn);
      adapter.InsertCommand.Parameters.AddWithValue("@name", textBox2.Text);
      adapter.InsertCommand.Parameters.AddWithValue("@countrycode", textBox3.Text);
      adapter.InsertCommand.Parameters.AddWithValue("@district", textBox4.Text);
      adapter.InsertCommand.Parameters.AddWithValue("@population", textBox5.Text);

      #region MySqlDataAdapter.InsertCommand를 이용한 처리

      /*try
      {
        conn.Open();
        if (adapter.InsertCommand.ExecuteNonQuery() > 0)
        {
          dataSet.Clear();
          adapter.Fill(dataSet, "CITY");
          dataGridView1.DataSource = dataSet.Tables["CITY"];
        }
        else
        {
          MessageBox.Show("추가된 데이터가 없습니다.");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }*/

      #endregion

      #region DataSet을 먼저 수정하고, DB로 Update() 처리

      DataRow newRow = dataSet.Tables["CITY"].NewRow();
      newRow["name"] = textBox2.Text;
      newRow["countrycode"] = textBox3.Text;
      newRow["district"] = textBox4.Text;
      newRow["population"] = textBox5.Text;
      dataSet.Tables["CITY"].Rows.Add(newRow);

      try
      {
        adapter.Update(dataSet, "CITY");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
        throw;
      }

      #endregion
    }

    private void button3_Click(object sender, EventArgs e)
    {
      string sql = "UPDATE CITY SET district = @district WHERE countrycode = @countrycode";
      adapter.UpdateCommand = new MySqlCommand(sql, conn);
      adapter.UpdateCommand.Parameters.AddWithValue("@countrycode", textBox3.Text);
      adapter.UpdateCommand.Parameters.AddWithValue("@district", textBox4.Text);

      #region UpdateCommand를 이용한 처리

      /*try
      {
        conn.Open();
        if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
        {
          dataSet.Clear();
          adapter.Fill(dataSet, "CITY");
          dataGridView1.DataSource = dataSet.Tables["CITY"];
        }
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception);
        throw;
      }*/

      #endregion

      #region Update()를 이용한 처리

      int id = (int) dataGridView1.SelectedRows[0].Cells["id"].Value;
      string filter = "id=" + id;
      DataRow[] findRows = dataSet.Tables["CITY"].Select(filter);
      findRows[0]["id"] = id;
      findRows[0]["name"] = textBox2.Text;
      findRows[0]["countrycode"] = textBox3.Text;
      findRows[0]["district"] = textBox4.Text;
      findRows[0]["population"] = textBox5.Text;

      try
      {
        adapter.Update(dataSet, "CITY");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

      #endregion
    }

    private void button4_Click(object sender, EventArgs e)
    {
      string sql = "DELETE FROM CITY WHERE id=@id";
      adapter.DeleteCommand = new MySqlCommand(sql, conn);
      int id = (int) dataGridView1.SelectedRows[0].Cells["id"].Value;
      adapter.DeleteCommand.Parameters.AddWithValue("@id", id);
      
      
      try
      {
        conn.Open();
        if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
        {
          dataSet.Clear();
          adapter.Fill(dataSet, "CITY");
          dataGridView1.DataSource = dataSet.Tables["CITY"];
        }
        else
        {
          MessageBox.Show("삭제된 데이터가 없습니다.");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
        throw;
      }
      finally
      {
        conn.Close();
      }
    }
  }
}