using System;

namespace Cliente
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Telefone { get; set; }
        public double Saldo { get; set; }

        public Cliente(string nome, string sobreNome, string telefone)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            SobreNome = sobreNome;
            Telefone = telefone;
            Saldo = 100;
        }

        public virtual void BonusPorConta()
        {
            Saldo *= 0.00;
        }
    }
}
