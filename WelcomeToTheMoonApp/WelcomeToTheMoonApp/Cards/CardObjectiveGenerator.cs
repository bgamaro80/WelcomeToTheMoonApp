using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WelcomeToTheMoonApp.Cards
{
    public static class CardObjectiveGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="scenarioNumber">From 1 to 8</param>
        /// <returns></returns>
        public static List<ObjectiveCard> GetCardsForScenario(int scenarioNumber)
        {
            switch (scenarioNumber)
            {
                case 5:
                    return GetObjectiveCards_Scenario5();

                default:
                    throw new ArgumentException($"Scenario number {scenarioNumber} not valid.");
            }
        }

        private static List<ObjectiveCard> GetObjectiveCards_Scenario5()
        {
            var scenarioNumber = 5;

            return new List<ObjectiveCard>
            {
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "A",
                    FirstScore = 1, //Special score here, 1 means first player
                    SecondScore = 2, //Special score here, 2 means second player
                    Text = "Numera todos los niveles de un rascacielos."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "AA",
                    FirstScore = 1, //Special score here, 1 means first player
                    SecondScore = 2, //Special score here, 2 means second player
                    Text = "Numera el último nivel de la parte superior de 2 rascacielos."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "B",
                    FirstScore = 1, //Special score here, 1 means first player
                    SecondScore = 2, //Special score here, 2 means second player
                    Text = "En la torre de plantas y agua, rodea al menos 2 símbolos (2 plantas o 1 planta + 1 agua) en tres niveles."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "BB",
                    FirstScore = 1, //Special score here, 1 means first player
                    SecondScore = 2, //Special score here, 2 means second player
                    Text = "En la torre de plantas y agua, rodea los tres símbolos (las 2 plantas + 1 agua) en dos niveles."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "C",
                    FirstScore = 1, //Special score here, 1 means first player
                    SecondScore = 2, //Special score here, 2 means second player
                    Text = "Construye todas las secciones de la cúpula."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "CC",
                    FirstScore = 1, //Special score here, 1 means first player
                    SecondScore = 2, //Special score here, 2 means second player
                    Text = "Anota una X en 4 niveles mediante acciones de Planificación."
                }
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scenarioNumber">From 1 to 8</param>
        /// <returns></returns>
        public static List<ObjectiveCard> GetCardsForGame(int scenarioNumber)
        {
            var cards = GetCardsForScenario(scenarioNumber);

            var rnd = new Random();

            var a = cards.Where(o => o.Letter.Contains("A")).ElementAt(rnd.Next(2));
            var b = cards.Where(o => o.Letter.Contains("B")).ElementAt(rnd.Next(2));
            var c = cards.Where(o => o.Letter.Contains("C")).ElementAt(rnd.Next(2));

            return new List<ObjectiveCard> { a, b, c };
        }
    }
}
