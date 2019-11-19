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

namespace WinFormDB04_SUID
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private MySqlConnection conn;

    private void Form1_Load(object sender, EventArgs e)
    {
      string connStr = "server=db.donote.co;port=3306;database=world;uid=world;pwd=1111";
      conn = new MySqlConnection(connStr);

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
      string sql = "SELECT * FROM CITY WHERE id = @id";
      MySqlCommand cmd = new MySqlCommand(sql, conn);
      cmd.Parameters.AddWithValue("@id", textBox1.Text);

      try
      {
        MySqlDataReader reader = cmd.ExecuteReader();
        if (reader.Read())
        {
          textBox1.Text = reader.GetString("id");
          textBox2.Text = reader.GetString("name");
          textBox3.Text = reader.GetString("countrycode");
          textBox4.Text = reader.GetString("district");
          textBox5.Text = reader.GetString("population");
        }
        reader.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      string sql =
        "INSERT INTO CITY (name, countrycode, district, population) VALUES (@name, @countrycode, @district, @population)";
      MySqlCommand cmd = new MySqlCommand(sql, conn);
      cmd.Parameters.AddWithValue("@name", textBox2.Text);
      cmd.Parameters.AddWithValue("@countrycode", textBox3.Text);
      cmd.Parameters.AddWithValue("@district", textBox4.Text);
      cmd.Parameters.AddWithValue("@population", textBox5.Text);

      try
      {
        cmd.ExecuteNonQuery();
        ShowData("Data Inserted.");
        // MessageBox.Show("Data Inserted.");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void ShowData(string caption)
    {
      string sql = "SELECT * FROM CITY WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
      
            try
            {
              MySqlDataReader reader = cmd.ExecuteReader();
              
              if (reader.Read())
              {
                textBox1.Text = reader.GetString("id");
                textBox2.Text = reader.GetString("name");
                textBox3.Text = reader.GetString("countrycode");
                textBox4.Text = reader.GetString("district");
                textBox5.Text = reader.GetString("population");
              }
              reader.Close();
              MessageBox.Show(caption);
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      string sql = "UPDATE CITY SET name=@name, countrycode=@countrycode, district=@district, population=@population WHERE id=@id";
      ExecuteQuery(sql, "Data Updated");
    }

    private void ExecuteQuery(string sql, string caption)
    {
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@countrycode", textBox3.Text);
            cmd.Parameters.AddWithValue("@district", textBox4.Text);
            cmd.Parameters.AddWithValue("@population", textBox5.Text);
      
            try
            {
              cmd.ExecuteNonQuery();
              ShowData(caption);
              // MessageBox.Show("Data Inserted.");
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      string sql = "DELETE FROM CITY WHERE id=@id";
      ExecuteQuery(sql, "Data Deleted");
    }
  }
}