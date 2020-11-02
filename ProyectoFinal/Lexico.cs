using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    class Lexico
    {
        protected const String reservado = "variable,entero,decimal,booleano,cadena,si,sino,mientras,hacer,funcion,principal,retornar,vacio,carácter,para,imprimir";
        protected String[] palabra = new String[] {"funcion", "principal", "retornar", "vacio", "variable", "entero", "decimal", "booleano", "cadena", "cadena", "carácter", "SI",
        "SINO", "mientras", "para", "hacer", "imprimir"};
        protected const String operadorAritmetico = "+-*/";
        protected const String operadorincremneto = "++";
        protected const String operadorDecremento = "--";
        protected const String operadoresRelacionales = "><>=<===!=";
        protected const String operadoresLogicos = "||&&";
        protected const String agrupacion = "()";
        protected const String llaves = "{}";
        protected const String sentencia = "=;";
        protected String[] booleano = new String[] {"VERDADERO","FALSO"};
        protected const String digito = "1234567890";
        protected const String alfabeto = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
        protected const String simbolo = "\";1234567890(){}+-*/%<>= ";

        public readonly Transicion[] transiciones = {
        new Transicion("S0", "/", "S1", false), new Transicion("S0", "'", "S8", false), new Transicion("S0", "\"", "S12", false),
        new Transicion("S0", alfabeto, "S15", true, "id"), new Transicion("S0", digito, "S16", true, "entero"), new Transicion("S0", "\";", "S19", true, "signo"),
        new Transicion("S0", agrupacion, "S20", true, "agrupacion"), new Transicion("S0", "<>=", "S21", true, "operador"),
        new Transicion("S0", "%/*-+", "S23", true, "operador"), new Transicion("S1", "*", "S3", false),
        new Transicion("S3", alfabeto, "S4", false), new Transicion("S3", simbolo, "S4", false), new Transicion("S4", alfabeto, "S4", false),
        new Transicion("S4", simbolo, "S4", false), new Transicion("S4", "*", "S6", false),
        new Transicion("S6", "/", "S7", true, "comentario"), new Transicion("S8", alfabeto, "S9", false), new Transicion("S8", simbolo, "S9", false),
        new Transicion("S9", "'", "S10", true, "caracter"),
        new Transicion("S12", alfabeto, "S13", false), new Transicion("S12", simbolo, "S13", false), new Transicion("S13", alfabeto, "S13", false),
        new Transicion("S13", simbolo, "S13", false), new Transicion("S13", "\"", "S14", true, "cadena"), new Transicion("S15", alfabeto, "S15", true, "id"),
        new Transicion("S15", digito, "S15", true, "id"),
        new Transicion("S16", digito, "S16", true, "entero"), new Transicion("S16", ".", "S17", false), new Transicion("S17", digito, "S18", true, "flotante"),
        new Transicion("S18", digito, "S18", true), new Transicion("S21", "=", "S22", true, "operador")};

    private int pos = 0;
    private Token analizado;
    private int linea;
    private String[] lineas;
    private Boolean tope = false;

    public Lexico()
    {
        linea = 0;
    }

    public Token analizarToken()
    {
            analizado = new Token(pos + 1, linea + 1);
        recorrerMatriz(true);
        if (analizado.getTipo() != null && analizado.getTipo().Equals("id"))
        {
            verificarBooleano();
            verificarReservada();
        }
        return analizado;
    }

    public void recorrerMatriz(Boolean seguir)
    {
            Char caracter = lineas[linea].ElementAt(pos);
        Boolean s = false;
        if (caracter != ' ')
        {
            foreach (Transicion trans in transiciones)
            {
                if (trans.getEstado().Equals(analizado.getEstado())
                        && trans.getTrancision().IndexOf(caracter.ToString()) != -1)
                {
                    analizado.getCharacter(caracter);
                    analizado.setEstado(trans.getEstadofinal());
                    analizado.setTipo(trans.getTipo());
                    s = true;
                    pos++;
                    break;
                }
            }
            if (!s && (analizado.getPalabra().Equals("") || analizado.getTipo() == null))
            {
                analizado.setTipo("error");
                analizado.getCharacter(caracter);
                pos++;
            }
            if (lineas[linea].Length <= pos)
            {
                linea++;
                pos = 0;
                if (analizado.getTipo() == null)
                {
                    analizado.setTipo("error");
                    if (!s)
                    {
                        analizado.getCharacter(caracter);
                    }
                }
                if (lineas.Length <= linea)
                {
                    tope = true;
                }
            }
            else if (s)
            {
                recorrerMatriz(seguir);
            }
        }
        else
        {
            if (analizado.getPalabra() == "")
            {
                pos++;
                if (lineas[linea].Length <= pos)
                {
                    pos = 0;
                    linea++;
                    if (lineas.Length <= linea)
                    {
                        tope = true;
                    }
                }
                recorrerMatriz(seguir);
            }
            else
            {
                pos++;
                if (lineas[linea].Length <= pos)
                {
                    pos = 0;
                    linea++;
                    if (lineas.Length <= linea)
                    {
                        tope = true;
                    }
                }
            }
        }
    }

    public void setLineas(String texto)
    {
        lineas = texto.Split('\n');
    }

    public Boolean isTope()
    {
        return tope;
    }

    public void setTope(Boolean tope)
    {
        this.tope = tope;
    }

    private void verificarBooleano()
    {
        foreach (String dato in booleano)
        {
            if (dato.Equals(analizado.getPalabra()))
            {
                analizado.setTipo("boolean");
            }
        }
    }

    private void verificarReservada()
    {
        foreach (String dato in palabra)
        {
            if (dato.Equals(analizado.getPalabra()))
            {
                analizado.setTipo("reservada");
            }
        }
    }

    public void setPos(int pos)
    {
        this.pos = pos;
    }

    public void setLinea(int linea)
    {
        this.linea = linea;
    }
}
}
