using Microsoft.AspNetCore.Mvc.Rendering;
using Pagamentos.Dominio.Enums;
using System.ComponentModel.DataAnnotations;

namespace Pagamentos.Mvc.Models
{
    public class PagamentoViewModel
    {
        public TipoPagamentoEnum TipoPagamento { get; set; } = TipoPagamentoEnum.AVista;

        [Required(ErrorMessage ="O valor do pagamento é obrigatório")]
        public decimal Valor { get; set; }

        public DateTime Dt_compra { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "A data de vencimento do pagamento é obrigatório")]
        public DateTime Dt_vencimento { get; set; }

        public int Num_parcela { get; set; } = 1;

        public int Qtd_parcela { get; set; } = 1;

        public string? Nota_fiscal { get; set; } = null;

        public string? FornecedorDescricao { get; set; } = null;

        public List<SelectListItem> FornecedoresBanco { get; set; } = new();
    }
}
