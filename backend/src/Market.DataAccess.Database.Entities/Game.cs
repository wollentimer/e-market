using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Database.Entities
{
    public class Game : BaseEntity
    {
        public string Name { get; set; }
        public bool Discounted { get; set; }
        public int DiscountPercent { get; set; }
        public int OriginalPrice { get; set; }
        public int FinalPrice { get; set; }
        public byte[] LargeCapsuleImage { get; set; } 
        public byte[] SmallCapsuleImage { get; set; }
        public byte[] HeaderImage { get; set; }
        public User User { get; set; }
    }
}
