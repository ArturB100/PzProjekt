using Newtonsoft.Json;
using System.Text;

namespace NeuralNetworkClient
{
    public class NeuralNetworkClient
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<int> GetPredictionAsync(
            double distanceBetweenCharacters,
            double playerActualStamina,
            double playerMaxStamina,
            double playerActualHP,
            double playerMaxHP,
            double playerBaseStamina,
            double playerBaseMagica,
            double playerBaseVitality,
            double playerBaseCharisma,
            double playerBaseAgility,
            double playerBaseAttack,
            double playerBaseDefence,
            double enemyActualStamina,
            double enemyMaxStamina,
            double enemyActualHP,
            double enemyMaxHP)
        {
            var data = new
            {
                DistanceBetweenCharacters = distanceBetweenCharacters,
                PlayerActualStamina = playerActualStamina,
                PlayerMaxStamina = playerMaxStamina,
                PlayerActualHP = playerActualHP,
                PlayerMaxHP = playerMaxHP,
                PlayerBaseStamina = playerBaseStamina,
                PlayerBaseMagica = playerBaseMagica,
                PlayerBaseVitality = playerBaseVitality,
                PlayerBaseCharisma = playerBaseCharisma,
                PlayerBaseAgility = playerBaseAgility,
                PlayerBaseAttack = playerBaseAttack,
                PlayerBaseDefence = playerBaseDefence,
                EnemyActualStamina = enemyActualStamina,
                EnemyMaxStamina = enemyMaxStamina,
                EnemyActualHP = enemyActualHP,
                EnemyMaxHP = enemyMaxHP
            };

            string jsonData = JsonConvert.SerializeObject(data);

            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:5000/predict", content);

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                var result = JsonConvert.DeserializeObject<dynamic>(responseBody);
                int action = result.action;

                return action;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Request error: " + e.Message);
                throw;
            }
        }

    }
}
