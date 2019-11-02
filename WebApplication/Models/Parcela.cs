using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Parcela
    {
        public int Id { get; set; }
        public string AreaOrcada { get; set; }
        public string EmpresaPagadora { get; set; }
        public decimal Valor { get; set; }
        public string NumeroPedido { get; set; }
        public DateTime DataPagamento { get; set; }

        public static List<Parcela> GetParcelas()
        {
            List<Parcela> Parcelas = new List<Parcela>();
            Parcelas.Add(new Parcela { Id = 1, AreaOrcada = "Segurança", EmpresaPagadora = "Empresa 1", Valor = 10000M, NumeroPedido = "012345", DataPagamento = new DateTime(2019, 6, 1) });
            Parcelas.Add(new Parcela { Id = 2, AreaOrcada = "Comunicação", EmpresaPagadora = "Empresa 2", Valor = 20000M, NumeroPedido = "678901", DataPagamento = new DateTime(2019, 7, 1) });
            Parcelas.Add(new Parcela { Id = 3, AreaOrcada = "Publicidade", EmpresaPagadora = "Empresa 3", Valor = 30000M, NumeroPedido = "234567", DataPagamento = new DateTime(2019, 8, 1) });
            Parcelas.Add(new Parcela { Id = 4, AreaOrcada = "Esporte", EmpresaPagadora = "Empresa 4", Valor = 40000M, NumeroPedido = "890123", DataPagamento = new DateTime(2019, 9, 1) });
            Parcelas.Add(new Parcela { Id = 5, AreaOrcada = "Financeiro", EmpresaPagadora = "Empresa 5", Valor = 50000M, NumeroPedido = "456789", DataPagamento = new DateTime(2019, 10, 1) });

            return Parcelas;
        }
    }
}