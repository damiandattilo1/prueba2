using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
            this.Text = "TP Final de Dattilo, Damian del curso 2A";
            this.StartPosition = FormStartPosition.CenterScreen;
            
            this.elegirClase.Items.AddRange(new String[] { "Microondas", "Aire Acondicionado" });
            
            this.eficiencia1.Items.AddRange(new String[] { "A", "B", "C", "D" });
            this.eficiencia2.Items.AddRange(new String[] { "A", "B", "C", "D" });
            
            this.comboBox1.Items.AddRange(new String[] { "Frio", "Calor", "FrioCalor", "Chico", "Mediano", "Grande"});
            this.comboBox2.Items.AddRange(new String[] { "Frio", "Calor", "FrioCalor", "Chico", "Mediano", "Grande"});
        }

        private void id1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EficienciaEnergetica auxEficiencia;
            if (String.IsNullOrWhiteSpace(id1.Text) || string.IsNullOrWhiteSpace(id2.Text) || String.IsNullOrWhiteSpace(eficiencia1.Text) || String.IsNullOrWhiteSpace(eficiencia2.Text) || String.IsNullOrWhiteSpace(comboBox1.Text) || String.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("ERROR: Ingrese valores");
            }
            else
            {
                if(eficiencia1.Text == )
                if(elegirClase.Text == "Microndas")
                {
                    Microondas obj1 = new Microondas(int.Parse(id1.Text), EficienciaEnergetica.P)
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
