using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNet01_Server
{
  public partial class Form1 : Form
  {
    private TcpListener tcpListener;
    private TcpClient tcpClient;
    private NetworkStream ns;
    
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      tcpListener = new TcpListener(3000);
      tcpListener.Start();
      
      // 서버의 IP 주소 출력
      IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
      for (int i = 0; i < host.AddressList.Length; i++)
      {
        if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
        {
          textBox1.Text = host.AddressList[i].ToString();
          break;
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      tcpClient = tcpListener.AcceptTcpClient();

      if (tcpClient.Connected)
      {
        textBox2.Text = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
      }

      ns = tcpClient.GetStream();
    }
  }
}