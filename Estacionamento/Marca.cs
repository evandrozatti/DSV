using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    internal class Marca
    {
        private string _nome;
        public string Nome
        {
            get => _nome; 
            set => _nome = value;
        }
        public Marca()
        {
            _nome = string.Empty;
        }
        public Marca(string nome)
        {
            _nome = nome;
        }
        public override string ToString()
        {
            return _nome;
        }
    }
}
