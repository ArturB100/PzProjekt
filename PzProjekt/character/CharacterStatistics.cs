using PzProjekt.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public class Statistics : ICloneable
    {
        public int Strength
        {
            get { return statisticsDictionary[0]; }
            set 
            { 
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    statisticsDictionary[0] = value;
                }
            }
        }
        public int Agility
        {
            get { return statisticsDictionary[1]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    statisticsDictionary[1] = value;
                }
            }
        }

        public int Attack
        {
            get { return statisticsDictionary[2]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    statisticsDictionary[2] = value;
                }
            }
        }

        public int Defence
        {
            get { return statisticsDictionary[3]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    statisticsDictionary[3] = value;
                }
            }
        }

        public int Vitality
        {
            get { return statisticsDictionary[4]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    statisticsDictionary[4] = value;
                }
            }
        }

        public int Charisma
        {
            get { return statisticsDictionary[5]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    statisticsDictionary[5] = value;
                }
            }
        }

        public int Stamina
        {
            get { return statisticsDictionary[6]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    statisticsDictionary[6] = value;
                }
            }
        }

        public int Magica
        {
            get { return statisticsDictionary[7]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    statisticsDictionary[7] = value;
                }
            }
        }

        public int Intelligence
        {
            get { return statisticsDictionary[8]; }
            set
            {
                if (value < 1)
                {
                    throw new NegativeStatisticPointsException();
                }
                else
                {
                    statisticsDictionary[8] = value;
                }
            }
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

        public bool IsGreater(Statistics? other)
        {
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
