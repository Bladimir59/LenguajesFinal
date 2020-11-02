using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    class Token
    {
        private String tipo;
        private String palabra;
        private int posicion;
        private int linea;
        private String estado;

        public Token(int pos, int linea)
        {
            tipo = "";
            palabra = "";
            this.linea = linea;
            posicion = pos;
            estado = "50";
        }
        public void getCharacter(Char caracter)
        {
            palabra += caracter;
        }
        public String getTipo()
        {
            return tipo;
        }
        public void setTipo(String tipo)
        {
            this.tipo = tipo;
        }
        public String getPalabra()
        {
            return palabra;
        }

        public void setPalabra(String palabra)
        {
            this.palabra = palabra;
        }

        public String getEstado()
        {
            return estado;
        }

        public void setEstado(String estado)
        {
            this.estado = estado;
        }

        public int getPosicion()
        {
            return posicion;
        }

        public void setPosicion(int posicion)
        {
            this.posicion = posicion;
        }

        public int getLinea()
        {
            return linea;
        }

        public void setLinea(int linea)
        {
            this.linea = linea;
        }
    }
}
