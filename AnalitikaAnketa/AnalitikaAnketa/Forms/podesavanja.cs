using System;
using System.IO;
using System.Windows.Forms;

namespace AnalitikaAnketa.Forms
{
    public partial class Podesavanja : Form
    {
        public Podesavanja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream("file11.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(textBox1.Text);
            writer.Close();
            stream.Close();
        }

        private void podesavanja_Load(object sender, EventArgs e)
        {

            try
            {
                StreamReader sr = new StreamReader("file11.txt");
                if (sr != null)
                {
                    string data = sr.ReadLine();

                    textBox1.Text = data;
                }
            }
            catch 
            {
                FileStream stream = new FileStream("file11.txt", FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);
                writer.WriteLine(textBox1.Text);
                writer.Close();
                stream.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
