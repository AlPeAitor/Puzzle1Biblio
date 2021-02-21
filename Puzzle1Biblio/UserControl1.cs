using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle1Biblio
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            Prueba(checkBox2, checkBox4);
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            Prueba(checkBox1, checkBox3, checkBox5);
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            Prueba(checkBox2, checkBox6);
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            Prueba(checkBox1, checkBox5, checkBox8);
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            Prueba(checkBox2, checkBox4, checkBox6, checkBox8);
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            Prueba(checkBox3, checkBox5, checkBox9);
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {
            Prueba(checkBox4, checkBox8);
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {
            Prueba(checkBox5, checkBox7, checkBox9);
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {
            Prueba(checkBox6, checkBox8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TO DO
            MessageBox.Show("Enhorabuena, ha resuelto el puzzle", "FELICIDADES");
        }


        private bool comprobarPuzzle()
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked && checkBox6.Checked && checkBox7.Checked && checkBox8.Checked && checkBox9.Checked)
             {
                 return true;
             }
             else
             {
                 return false;
             }


        }


        public void Prueba(params CheckBox[] x)
        {
            foreach (CheckBox i in x)
            {
                i.Checked = i.Checked ? false : true;
            }
            button1.Enabled = comprobarPuzzle();
        }

        public void Reiniciar(params CheckBox[] x)
        {
            foreach (CheckBox i in x)
            {
                i.Checked = false;
            }
        }

        private void button2_Reiniciar(object sender, EventArgs e)
        {
            Reiniciar(checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9);

        }



    }
}