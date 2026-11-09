namespace Estudo3.Entidade
{
    public class Transacao
    {
        public string Id { get; set; }
        public string Cliente { get; set; }
        public decimal Valor { get; set; }
        public string MetodoEscolhido { get; set; }
        public StatusTransacao Status { get; set; }

        public Transacao(string id, string cliente, decimal valor, string metodoEscolhido)
        {
            Id = id;
            Cliente = cliente;
            Valor = valor;
            MetodoEscolhido = metodoEscolhido;
            Status = StatusTransacao.Pendente;
        }
    }
}