namespace Encapsulamento
{
    public class Client
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string Endereco { get; private set; }

        public Client(string nome, string cpf, string rg, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Endereco = endereco;
        }
    }
}
