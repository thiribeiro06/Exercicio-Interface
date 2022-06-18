using System;
using Exercicio_Contrato_Interface.Entities;

namespace Exercicio_Contrato_Interface.Service
{
    internal class ServicoPagamento
    {

        private IEmpresas _empresas;

        public ServicoPagamento(IEmpresas empresas)
        {
            _empresas = empresas;
        }

        public void ProcessamentoContrato(Contrato contrato, int mes)
        {
            double valorbase = contrato.ValorTotal / mes;
            for(int i = 1; i <= mes; i++)
            {
                DateTime date = contrato.Data.AddMonths(i);
                double valorcomjuros = valorbase + _empresas.Juros(valorbase, i);
                double valortotal = valorcomjuros + _empresas.Taxa(valorcomjuros);
                contrato.AddPrestacao(new Prestacao(date, valortotal));

            }
        }
    }
}
