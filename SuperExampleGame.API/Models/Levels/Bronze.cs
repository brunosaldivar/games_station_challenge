using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperExampleGame.API.Models.Interfaces;

namespace SuperExampleGame.API.Models.Levels
{
    public class Bronze : ILevel
    {
        public Bronze(){
            _degree = 1;
        }
        private int _degree;
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