using System;
using System.Collections.Generic;
using System.Text;

namespace WelcomeToTheMoonApp.Scenarios
{
    public class Scenario
    {
        /// <summary>
        /// From 1 to 8
        /// </summary>
        public int Number { get; set; }

        public string Name { get; set; }

        public string GetAdventureTitle() => $"AVENTURA {Number}: {Name.ToUpperInvariant()}";
    }
}
