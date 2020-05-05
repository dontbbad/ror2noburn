//remove DOT from fire enemies.
using BepInEx;
using R2API;
using R2API.Utils;
using RoR2;
using UnityEngine;


namespace bbad
{
    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin("com.bbad.noburn", "No Burn DOT", "1.1.0")]
    public class noburn : BaseUnityPlugin
    {
        public void Awake()

        {
            //Chat Message
            Chat.AddMessage("Loaded noburn!");
            On.RoR2.DotController.AddDot += DotController_AddDot;
        }

        private void DotController_AddDot(On.RoR2.DotController.orig_AddDot orig, DotController self, GameObject attackerObject, float duration, DotController.DotIndex dotIndex, float damageMultiplier)
        {
            if (dotIndex == DotController.DotIndex.PercentBurn)
            {

            //Duration of Burn Percentage
                duration = 0;
            }
            orig(self, attackerObject, duration, dotIndex, damageMultiplier);
        }
    }
    }

