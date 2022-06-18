using System;
using System.Globalization;

namespace Exercicio_Contrato_Interface.Entities
{
    internal class Prestacao
    {
        public DateTime DataPrestacao { get; set; }
        public double Quantia { get; set; }

        public Prestacao(DateTime dataPrestacao, double quantia)
        {
            DataPrestacao=dataPrestacao;
            Quantia=quantia;
        }

        public override string ToString()
        {
            return 
                DataPrestacao.ToString("dd/MM/yyyy")
                + " - "
                + Quantia.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
