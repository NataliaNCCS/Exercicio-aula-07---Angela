
namespace Exercicio_aula_07___Angela
{
    public class Program
    {
        static void Main()
        {

            Console.WriteLine("FINANCEIRA - NOVO CONTRATO");
            Console.WriteLine();


            int opcaoEscolhida;
            string opcaoEscolhidaStr;
            string _contractor;
            decimal _valor;
            int _deadline;


            do
            {
                Console.WriteLine(@"Contrato para: 
[1] - Pessoa Física 
[2] - Pessoa Jurídica");
                opcaoEscolhidaStr = Console.ReadLine();
            } while (!int.TryParse(opcaoEscolhidaStr, out opcaoEscolhida) || (opcaoEscolhida != 1 && opcaoEscolhida != 2));

            do
            {
                Console.Write("NOME: ");
                _contractor = Console.ReadLine();
            } while (string.IsNullOrEmpty(_contractor));

            string valorStr;
            do
            {
                Console.Write("VALOR: R$ ");
                valorStr = Console.ReadLine();
            } while (!decimal.TryParse(valorStr, out _valor));

            string prazoStr;
            do
            {
                Console.Write("PRAZO: ");
                prazoStr = Console.ReadLine();
            } while (!int.TryParse(prazoStr, out _deadline));


            if (opcaoEscolhida == 1)
            {
                string _cpf;
                string birthDateStr;
                DateTime _birthDate;

                do
                {
                    Console.Write("CPF: ");
                    _cpf = Console.ReadLine();
                } while (string.IsNullOrEmpty(_cpf) || _cpf.Length != 11);


                do
                {
                    Console.Write("DATA DE NASCIMENTO: ");
                    birthDateStr = Console.ReadLine();
                } while (!DateTime.TryParse(birthDateStr, out _birthDate));



                ContratoPessoaFisica novaPF = new(_contractor, _valor, _deadline, _cpf, _birthDate);

                novaPF.ExibirInfo();
                                
            }
            else
            {
                string _cnpj;
                string _inscricaoEstadual;

                do
                {
                    Console.Write("CNPJ: ");
                    _cnpj = Console.ReadLine();
                } while (string.IsNullOrEmpty(_cnpj) || _cnpj.Length != 14);

                do
                {
                    Console.Write("INSCRIÇÃO ESTADUAL: ");
                    _inscricaoEstadual = Console.ReadLine();
                } while (string.IsNullOrEmpty(_inscricaoEstadual) || _inscricaoEstadual.Length != 10);

                ContratoPessoaJuridica novaPJ = new(_contractor, _valor, _deadline, _cnpj, _inscricaoEstadual);

                novaPJ.ExibirInfo();
            }
        }
    }
}




