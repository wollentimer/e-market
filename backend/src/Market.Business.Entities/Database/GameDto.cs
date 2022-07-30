using Market.Business.Entities.Base;

namespace Market.Business.Entities.Database
{
    public class GameDto : BaseDto
    {
        public string Name { get; set; }
        public bool Discounted { get; set; }
        public int DiscountPercent { get; set; }
        public int OriginalPrice { get; set; }
        public int FinalPrice { get; set; }
        public byte[] LargeCapsuleImage { get; set; }
        public byte[] SmallCapsuleImage { get; set; }
        public byte[] HeaderImage { get; set; }
        public UserDto User { get; set; }
    }
}
