using AOIS1.Core.Domain.Models.JoinEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOIS1.Core.Domain.Models.Characteristics
{
    public class Novelty
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string ImageURL { get; private set; }
        public IEnumerable<ArtistNovelty> ArtistNovelties{ get; private set; }
    }
}
