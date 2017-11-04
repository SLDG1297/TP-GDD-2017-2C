﻿using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Modelo.Estadistica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Orquestradores.Estadisticas
{
    public class GestorDeEstadisticas
    {

        private static GestorDeEstadisticas instance = new GestorDeEstadisticas();

        private GestorDeEstadisticas(){}

        public static GestorDeEstadisticas getInstance()
        {
            return instance;
        }

        Estadistica estadistica;
        List<string> columnasElectas = new List<string>();
        int trimestre = 0;

        public Estadistica[] obtenerEstadisticas()
        {
            return RepositorioDeEstadisticas.getInstance().obtenerEstadisticas();
        }

        public void asignarTrimestre(int trimestre)
        {

            this.trimestre = trimestre;

        }

        public Boolean esCalculable()
        {

            return this.estadistica != null && this.trimestre != 0;

        }

        public void agregarColumna(string columna)
        {

            columnasElectas.Add(columna);

        }

        public void quitarColumna(string columna)
        {

            columnasElectas.Remove(columna);

        }

        public void elegir(Estadistica estadisticaElegida)
        {

            this.estadistica = estadisticaElegida;

            this.columnasElectas = new List<string>(estadisticaElegida.getColumnas());

        }

        public DataTable calcularEstadistica(string anio)
        {

            if (this.esCalculable())
            {

                string funcion = estadistica.getFuncionArmada(Int32.Parse(anio), trimestre);

                return LectorDeTablas.getInstance().obtenerCiertasColumnas(funcion, columnasElectas);

            }
            else
                throw new ArgumentException("Argumentos invalidos");

        }

    }

}
