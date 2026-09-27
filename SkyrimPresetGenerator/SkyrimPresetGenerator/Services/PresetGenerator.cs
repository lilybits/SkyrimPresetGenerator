using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkyrimPresetGenerator.Data;
using SkyrimPresetGenerator.Models;

namespace SkyrimPresetGenerator.Services
{
    public class PresetGenerator
    {

        // randomly select options from data
        private readonly Random random = new Random();


        // TODO: move preset gen options into seperate class/files
        // TODO: add race specific gen data
        // TODO: facial features (face shape, eyes, etc.)
        // TODO: personality maybe?

        // create preset with selected race and sex
        public Preset Generate(string race, string sex)
        {

            // random race
            if (race == "Random")
            {
                race = GeneralData.Races[
                    random.Next(GeneralData.Races.Length)
                ];
            }

            // ransom sex
            if (sex == "Random")
            {
                sex = GeneralData.Sexes[
                    random.Next(GeneralData.Sexes.Length)
                ];
            }

            Preset preset = new Preset();

            // user selected choices
            preset.Race = race;
            preset.Sex = sex;

            // or random
            preset.Age = GeneralData.Ages[
                random.Next(GeneralData.Ages.Length) ];

            return preset;
        }
    }
}