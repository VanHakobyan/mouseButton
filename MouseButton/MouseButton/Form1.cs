using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MouseButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            Random x = new Random();
            for ( i = 0; i < 50; i++)
            {
                Thread.Sleep(70);
                Point pt = new Point(
                      int.Parse(x.Next(200).ToString()),
                      int.Parse(x.Next(200).ToString())
                      );
                button1.Location = pt;

            }
            textBox1.Text = "Hits: " + i;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
