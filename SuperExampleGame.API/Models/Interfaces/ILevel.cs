using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperExampleGame.API.Models.Interfaces
{
    public interface ILevel
    {
        void GetDegree();
        void SetDegree(int degree);
        ILevel NextLevel<ILevel>();
        ILevel PreviousLevel<ILevel>();
    }
}