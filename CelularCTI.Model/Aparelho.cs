using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelularCTI.Model.Entidades
{
    public class Aparelho
    {
        // Criar os atributos internos
        private Int64 id_aparelho;
        private Fabricante fabricante;
        private string modelo;
        private double largura;
        private double altura;
        private double espessura;
        private double quantidade;
        private double peso;
        private decimal preco;
        private decimal desconto;

        // Criar as propriedade
        public Int64 Id_Aparelho { get; set; }
        public Fabricante Fabricante { get; set; }
        public string Modelo { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set;}
        public double Espessura { get; set; }

        public double Quantidade
        {
            get { return quantidade; }
            set {
                if (value >= 0)
                    quantidade = value;
                else
                    throw new Exception("A quantidade deve ser maior ou igual a zero");
            }   
        }

        public double Peso { get; set; }
        public decimal Preco
        {
            get { return preco; }
            set
            {
                if (value > 0)
                    preco = value;
                else
                    throw new Exception("O preco deve ser maior que zero !!!");
            }
        }
        public decimal Desconto { get; set; }
        
        public override String ToString()
        {
            // veremos o uso deste método em breve.
            return Fabricante.Nome.PadRight(15) +  
                Modelo.PadRight(25) +  
                Preco.ToString("#,##0.00").PadLeft(20) +
                "    (" + Quantidade + " em estoque)";
        }
        
    }
}
