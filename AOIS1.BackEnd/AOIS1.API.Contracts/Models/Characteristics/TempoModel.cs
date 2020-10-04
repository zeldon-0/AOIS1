using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AOIS1.API.Contracts.Models.Characteristics
{
    public class TempoModel
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
    }
}
