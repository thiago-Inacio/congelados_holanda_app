namespace CongeladosHolandaApp.Models
{
    /// <summary>
    /// ViewModel para representar um produto em estoque
    /// </summary>
    public class ProdutoViewModel
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
