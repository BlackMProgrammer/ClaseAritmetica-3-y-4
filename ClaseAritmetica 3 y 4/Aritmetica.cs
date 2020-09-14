using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Text;

namespace ClaseAritmetica_3_y_4
{
    class Aritmetica
    {
        private double _numero1;
        private double _numero2;

        public Aritmetica(double _numero1, double _numero2) {
            this._numero1 = _numero1;
            this._numero2 = _numero2;
        }

        public double Sumar(double _numero1, double _numero2) {
            return _numero1 + _numero2;
        }

        public double Restar(double _numero1, double _numero2) {
            return _numero1 - _numero2;        
        }

        public double Multiplicar(double _numero1, double _numero2) {
            return _numero1 * _numero2;
        }

        public double Dividir(double _numero1, double _numero2) {
            return _numero1 / _numero2;
        }
            
    }
}
