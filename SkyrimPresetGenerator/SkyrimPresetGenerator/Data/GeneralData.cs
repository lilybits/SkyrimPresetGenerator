using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimPresetGenerator.Data
{
    // general options (NOT race specific)
    public static class GeneralData
    {
        // races
        public static readonly string[] Races =
        {
            "Altmer",
            "Argonian",
            "Bosmer",
            "Breton",
            "Dunmer",
            "Imperial",
            "Khajiit",
            "Nord",
            "Orc",
            "Redguard"
        };

        // sexes
        public static readonly string[] Sexes =
        {
            "Female",
            "Male"
        };

        // ages
        public static readonly string[] Ages =
        {
            "Very Young Adult",
            "Young Adult",
            "Adult",
            "Older Adult",
            "Very Old Adult"
        };
    }
}