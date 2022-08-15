using System;
using System.Collections.Generic;
using System.Text;

namespace WelcomeToTheMoonApp.Scenarios
{
    public static class ScenarioGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="scenarioNumber">From 1 to 8</param>
        /// <returns></returns>
        public static Scenario GetScenario(int scenarioNumber)
        {
            switch (scenarioNumber)
            {
                case 1:
                    return new Scenario { Number = scenarioNumber, Name = "El Despegue" };
                case 2:
                    return new Scenario { Number = scenarioNumber, Name = "El Viaje" };
                case 3:
                    return new Scenario { Number = scenarioNumber, Name = "La Colonia" };
                case 4:
                    return new Scenario { Number = scenarioNumber, Name = "La Mina" };
                case 5:
                    return new Scenario { Number = scenarioNumber, Name = "La Cúpula" };
                case 6:
                    return new Scenario { Number = scenarioNumber, Name = "El Virus" };
                case 7:
                    return new Scenario { Number = scenarioNumber, Name = "La Fuga" };
                case 8:
                    return new Scenario { Number = scenarioNumber, Name = "La Batalla" };

                default:
                    throw new ArgumentException($"Scenario number {scenarioNumber} not valid.");
            }
        }

        public static List<Scenario> GetAllScenarios()
        { 
            var list = new List<Scenario>();
            for (int i = 1; i <= 8; i++)
                list.Add(GetScenario(i));
            return list;
        }
    }
}
