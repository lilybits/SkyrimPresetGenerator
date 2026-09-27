using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SkyrimPresetGenerator.Data.Races;
using SkyrimPresetGenerator.Models;

namespace SkyrimPresetGenerator.Data
{
    // find  gen data for selected race
    public static class RaceDataProvider
    {
        public static RaceData? GetRaceData(string race)
        {
            // return data
            switch (race)
            {
                case "Dunmer":
                    return DunmerData.Data;

                default:
                    return null;
            }
        }
    }
}