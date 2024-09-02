using PzProjekt;
using PzProjekt.fight;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkClient
{
    public class AIaction : IBotAction
    {

        public string NameOfPlugin()
        {
            return "neural network";
        }

        public async Task MakeMove(Fight fight)
        {
            int action = await NeuralNetworkClient.GetPredictionAsync(
                fight.DistanceBetweenCharacters,
                fight.Enemy.Parameters.ActualStamina,
                fight.Enemy.Parameters.MaxStamina,
                fight.Enemy.Parameters.ActualHP,
                fight.Enemy.Parameters.MaxHP,
                fight.Enemy.BaseStatistics.Stamina,
                fight.Enemy.BaseStatistics.Magica,
                fight.Enemy.BaseStatistics.Vitality,A
                fight.Enemy.BaseStatistics.Charisma,
                fight.Enemy.BaseStatistics.Agility,
                fight.Enemy.BaseStatistics.Attack,
                fight.Enemy.BaseStatistics.Defence,
                fight.Player.Parameters.ActualStamina,
                fight.Player.Parameters.MaxStamina,
                fight.Player.Parameters.ActualHP,
                fight.Player.Parameters.MaxHP
            );
            CharacterFightActions characterFightActions = fight.CharacterFightActions;

            Debug.WriteLine("neural network response " +  action );
            switch (action)
            {
                case 1:
                    characterFightActions.Attack(AttackType.STRONG);
                    break;
                case 2:
                    characterFightActions.Attack(AttackType.MEDIUM);
                    break;
                case 3:
                    characterFightActions.Attack(AttackType.WEAK);
                    break;
                case 4:
                    characterFightActions.MoveTowardsEnemy();
                    break;
                case 5:
                    characterFightActions.MoveFromEnemy();
                    break;
                case 6:
                    characterFightActions.Sleep();
                    break;
                case 7:
                    characterFightActions.SatisfyTheCrowd();
                    break;
                default:
                    characterFightActions.Sleep();
                    break;

            }
        }
    }
}
