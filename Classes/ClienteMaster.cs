
namespace ClienteMaster
{
    public class ClienteMaster : Cliente.Cliente , IFuncao
    {
        public double Porcentagem { get; set; }

        public ClienteMaster(string nome, string sobreNome, string telefone) : base(nome, sobreNome, telefone)
        {
            Porcentagem = 0.20;
        }

        public override void BonusPorConta()
        {
            Saldo *= (1 + Porcentagem);
        }

        public void Sacar(int valor)
        {
            if (valor > 0)
            {
                Console.WriteLine("Digite a senha padrao fifa para Sacar: ");
                int senha = Convert.ToInt32(Console.ReadLine());
                if (senha == 12345)
                {
                    Console.WriteLine("Saque de B$" + valor + " para o cliente Master " + Nome + ":");
                    Console.WriteLine("Notas:");

                    int notasCem = valor / 100;
                    Console.WriteLine(notasCem + " nota(s) de B$100");
                    valor %= 100;

                    int notasCinquenta = valor / 50;
                    Console.WriteLine(notasCinquenta + " nota(s) de B$50");
                    valor %= 50;

                    int notasVinte = valor / 20;
                    Console.WriteLine(notasVinte + " nota(s) de B$20");
                    valor %= 20;

                    int notasDez = valor / 10;
                    Console.WriteLine(notasDez + " nota(s) de B$10");
                    valor %= 10;

                    int notasCinco = valor / 5;
                    Console.WriteLine(notasCinco + " nota(s) de B$5");
                    valor %= 5;

                    int notasUm = valor;
                    Console.WriteLine(notasUm + " nota(s) de B$1");

                    int valorTotal = (notasCinquenta * 50) + (notasVinte * 20) + (notasDez * 10) + (notasCinco * 5) + notasUm;
                    Saldo -= valorTotal;
                }
                else
                {
                    Console.WriteLine("Senha errada");
                }
            }
            else
            {
                Console.WriteLine("Não foi possivel sacar");
            }
            
            }
        
        public void Depositar(int valor)
        {
            if(valor >= 0)
            {
                Console.WriteLine("Digite a senha padrao fifa para depositar: ");
                int senha = Convert.ToInt32(Console.ReadLine());
                if (senha == 12345)
                {
                    Console.WriteLine("Deposito realizado com sucesso");
                    Saldo += valor;
                }else
                {
                    Console.WriteLine("Senha errada");
                }
            }else
            {
                Console.WriteLine("Deposito so pode ser maior ou igual que R$1.0");
            }
        }
        public void DadosSobreConta()
        {
            throw new NotImplementedException();
        }
       

        public void Transferir(double valor, ClienteMaster cliente)
        {
            throw new NotImplementedException();
        }
    }
}
