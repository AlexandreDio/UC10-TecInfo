﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semHeranca
{
    class Mustang
    {
        private string marca;
        private string modelo;
        private int quantPortas;
        private int potencia;
        private string combustivel;
        private bool cambioAutomatico;
        private int aroRodas;
        private string versaoMustang;

        public Mustang()
        {
        }

        public Mustang(string marca, string modelo, int quantPortas, int potencia, string combustivel, bool cambioAutomatico, int aroRodas, string versaoMustang)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.quantPortas = quantPortas;
            this.potencia = potencia;
            this.combustivel = combustivel;
            this.cambioAutomatico = cambioAutomatico;
            this.aroRodas = aroRodas;
            this.versaoMustang = versaoMustang;
        }

        public string VersaoMustang
        {
            get { return versaoMustang; }
            set { versaoMustang = value; }
        }

        public int AroRodas
        {
            get { return aroRodas; }
            set { aroRodas = value; }
        }

        public bool CambioAutomatico
        {
            get { return cambioAutomatico; }
            set { cambioAutomatico = value; }
        }

        public string Combustivel
        {
            get { return combustivel; }
            set { combustivel = value; }
        }

        public int Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }

        public int QuantPortas
        {
            get { return quantPortas; }
            set { quantPortas = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        void Mover()
        {
        }

        void Frear()
        {

        }

        void Virar()
        {

        }
    }
}
