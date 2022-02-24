using SuperExampleGame.API.Domain;
using SuperExampleGame.API.Models;
using SuperExampleGame.API.Models.Interfaces;
using SuperExampleGame.API.Infrastructure;

namespace SuperExampleGame.API.Services
{
    public interface IWarriorService{
        public Task<Warrior> GetInitialWarrior();
        
    }
    public class WarriorService : IWarriorService
    {
        private WarriorManager warriorManager;
        public WarriorService(){
            warriorManager = new WarriorManager();
        }
        public async Task BuyItem(IItemEquipment item, IUser user)
        {

            if(user.CanBuy())
            {
                using (var context = new SuperExampleGameContext())
                {

                    await context.SaveChangesAsync();
                }
            }else{

                //
          }
        }
        public async Task<Warrior> GetInitialWarrior()
        {
           return await warriorManager.GetWarriorDefault();
        }

    }
}