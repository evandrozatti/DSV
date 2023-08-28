namespace Estacionamento
{
    internal class Veiculo
    {
        public enum Cor { Amarela, Azul, Branca, Vermelha, Verde, Preta }
        protected string _placa;
        protected Modelo _modelo;
        protected string _descricao;
        protected Cor _corExterna;
        public string Placa
        {
            get => _placa;
            set => _placa = value;
        }
        public Modelo Modelo
        {
            get => _modelo;
            set => _modelo = value;
        }
        public string Descricao
        {
            get => _descricao;
            set => _descricao = value;
        }
        public Cor CorExterna
        {
            get => _corExterna;
            set => _corExterna = value;
        }
        public Veiculo()
        {
            _placa = string.Empty;
            _modelo = new();
            _descricao = string.Empty;
            _corExterna = Cor.Branca;
        }
        public Veiculo(string placa, Modelo modelo, string descricao, Cor corExterna)
        {
            _placa = placa;
            _modelo = modelo;
            _descricao = descricao;
            _corExterna = corExterna;
        }
        public virtual void Mostrar()
        {
            // este método será sobrescrito pelas classes derivadas
        }
    }
}
