using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalitikaAnketa.Forms
{
    public partial class import : Form
    {
        public import()
        {
            InitializeComponent();
        }

        private  void button1_Click(object sender, EventArgs e)
        {



            openFD.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (openFD.ShowDialog() == DialogResult.OK)
            {     
           
                txtIzborFajla.Text = openFD.FileName; 

            }
        

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFD_FileOk(object sender, CancelEventArgs e)
        {
            
        }
    }
    }

