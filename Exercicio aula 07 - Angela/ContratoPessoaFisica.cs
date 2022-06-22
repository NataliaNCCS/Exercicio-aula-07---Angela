using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_aula_07___Angela
{
    public class ContratoPessoaFisica : Contrato
    {


        public string cpf { get; set; }

        public DateTime dataNascimento { get; set; }

        public int idade { get; set; }

        public ContratoPessoaFisica(string contractor, decimal valor, int deadline, string _cpf, DateTime _dataNascimento)
        {
            this.contratante = contractor; 
            this.valor = valor;
            this.prazo = deadline;
            this.cpf = _cpf;
            this.dataNascimento = _dataNascimento;
            this.idade = CalcularIdade();
        }

        private int CalcularIdade()
        {
            idade = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
            {
                idade--;
            }

            return idade;
        }

        public override decimal CalularPrestacao()
        {
            CalcularIdade();
            int adicional;

            if (CalcularIdade() <= 30)
                adicional = 1;
            else if (CalcularIdade() <= 40)
                adicional = 2;
            else if (CalcularIdade() <= 50)
                adicional = 3;
            else
                adicional = 4;

            return base.CalularPrestacao()+adicional;
        }


        public override void ExibirInfo()
        {//// Além disso, os contratos de pessoa física devem informar também a idade do contratante.

            base.ExibirInfo();
            Console.WriteLine($"IDADE: {CalcularIdade()} anos");

        }
    }
}
