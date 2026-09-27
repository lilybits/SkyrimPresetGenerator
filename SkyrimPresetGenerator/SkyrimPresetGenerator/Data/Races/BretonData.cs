using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO

namespace SkyrimPresetGenerator.Data.Races
{
    // character options specific to breton
    public static class BretonData
    {
        // face
        public static readonly string[] FaceShapes =
        {
            "Long and angular",
            "Narrow and sharp",
            "Oval with angular features",
            "Long with prominent cheekbones",
            "Narrow with a pointed chin",
            "Broad with strong cheekbones"
        };

        // eyes
        public static readonly string[] Eyes =
        {
            "Narrow and slightly upturned",
            "Deep set and angular",
            "Large and almond shaped",
            "Heavy lidded",
            "Sharp and slightly downturned",
            "Small and deep set"
        };

        // nose
        public static readonly string[] Noses =
        {
            "Long with a high bridge",
            "Narrow and straight",
            "Long with a slightly hooked tip",
            "Sharp with a narrow bridge",
            "Broad with a defined bridge",
            "Short with a pointed tip"
        };

        // mouth
        public static readonly string[] Mouths =
        {
            "Thin and narrow",
            "Small with a defined cupid's bow",
            "Wide with thin lips",
            "Full lower lip",
            "Small and slightly downturned",
            "Medium with a soft cupid's bow"
        };

        // Jaw and chin shapes.
        public static readonly string[] Jaws =
        {
            "Narrow with a pointed chin",
            "Sharp and angular",
            "Long and slender",
            "Strong with a square chin",
            "Softly tapered",
            "Broad and defined"
        };

        // skin/complextion
        public static readonly string[] Complexions =
        {
            "Pale ash grey",
            "Cool medium grey",
            "Deep charcoal grey",
            "Grey with subtle blue undertones",
            "Grey with subtle violet undertones",
            "Weathered ash grey"
        };

        // little details
        public static readonly string[] DistinctiveFeatures =
        {
            "Dark circles beneath the eyes",
            "Prominent cheekbones",
            "Slightly sunken cheeks",
            "Small facial scar",
            "Strong brow ridge",
            "Faint forehead lines",
            "Asymmetrical eyebrows",
            "No especially distinctive feature"
        };

        // background
        public static readonly string[] Background =
        {
            "Temple Scholar",
            "Ashlander Hunter",
            "House Noble",
            "Traveling Alchemist",
            "Mercenary",
            "Refugee",
            "Mage Apprentice",
            "Temple Priestess",
            "Dock Worker",
            "Merchant"
        };
    }
}