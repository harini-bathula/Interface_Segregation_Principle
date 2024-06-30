using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Interfaces.Example10_Music_Player_System
{
    public interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
}
