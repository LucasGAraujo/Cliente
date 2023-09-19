namespace ClienteMaster
{
    public interface IFuncao
    {
        public void Sacar(int valor);
        public void Depositar(int valor);
        public void DadosSobreConta();
        public void Transferir(double valor, ClienteMaster cliente);
    }
}