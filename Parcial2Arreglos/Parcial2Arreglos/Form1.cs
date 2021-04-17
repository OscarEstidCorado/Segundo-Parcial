using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clases;

namespace Parcial2Arreglos
{
    
    public partial class Form1 : Form
    {

        private string[] ArregloNotas;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona el archivo plano";
            ofd.InitialDirectory = @"C:C:\Users\OscarEstid\Documents\progra\";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBoxresultado.Text = resultado;

            }
        }

        private void buttonnombres_Click(object sender, EventArgs e)
        {
            int Conta = 0;

            string[] Arreglo = new string[ArregloNotas.Length - 1];

            foreach (string linea in ArregloNotas)
            {
                if (Conta != 0)
                {
                    string[] Nombres = linea.Split(',');
                    Arreglo[Conta - 1] = Nombres[1];
                }

                Conta++;
            }

            ClsArreglos arreglo = new ClsArreglos(Arreglo);
            string[] Ordenar = arreglo.BurjubaOrden();

            for (int i = 0; i < Ordenar.Length; i++)
            {
                listBoxOrdenar.Items.Add($"{Ordenar[i]} ");
            }

        }

        private void buttonnombresdesor_Click(object sender, EventArgs e)
        {
            foreach (string Linea in ArregloNotas)
            {
                string[] datos = Linea.Split(',');
                listBoxNombresDesordenados.Items.Add($"{datos[1]}");
            }
        }

        private void buttonparcial1_Click(object sender, EventArgs e)
        {
            foreach (string Linea in ArregloNotas)
            {
                string[] datos = Linea.Split(',');
                listBoxParcial1.Items.Add($"{datos[2]}");
            }
        }

        private void buttonparcial2_Click(object sender, EventArgs e)
        {
            foreach (string Linea in ArregloNotas)
            {
                string[] datos = Linea.Split(',');
                listBoxParcial2.Items.Add($"{datos[3]}");
            }
        }

        private void buttonparcial3_Click(object sender, EventArgs e)
        {
            foreach (string Linea in ArregloNotas)
            {
                string[] datos = Linea.Split(',');
                listBoxParcial3.Items.Add($"{datos[4]}");
            }
        }

        private void buttonpromedio_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string[] ordenNombre = new string[ArregloNotas.Length - 1];

            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (contador != 0)
                {

                    ordenNombre[contador - 1] = (datos[4]) + datos[1];

                }

                contador++;
            }
            Arreglo1 cadena = new Arreglo1(ordenNombre);


            for (int h = 0; h < ordenNombre.Length; h++)
            {
                listBoxOrdenamiento.Items.Add(ordenNombre[h]);
            }
        }
    }

    internal class Arreglo1
    {
        private string[] ordenNombre;

        public Arreglo1(string[] ordenNombre)
        {
            this.ordenNombre = ordenNombre;
        }
    }
}
