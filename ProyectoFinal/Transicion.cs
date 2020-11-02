using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Transicion
    {
        private String estado;
        private String trancision;
        private String[] trancisiones;
        private String estadofinal;
        private Boolean aceptado;
        private String tipo;

        public Transicion(String estado, String trancision, String estadofinal, Boolean aceptado)
        {
            this.estado = estado;
            this.trancision = trancision;
            this.estadofinal = estadofinal;
            this.aceptado = aceptado;
        }

        public Transicion(String estado, String[] trancisiones, String estadofinal, Boolean aceptado)
        {
            this.estado = estado;
            this.trancisiones = trancisiones;
            this.estadofinal = estadofinal;
            this.aceptado = aceptado;
        }

        public Transicion(String estado, String trancision, String estadofinal, Boolean aceptado, String tipo)
        {
            this.estado = estado;
            this.trancision = trancision;
            this.estadofinal = estadofinal;
            this.aceptado = aceptado;
            this.tipo = tipo;
        }

        public Transicion(String estado, String[] trancisiones, String estadofinal, Boolean aceptado, String tipo)
        {
            this.estado = estado;
            this.trancisiones = trancisiones;
            this.estadofinal = estadofinal;
            this.aceptado = aceptado;
            this.tipo = tipo;
        }

        public void analizarToken(Token token)
        {

        }

        public String getEstado()
        {
            return estado;
        }

        public String getTrancision()
        {
            return trancision;
        }

        public String getEstadofinal()
        {
            return estadofinal;
        }

        public String[] getTrancisiones()
        {
            return trancisiones;
        }

        public void setTrancisiones(String[] trancisiones)
        {
            this.trancisiones = trancisiones;
        }

        public Boolean isAceptado()
        {
            return aceptado;
        }

        public String getTipo()
        {
            return tipo;
        }
    }
}
