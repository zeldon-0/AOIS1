﻿using AOIS1.Core.Domain.Models.Artists;
using AOIS1.Core.Domain.Models.Characteristics;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOIS1.Core.Domain.Models.JoinEntities
{
    public class ArtistGenre
    {
        public int ArtistId { get; private set; }
        public Artist Artist { get; private set; }
        public int GenreId { get; private set; }
        public Genre Genre { get; private set; }
        public decimal Probability { get; private set; }
    }
}
