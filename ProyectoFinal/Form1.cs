using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
    }
}
