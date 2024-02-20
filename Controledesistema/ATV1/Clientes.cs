namespace Exemplo
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public float ValorCompra { get; set; }
        public float ValorImposto { get; protected set; }
        public float TotalComImposto { get; protected set; }

        public virtual void CalcularImposto(float taxa)
        {
            this.ValorImposto = this.ValorCompra * taxa;
            this.TotalComImposto = this.ValorCompra + this.ValorImposto;
        }
    }
}
