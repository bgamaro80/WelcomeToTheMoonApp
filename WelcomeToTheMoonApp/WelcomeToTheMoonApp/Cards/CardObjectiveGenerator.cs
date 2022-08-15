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
                case 1:
                    return GetObjectiveCards_Scenario1();
                case 2:
                    return GetObjectiveCards_Scenario2();
                case 3:
                    return GetObjectiveCards_Scenario3();
                case 4:
                    return GetObjectiveCards_Scenario4();
                case 5:
                    return GetObjectiveCards_Scenario5();
                case 6:
                    return GetObjectiveCards_Scenario6();
                case 7:
                    return GetObjectiveCards_Scenario7();
                case 8:
                    return GetObjectiveCards_Scenario8();

                default:
                    throw new ArgumentException($"Scenario number {scenarioNumber} not valid.");
            }
        }

        private static List<ObjectiveCard> GetObjectiveCards_Scenario1()
        {
            var scenarioNumber = 1;

            return new List<ObjectiveCard>
            {
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "A",
                    FirstScore = 3,
                    SecondScore = 2,
                    Text = "Numera completamente los 3 niveles Astronauta y Agua."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "AA",
                    FirstScore = 4,
                    SecondScore = 2,
                    Text = "Numera completamente los 3 niveles Robot y Planificación."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "B",
                    FirstScore = 3,
                    SecondScore = 2,
                    Text = "Numera completamente el nivel Energía."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "BB",
                    FirstScore = 3,
                    SecondScore = 2,
                    Text = "Numera completamente los 2 niveles Planta y Comodín."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "C",
                    FirstScore = 2,
                    SecondScore = 1,
                    Text = "Anota 10 cruces gracias a los efectos de Construcción."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "CC",
                    FirstScore = 3,
                    SecondScore = 2,
                    Text = "Ten 5 casillas Error del Sistema rodeadas y sin tachar."
                }
            };
        }

        private static List<ObjectiveCard> GetObjectiveCards_Scenario2()
        {
            var scenarioNumber = 2;

            return new List<ObjectiveCard>
            {
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "A",
                    FirstScore = 9,
                    SecondScore = 5,
                    Text = "Rodea un multiplicador de 3 estaciones espaciales gracias a robots."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "AA",
                    FirstScore = 10,
                    SecondScore = 5,
                    Text = "Rodea todas las plantas en dos estaciones espaciales. Los robots no tienen por qué estar todos rodeados."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "B",
                    FirstScore = 11,
                    SecondScore = 6,
                    Text = "Mediante la Energía, crea en tu trayecto 2 zonas de una longitud de 6 casillas todas numeradas."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "BB",
                    FirstScore = 12,
                    SecondScore = 6,
                    Text = "Mediante la Energía, crea en tu trayecto 3 zonas completamente numeradas: 1 zona de longitud de 6 casillas, 1 zona de 4 casillas y 1 zona de 2 casillas."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "C",
                    FirstScore = 9,
                    SecondScore = 5,
                    Text = "Rodea 6 casillas de agua."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "CC",
                    FirstScore = 11,
                    SecondScore = 6,
                    Text = "Rodea 4 reservas de agua seguidas en el trayecto."
                }
            };
        }

        private static List<ObjectiveCard> GetObjectiveCards_Scenario3()
        {
            var scenarioNumber = 3;

            return new List<ObjectiveCard>
            {
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "A",
                    FirstScore = 12,
                    SecondScore = 6,
                    Text = "Numera todos los edificios de 3 columnas verticales."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "AA",
                    FirstScore = 12,
                    SecondScore = 5,
                    Text = "Numera todos los edificios de 3 filas horizontales."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "B",
                    FirstScore = 9,
                    SecondScore = 4,
                    Text = "Mediante los robots, une a la red de túneles el observatorio de arriba a la derecha de la hoja."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "BB",
                    FirstScore = 9,
                    SecondScore = 4,
                    Text = "Rodea todas la antenas parabólicas de 2 sectores."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "C",
                    FirstScore = 8,
                    SecondScore = 4,
                    Text = "Rodea invernaderos para tener 10 plantas."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "CC",
                    FirstScore = 9,
                    SecondScore = 5,
                    Text = "Rodea todas la reservas de agua en 2 sectores."
                }
            };
        }

        private static List<ObjectiveCard> GetObjectiveCards_Scenario4()
        {
            var scenarioNumber = 4;

            return new List<ObjectiveCard>
            {
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "A",
                    FirstScore = 8,
                    SecondScore = 4,
                    Text = "En la mina, rodea 5 bombas de extracción."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "AA",
                    FirstScore = 9,
                    SecondScore = 4,
                    Text = "En la mina, rodea 4 bombas de extracción adyacentes."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "B",
                    FirstScore = 11,
                    SecondScore = 6,
                    Text = "Activa las 5 fábricas secundarias situadas en la parte superior."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "BB",
                    FirstScore = 10,
                    SecondScore = 4,
                    Text = "Mejora o activa un total de 6 fábricas principales o secundarias."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "C",
                    FirstScore = 8,
                    SecondScore = 3,
                    Text = "Rodea 8 plantas en la mina, estén extraídas o no."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "CC",
                    FirstScore = 10,
                    SecondScore = 4,
                    Text = "Rodea 5 aguas en la mina, estén extraídas o no."
                }
            };
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

        private static List<ObjectiveCard> GetObjectiveCards_Scenario6()
        {
            var scenarioNumber = 6;

            return new List<ObjectiveCard>
            {
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "A",
                    FirstScore = 9,
                    SecondScore = 5,
                    Text = "."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "AA",
                    FirstScore = 10,
                    SecondScore = 5,
                    Text = "."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "B",
                    FirstScore = 11,
                    SecondScore = 6,
                    Text = "."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "BB",
                    FirstScore = 12,
                    SecondScore = 6,
                    Text = "."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "C",
                    FirstScore = 9,
                    SecondScore = 5,
                    Text = "."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "CC",
                    FirstScore = 11,
                    SecondScore = 6,
                    Text = "."
                }
            };
        }

        private static List<ObjectiveCard> GetObjectiveCards_Scenario7()
        {
            var scenarioNumber = 7;

            return new List<ObjectiveCard>
            {
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "A",
                    FirstScore = 9,
                    SecondScore = 5,
                    Text = "."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "AA",
                    FirstScore = 10,
                    SecondScore = 5,
                    Text = "."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "B",
                    FirstScore = 11,
                    SecondScore = 6,
                    Text = "."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "BB",
                    FirstScore = 12,
                    SecondScore = 6,
                    Text = "."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "C",
                    FirstScore = 9,
                    SecondScore = 5,
                    Text = "."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "CC",
                    FirstScore = 11,
                    SecondScore = 6,
                    Text = "."
                }
            };
        }

        private static List<ObjectiveCard> GetObjectiveCards_Scenario8()
        {
            var scenarioNumber = 8;

            return new List<ObjectiveCard>
            {
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "A",
                    FirstScore = 9,
                    SecondScore = 5,
                    Text = "."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "AA",
                    FirstScore = 10,
                    SecondScore = 5,
                    Text = "."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "B",
                    FirstScore = 11,
                    SecondScore = 6,
                    Text = "."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "BB",
                    FirstScore = 12,
                    SecondScore = 6,
                    Text = "."
                },

                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "C",
                    FirstScore = 9,
                    SecondScore = 5,
                    Text = "."
                },
                new ObjectiveCard
                {
                    ScenarioNumber = scenarioNumber,
                    Letter = "CC",
                    FirstScore = 11,
                    SecondScore = 6,
                    Text = "."
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
