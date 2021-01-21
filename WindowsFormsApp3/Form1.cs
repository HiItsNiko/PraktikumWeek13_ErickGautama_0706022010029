using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
            listawal.Items.Add("Mie Instan");
            listawal.Items.Add("Telor");
            listawal.Items.Add("Susu Sapi");
            listawal.Items.Add("Kopi");
            listawal.Items.Add("Roti");
            listawal.Items.Add("Keju");
            listawal.Items.Add("Daging giling");
            listawal.Items.Add("Teh");
            listawal.Items.Add("Bir");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listawal.Items.Add(textnama.Text);
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            listpilihan.Items.Add(listawal.SelectedItem);
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            listpilihan.Items.Remove(listpilihan.SelectedItem);
        }
    }
}
