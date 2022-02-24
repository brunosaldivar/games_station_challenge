using SuperExampleGame.API.Models;

namespace SuperExampleGame.API.Domain
{
    public class WarriorManager
    {
        private WarriorBuilder warriorBuilder;
        public WarriorManager(){
            warriorBuilder = new WarriorBuilder();
        }
        public async Task<Warrior> GetWarriorDefault(){

            warriorBuilder.SetInitialSkills();
            warriorBuilder.SetInitialLevelsInSkills();
            warriorBuilder.SetInitialDegreeInLevels();
            return warriorBuilder.GetWarrior();
        }
    }
}