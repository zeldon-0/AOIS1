using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using AOIS1.Core.Domain.Models.JoinEntities;
using Microsoft.VisualBasic.CompilerServices;

namespace AOIS1.Core.Domain.Models.Artists
{
    public class ArtistWithProbability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public IEnumerable<ArtistGenre> ArtistGenres { get; set; }
        public IEnumerable<ArtistTempo> ArtistTempos { get; set; }
        public IEnumerable<ArtistInstrument> ArtistInstruments { get; set; }
        public IEnumerable<ArtistNovelty> ArtistNovelties { get; set; }
        private Probability MatchProbability = new Probability();

        public void CalculateProbability(decimal probability)
        {
            if (probability < 0)
                throw new ArgumentException("Probability must not be negative."); 

            MatchProbability = MatchProbability * probability;
        }

        public decimal GetProbabilityValue()
        {
            return MatchProbability.GetValue();
        }


        private sealed class Probability
        {
            private decimal Value { get; set; }
            public Probability()
            {
                Value = 1;
            }

            public static Probability operator *(Probability leftSide, decimal rightSide)
            {
                return new Probability() { Value = leftSide.Value * rightSide };
            }
            public decimal GetValue()
            {
                return Value;
            }
        }
    }
}
