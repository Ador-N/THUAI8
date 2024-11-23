﻿using Preparation.Interface;
using Preparation.Utility;

namespace GameClass.GameObj.Occupations
{
    public class Monkid : IOccupation
    {
        public int MoveSpeed { get; } = GameData.NumOfStepPerSecond;
        public int MaxHp { get; } = GameData.MonkidHP;
        public int ViewRange { get; } = GameData.Viewrange;
        public int Cost { get; } = GameData.Monkidcost;
        public int BaseAttackSize { get; } = GameData.MonkidATKsize;
        public bool IsEquipValid(EquipmentType equiptype) => equiptype switch
        {
            EquipmentType.SPEEDBOOTS => false,

            EquipmentType.SMALL_HEALTH_POTION => false,
            EquipmentType.MEDIUM_HEALTH_POTION => false,
            EquipmentType.LARGE_HEALTH_POTION => false,

            EquipmentType.SMALL_SHIELD => false,
            EquipmentType.MEDIUM_SHIELD => false,
            EquipmentType.LARGE_SHIELD => false,

            EquipmentType.BERSERK_POTION => false,

            EquipmentType.INVISIBILITY_POTION => false,

            _ => false
        };
    }
}
