using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interprete_Prolog
{
    public partial class Prolog : Form
    {
        public Prolog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
               

                string ubicacion = openFileDialog1.FileName;
                string leer = File.ReadAllText(ubicacion);
                if (leer == "")
                {
                    MessageBox.Show("El archivo de conocimiento esta vacio");
                }
                else
                {
                    textBox1.Text = leer;
                    panel2.Visible = true;
                    MessageBox.Show("carga la base de conocimientos");


                }
              

                button_enter_consulta.Enabled = false;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
        private void textBox_consulta_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }
      
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void validarCampo()
        {

            var campo = !string.IsNullOrEmpty(textBox_consulta.Text);
            button_enter_consulta.Enabled = campo;
        }

        private void textBox_consulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_enter_consulta.PerformClick();
            }
        }

        private void button_enter_consulta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("se inserto la consulta");
            button_Arbol.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

   
    }
}
