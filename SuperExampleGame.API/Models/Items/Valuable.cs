using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperExampleGame.API.Models.Interfaces;

namespace SuperExampleGame.API.Models.Items
{
    public abstract class  Valuable : IItemEquipment
    {
        int Cost;
    }
}