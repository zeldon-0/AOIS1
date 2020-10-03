using AOIS1.Core.Domain.Models.JoinEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOIS1.Core.Domain.Models.Characteristics
{
    public class Genre
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string ImageURL { get; private set; }
        public IEnumerable<ArtistGenre> ArtistGenres { get; private set; }
    }
}
