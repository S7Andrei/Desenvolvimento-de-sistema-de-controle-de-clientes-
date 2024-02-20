namespace Exemplo
{
    class PessoaFisica : Cliente
    {
        public string CPF { get; set; }
        public string RG { get; set; }

        public override void CalcularImposto(float taxa)
        {
            this.ValorImposto = this.ValorCompra * taxa;
            this.TotalComImposto = this.ValorCompra + this.ValorImposto;
        }
    }
}
