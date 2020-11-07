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

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        private Lexico analizador;
        protected String[] lineas;
        protected int iterador = 0;
        protected String codigo = "";
        string archivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkautocomplete();

        }

        private void checkautocomplete()
        {
                       
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Area1_TextChanged(object sender, EventArgs e)
        {

        }
        //para la lectura de los datos lee linea por linea
        private void Copilar_Click(object sender, EventArgs e)
        {
            lineas = Area1.Text.Split('\n');
            analizador = new Lexico();
            
        }

        private void Analisis_Click(object sender, EventArgs e)
        {
            if (iterador < lineas.Length)
            {
                lineaActual.Text=lineas[iterador];
                analizador.setLineas(lineas[iterador]);
                analizador.setTope(false);
                analizador.setLinea(0);
                analizador.setPos(0);

                while (!analizador.isTope() && lineas[iterador] != null && !lineas[iterador].Equals(""))
                {
                    Token token = analizador.analizarToken();
                    token.setLinea(iterador + 1);
                    codigo += "  token: " + token.getPalabra() + " columna: " + token.getPosicion() + "  tipo: " + token.getTipo() + "  linea: " + token.getLinea() + "\n";

                }
                copilado.Text=codigo;
                iterador++;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void pintar(object sender, KeyPressEventArgs e)
        {
            string comparar = "";
            int indice = 0;
            if (Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.Space))
            {

                comparar = Area1.Text;
                char[] arreglo = Area1.Text.ToCharArray();
                for (int i = 0; i < Area1.TextLength; i++)
                {
                    if (arreglo[i] == ' ')
                    {
                        indice = i;
                    }
                }
                comparar = null;
                if (indice != 0)
                {
                    indice++;
                }
                for (int i = indice; i < Area1.Text.Length; i++)
                {
                    comparar += arreglo[i];
                }
                compararTexto(comparar, indice);
            }
        }
        private void compararTexto(string comparar, int indice)
        {

            if (comparar == "SI" || comparar == "SINO" || comparar == "SINO_SI" || comparar == "MIENTRAS" || comparar == "HACER"
                || comparar == "DESDE" || comparar == "HASTA" || comparar == "INCREMENTO")
            {
                Area1.Select(indice, Area1.Text.Length);
                Area1.SelectionColor = Color.Green;
                Area1.SelectionStart = this.Area1.Text.Length;
            }
            else if (comparar == "verdadero" || comparar == "falso")
            {
                Area1.Select(indice, Area1.Text.Length);
                Area1.SelectionColor = Color.Orange;
                Area1.SelectionStart = this.Area1.Text.Length;
            }
            else if (comparar == "+" || comparar == "-" || comparar == "*" || comparar == "/" || comparar == "++" || comparar == "++"
                || comparar == "--" || comparar == ">" || comparar == "<" || comparar == ">=" || comparar == "<=" || comparar == "=="
                || comparar == "!=" || comparar == "||" || comparar == "&&" || comparar == "!" || comparar == "(" || comparar == ")")
            {
                Area1.Select(indice, Area1.Text.Length);
                Area1.SelectionColor = Color.DarkBlue;
                Area1.SelectionStart = this.Area1.Text.Length;
            }
            else if (comparar == "=" || comparar == ";")
            {
                Area1.Select(indice, Area1.Text.Length);
                Area1.SelectionColor = Color.Pink;
                Area1.SelectionStart = this.Area1.Text.Length;
            }
            else if (comparar == "A" || comparar == "B" || comparar == "i" || comparar == "a")
            {
                Area1.Select(indice, Area1.Text.Length);
                Area1.SelectionColor = Color.Brown;
                Area1.SelectionStart = this.Area1.Text.Length;
            }
            else
            {
                Area1.Select(indice, Area1.Text.Length);
                Area1.SelectionColor = Color.Black;
                Area1.SelectionStart = this.Area1.Text.Length;
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void crearArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Area1.Clear();
            archivo = null;
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog cuadroDialogo = new OpenFileDialog();
                cuadroDialogo.Filter = "Texto|*.gt";
                if (cuadroDialogo.ShowDialog() == DialogResult.OK)
                {
                    archivo = cuadroDialogo.FileName;
                    using (StreamReader lectura = new StreamReader(archivo))
                    {
                        Area1.Text = lectura.ReadToEnd();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error de abrir archivo");
            }
        }

        private void cerrarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog Guardar = new SaveFileDialog();
                Guardar.Filter = "Texto|*.gt";
                if (archivo != null)
                {
                    using (StreamWriter sobreEscribir = new StreamWriter(archivo))
                    {
                        sobreEscribir.Write(Area1.Text);
                    }
                }
                else
                {
                    if (Guardar.ShowDialog() == DialogResult.OK)
                    {
                        archivo = Guardar.FileName;
                        using (StreamWriter escribir = new StreamWriter(Guardar.FileName))
                        {
                            escribir.Write(Area1.Text);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("error al guardar");
            }
        }
    }
}
