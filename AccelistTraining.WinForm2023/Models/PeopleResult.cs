using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AccelistTraining.WinForm2023.Models
{
    public class PeopleResult
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("next")]
        public string? Next { get; set; }

        [JsonPropertyName("previous")]
        public string? Previous { get; set; }

        // JsonPropertyName will tell the JSON parser to automatically parse "results" object as PeopleData and vice versa.
        [JsonPropertyName("results")]
        public List<PeopleData> PeopleData { get; set; } = new List<PeopleData>();
    }
}
