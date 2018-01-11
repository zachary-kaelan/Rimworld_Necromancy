using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RimWorld;
using Verse;
using Verse.Sound;

namespace Necromancy
{
    public class Lich
    {
        public PawnComponentsUtility pawnComponents = new PawnComponentsUtility();
        public RaceProperties raceProps = new RaceProperties()
        {
            baseBodySize = 1.0F,
            baseHungerRate = 0,
            baseHealthScale = 1.25F,
            canBePredatorPrey = false,
            foodType = FoodTypeFlags.None,
            hasGenders = true,
            herdAnimal = false,
            herdMigrationAllowed = false,
            intelligence = Intelligence.Humanlike,
            lifeExpectancy = float.MaxValue,
            makesFootprints = false,
            nameCategory = PawnNameCategory.HumanStandard,
            needsRest = false
        };

        public void Debug()
        {
            
        }
        
    }

    public static class UndeadProps
    {
        public static List<StatModifier> baseStats = new List<StatModifier>()
        {
            new StatModifier()
            {
                stat = StatDef.Named("MoveSpeed"),
                value = 1.041F
            },
            new StatModifier()
            {
                stat = StatDef.Named("PsychicSensitivity"),
                value = 0.25F
            },
            new StatModifier()
            {
                stat = StatDef.Named("ToxicSensitivity"),
                value = 0F
            },
            new StatModifier()
            {
                stat = StatDef.Named("GlobalLearningFactor"),
                value = 1.125F
            },
            new StatModifier()
            {
                stat = StatDef.Named("EatingSpeed"),
                value = 0F
            },
            new StatModifier()
            {
                stat = StatDef.Named("CarryingCapacity"),
                value = 0.97F
            },
            new StatModifier()
            {
                stat = StatDef.Named("MeatAmount"),
                value = 0.25F
            },
            new StatModifier()
            {
                stat = StatDef.Named("LeatherAmount"),
                value = 0.25F
            },

            // Social
            
            new StatModifier()
            {
                stat = StatDef.Named("RecruitPrisonerChance"),
                value = 0.25F
            },
            new StatModifier()
            {
                stat = StatDef.Named("TameAnimalChance"),
                value = 0.25F
            },
            new StatModifier()
            {
                stat = StatDef.Named("TrainAnimalChance"),
                value = 0.25F
            },
            new StatModifier()
            {
                stat = StatDef.Named("SocialImpact"),
                value = 1.25F
            },
            new StatModifier()
            {
                stat = StatDef.Named("DiplomacyPower"),
                value = 0.35F
            },

            new StatModifier()
            {
                stat = StatDef.Named("TradePriceImprovement"),
                value = 1.15F
            },
        };

        public static List<LifeStageDef> LifeStageDefs = new List<LifeStageDef>()
        {
            new LifeStageDef()
            {
                bodySizeFactor = 0.95F,
                defName = "Decomposition Stage 1",
                description = "The initial stages of decomposition.",
                foodMaxFactor = 0,
                healthScaleFactor = 1,
                hungerRateFactor = 0,
                marketValueFactor = 1.05F,
                label = "decomp stage 1",
                milkable = false,
                reproductive = false,
                shearable = false,
                visible = true
            }
        };

        public static List<LifeStageAge> LifeStages = new List<LifeStageAge>() {
            
            new LifeStageAge()
            {
                minAge = 0.0F
            }
        };
    }
}
