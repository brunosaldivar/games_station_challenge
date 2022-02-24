using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperExampleGame.API.Models.Interfaces;
using SuperExampleGame.API.Models.Skills;

namespace SuperExampleGame.API.Models
{
    public class Warrior
    {  
        public Warrior(){
        }
        private List<Skill> Skills
        {
            get => default;
            set
            {
            }
        }

        public List<IItemEquipment> Equipment
        {
            get => default;
            set
            {
            }
        }
        public void AddSkill(Skill skill)
        {
            throw new System.NotImplementedException();
        }

        public List<Skill> GetSkills()
        {
            return Skills;
        }
        public void Equip()
        {
            throw new System.NotImplementedException();
        }
    }
}