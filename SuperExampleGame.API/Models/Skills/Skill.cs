using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperExampleGame.API.Models.Levels;

namespace SuperExampleGame.API.Models.Interfaces
{
    public abstract class Skill
    {
        ILevel Level { get; set; }
        public void SetInitialLevel<T>(T level) where T :ILevel{
            this.Level = level;
            this.Level.SetDegree(1);
        }
    }
}