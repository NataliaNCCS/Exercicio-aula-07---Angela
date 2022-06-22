using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_aula_07___Angela
{
    public class Contrato
    {
        // idContrato ( Guid ), contratante ( string ), valor ( decimal ) e prazo ( int ).

        public Guid idContrato = Guid.NewGuid();

        public string contratante;

        public decimal valor;

        public int prazo;

        public virtual void CadastroContrato(string contractor, decimal value, int deadline)
        {
            contratante = contractor;
            valor = value;
            prazo = deadline;
        }


        public virtual decimal CalularPrestacao()
        {
            return valor / prazo;
        }


        public virtual void ExibirInfo()
        {
            Console.WriteLine(@$"
INFORMAÇÕES DE CONTRATO:
VALOR: {valor:C2}
PRAZO: {prazo} meses
VALOR PRESTAÇÃO: {CalularPrestacao():C2}");
        }


    }
}

