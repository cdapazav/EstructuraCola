using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraCola
{
    public partial class Form1 : Form
    {
        ColaCircular colaCircular = new ColaCircular();
        public void mostrarColaCircular()
        {
            listView1.Clear();
            for(int i=0; i<=colaCircular.maxcola-1;i++)
            {
                listView1.Items.Add(colaCircular.lista[i]);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colaCircular.eliminar();
            mostrarColaCircular();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colaCircular.insertar(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            mostrarColaCircular();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
