﻿using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ItemModifier
{
    public class ItemModifierConfiguration : IRocketPluginConfiguration
    {
        public bool LoadAfterWorkshop { get; set; }
        [XmlArrayItem(ElementName = "Item")]
        public List<ItemModification> Items { get; set; }

        public void LoadDefaults()
        {
            LoadAfterWorkshop = false;
            Items = new List<ItemModification>()
            {
                new ItemModification()
                {
                    ID = 363,
                    Name = "Maplestrike",
                    PlayerDamage = 40,
                    PlayerLegMultiplier = 0.6f,
                    PlayerArmMultiplier = 0.6f,
                    PlayerSpineMultiplier = 0.8f,
                    PlayerSkullMultiplier = 1.1f
                },
                new ItemModification()
                {
                    ID = 310,
                    Name = "Forest Military Vest",
                    Armor = 0.7f
                },
                new ItemModification()
                {
                    ID = 458,
                    Name = "Portable Generator",
                    GeneratorCapacity = 2000,
                    GeneratorBurn = 20
                }
            };
        }
    }
}
