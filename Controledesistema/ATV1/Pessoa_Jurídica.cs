namespace Exemplo
{
    class PessoaJuridica : Cliente
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }

        public override void CalcularImposto(float taxa)
        {
            this.ValorImposto = this.ValorCompra * taxa;
            this.TotalComImposto = this.ValorCompra + this.ValorImposto;
        }
    }
}
