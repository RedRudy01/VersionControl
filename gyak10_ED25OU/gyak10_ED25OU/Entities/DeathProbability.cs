using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak10_ED25OU.Entities
{
    public class DeathProbability
    {
        public Gender gender { get; set; }
        public int Age { get; set; }

        public double DeathProb { get; set; }

    }
}
