using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_2
{
    public partial class Form1 : Form
    {
        private List<Alimento> alimentos;
        private List<Bebida> bebidas;
        private List<Venta> ventas;
        public Form1()
        {
            InitializeComponent();
            alimentos = new List<Alimento>();
            bebidas = new List<Bebida>();
            ventas = new List<Venta>();
            CargarDatos();
            MostrarOpciones();
        }

        private void CargarDatos()
        {
            // Cargar datos de alimentos desde el archivo CSV "alimentos.csv"
            // Cargar datos de bebidas desde el archivo CSV "bebidas.csv"
            // Cargar datos de precios desde el archivo CSV "precio.csv"
        }

        private void MostrarOpciones()
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void MostrarComida()
        {
            tabControl1.SelectedTab = tabPage2;
            //dataGridViewComida.DataSource = alimentos;
        }

        private void MostrarBebida()
        {
            tabControl1.SelectedTab = tabPage3;
            //dataGridViewBebida.DataSource = bebidas;
        }

        private void MostrarAjustes()
        {
            tabControl1.SelectedTab = tabPage4;
            //dataGridViewPrecios.DataSource = alimentos;
            // Configurar la apariencia del DataGridViewPrecios
        }

        private void MostrarHistorial()
        {
            tabControl1.SelectedTab = tabPage5;
            //dataGridViewHistorial.DataSource = ventas;
            // Configurar la apariencia del DataGridViewHistorial
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            MostrarComida();
        }
        private void btnOpciones_Click(object sender, EventArgs e)
        {
            MostrarOpciones();
        }

        private void btnBebida_Click(object sender, EventArgs e)
        {
            MostrarBebida();
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            MostrarAjustes();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            MostrarHistorial();
        }

        private void btnGuardarPrecios_Click(object sender, EventArgs e)
        {
            // Guardar los precios en el archivo CSV "precio.csv"
        }

        private void btnGuardarHistorial_Click(object sender, EventArgs e)
        {
            // Guardar el historial de ventas en el archivo CSV "Ventas-[FechaDelDia].csv"
        }

        private void btnLeerHistorial_Click(object sender, EventArgs e)
        {
            // Abrir un cuadro de diálogo para seleccionar un archivo CSV de ventas
            // Leer los datos del archivo y mostrarlos en el DataGridViewHistorial
        }
    }

    // Clase Alimento - Representa un alimento del menú

    public class Alimento
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
    }

    // Clase Bebida - Representa una bebida del menú

    public class Bebida
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
    }

    // Clase Venta - Representa una venta

    public class Venta
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        // Agregar propiedades adicionales según el historial de ventas
    }
}
