using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    
    public partial class FormMenu : Form
    {
        public string[] menumakanan = new string[] { "Nasi Goreng", "Nasi Goreng Special", "Nasi Goreng Pete", "Ayam Goreng" };
        public string[] menuminuman = new string[] { "Es Teh", "Teh Hangat", "Nutrisari", "Air Putih" };
        public int currentharga = 0;

        public static int subtotal = 0;


        public FormMenu()
        {
            InitializeComponent();
            
            
        }
        
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            angkaharga.Show();
            if (makanan.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0) currentharga = 10000;
                if (comboBox1.SelectedIndex == 1) currentharga = 12000;
                if (comboBox1.SelectedIndex == 2) currentharga = 15000;
                if (comboBox1.SelectedIndex == 3) currentharga = 15000;
            }
            if (radioButton1.Checked == true && minuman.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0) currentharga = 5000;


                if (comboBox1.SelectedIndex == 1) currentharga = 3000;

                if (comboBox1.SelectedIndex == 2) currentharga = 6000;

                if (comboBox1.SelectedIndex == 3) currentharga = 2000;

            }
            if (radioButton2.Checked == true && minuman.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0) currentharga = 7000;


                if (comboBox1.SelectedIndex == 1) currentharga = 5000;

                if (comboBox1.SelectedIndex == 2) currentharga = 10000;

                if (comboBox1.SelectedIndex == 3) currentharga = 5000;
            }
            angkaharga.Text = Convert.ToString(currentharga);
        }

        private void menu_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            angkaharga.Hide();
            radioButton1.Checked = true;
        }

        private void makanan_CheckedChanged(object sender, EventArgs e)
        {
            if (makanan.Checked == true)
            {
                for (int x = 0; x < 4; x++) comboBox1.Items.Add(menumakanan[x]);
            }
            else
            {
                comboBox1.Items.Clear();
                comboBox1.Text = "";
            }
        }

        private void minuman_CheckedChanged(object sender, EventArgs e)
        {
            if (minuman.Checked == true)
            {
                groupBox1.Show();
                for (int x = 0; x < 4; x++) comboBox1.Items.Add(menuminuman[x]);
            }
            else
            {
                comboBox1.Items.Clear();
                groupBox1.Hide();
                comboBox1.Text = "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && minuman.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0) currentharga = 5000;


                if (comboBox1.SelectedIndex == 1) currentharga = 3000;

                if (comboBox1.SelectedIndex == 2) currentharga = 6000;

                if (comboBox1.SelectedIndex == 3) currentharga = 2000;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true && minuman.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0) currentharga = 7000;


                if (comboBox1.SelectedIndex == 1) currentharga = 5000;

                if (comboBox1.SelectedIndex == 2) currentharga = 10000;

                if (comboBox1.SelectedIndex == 3) currentharga = 5000;
            }
            angkaharga.Text = Convert.ToString(currentharga);
        }

        private void buy_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
            listBox2.Items.Add(Convert.ToString(currentharga));
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            listBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(Convert.ToInt32(listBox1.SelectedValue));
            listBox2.Items.RemoveAt(Convert.ToInt32(listBox2.SelectedValue));
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void checkout_Click(object sender, EventArgs e)
        {
          foreach (var x in listBox2.Items)
            {
                subtotal += Convert.ToInt32(x);
            }
            calculation form2 = new calculation();
            form2.ShowDialog();
        }
    }
}
