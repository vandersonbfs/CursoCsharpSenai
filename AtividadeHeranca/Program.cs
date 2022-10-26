using System;

namespace AtividadeHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crie uma classe Pessoa com os atributo nome.
            // Crie as classes pessoa física com os atributos: rg , cpf, data nascimento, e
            // pessoa jurídica com os atributos:  inscrição estadual, cnpj, endereço;
            Pessoa pessoa = new Pessoa();
            PessoaFisica pessoafisca = new PessoaFisica();
            PessoaJuridica pessoajuridica = new PessoaJuridica();

            Console.WriteLine("Digite o nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF: ");
            pessoafisca.Cpf = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o RG: ");
            pessoafisca.Rg = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a data de nascimento: ");
            pessoafisca.DatadeNascimento = Console.ReadLine();
            Console.WriteLine("Digite a Inscrição Estadual: ");
            pessoajuridica.InscriçãoEstadual = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CNPJ: ");
            pessoajuridica.Cnpj = Console.ReadLine();
            Console.WriteLine("Digite o endereço: ");
            pessoajuridica.Endereco = Console.ReadLine();


            Console.WriteLine("Nome:....................... {0}", pessoa.Nome);
            Console.WriteLine("RG:......................... {0}", pessoafisca.Rg);
            Console.WriteLine("CPF:........................ {0}", pessoafisca.Cpf);
            Console.WriteLine("Data de Nascimento:......... {0}", pessoafisca.DatadeNascimento);
            Console.WriteLine("Inscrição Estadual:......... {0}", pessoajuridica.InscriçãoEstadual);
            Console.WriteLine("CNPJ:....................... {0}", pessoajuridica.Cnpj);
            Console.WriteLine("Endereço:................... {0}", pessoajuridica.Endereco);

            
            



        }
    }
}
