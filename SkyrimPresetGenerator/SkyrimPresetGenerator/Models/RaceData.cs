using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimPresetGenerator.Models
{
    // all options for a race
    public class RaceData
    {
        public string[] FaceShapes { get; set; } = [];
        public string[] Eyes { get; set; } = [];
        public string[] Noses { get; set; } = [];
        public string[] Mouths { get; set; } = [];
        public string[] Jaws { get; set; } = [];
        public string[] Complexions { get; set; } = [];
        public string[] DistinctiveFeatures { get; set; } = [];
        public string[] Background { get; set; } = [];
    }
}