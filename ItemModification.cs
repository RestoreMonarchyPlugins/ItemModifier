using System.ComponentModel;
using System.Xml.Serialization;

namespace ItemModifier
{
    public class ItemModification
    {        
        [XmlAttribute]
        public ushort ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }

        #region Items
        public bool? ShouldDropOnDeath { get; set; }
        public bool ShouldSerializeShouldDropOnDeath() => Width != null;
        #endregion

        #region Bags
        public byte? Width { get; set; }
        public bool ShouldSerializeWidth() => Width != null;
        public byte? Height { get; set; }
        public bool ShouldSerializeHeight() => Height != null;
        #endregion

        #region Structures/Barricades
        public ushort? Health { get; set; }
        public bool ShouldSerializeHealth() => Health != null;
        #endregion

        #region Weapons
        public float? PlayerDamage { get; set; }
        public bool ShouldSerializePlayerDamage() => PlayerDamage != null;
        public float? PlayerLegMultiplier { get; set; }
        public bool ShouldSerializePlayerLegMultiplier() => PlayerLegMultiplier != null;
        public float? PlayerArmMultiplier { get; set; }
        public bool ShouldSerializePlayerArmMultiplier() => PlayerArmMultiplier != null;
        public float? PlayerSpineMultiplier { get; set; }
        public bool ShouldSerializePlayerSpineMultiplier() => PlayerSpineMultiplier != null;
        public float? PlayerSkullMultiplier { get; set; }
        public bool ShouldSerializePlayerSkullMultiplier() => PlayerSkullMultiplier != null;

        public float? ZombieDamage { get; set; }
        public bool ShouldSerializeZombieDamage() => ZombieDamage != null;
        public float? ZombieLegMultiplier { get; set; }
        public bool ShouldSerializeZombieLegMultiplier() => ZombieLegMultiplier != null;
        public float? ZombieArmMultiplier { get; set; }
        public bool ShouldSerializeZombieArmMultiplier() => ZombieArmMultiplier != null;
        public float? ZombieSpineMultiplier { get; set; }
        public bool ShouldSerializeZombieSpineMultiplier() => ZombieSpineMultiplier != null;
        public float? ZombieSkullMultiplier { get; set; }
        public bool ShouldSerializeZombieSkullMultiplier() => ZombieSkullMultiplier != null;

        public float? AnimalDamage { get; set; }
        public bool ShouldSerializeAnimalDamage() => AnimalDamage != null;
        public float? AnimalLegMultiplier { get; set; }
        public bool ShouldSerializeAnimalLegMultiplier() => AnimalLegMultiplier != null;
        public float? AnimalSpineMultiplier { get; set; }
        public bool ShouldSerializeAnimalSpineMultiplier() => AnimalSpineMultiplier != null;
        public float? AnimalSkullMultiplier { get; set; }
        public bool ShouldSerializeAnimalSkullMultiplier() => AnimalSkullMultiplier != null;

        public float? BarricadeDamage { get; set; }
        public bool ShouldSerializeBarricadeDamage() => BarricadeDamage != null;
        public float? StructureDamage { get; set; }
        public bool ShouldSerializeStructureDamage() => StructureDamage != null;
        public float? VehicleDamage { get; set; }
        public bool ShouldSerializeVehicleDamage() => VehicleDamage != null;
        public float? ResourceDamage { get; set; }
        public bool ShouldSerializeResourceDamage() => ResourceDamage != null;
        public float? ObjectDamage { get; set; }
        public bool ShouldSerializeObjectDamage() => ObjectDamage != null;

        public bool? Invulnerable { get; set; }
        public bool ShouldSerializeInvulnerable() => Invulnerable != null;
        #endregion

        #region Guns
        public ushort? Caliber { get; set; }
        public bool ShouldSerializeCaliber() => Caliber != null;
        public float? Range { get; set; }
        public bool ShouldSerializeRange() => Range != null;
        public float? SpreadAim { get; set; }
        public bool ShouldSerializeSpreadAim() => SpreadAim != null;
        public float? SpreadHip { get; set; }
        public bool ShouldSerializeSpreadHip() => SpreadHip != null;
        public ushort? Muzzle { get; set; }
        public bool ShouldSerializeMuzzle() => Muzzle != null;
        public ushort? Explosion { get; set; } // For barricades/structures also
        public bool ShouldSerializeExplosion() => Explosion != null;
        #endregion

        #region Barrels
        public float? BallisticDrop { get; set; }
        public bool ShouldSerializeBallisticDrop() => BallisticDrop != null;
        public bool? Braked { get; set; }
        public bool ShouldSerializeBraked() => Braked != null;
        public bool? Silenced { get; set; }
        public bool ShouldSerializeSilenced() => Silenced != null;
        public float? Volume { get; set; }
        public bool ShouldSerializeVolume() => Volume != null;
        #endregion

        #region Clothing
        public float? Armor { get; set; }
        public bool ShouldSerializeArmor() => Armor != null;
        #endregion

        #region Generators
        public ushort? GeneratorCapacity { get; set; }
        public bool ShouldSerializeGeneratorCapacity() => GeneratorCapacity != null;
        public float? GeneratorBurn { get; set; }
        public bool ShouldSerializeGeneratorBurn() => GeneratorBurn != null;
        #endregion
    }
}
