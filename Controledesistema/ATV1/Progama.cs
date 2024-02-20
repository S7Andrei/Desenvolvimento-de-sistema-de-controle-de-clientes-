using System;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorPagamento;
            Console.WriteLine("Informe o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o endereço: ");
            string endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j)? ");
            string resposta = Console.ReadLine().ToLower();
            
            if (resposta == "f")
            {
                PessoaFisica pessoaFisica = new PessoaFisica();
                pessoaFisica.Nome = nome;
                pessoaFisica.Endereco = endereco;
                Console.WriteLine("Informe o CPF: ");
                pessoaFisica.CPF = Console.ReadLine();
                Console.WriteLine("Informe o RG: ");
                pessoaFisica.RG = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra: ");
                valorPagamento = float.Parse(Console.ReadLine());
                pessoaFisica.CalcularImposto(0.20f); // 20% de imposto para pessoa física
                
                Console.WriteLine("Pessoa Física");
                Console.WriteLine("Nome: " + pessoaFisica.Nome);
                Console.WriteLine("RG: " + pessoaFisica.RG);
                Console.WriteLine("CPF: " + pessoaFisica.CPF);
                Console.WriteLine("Endereço: " + pessoaFisica.Endereco);
                Console.WriteLine("Valor da Compra: " + valorPagamento.ToString("C"));
                Console.WriteLine("Imposto: " + pessoaFisica.ValorImposto.ToString("C"));
                Console.WriteLine("Total a Pagar: " + pessoaFisica.TotalComImposto.ToString("C"));
            }
            
            if (resposta == "j")
            {
                PessoaJuridica pessoaJuridica = new PessoaJuridica();
                pessoaJuridica.Nome = nome;
                pessoaJuridica.Endereco = endereco;
                Console.WriteLine("Informe o CNPJ:");
                pessoaJuridica.CNPJ = Console.ReadLine();
                Console.WriteLine("Informe a IE:");
                pessoaJuridica.IE = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra:");
                valorPagamento = float.Parse(Console.ReadLine());
                pessoaJuridica.CalcularImposto(0.10f); // 10% de imposto para pessoa jurídica
                
                Console.WriteLine("-------- Pessoa Jurídica --------");
                Console.WriteLine("Nome: " + pessoaJuridica.Nome);
                Console.WriteLine("Endereço: " + pessoaJuridica.Endereco);
                Console.WriteLine("CNPJ: " + pessoaJuridica.CNPJ);
                Console.WriteLine("IE: " + pessoaJuridica.IE);
                Console.WriteLine("Valor da Compra: " + valorPagamento.ToString("C"));
                Console.WriteLine("Imposto: " + pessoaJuridica.ValorImposto.ToString("C"));
                Console.WriteLine("Total a Pagar: " + pessoaJuridica.TotalComImposto.ToString("C"));
            }
        }
    }
}
