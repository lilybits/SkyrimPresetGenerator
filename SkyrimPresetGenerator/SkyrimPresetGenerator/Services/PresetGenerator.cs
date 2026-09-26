using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkyrimPresetGenerator.Models;

namespace SkyrimPresetGenerator.Services
{
    public class PresetGenerator
    {

        // randomly select options from data
        private readonly Random random = new Random();


        // age ranges
        private readonly string[] ages =
        {
            "Very Young Adult",
            "Young Adult",
            "Adult",
            "Mature Adult",
            "Older Adult"
        };

        // create preset with selected race and sex
        public Preset Generate(string race, string sex)
        {
            Preset preset = new Preset();

            // user selected choices
            preset.Race = race;
            preset.Sex = sex;

            // or random
            preset.Age = ages[random.Next(ages.Length)];

            return preset;
        }
    }
}