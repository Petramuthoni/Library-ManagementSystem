using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatas.Models
{
    public class LibraryCard
    {
        public int Id { get; set; }
        public decimal Fees { get; set; }
        public DateTime Created{ get; set; }
       // below methed IS FOR LISTING CHECKOUTS
        public virtual IEnumerable<Checkout> Checkouts { get; set; }
    }
}
