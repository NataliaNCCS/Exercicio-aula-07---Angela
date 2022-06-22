using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_aula_07___Angela
{
    public class ContratoPessoaJuridica : Contrato
    {
        public string cnpj;
        public string inscricaoEstadual;

        public ContratoPessoaJuridica(string contratante, decimal valor, int prazo, string cnpj, string inscricaoEstadual)
        {
            this.contratante = contratante;
            this.valor = valor;
            this.prazo = prazo;
            this.cnpj = cnpj;
            this.inscricaoEstadual = inscricaoEstadual;
        }

        public override decimal CalularPrestacao()
        {
            return base.CalularPrestacao()+3;
        }

    }
}
