using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniSolution.Models
{
    public class Tanque
    {
        [Key]
        public string Deposito { get; set; }

        public decimal Capacidade { get; set; }

        public string TipoDeProduto { get; set; }

        public Tanque(string deposito, decimal capacidade, string tipoDeProduto)
        {
            Deposito = deposito;
            Capacidade = capacidade;
            TipoDeProduto = tipoDeProduto;
        }
    }
}