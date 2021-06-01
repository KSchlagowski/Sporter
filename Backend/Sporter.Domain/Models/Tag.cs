using System.Collections;
using System.Collections.Generic;

namespace Sporter.Domain.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ItemTag> ItemTags { get; set; }
    }
}