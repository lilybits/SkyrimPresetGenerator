using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkyrimPresetGenerator.Data;
using SkyrimPresetGenerator.Data.Races;
using SkyrimPresetGenerator.Models;

namespace SkyrimPresetGenerator.Services
{
    public class PresetGenerator
    {

        // randomly select options from data
        private readonly Random random = new Random();


        // TODO: add race specific gen data
        // TODO: maybe sex specific stuff?
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
            preset.Age = GetRandom(GeneralData.Ages);




            // .... RACE SPECIFIC STUFF ....

            // dunmer specific stuff
            if (race == "Dunmer")
            {
                preset.FaceShape = GetRandom(DunmerData.FaceShapes);
                preset.Eyes = GetRandom(DunmerData.Eyes);
                preset.Nose = GetRandom(DunmerData.Noses);
                preset.Mouth = GetRandom(DunmerData.Mouths);
                preset.Jaw = GetRandom(DunmerData.Jaws);
                preset.Complexion = GetRandom(DunmerData.Complexions);
                preset.DistinctiveFeature = GetRandom(DunmerData.DistinctiveFeatures);
                preset.Background = GetRandom(DunmerData.Background);
            }
            
            return preset;
        }

        // return random item
        private string GetRandom(string[] options)
        {
            return options[random.Next(options.Length)];
        }
    }
}