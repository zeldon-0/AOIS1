using System;
using System.Collections.Generic;
using System.Text;

namespace AOIS1.API.Contracts.Models.Characteristics
{
    public class CharacteristicsQuery
    {
        public IEnumerable<GenreModel> Genres { get; set; }
        public IEnumerable<InstrumentModel> Instruments { get; set; }
        public IEnumerable<TempoModel> Tempos { get; set; }
        public IEnumerable<NoveltyModel> Novelties { get; set; }
    }
}
