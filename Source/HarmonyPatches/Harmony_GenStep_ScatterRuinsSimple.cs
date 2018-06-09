﻿using Harmony;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Verse;
using UnityEngine;
using System.Reflection.Emit;
using RimWorld.Planet;
using Verse.Noise;

namespace TerraFW
{

    [HarmonyPatch(typeof(GenStep_ScatterRuinsSimple))]
    [HarmonyPatch("Generate")]
    public class Harmony_GenStep_ScatterRuinsSimple_Generate
    {

        public static bool Prefix(Map map)
        {
            ModExt_Biome_FeatureControl extFtControl = map.Biome.GetModExtension<ModExt_Biome_FeatureControl>();
            if (extFtControl != null && extFtControl.removeRuinsSimple)
            {
                return false;
            }
            return true;
        }

    }

}