using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_06
{
    class Calculo
    {
        #region atributos
        private double num1;
        private double resultado;
        #endregion

        #region construtores
        public Calculo()
        {
            this.num1 = 0;
        }

        public Calculo(double num1)
        {
            this.num1 = num1;
        }
        #endregion

        #region métodos de interface (Setter's & Getter's)
        public void setNum1(double num1)
        {
            this.num1 = num1;
        }

        public double getNum1()
        {
            return this.num1;
        }

        public double getResultado()
        {
            return this.resultado;
        }
        #endregion

        #region métodos funcionais
        public void calcular()
        {
            this.resultado = this.num1 * 1.852;
        }
        #endregion
    }
}
