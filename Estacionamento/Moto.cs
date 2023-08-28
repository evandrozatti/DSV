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

        public Moto(
            string placa,
            Modelo modelo,
            string descricao,
            Cor corExterna,
            bool bau)
            : base(placa, modelo, descricao, corExterna)
        {
            _bau = bau;
        }
        public override void Mostrar()
        {
            Console.WriteLine("Placa: " + _placa);
            Console.WriteLine("Modelo: " + _modelo);
            Console.WriteLine("Descrição: " + _descricao);
            Console.WriteLine("Cor externa: " + _corExterna);
            Console.WriteLine("Possui baú?: " + (_bau ? "Sim" : "Não"));
        }
    }
}
