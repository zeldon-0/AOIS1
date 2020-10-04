using System;
using System.Collections.Generic;
using System.Text;

namespace AOIS1.API.Contracts.Models.Artists
{
    public class ArtistResultModel
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public decimal Probability { get; set; }
    }
}
