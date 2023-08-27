using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class Cliente
    {
        // Atributos privados
        private string _cpf;
        private string _nome;

        public static List<Cliente> clientes = new();

        #region Métodos getters e setters públicos
        // Somente para referência, poís não são mais utilizados
        /*
        public void SetCpf(string cpf)
        {
            _cpf = cpf;
        }
        public string GetCpf()
        {
            return _cpf;
        }
        */
        #endregion

        #region Propriedades públicas
        // Utilizadas no lugar dos métodos
        /*
        public string Cpf // Forma ainda bastante utilizada, porém obsoleta
        {
            get { return _cpf };
            set { _cpf = value; }
        }
        public string Cpf { get; set; } // "Porteira aberta", diretamente pública, não faz uso dos atributos privados
        */

        public string Cpf // Forma mais atual
        {
            get => _cpf;
            set => _cpf = value;
        }
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
        #endregion

        #region Construtores
        public Cliente()
        {
            _cpf = string.Empty;    
            _nome = string.Empty;
        }

        public Cliente(string cpf, string nome)
        {
            _cpf = cpf;
            _nome = nome;
        }

        public Cliente(string cpf)
        {
            Cliente cTemp = clientes.Find(x => x.Cpf == cpf);
            if (cTemp == null)
            {
                _cpf = string.Empty;
                _nome = string.Empty;
            }
            else
            {
                _cpf = cTemp.Cpf;
                _nome = cTemp.Nome;
            }
        }
        #endregion

        #region CRUD
        public void Inserir()
        {
            clientes.Add(this);
        }
        #endregion
    }
}
