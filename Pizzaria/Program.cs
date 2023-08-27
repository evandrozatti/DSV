using Pizzaria;

// Instanciando e populando um cliente
// Cliente cliente = new Cliente(); // construção obsoleta
Cliente cliente = new();
Console.WriteLine("Inserindo um cliente único: ");
Console.Write("Informe o CPF: ");
cliente.Cpf = Console.ReadLine();
Console.Write("Informe o nome: ");
cliente.Nome = Console.ReadLine();
Console.WriteLine("Os dados inseridos foram: ");
Console.WriteLine("CPF: " +  cliente.Cpf);
Console.WriteLine("Nome: " + cliente.Nome);

// Populando a lista com 3 clientes
Console.WriteLine("Inserindo 3 clientes: ");
for(int i = 0; i < 3; i++)
{
    Cliente cTemp = new();
    Console.Write("Informe o CPF: ");
    cTemp.Cpf = Console.ReadLine();
    Console.Write("Informe o nome: ");
    cTemp.Nome = Console.ReadLine();
    cTemp.Inserir();
}

// Mostrando os clientes da lista
// Usando for simples
Console.WriteLine("Os clientes inseridos foram: (mostrando com for)");
for (int i = 0; i < Cliente.clientes.Count; i++)
{
    Console.Write("CPF: " + Cliente.clientes[i].Cpf + " | ");
    Console.WriteLine("Nome: " + Cliente.clientes[i].Nome);
}

// Usando foreach
Console.WriteLine("Os clientes inseridos foram: (mostrando com foreach)");
foreach (Cliente cTemp in Cliente.clientes)
{
    Console.Write("CPF: " + cTemp.Cpf + " | ");
    Console.WriteLine("Nome: " + cTemp.Nome);
}

// Inserindo um pedido identificado:
Console.WriteLine("Inserindo um pedido identificado: ");
PedidoIdentificado pi = new();
Console.Write("Informe o número do pedido: ");
pi.Id = int.Parse(Console.ReadLine());
Console.Write("Informe o CPF do cliente: ");
string cpf = Console.ReadLine();
pi.Cliente = new(cpf);

// Mostrando os dados inseridos
Console.WriteLine("Número do pedido: " + pi.Id);
Console.WriteLine("CPF/Nome do cliente: " + pi.Cliente.Cpf + " | " + pi.Cliente.Nome);
