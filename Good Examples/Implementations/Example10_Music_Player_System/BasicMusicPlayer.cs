using Interface_Segregation_Principle.Good_Examples.Interfaces.Example10_Music_Player_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Implementations.Example10_Music_Player_System
{
    public class BasicMusicPlayer : IPlayable, IVolumeControl
    {
        public void Play() { /* Implementation */ }
        public void Pause() { /* Implementation */ }
        public void Stop() { /* Implementation */ }
        public void IncreaseVolume() { /* Implementation */ }
        public void DecreaseVolume() { /* Implementation */ }
        public void Mute() { /* Implementation */ }
    }
}
