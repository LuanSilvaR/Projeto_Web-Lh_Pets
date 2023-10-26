namespace Atividade
{
	class Pessoa_Fisica : Clientes
	{
		public string cpf { get; set; }
		public string rg { get; set; }

		//modificador de metodo virtual - permite que seja reescrito
		public virtual void Pagar_Imposto(float v) 
		{
			this.valor = v;
			this.valor_imposto = this.valor * 10 / 100;
			this.total = this.valor + this.valor_imposto;
		}
	}
}