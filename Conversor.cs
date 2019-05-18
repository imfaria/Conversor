using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_POOT
{
    class Conversor
    {
        private double pesParaMetros = 0.3048;
        private double pesParaPolegadas = 12;
        private double pesParaCentimetros = 30.48;

        private double polegadasParaMetros = 0.0254;
        private double polegadasParaPes = 0.0833333;
        private double polegadasParaCentimetros = 2.54;

        private double metrosParaPes = 3.28084;
        private double metrosParaPolegadas = 39.3701;
        private double metrosParaCentimetros = 100;

        private double centimetrosParaPes = 0.0328084;
        private double centimetrosParaPolegadas = 0.393701;
        private double centimetrosParaMetros = 0.01;

        public double ConverterPesParaMetros(double valor)
        {
            return (pesParaMetros * valor);
        }

        public double ConverterPesParaPolegadas(double valor)
        {
            return (pesParaPolegadas * valor);
        }

        public double ConverterPesParaCentimetros(double valor)
        {
            return (pesParaCentimetros * valor);
        }

        public double ConverterPolegadasParaMetros(double valor)
        {
            return (polegadasParaMetros * valor);
        }

        public double ConverterPolegadasParaPes(double valor)
        {
            return (polegadasParaPes * valor);
        }

        public double ConverterPolegadasParaCentimetros(double valor)
        {
            return (polegadasParaCentimetros * valor);
        }

        public double ConverterMetrosParaPes(double valor)
        {
            return (metrosParaPes * valor);
        }

        public double ConverterMetrosParaPolegadas(double valor)
        {
            return (metrosParaPolegadas * valor);
        }

        public double ConverterMetrosParaCentimetros(double valor)
        {
            return (metrosParaCentimetros * valor);
        }

        public double ConverterCentimetrosParaPes(double valor)
        {
            return (centimetrosParaPes * valor);
        }

        public double ConverterCentimetrosParaPolegadas(double valor)
        {
            return (centimetrosParaPolegadas * valor);
        }

        public double ConverterCentimetrosParaMetros(double valor)
        {
            return (centimetrosParaMetros * valor);
        }
    }
}
