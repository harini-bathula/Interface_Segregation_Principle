using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle.Good_Examples.Interfaces.Example10_Music_Player_System
{
    public interface IPlaylistManagement
    {
        void CreatePlaylist(string name);
        void AddToPlaylist(int songId, int playlistId);
        void RemoveFromPlaylist(int songId, int playlistId);
    }
}
