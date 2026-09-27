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


        // TODO: maybe sex specific stuff?
        // TODO: facial features (face shape, eyes, etc.)
                // TODO: Dunmer done, need to fix all other races
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

            // get gen data for selected race
            RaceData? raceData = RaceDataProvider.GetRaceData(race);

            // gen appearance details if data exists
            if (raceData != null)
            {
                preset.FaceShape = GetRandom(raceData.FaceShapes);
                preset.Eyes = GetRandom(raceData.Eyes);
                preset.Nose = GetRandom(raceData.Noses);
                preset.Mouth = GetRandom(raceData.Mouths);
                preset.Jaw = GetRandom(raceData.Jaws);
                preset.Complexion = GetRandom(raceData.Complexions);
                preset.DistinctiveFeature = GetRandom(raceData.DistinctiveFeatures);
                preset.Background = GetRandom(raceData.Background);
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