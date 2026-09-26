using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimPresetGenerator.Models
{

    // stores all info for preset
    public class Preset
    {
        public string Race { get; set; } = "";
        public string Sex { get; set; } = "";

        public string Age { get; set; } = "";
        public string FaceShape { get; set; } = "";
        public string Eyes { get; set; } = "";
        public string Nose { get; set; } = "";
        public string Mouth { get; set; } = "";
        public string Jaw { get; set; } = "";
        public string Complexion { get; set; } = "";
        public string DistinctiveFeature { get; set; } = "";
        public string Archetype { get; set; } = "";
    }
}