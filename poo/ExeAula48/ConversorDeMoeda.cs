using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeAula48
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double ConversaoDolaresReais(double qtd, double cotacao)
        {
            double total = qtd * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}
