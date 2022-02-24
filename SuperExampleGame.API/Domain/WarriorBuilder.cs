using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperExampleGame.API.Models;
using SuperExampleGame.API.Models.Interfaces;
using SuperExampleGame.API.Models.Levels;
using SuperExampleGame.API.Models.Skills;

namespace SuperExampleGame.API.Domain
{
    public interface IWarriorBuilder{

        void SetInitialSkills();
        void SetInitialLevelsInSkills();
        void SetInitialDegreeInLevels();
        Warrior GetWarrior();
        
    }
    public class WarriorBuilder : IWarriorBuilder
    {
        private Warrior _warrior;

        public WarriorBuilder(){
            _warrior = new Warrior();
        }
        public void SetInitialLevelsInSkills()
        {
            //seteo bronce como nivel inicial
            foreach (var skill in _warrior.GetSkills()){
                skill.SetInitialLevel<Bronze>(new Bronze());
            }
        }

        public void SetInitialSkills()
        {
            var force = new Force();
            var resistence = new Resistence();
            var velocity = new Velocity();
   
            _warrior.AddSkill(force);
            _warrior.AddSkill(resistence);
            _warrior.AddSkill(velocity);
   
        }
        public Warrior GetWarrior(){

            return _warrior;
        }

        public void SetInitialDegreeInLevels()
        {
            throw new NotImplementedException();
        }
    }
}