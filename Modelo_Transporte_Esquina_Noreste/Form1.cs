using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo_Transporte_Esquina_Noreste
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        public Form1()
        {
            InitializeComponent();
            tabla = new DataTable();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int filas = 0;
            int columnas = 0;
            int i = 0;
            int j = 0;
            filas = Convert.ToInt32(txtOrigen.Text);
            columnas = Convert.ToInt32(txtDestino.Text);
            
            dataGridView1.DataSource = "";
            for (i = 0; i < columnas; i++)
            {
                if (i == 0)
                {
                    tabla.Columns.Add("Base");
                }
                tabla.Columns.Add("Destino " + (i + 1));
            }
            i = 0;
            for (j = 0; j < filas; j++)
            {
                if (i==0)
                {
                    tabla.Rows.Add("Origen " + (j + 1));
                }
            }
            tabla.Rows.Add("Demanda");
            tabla.Columns.Add("Oferta");
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = tabla;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[dataGridView1.Columns.Count + 1, dataGridView1.Rows.Count + 1];
            int f = 0;
            int c = 0;
            for (f = 0; f < dataGridView1.Rows.Count; f++)
            {
                for (c = 0; c < dataGridView1.Columns.Count; c++)
                {
                    //matriz[c, f] = dataGridView1.Rows[f].Cells[c].Value;   
                }
                
            }
        }
    }
}
