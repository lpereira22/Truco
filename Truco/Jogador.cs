using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truco
{
    internal class Jogador
    {
        private string _name;
        private Cartas[] _maoDeCartas = new Cartas[3];
        
        public string Name { get { return _name; } set { _name = value; } }
        public Cartas[] MaoDeCartas { get { return _maoDeCartas; } set { _maoDeCartas = value; } }


    }
}
