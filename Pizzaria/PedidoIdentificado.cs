using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    // A classe PedidoIdentificado é derivada da classe Pedido
    internal class PedidoIdentificado : Pedido
    {
        public Cliente Cliente { get; set; }
    }
}
