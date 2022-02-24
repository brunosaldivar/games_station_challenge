using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperExampleGame.API.Models.Interfaces;

namespace SuperExampleGame.API.Models.Levels
{
    public class Platinum : ILevel
    {
        public void GetDegree()
        {
            throw new NotImplementedException();
        }

        public ILevel NextLevel<ILevel>()
        {
            throw new NotImplementedException();
        }

        public ILevel PreviousLevel<ILevel>()
        {
            throw new NotImplementedException();
        }

        public void SetDegree(int degree)
        {
            throw new NotImplementedException();
        }

    }
}