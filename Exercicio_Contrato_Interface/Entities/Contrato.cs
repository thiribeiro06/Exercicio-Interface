using System;
using System.Collections.Generic;

namespace Exercicio_Contrato_Interface.Entities
{
    internal class Contrato
    {
        public double Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Prestacao> Prestacoes { get; set; }

        public Contrato(double numero, DateTime data, double valorTotal)
        {
            Numero=numero;
            Data=data;
            ValorTotal=valorTotal;
            Prestacoes = new List<Prestacao>();
        }

        public void AddPrestacao(Prestacao prestacao)
        {
            Prestacoes.Add(prestacao);
        }
        
    }
}
