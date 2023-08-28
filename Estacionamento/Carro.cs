using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    internal class Carro : Veiculo
    {
        private int _nroPortas;
        public int NroPortas
        {
            get => _nroPortas;
            set => _nroPortas = value;
        }
        public Carro()
        {
            _nroPortas = 0;
        }

        public Carro(string placa, string descricao, Cor corExterna, int nroPortas) :
            base (placa, descricao, corExterna)
        {
            _nroPortas = nroPortas;
        }
        public override void Mostrar()
        {
            Console.WriteLine("Placa: " + _placa);
            Console.WriteLine("Descrição: " + _descricao);
            Console.WriteLine("Cor externa: " + _corExterna);
        }
    }
}
