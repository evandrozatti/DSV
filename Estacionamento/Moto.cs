using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Estacionamento.Veiculo;

namespace Estacionamento
{
    internal class Moto : Veiculo
    {
        private bool _bau;
        public bool Bau
        {
            get => _bau;
            set => _bau = value;
        }
        public Moto()
        {
            _bau = false;
        }

        public Moto(string placa, string descricao, Cor corExterna, bool bau) :
            base(placa, descricao, corExterna)
        {
            _bau = bau;
        }
    }
}
