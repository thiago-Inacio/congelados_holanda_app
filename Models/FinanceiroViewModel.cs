namespace CongeladosHolandaApp.Models
{
    /// <summary>
    /// ViewModel para exibir dados financeiros e estoque
    /// </summary>
    public class FinanceiroViewModel
    {
        public decimal TotalVendas { get; set; }
        public decimal Despesas { get; set; }
        public decimal Lucro { get; set; }
        public int EstoqueTotal { get; set; }
        public List<ProdutoViewModel> Produtos { get; set; } = new List<ProdutoViewModel>();
    }
}
