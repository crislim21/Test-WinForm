using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AccelistTraining.WinForm2023.Models
{
    public class PeopleData
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("height")]
        public string Height { get; set; } = "";

        [JsonPropertyName("mass")]
        public string Mass { get; set; } = "";

        [JsonPropertyName("hair_color")]
        public string HairColor { get; set; } = "";

        [JsonPropertyName("skin_color")]
        public string SkinColor { get; set; } = "";

        [JsonPropertyName("eye_color")]
        public string EyeColor { get; set; } = "";

        [JsonPropertyName("birth_year")]
        public string BirthYear { get; set; } = "";

        [JsonPropertyName("gender")]
        public string Gender { get; set; } = "";
    }
}
