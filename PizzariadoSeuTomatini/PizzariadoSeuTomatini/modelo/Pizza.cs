using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariadoSeuTomatini.modelo
{
    class Pizza
    {
        private string tipo;
        private string sabor;
        private string composicao;
        private bool permitebordas;
        private string bordas;
        private double valorpequena;
        private double valorfamilia;

        public Pizza(string tipo,string sabor,string composicao,bool permiteborda, string bordas,double valorpequena, double valorfamilia)
        {
            this.tipo = tipo;
            this.sabor = sabor;
            this.composicao = composicao;
            this.permitebordas = permiteborda;
            this.bordas = bordas;
            this.valorpequena = valorpequena;
            this.valorfamilia = valorfamilia;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string getTipo()
        {
            return this.tipo;
        }

        public void setSabor(string sabor)
        {
            this.sabor = sabor;
        }

        public string getSabor()
        {
            return this.sabor;
        }

        public void setComposicao(string composicao)
        {
            this.composicao = composicao;
        }

        public string getComposicao()
        {
            return this.composicao;
        }

        public void setPermiteBordas(bool permitebordas)
        {
            this.permitebordas = permitebordas;
        }

        public bool isPermiteBordas()
        {
            return this.permitebordas;
        }

        public void setBordas(string bordas)
        {
            this.bordas = bordas;
        }

        public string getBordas()
        {
            return this.bordas;
        }
        public void setValorPequena(double valorpequena)
        {
            this.valorpequena = valorpequena;
        }

        public double getValorPequena()
        {
            return this.valorpequena;
        }

        public void setValorFamilia(double valorfamilia)
        {
            this.valorfamilia = valorfamilia;
        }

        public double getValorFamilia()
        {
            return this.valorfamilia;
        }
    }
}
