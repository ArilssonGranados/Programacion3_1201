using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion3_1201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaro la matriz
        int[,] matriz;
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //Declaro dos variables para las filas y las columnas y las inicializo con los textbox correspondiente
            int fila = int.Parse(txtFila.Text);
            int columna = int.Parse(txtColumna.Text);

            //Declaro una variable de tipo random
            Random aleatorio = new Random();

            //Le doy el tamaño a la matriz con las dimensiones ingresadas por el usuario
            matriz = new int[fila, columna];

            //Le asigno las dimensiones que tendra el datagridview con los datos ingresados por el usuario
            dgvMatriz.ColumnCount = columna;
            dgvMatriz.RowCount = fila;

            //Aquí guardo los números random dentro de la matriz en dos for anidados
            for (int i = 0; i < fila; i++) //Este for será para el conteo de filas 
            {
                for (int j = 0; j < columna; j++) //Este será para el conteo de columnas
                {
                    matriz[i, j] = aleatorio.Next(100); //Aquí almaceno los números aleatorios en el DataGridView
                }

            }

            //Estos for anidados serán para mostrar los números almacenados en la matriz
            for (int i = 0; i < fila; i++) //For para conteo de filas
            {
                for (int j = 0; j < columna; j++)//For para conteo de columnas
                {
                    dgvMatriz.Rows[i].Cells[j].Value = matriz[i, j]; //Muestro los datos de la matriz al DataGridView
                }
            }

        }

        //Botón para limpiar los textbox y el DataGridView
        private void button1_Click(object sender, EventArgs e)
        {
            txtFila.Clear();
            txtColumna.Clear();
            dgvMatriz.Rows.Clear();
            dgvMatriz.Columns.Clear();
            txtFila.Focus();
        }

        //Botón para Cerrar el Form
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
