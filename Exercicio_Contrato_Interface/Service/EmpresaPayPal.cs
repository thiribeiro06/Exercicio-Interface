namespace Exercicio_Contrato_Interface.Service
{
    internal class EmpresaPayPal : IEmpresas
    {
        private const double JurosSimples = 0.01;
        private const double TaxaPagamento = 0.02;
        public double Juros(double valorparcela, int mes)
        {
            return valorparcela * JurosSimples * mes;
        }

        public double Taxa(double valorparcela)
        {
            return valorparcela * TaxaPagamento;
        }
    }
}
