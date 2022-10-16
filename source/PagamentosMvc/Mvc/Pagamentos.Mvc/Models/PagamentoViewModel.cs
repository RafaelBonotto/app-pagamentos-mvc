using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pagamentos.Mvc.Models
{
    public class PagamentoViewModel
    {
        public decimal Valor { get; set; }
        public DateTime Dt_entrega { get; set; }
        public DateTime Dt_vencimento { get; set; }
        public int Num_parcela { get; set; }
        public int Qtd_parcela { get; set; }
        public string Nota_fiscal { get; set; }
        public string FornecedorDescricao { get; set; }
        public List<SelectListItem> FornecedoresBanco { get; set; } = new();
    }
}
