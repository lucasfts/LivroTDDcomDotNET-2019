﻿using System.Collections.Generic;

namespace Crediario
{
    public class Fatura
    {

        public IList<Pagamento> Pagamentos              { get; }
        public string Nome                              { get; }
        public double ValorTotalDaFatura                { get; }

        public Fatura(string nome, double valorTotalDaFatura)
        {
            this.Pagamentos              = new List<Pagamento>();
            this.Nome                    = nome;
            this.ValorTotalDaFatura      = valorTotalDaFatura;
        }
    }
}
