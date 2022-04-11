namespace CardGamesShop.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsCardPreferido { get; set; }
        public bool EmEstoque { get; set; }

        public int CatedoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
