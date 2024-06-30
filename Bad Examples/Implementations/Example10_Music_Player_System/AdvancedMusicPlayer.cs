using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Implementations.Example10_Music_Player_System
{
    internal class AdvancedMusicPlayer
    {
        public void Play() { /* Implementation */ }
        public void Pause() { /* Implementation */ }
        public void Stop() { /* Implementation */ }
        public void CreatePlaylist(string name) { /* Implementation */ }
        public void AddToPlaylist(int songId, int playlistId) { /* Implementation */ }
        public void RemoveFromPlaylist(int songId, int playlistId) { /* Implementation */ }
        public void IncreaseVolume() { /* Implementation */ }
        public void DecreaseVolume() { /* Implementation */ }
        public void Mute() { /* Implementation */ }
    }
}
