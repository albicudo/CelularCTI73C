﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model.Entidades
{
    public class Pedido
    {
        private Int64 id_pedido;
        private Aparelho aparelho;
        private DateTime dataHoraPedido;
        private string observacao;

        public long Id_Pedido { get => id_pedido; set => id_pedido = value; }
        public Aparelho Aparelho { get => aparelho; set => aparelho = value; }
        public DateTime DataHoraPedido { get => dataHoraPedido; set => dataHoraPedido = value; }
        public string Observacao { get => observacao; set => observacao = value; }
    }
}
