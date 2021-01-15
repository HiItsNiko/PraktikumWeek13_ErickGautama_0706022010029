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
    public partial class calculation : Form
    {
        static FormMenu form1 =  new FormMenu();
        public double angkasubtotal = 0; 
        public double angkatax = 0;
        public double angkadiskon = 0;
        public  double currentdiskon = 0;
        public double angkatotal = 0;
        
        public calculation()
        {
            InitializeComponent();
        }

        private void calculation_Load(object sender, EventArgs e)
        {
            label6.Hide();
            label5.Hide();
            textBox1.Hide();
            angkasubtotal = FormMenu.subtotal;
            currentdiskon = FormMenu.subtotal;
            angkatax = angkasubtotal / 10;
            
            
        }

        private void Discountbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Discountbox.Checked == true)
            {
                label6.Show();
                label5.Show();
                textBox1.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if(textBox1.Text != "")
                angkadiskon = Convert.ToInt32(textBox1.Text);
            angkadiskon = angkadiskon / 100;
            
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            currentdiskon = currentdiskon * angkadiskon;
            angkatotal = angkasubtotal + angkatax - currentdiskon; 
            Subtotal.Text = Convert.ToString(angkasubtotal);
            Tax.Text = Convert.ToString(angkatax);
            Discount.Text = Convert.ToString(currentdiskon);
            Total.Text = Convert.ToString(angkatotal);
            
            

        }
    }
}
