using System;
using System.Collections.Generic;
using System.Text;
using AOIS1.Core.Domain.Models.JoinEntities;

namespace AOIS1.Core.Domain.Models.Artists
{
    public class Artist
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string ImageURL { get; private set; }
        public IEnumerable<ArtistGenre> ArtistGenres { get; private set;  }
        public IEnumerable<ArtistTempo> ArtistTempos { get; private set; }
        public IEnumerable<ArtistInstrument> ArtistInstruments { get; private set; }
        public IEnumerable<ArtistNovelty> ArtistNovelties { get; private set; }
    }
}
