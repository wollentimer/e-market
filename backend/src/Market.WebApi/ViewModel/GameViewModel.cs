namespace Market.WebApi.ViewModel
{
    public class GameViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Discounted { get; set; }
        public int DiscountPercent { get; set; }
        public int OriginalPrice { get; set; }
        public int FinalPrice { get; set; }
        public byte[] LargeCapsuleImage { get; set; }
        public byte[] SmallCapsuleImage { get; set; }
        public byte[] HeaderImage { get; set; }
        public UserViewModel User { get; set; }
    }
}
