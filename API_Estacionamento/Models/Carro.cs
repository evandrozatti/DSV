namespace API_Estacionamento.Models;

public class Carro
{
    private string _placa;
    private string _descricao;
    public string Placa
    {
        get => _placa;
        set => _placa = value;
    }
    public string Descricao
    {
        get => _descricao;
        set => _descricao = value;
    }
    public Carro()
    {
        _placa = string.Empty;
        _descricao = string.Empty;
    }
    public Carro(string placa, string descricao)
    {
        _placa = placa;
        _descricao = descricao;
    }
}
