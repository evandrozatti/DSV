using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    internal class Modelo
    {
        private const string SEPARADOR = " | ";
        private Marca _marca;
        private string _descricao;
        public Marca Marca
        {
            get => _marca;
            set => _marca = value;
        }
        public string Descricao
        {
            get => _descricao;
            set => _descricao = value;
        }
        public Modelo()
        {
            _marca = new();
            _descricao = string.Empty;
        }
        public Modelo(Marca marca, string descricao)
        {
            _marca = marca;
            _descricao = descricao;
        }
        public override string ToString()
        {
            return _marca + SEPARADOR + _descricao;
        }
    }
}
