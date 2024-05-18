using PzProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinForm
{
    public class GameSetup
    {
        public ArmourShop  ArmourShop { get; set; }

        public WeaponShop WeaponShop { get; set; }

        public SpellShop SpellShop { get; set; }

        public EffectShop EffectShop { get; set; }

        public GameSetup() 
        { 
            DataFeeder dataFeeder = new DataFeeder();

            ArmourShop = new ArmourShop();
            ArmourShop.AddItems(dataFeeder.GetArmours());
            
            WeaponShop = new WeaponShop();
            WeaponShop.AddItems(dataFeeder.GetWeapons());

            SpellShop = new SpellShop();
            SpellShop.AddItems(dataFeeder.GetSpells());

            EffectShop = new EffectShop();
            EffectShop.AddItems(dataFeeder.GetEffects());

        }

     
    }


    internal class DataFeeder
    {
        public DataFeeder() { }
        
        static List<Spell> spells = new List<Spell>
        {
            new Spell("Teleportation", 2149, new CharacterStatistics() {Magica = 3}, Spells.Teleport),
            new Spell("Gale", 3820, new CharacterStatistics() {Magica = 4}, Spells.Gale),
            new Spell("Adulation", 15280, new CharacterStatistics() {Magica = 8}, Spells.Adulation),
            new Spell("Command", 15280, new CharacterStatistics() {Magica = 8}, Spells.Command),
            new Spell("Fireball", 19857, new CharacterStatistics() {Magica = 13}, Spells.Fireball),
            new Spell("Lightning Bolt", 26437, new CharacterStatistics() {Magica = 15}, Spells.LightningBolt),
            new Spell("Hell Fireball", 47000, new CharacterStatistics() {Magica = 20}, Spells.HellFireball),
            new Spell("Ghost Strike", 105289, new CharacterStatistics() {Magica = 21}, Spells.GhostStrike),
            new Spell("Weaken Armor", 115555, new CharacterStatistics() {Magica = 22}, Spells.WeakenArmor),
            new Spell("Frightening Bolt", 67680, new CharacterStatistics() {Magica = 24}, Spells.FrighteningBolt),
            new Spell("Dire Fireball", 105750, new CharacterStatistics() {Magica = 30}, Spells.DireFireball),
            new Spell("Rejuvinate", 188000, new CharacterStatistics() {Magica = 40}, Spells.Rejuvinate),
            new Spell("Molten Death", 423000, new CharacterStatistics() {Magica = 60}, Spells.MoltenDeath),
        };

        List<Effect> effects = new List<Effect>
        {
            new Effect("Freeze", 1000, null, null, Actions.Freeze, 1),
            new Effect("Weakness", 1000, Actions.BeginWeakness, Actions.EndWeakness, null, 2),
            new Effect("Poison", 1000, null, null, Actions.Poison, 3),
        };
        
        static List<Armour> helmets = new List<Armour>
        {
            new Armour(1, "Peasant Helmet", 1200, ArmourType.Helmet, 20),
            new Armour(1, "Cutpurse Helmet", 2700, ArmourType.Helmet, 30),
            new Armour(1, "Brigand Helmet", 4800, ArmourType.Helmet, 40),
            new Armour(6, "Militia Helmet", 7500, ArmourType.Helmet, 50),
            new Armour(6, "Veteran Helmet", 10800, ArmourType.Helmet, 60),
            new Armour(12, "Hoplite Helmet", 14700, ArmourType.Helmet, 70),
            new Armour(12, "Swashbuckler Helmet", 19200, ArmourType.Helmet, 80),
            new Armour(12, "Retarius Helmet", 24300, ArmourType.Helmet, 90),
            new Armour(18, "Myrmidon Helmet", 30000, ArmourType.Helmet, 100),
            new Armour(18, "Legion Helmet", 36300, ArmourType.Helmet, 110),
            new Armour(18, "Warlord Helmet", 43200, ArmourType.Helmet, 120),
            new Armour(24, "Centurion Helmet", 50700, ArmourType.Helmet, 130),
            new Armour(24, "Knight Helmet", 58800, ArmourType.Helmet, 140),
            new Armour(24, "Paladin Helmet", 67500, ArmourType.Helmet, 150),
            new Armour(30, "Templar Helmet", 76800, ArmourType.Helmet, 160),
            new Armour(30, "Cavalier Helmet", 86700, ArmourType.Helmet, 170),
            new Armour(30, "Crusader Helmet", 97200, ArmourType.Helmet, 180),
            new Armour(36, "Avenger Helmet", 108300, ArmourType.Helmet, 190),
            new Armour(36, "Infernal Helmet", 120000, ArmourType.Helmet, 200),
            new Armour(36, "Samurai Helmet", 132300, ArmourType.Helmet, 210),
            new Armour(42, "Demon-plate Helmet", 145200, ArmourType.Helmet, 220),
            new Armour(42, "Conquerer Helmet", 158700, ArmourType.Helmet, 230),
            new Armour(42, "Automaton Helmet", 172800, ArmourType.Helmet, 240),
            new Armour(48, "Champions Helmet", 187500, ArmourType.Helmet, 250),
        };

        static List<Armour> chestplates = new List<Armour>
        {
            new Armour(1, "Peasant Chestplate", 3072, ArmourType.Chestplate, 32),
            new Armour(1, "Cutpurse Chestplate", 6912, ArmourType.Chestplate, 48),
            new Armour(1, "Brigand Chestplate", 12288, ArmourType.Chestplate, 64),
            new Armour(6, "Militia Chestplate", 19200, ArmourType.Chestplate, 80),
            new Armour(6, "Veteran Chestplate", 27648, ArmourType.Chestplate, 96),
            new Armour(12, "Hoplite Chestplate", 37632, ArmourType.Chestplate, 112),
            new Armour(12, "Swashbuckler Chestplate", 49152, ArmourType.Chestplate, 128),
            new Armour(12, "Retarius Chestplate", 62208, ArmourType.Chestplate, 144),
            new Armour(18, "Myrmidon Chestplate", 76800, ArmourType.Chestplate, 160),
            new Armour(18, "Legion Chestplate", 92928, ArmourType.Chestplate, 176),
            new Armour(18, "Warlord Chestplate", 110592, ArmourType.Chestplate, 192),
            new Armour(24, "Centurion Chestplate", 129792, ArmourType.Chestplate, 208),
            new Armour(24, "Knight Chestplate", 150528, ArmourType.Chestplate, 224),
            new Armour(24, "Paladin Chestplate", 172800, ArmourType.Chestplate, 240),
            new Armour(30, "Templar Chestplate", 196608, ArmourType.Chestplate, 256),
            new Armour(30, "Cavalier Chestplate", 221952, ArmourType.Chestplate, 272),
            new Armour(30, "Crusader Chestplate", 248832, ArmourType.Chestplate, 288),
            new Armour(36, "Avenger Chestplate", 277248, ArmourType.Chestplate, 304),
            new Armour(36, "Infernal Chestplate", 307200, ArmourType.Chestplate, 320),
            new Armour(36, "Samurai Chestplate", 338688, ArmourType.Chestplate, 336),
            new Armour(42, "Demon-plate Chestplate", 371712, ArmourType.Chestplate, 352),
            new Armour(42, "Conquerer Chestplate", 406272, ArmourType.Chestplate, 368),
            new Armour(42, "Automaton Chestplate", 442368, ArmourType.Chestplate, 384),
            new Armour(48, "Champions Chestplate", 480000, ArmourType.Chestplate, 400),
        };

        static List<Armour> leggings = new List<Armour>
        {
            new Armour(1,  "Peasant Leggings", 108, ArmourType.Leggings, 6),
            new Armour(1,  "Cutpurse Leggings", 243, ArmourType.Leggings, 9),
            new Armour(1,  "Brigand Leggings", 432, ArmourType.Leggings, 12),
            new Armour(6,  "Militia Leggings", 675, ArmourType.Leggings, 15),
            new Armour(6,  "Veteran Leggings", 972, ArmourType.Leggings, 18),
            new Armour(12, "Hoplite Leggings", 1323, ArmourType.Leggings, 21),
            new Armour(12, "Swashbuckler Leggings", 1728, ArmourType.Leggings, 24),
            new Armour(12, "Retarius Leggings", 2187, ArmourType.Leggings, 27),
            new Armour(18, "Myrmidon Leggings", 2700, ArmourType.Leggings, 30),
            new Armour(18, "Legion Leggings", 3267, ArmourType.Leggings, 33),
            new Armour(18, "Warlord Leggings", 3888, ArmourType.Leggings, 36),
            new Armour(24, "Centurion Leggings", 4563, ArmourType.Leggings, 39),
            new Armour(24, "Knight Leggings", 5292, ArmourType.Leggings, 42),
            new Armour(24, "Paladin Leggings", 6075, ArmourType.Leggings, 45),
            new Armour(30, "Templar Leggings", 6912, ArmourType.Leggings, 48),
            new Armour(30, "Cavalier Leggings", 7803, ArmourType.Leggings, 51),
            new Armour(30, "Crusader Leggings", 8748, ArmourType.Leggings, 54),
            new Armour(36, "Avenger Leggings", 9747, ArmourType.Leggings, 57),
            new Armour(36, "Infernal Leggings", 10800, ArmourType.Leggings, 60),
            new Armour(36, "Samurai Leggings", 11907, ArmourType.Leggings, 63),
            new Armour(42, "Demon-plate Leggings", 13068, ArmourType.Leggings, 66),
            new Armour(42, "Conquerer Leggings", 14283, ArmourType.Leggings, 69),
            new Armour(42, "Automaton Leggings", 15552, ArmourType.Leggings, 72),
            new Armour(48, "Champions Leggings", 16875, ArmourType.Leggings, 75),
        };

        static List<Armour> boots = new List<Armour>
        {
            new Armour(1, "Peasant Boots", 48, ArmourType.Boots, 4),
            new Armour(1, "Cutpurse Boots", 108, ArmourType.Boots, 6),
            new Armour(1, "Brigand Boots", 192, ArmourType.Boots, 8),
            new Armour(6, "Militia Boots", 300, ArmourType.Boots, 10),
            new Armour(6, "Veteran Boots", 432, ArmourType.Boots, 12),
            new Armour(12,"Hoplite Boots", 588, ArmourType.Boots, 14),
            new Armour(12,"Swashbuckler Boots", 768, ArmourType.Boots, 16),
            new Armour(12,"Retarius Boots", 972, ArmourType.Boots, 18),
            new Armour(18,"Myrmidon Boots", 1200, ArmourType.Boots, 20),
            new Armour(18,"Legion Boots", 1452, ArmourType.Boots, 22),
            new Armour(18,"Warlord Boots", 1728, ArmourType.Boots, 24),
            new Armour(24,"Centurion Boots", 2028, ArmourType.Boots, 26),
            new Armour(24,"Knight Boots", 2352, ArmourType.Boots, 28),
            new Armour(24,"Paladin Boots", 2700, ArmourType.Boots, 30),
            new Armour(30,"Templar Boots", 3072, ArmourType.Boots, 32),
            new Armour(30,"Cavalier Boots", 3468, ArmourType.Boots, 34),
            new Armour(30,"Crusader Boots", 3888, ArmourType.Boots, 36),
            new Armour(36,"Avenger Boots", 4332, ArmourType.Boots, 38),
            new Armour(36,"Infernal Boots", 4800, ArmourType.Boots, 40),
            new Armour(36,"Samurai Boots", 5292, ArmourType.Boots, 42),
            new Armour(42,"Demon-plate Boots", 5808, ArmourType.Boots, 44),
            new Armour(42,"Conquerer Boots", 6348, ArmourType.Boots, 46),
            new Armour(42,"Automaton Boots", 6912, ArmourType.Boots, 48),
            new Armour(48,"Champions Boots", 7500, ArmourType.Boots, 50),
        };
        
        static List<Weapon> swords = new List<Weapon>
        {
            new Weapon("Dagger", 1285, new CharacterStatistics() {Agility = 3}, WeaponType.Sword,3, 9),
            new Weapon("Shortsword", 2270, new CharacterStatistics() {Agility = 6}, WeaponType.Sword, 4, 16),
            new Weapon("Dirk", 3535, new CharacterStatistics() {Agility = 9}, WeaponType.Sword, 5, 25),
            new Weapon("Gladius", 5078, new CharacterStatistics() {Agility = 12}, WeaponType.Sword, 6, 36),
            new Weapon("Broadsword", 6901, new CharacterStatistics() {Agility = 15}, WeaponType.Sword, 7, 49),
            new Weapon("Claymore", 9002, new CharacterStatistics() {Agility = 18}, WeaponType.Sword, 8, 64),
            new Weapon("Bastard Sword", 11383, new CharacterStatistics() {Agility = 21}, WeaponType.Sword, 9, 81),
            new Weapon("Longsword", 14042, new CharacterStatistics() {Agility = 24}, WeaponType.Sword, 10, 100),
            new Weapon("Knight Sword", 20198, new CharacterStatistics() {Agility = 27}, WeaponType.Sword, 12, 144),
            new Weapon("Silver Longsword", 27470, new CharacterStatistics() {Agility = 30}, WeaponType.Sword, 14, 196),
            new Weapon("Heartblade", 35858, new CharacterStatistics() {Agility = 33}, WeaponType.Sword, 16, 256),
            new Weapon("Crystal Sword", 45362, new CharacterStatistics() {Agility = 36}, WeaponType.Sword, 18, 324),
            new Weapon("Rapier", 50533, new CharacterStatistics() {Agility = 39}, WeaponType.Sword, 19, 351),
            new Weapon("Cutlas", 55982, new CharacterStatistics() {Agility = 42}, WeaponType.Sword, 20, 400),
            new Weapon("Scimitar", 61711, new CharacterStatistics() {Agility = 45}, WeaponType.Sword, 21, 441),
            new Weapon("Raj Scimitar", 67718, new CharacterStatistics() {Agility = 48}, WeaponType.Sword, 22, 484),
            new Weapon("Katana", 74005, new CharacterStatistics() {Agility = 51}, WeaponType.Sword, 23, 529),
            new Weapon("Ancestor Katana", 80570, new CharacterStatistics() {Agility = 54}, WeaponType.Sword, 24, 576),
            new Weapon("Kensai Spirit", 87415, new CharacterStatistics() {Agility = 57}, WeaponType.Sword, 25, 625),
            new Weapon("Daikatana", 94538, new CharacterStatistics() {Agility = 60}, WeaponType.Sword, 26, 676),
        };
        
        static List<Weapon> axes = new List<Weapon>
        {
            new Weapon("Cleaver", 1285, new CharacterStatistics() {Strength = 3}, WeaponType.Axe, 4, 16),
            new Weapon("Hand axe", 2270, new CharacterStatistics() {Strength = 6}, WeaponType.Axe, 5, 20),
            new Weapon("Bronze axe", 3535, new CharacterStatistics() {Strength = 9}, WeaponType.Axe, 6, 24),
            new Weapon("Hatchet", 5078, new CharacterStatistics() {Strength = 12}, WeaponType.Axe, 8, 32),
            new Weapon("Warrior axe", 6901, new CharacterStatistics() {Strength = 15}, WeaponType.Axe, 10, 40),
            new Weapon("Berserker axe", 8511, new CharacterStatistics() {Strength = 18}, WeaponType.Axe, 15, 60),
            new Weapon("Greensteel axe", 10212, new CharacterStatistics() {Strength = 21}, WeaponType.Axe, 18, 72),
            new Weapon("Madman's cleaver", 11346, new CharacterStatistics() {Strength = 24}, WeaponType.Axe, 20, 80),
            new Weapon("Greataxe", 14181, new CharacterStatistics() {Strength = 27}, WeaponType.Axe, 25, 100),
            new Weapon("Blacksteel battleaxe", 22686, new CharacterStatistics() {Strength = 36}, WeaponType.Axe, 40, 160),
            new Weapon("Steel battleaxe", 19851, new CharacterStatistics() {Strength = 33}, WeaponType.Axe, 35, 140),
            new Weapon("Ogre battleaxe", 25521, new CharacterStatistics() {Strength = 39}, WeaponType.Axe, 45, 180),
            new Weapon("Iron greataxe", 17016, new CharacterStatistics() {Strength = 30}, WeaponType.Axe, 30, 120),
            new Weapon("Ramhead sickle", 34116, new CharacterStatistics() {Strength = 45}, WeaponType.Axe, 70, 240),
            new Weapon("Reaper scythe", 62916, new CharacterStatistics() {Strength = 60}, WeaponType.Axe, 170, 440),
            new Weapon("Hunter spear", 28356, new CharacterStatistics() {Strength = 42}, WeaponType.Axe, 50, 200),
            new Weapon("Halberd", 39876, new CharacterStatistics() {Strength = 48}, WeaponType.Axe, 90, 280),
            new Weapon("Awl pike", 45636, new CharacterStatistics() {Strength = 51}, WeaponType.Axe, 110, 320),
            new Weapon("Poleaxe", 51396, new CharacterStatistics() {Strength = 54}, WeaponType.Axe, 130, 360),
            new Weapon("Pilum", 57156, new CharacterStatistics() {Strength = 57}, WeaponType.Axe, 150, 400),
        };

        private static List<Character> bosses = new List<Character>()
        {
            new Character(
                "John The Butcher",
                new CharacterStatistics()
                {
                    Strength = 6, Agility = 3, Attack = 1, Defence = 3, Vitality = 3, Charisma = 2, Stamina = 5,
                    Magica = 1
                },
                5,
                axes[3],
                new ArmourSet(new Armour(1, "Hat of the Pig", 0, ArmourType.Helmet, 25), null, leggings[0], null)
            ),
            
            new Character(
                "The Evil Ninja",
                new CharacterStatistics()
                {
                    Strength = 1, Agility = 12, Attack = 9, Defence = 4, Vitality = 5, Charisma = 6, Stamina = 6, Magica = 5
                },
                7,
                swords[1],
                new ArmourSet(new Armour(1, "Devious Mask", 0, ArmourType.Helmet, 35), chestplates[3], leggings[2], boots[4]),
                new List<Spell>() { spells[1], spells[1] }
                ),
            
            new Character(
                "Son of Stylonius",
                new CharacterStatistics()
                {
                    Strength = 15, Agility = 2, Attack = 5, Defence = 2, Vitality = 7, Charisma = 3, Stamina = 9, Magica = 10
                },
                10,
                axes[7],
                new ArmourSet(new Armour(1, "Helm of Ownage", 0, ArmourType.Helmet, 50), null, leggings[8], boots[8])
                ),
            
            new Character(
                "Marksman Dantus",
                new CharacterStatistics()
                {
                    Strength = 3, Agility = 16, Attack = 10, Defence = 10, Vitality = 10, Charisma = 12, Stamina = 13, Magica = 10
                },
                14,
                swords[7],
                new ArmourSet(new Armour(1, "Cavalry Helm", 0, ArmourType.Helmet, 70), chestplates[4], leggings[4], boots[4]),
                new List<Spell>() { spells[0], spells[0], spells[1] }
                ),
            
            new Character(
                "The Great Beast",
                new CharacterStatistics()
                {
                    Strength = 27, Agility = 9, Attack = 11, Defence = 10, Vitality = 15, Charisma = 5, Stamina = 15, Magica = 10
                },
                16,
                axes[6],
                new ArmourSet(null, chestplates[8], null, null)
                ),
            
            new Character(
                "Wizard Sagan",
                new CharacterStatistics()
                {
                    Strength = 20, Agility = 5, Attack = 10, Defence = 10, Vitality = 5, Charisma = 10, Stamina = 15, Magica = 35
                },
                19,
                swords[1],
                new ArmourSet(new Armour(1, "Magical Hat", 0, ArmourType.Helmet, 95), chestplates[6], leggings[3], boots[5]),
                new List<Spell>() { spells[4], spells[4], spells[5], spells[5], spells[0] }
            ),
            
            new Character(
                "The Slave Driver",
                new CharacterStatistics()
                {
                    Strength = 25, Agility = 6, Attack = 14, Defence = 12, Vitality = 45, Charisma = 7, Stamina = 16, Magica = 12
                },
                23,
                axes[7],
                new ArmourSet(new Armour(1, "Oppressor's Mask", 0, ArmourType.Helmet, 115), chestplates[7], leggings[10], boots[6]),
                new List<Spell>() { spells[3], spells[7] }
            ),
            
            new Character(
                "Spheracles",
                new CharacterStatistics()
                {
                    Strength = 30, Agility = 10, Attack = 38, Defence = 17, Vitality = 17, Charisma = 24, Stamina = 17, Magica = 17
                },
                26,
                axes[8],
                new ArmourSet(null, chestplates[8], leggings[8], boots[8]),
                new List<Spell>() { spells[2], spells[3] }
            ),
            
            new Character(
                "Maharaja Saeed",
                new CharacterStatistics()
                {
                    Strength = 15, Agility = 23, Attack = 25, Defence = 36, Vitality = 24, Charisma = 13, Stamina = 15, Magica = 11
                },
                30,
                swords[8],
                new ArmourSet(new Armour(1, "Turban", 0, ArmourType.Helmet, 150), chestplates[10], leggings[10], boots[10]),
                new List<Spell>() { spells[7] }
            ),
            
            new Character(
                "Gaiax",
                new CharacterStatistics()
                {
                    Strength = 37, Agility = 5, Attack = 25, Defence = 20, Vitality = 45, Charisma = 10, Stamina = 40, Magica = 10
                },
                37,
                axes[16],
                new ArmourSet(new Armour(1, "Brow of Kronos", 0, ArmourType.Helmet, 165), chestplates[12], leggings[11], boots[11]),
                new List<Spell>() { spells[3], spells[5] }
            ),
            
            new Character(
                "Daimyo Katsumodo",
                new CharacterStatistics()
                {
                    Strength = 30, Agility = 34, Attack = 10, Defence = 28, Vitality = 18, Charisma = 29, Stamina = 40, Magica = 18
                },
                35,
                axes[16],
                new ArmourSet(new Armour(1, "Kabuto", 0, ArmourType.Helmet, 175), chestplates[13], leggings[13], boots[13]),
                new List<Spell>() { spells[8] }
            ),
            
            new Character(
                "HeChaos the Scourge",
                new CharacterStatistics()
                {
                    Strength = 23, Agility = 23, Attack = 23, Defence = 30, Vitality = 23, Charisma = 23, Stamina = 23, Magica = 23
                },
                37,
                axes[12],
                new ArmourSet(new Armour(1, "Chaos Helm", 0, ArmourType.Helmet, 185), chestplates[14], leggings[14], boots[0]),
                new List<Spell>() { spells[0], spells[0], spells[6] }
            ),
            
            new Character(
                "Archfiend Zeerzabahl",
                new CharacterStatistics()
                {
                    Strength = 50, Agility = 40, Attack = 30, Defence = 25, Vitality = 25, Charisma = 22, Stamina = 20, Magica = 20
                },
                40,
                axes[11],
                new ArmourSet(new Armour(1, "Demon Skull", 0, ArmourType.Helmet, 200), chestplates[18], leggings[18], boots[18]),
                new List<Spell>() { spells[6], spells[5], spells[3] }
            ),
            
            new Character(
                "Sir Belgrave",
                new CharacterStatistics()
                {
                    Strength = 36, Agility = 40, Attack = 40, Defence = 50, Vitality = 34, Charisma = 30, Stamina = 25, Magica = 10
                },
                42,
                swords[13],
                new ArmourSet(new Armour(1, "Rhykier Helm", 0, ArmourType.Helmet, 200), chestplates[16], leggings[16], boots[16]),
                new List<Spell>() { spells[7] }
            ),
            
            new Character(
                "Bhaargle",
                new CharacterStatistics()
                {
                    Strength = 2, Agility = 50, Attack = 2, Defence = 2, Vitality = 50, Charisma = 50, Stamina = 30, Magica = 60
                },
                44,
                swords[11],
                new ArmourSet(new Armour(1, "Bhaargle's Circlet", 0, ArmourType.Helmet, 5), chestplates[21], leggings[21], boots[21]),
                new List<Spell>() { spells[6], spells[10], spells[12] }
            ),
            
            new Character(
                "Archangel Sandalphon",
                new CharacterStatistics()
                {
                    Strength = 55, Agility = 30, Attack = 40, Defence = 40, Vitality = 40, Charisma = 30, Stamina = 20, Magica = 20
                },
                48,
                swords[19],
                new ArmourSet(new Armour(1, "Archangels Mantle", 0, ArmourType.Helmet, 240), chestplates[23], leggings[23], boots[23]),
                new List<Spell>() { spells[2], spells[2], spells[2], spells[2], spells[0], spells[3] }
            ),
            
            new Character(
                "Emperor Antares",
                new CharacterStatistics()
                {
                    Strength = 60, Agility = 60, Attack = 60, Defence = 60, Vitality = 60, Charisma = 60, Stamina = 60, Magica = 60
                },
                60,
                new Weapon("Blade of the Empire", 6901, new CharacterStatistics() {Agility = 60}, WeaponType.Sword, 200, 800),
                new ArmourSet(
                    new Armour(1, "Helm of Ages", 0, ArmourType.Helmet, 300), 
                    new Armour(1, "Emperors chestplate", 0, ArmourType.Chestplate, 416), 
                    new Armour(1, "Emperors leggings", 0, ArmourType.Leggings, 78), 
                    new Armour(1, "Emperors boots", 0, ArmourType.Boots, 52)),
                new List<Spell>() { spells[12], spells[7], spells[10], spells[8], spells[3] }

            )
        };

        private List<Tournament> _tournaments = new List<Tournament>()
        {
            new Tournament(4, 2, bosses[0]),
            new Tournament(7, 3, bosses[1]),
            new Tournament(9, 4, bosses[2]),
            new Tournament(12, 5, bosses[3]),
            new Tournament(15, 6, bosses[4]),
            new Tournament(18, 7, bosses[5]),
            new Tournament(21, 8, bosses[6]),
            new Tournament(24, 9, bosses[7]),
            new Tournament(27, 10, bosses[8]),
            new Tournament(30, 11, bosses[9]),
            new Tournament(33, 12, bosses[10]),
            new Tournament(36, 13, bosses[11]),
            new Tournament(39, 14, bosses[12]),
            new Tournament(42, 15, bosses[13]),
            new Tournament(48, 17, bosses[14]),
        };
        
        public  List<Armour> GetArmours () {
            List<Armour> results = new List<Armour> () ;
            results.AddRange(leggings);
            results.AddRange(boots);
            results.AddRange(helmets);
            results.AddRange(chestplates);
            return results ;
        }

        public List<Weapon> GetWeapons ()
        {
            List<Weapon> results = new List<Weapon> ();
            results.AddRange(swords);
            results.AddRange(axes);
            return results;
        }


        public List<Spell> GetSpells()
        {
            List<Spell> results = new List<Spell>();
            results.AddRange(spells);
            return results;
        }

        public List<Effect> GetEffects()
        {
            List<Effect> results = new List<Effect>();
            results.AddRange(effects);
            return results;
        }
    }
           
}


    

