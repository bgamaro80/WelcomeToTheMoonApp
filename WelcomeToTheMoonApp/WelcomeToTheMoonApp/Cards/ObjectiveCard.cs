using System;
using System.Collections.Generic;
using System.Text;

namespace WelcomeToTheMoonApp.Cards
{
    public class ObjectiveCard : ICloneable
    {
        /// <summary>
        /// Scenario number from 1 to 8
        /// </summary>
        public int ScenarioNumber { get; set; }

        /// <summary>
        /// A or AA for the first or second card of A's objective.
        /// B or BB
        /// C or CC
        /// </summary>
        public string Letter { get; set; }

        public int FirstScore { get; set; }
        public int SecondScore { get; set; }

        public string Text { get; set; }

        public bool IsAccomplished { get; set; } = false;

        /// <summary>
        /// obj_{N}{L|LL}_f.png
        /// obj_5A_b.png
        /// </summary>
        public string ImageFront => $"obj_{ScenarioNumber}{Letter}_f.png";

        /// <summary>
        /// obj_{N}{L|LL}_b.png
        /// obj_5A_b.png
        /// </summary>
        public string ImageBack => $"obj_{ScenarioNumber}{Letter}_b.png";

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
