using System.Collections.Generic;

namespace DEX.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Company> Companies { get; set; }

    }
}