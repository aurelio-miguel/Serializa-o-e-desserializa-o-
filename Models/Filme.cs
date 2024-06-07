using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API02
{
    public class Filme
    {
        [JsonPropertyName("title")]
        public string Titulo { get; set; }
        [JsonPropertyName("year")]
        public string Lançamento { get; set; }

    }
}