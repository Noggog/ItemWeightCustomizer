using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ItemWeightCustomizer
{
    public partial class Settings
    {
        [JsonProperty("weightSettings")]
        public WeightSettings WeightSettings { get; set; } = new();

        [JsonProperty("categories")]
        public HashSet<WeightCategory> Categories { get; set; } = new()
        {
            new WeightCategory("tools")
            {
                Types = new HashSet<string>() { "weapons" },
                EditorIds = new HashSet<string>()
                {
                    "weapPickaxe",
                    "Axe01",
                    "DLC2AncientNordPickaxe",
                    "DLC2RR03NordPickaxe",
                    "DLC2dunKolbjornRalisPickaxe",
                    "dunVolunruudPickaxe",
                    "dunHaltedStreamPoachersAxe",
                    "dunHaltedStreamPoachersAxeREPLICA"s
                },
                Weight = -1
            }
        };
    }
}