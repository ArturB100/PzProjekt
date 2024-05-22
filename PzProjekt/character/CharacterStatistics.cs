using PzProjekt.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public class CharacterStatistics : ICloneable
    {
        public int Strength
        {
            get { return StatisticsDictionary[0]; }
            set 
            { 
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    StatisticsDictionary[0] = value;
                }
            }
        }
        public int Agility
        {
            get { return StatisticsDictionary[1]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    StatisticsDictionary[1] = value;
                }
            }
        }

        public int Attack
        {
            get { return StatisticsDictionary[2]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    StatisticsDictionary[2] = value;
                }
            }
        }

        public int Defence
        {
            get { return StatisticsDictionary[3]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    StatisticsDictionary[3] = value;
                }
            }
        }

        public int Vitality
        {
            get { return StatisticsDictionary[4]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    StatisticsDictionary[4] = value;
                }
            }
        }

        public int Charisma
        {
            get { return StatisticsDictionary[5]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    StatisticsDictionary[5] = value;
                }
            }
        }

        public int Stamina
        {
            get { return StatisticsDictionary[6]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    StatisticsDictionary[6] = value;
                }
            }
        }

        public int Magica
        {
            get { return StatisticsDictionary[7]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    StatisticsDictionary[7] = value;
                }
            }
        }

        public int Intelligence
        {
            get { return StatisticsDictionary[8]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    StatisticsDictionary[8] = value;
                }
            }
        }

        public override string ToString ()
        {
            return $"strength: {Strength} | " +
                   $"agility: {Agility} | " +
                   $"attack: {Attack} | " +
                   $"defence: {Defence} | " +
                   $"vitality: {Vitality} | " +
                   $"charisma: {Charisma} | " +
                   $"stamina: {Stamina} | " +
                   $"magica: {Magica} | ";
        }

        
        public Dictionary<int, int> StatisticsDictionary { get; set; }

        public CharacterStatistics()
        {
            StatisticsDictionary = new Dictionary<int, int>();
            
            Strength = 1;
            Agility = 1;
            Attack = 1;
            Defence = 1;
            Vitality = 1;
            Charisma = 1;
            Stamina = 1;
            Magica = 1;
            Intelligence = 1;
        }

        public bool IsGreater(CharacterStatistics statistics)
        {
            foreach (var stat in StatisticsDictionary)
            {
                if (stat.Value < statistics.StatisticsDictionary[stat.Key])
                {
                    return false;
                }
            }
            
            return true;
        }
        
        public object Clone()
        {
            return new CharacterStatistics
            {
                Strength = Strength,
                Agility = Agility,
                Attack = Attack,
                Defence = Defence,
                Vitality = Vitality,
                Charisma = Charisma,
                Stamina = Stamina,
                Magica = Magica,
                Intelligence = Intelligence
            };
        }
        
         
    }
}
