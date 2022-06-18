namespace Exercicio_Contrato_Interface.Service
{
    interface IEmpresas
    {
        double Juros(double valorparcela, int mes);
        double Taxa(double valorparcela);
    }
}
