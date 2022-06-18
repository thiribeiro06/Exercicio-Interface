using System;
using System.Globalization;
using Exercicio_Contrato_Interface.Entities;
using Exercicio_Contrato_Interface.Service;

namespace Exercicio_Contrato_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NOVO CONTRATO");
            Console.Write("Numero do Contrato: ");
            int contrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valorcontrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Parcelado em quantas vezes: ");
            int parcelas = int.Parse(Console.ReadLine());
            Contrato infocontrato = new Contrato(contrato, data,valorcontrato);

            ServicoPagamento pagamento = new ServicoPagamento(new EmpresaPayPal());
            pagamento.ProcessamentoContrato(infocontrato, parcelas);

            Console.WriteLine("PRESTAÇÕES");
            foreach(Prestacao prestacao in infocontrato.Prestacoes)
            {
                Console.WriteLine(prestacao);
            }

        }
    }
}
