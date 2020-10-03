using AOIS1.Core.Domain.Models.JoinEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOIS1.Core.Domain.Models.Characteristics
{
    public class Instrument
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string ImageURL { get; private set; }
        public IEnumerable<ArtistInstrument> ArtistInstruments { get; private set; }
    }
}
