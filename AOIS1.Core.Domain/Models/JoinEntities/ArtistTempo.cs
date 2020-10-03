using AOIS1.Core.Domain.Models.Characteristics;
using System;
using System.Collections.Generic;
using System.Text;
using AOIS1.Core.Domain.Models.Artists;

namespace AOIS1.Core.Domain.Models.JoinEntities
{
    public class ArtistTempo
    {
        public int ArtistId { get; private set; }
        public Artist Artist { get; private set; }
        public int TempoId { get; private set; }
        public Tempo Tempo { get; private set; }
        public decimal Probability { get; private set; }
    }
}
