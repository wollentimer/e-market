using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DataAccess.Database.Entities
{
    public class Game : BaseEntity
    {
        public User User { get; set; }
    }
}
