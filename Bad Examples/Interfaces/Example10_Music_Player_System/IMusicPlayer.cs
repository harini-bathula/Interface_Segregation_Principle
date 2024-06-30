using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Bad_Examples.Interfaces.Example10_Music_Player_System
{
    public interface IMusicPlayer
    {
        void Play();
        void Pause();
        void Stop();
        void CreatePlaylist(string name);
        void AddToPlaylist(int songId, int playlistId);
        void RemoveFromPlaylist(int songId, int playlistId);
        void IncreaseVolume();
        void DecreaseVolume();
        void Mute();
        void Shuffle();
        void Repeat();
    }
}
