using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truco
{
    internal class Cartas
    {
        private string _naipe;
        private char _numero;
        private int _valor;

        public Cartas(string naipe, char numero, int valor)
        {
            _naipe = naipe;
            _numero = numero;
            _valor = valor;
        }

        public string Naipe { get { return _naipe; } set { _naipe = value; } }
        public char Numero { get { return _numero; } set { _numero = value; } }
        public int Valor { get { return _valor; } set { _valor = value; } }
    }
}
