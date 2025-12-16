namespace Domain
{
    public class Revenda
    {
        public required string Nome { get; set; }

        List<Servidor> Servidores = new List<Servidor>();

        public Revenda(string nome) => Nome = nome;

    }
}
